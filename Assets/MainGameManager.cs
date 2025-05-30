using System.Collections;
using System.Collections.Generic;
using System.IO;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;


namespace Alpha.Phases.Destiny.Quest
{
    [System.Serializable] // serialize this save data
    public class DQWBSaveData
    {
        [Header("StageProgress")] // header for the save location for the robot
        public int current_stage; // int to hold the level number

    }
    public class MainGameManager : MonoBehaviour
    {
        #region global code
        [SerializeField, Header("Initial State Data")]
        DQWBSaveData dqwbSaveData; // get access to save section of this script
        public int currentStagedqwb;
        private bool hasIPadBeenSelected;
        public bool iPadChosen;
        //   public NavMeshAgent playerNavmeshAgent;

        //public GameObject peoplePLayer; // game object for the player
        public bool runScriptOnce;


        [SerializeField] Button continueButton, newGameButton; // declare two buttons for the start new game and continue game options
        public TextMeshProUGUI newGameText; // TMP for the new game button
        public TextMeshProUGUI continueText; // TMP for the continue game button
        #endregion

        // stage one stuff
        #region "stage1stufftobecollapsed"
        [SerializeField, Header("Stage 1 Code")]

        #endregion
        JSONNode _langNode; // declare lanuage code for this game so we know if its spanish or english
        public string _langCode = "en"; // declare string for english text
        string _langCodeSpanish = "es"; // declare string for spanish text


        private void Awake() // on awake of script
        {
            Application.runInBackground = false; // dont let the game run in the background
            DontDestroyOnLoad(this.gameObject);

            //#if UNITY_IOS
            //   
            //#endif
            //  Application.targetFrameRate = -1; // Set the target frame rate for iOS builds
        }

        void Start()
        {
            newGameButton.onClick.AddListener(RemoveMainMenuUINewGame); // new game button after pressing, hides the button - see script at the bottom of the script
            continueButton.onClick.AddListener(RemoveMainMenuUIContinue); ; // continune saved game button after pressing, hides the button - see script at the bottom of the script

#if UNITY_EDITOR
            ILOLSDK sdk = new LoLSDK.MockWebGL();
#elif UNITY_WEBGL
	    ILOLSDK sdk = new LoLSDK.WebGL();
#endif
            Helper.StateButtonInitialize<DQWBSaveData>(newGameButton, continueButton, OnLoad); // initialise LOLSDK helper function and attached both new game and continue buttons to it

        }

        private void Update()
        {
            dqwbSaveData.current_stage = currentStagedqwb;

            if (iPadChosen)
            {
                if (!hasIPadBeenSelected)
                {
                    Application.targetFrameRate = 30; // Set the target frame rate for iOS builds
                    hasIPadBeenSelected = true;
                    iPadChosen = false;
                }

                Debug.Log("Is this running twice");

            }                  

        }
       
        public void Save()
        {
            LOLSDK.Instance.SaveState(dqwbSaveData); // save data to cargoSaveData
            Debug.Log("Game Saved");
        }

        /// <summary>
        /// This is the setting of your initial state when the scene loads.
        /// The state can be set from your default editor settings or from the
        /// users saved data after a valid save is called.
        /// </summary>
        /// <param name="loadedGardenData"></param>

        void OnLoad(DQWBSaveData loadedGardenData)
        {
            JSONNode langs = SharedState.LanguageDefs;
            // Overrides serialized state data or continues with editor serialized values.
            if (loadedGardenData != null)
                dqwbSaveData = loadedGardenData;
            currentStagedqwb = dqwbSaveData.current_stage;

            if (dqwbSaveData.current_stage == 1)
            {
                SceneManager.LoadScene("Stage1Lab");
                Debug.Log("Loaded Stage 1 Save");
            }
                  
            Debug.Log("Load Function Called");
        }

        void RemoveMainMenuUINewGame()
        {
            currentStagedqwb = 1;
        }
        void RemoveMainMenuUIContinue()
        {
            currentStagedqwb = dqwbSaveData.current_stage;
          
          Debug.Log("Loaded Save");
        }

        #region global Save stuff
        public void SavePlayerPos()
        {
            StartCoroutine(ShowAutoSaveMessage());
            LOLSDK.Instance.SaveState(dqwbSaveData);
        }
       
        public IEnumerator ShowAutoSaveMessage()
        {
            //    autoSavingMessage.gameObject.SetActive(true);
            yield return new WaitForSeconds(3);

        }
        #endregion          
    }
}

