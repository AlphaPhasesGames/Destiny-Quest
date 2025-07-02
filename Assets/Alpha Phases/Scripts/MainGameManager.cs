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
        public static MainGameManager Instance { get; private set; }

        #region global code
        [SerializeField, Header("Initial State Data")]
        DQWBSaveData dqwbSaveData;
        public int currentStagedqwb;
        public bool hasIPadBeenSelected;
        public bool iPadChosen;
        public bool runScriptOnce;

        [SerializeField] Button continueButton, newGameButton;
        public TextMeshProUGUI newGameText;
        public TextMeshProUGUI continueText;
        #endregion

        #region "stage1stufftobecollapsed"
        [SerializeField, Header("Stage 1 Code")]
        #endregion

        JSONNode _langNode;
        public string _langCode = "en";
        string _langCodeSpanish = "es";

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this.gameObject); // Prevent duplicates
                return;
            }

            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            Application.runInBackground = false;
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
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                SceneManager.LoadScene("Stage3Scene1");
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
                Debug.Log("Loaded Stage 1 Scene 1 Save");
            }

            if (dqwbSaveData.current_stage == 2)
            {
                SceneManager.LoadScene("Stage1Camp");
                Debug.Log("Loaded Stage 1 Scene 2 Save");
            }

            if (dqwbSaveData.current_stage == 3)
            {
                SceneManager.LoadScene("ParisStudy");
                Debug.Log("Loaded Stage 1 Scene 3 Save");
            }

            if (dqwbSaveData.current_stage == 4)
            {
                SceneManager.LoadScene("Stage1CampSection2");
                Debug.Log("Loaded Stage 1 Scene 4 Save");
            }

            if (dqwbSaveData.current_stage == 5)
            {
                SceneManager.LoadScene("Stage1Scene5Map");
                Debug.Log("Loaded Stage 1 Scene 4 Save");
            }

            if (dqwbSaveData.current_stage == 6)
            {
                SceneManager.LoadScene("Stage2Scene1");
                Debug.Log("Loaded Stage 1 Scene 4 Save");
            }

            if (dqwbSaveData.current_stage == 7)
            {
                SceneManager.LoadScene("Stage2Scene2");
                Debug.Log("Loaded Stage 1 Scene 4 Save");
            }

            if (dqwbSaveData.current_stage == 8)
            {
                SceneManager.LoadScene("Stage2Scene3");
                Debug.Log("Loaded Stage 2 Scene 3 Save");
            }

            if (dqwbSaveData.current_stage == 9)
            {
                SceneManager.LoadScene("Stage3Scene1");
                Debug.Log("Loaded Stage 2 Scene 1 Save");
            }

            if (dqwbSaveData.current_stage == 10)
            {
                SceneManager.LoadScene("Stage3Scene2");
                Debug.Log("Loaded Stage 2 Scene 1 Save");
            }

            if (dqwbSaveData.current_stage == 11)
            {
                SceneManager.LoadScene("Stage4Scene1");
                Debug.Log("Loaded Stage 4 Scene 1 Save");
            }

            if (dqwbSaveData.current_stage == 12)
            {
                SceneManager.LoadScene("Stage4EndGame");
                Debug.Log("Loaded Stage 4 Scene 2 Save");
            }

            Debug.Log("Load Function Called");
        }

        void RemoveMainMenuUINewGame()
        {
            currentStagedqwb = 1;
            SaveS1S1();
        }
        void RemoveMainMenuUIContinue()
        {
            currentStagedqwb = dqwbSaveData.current_stage;
          
          Debug.Log("Loaded Save");
        }

        #region global Save stuff

        public void SaveS1S1()
        {
            currentStagedqwb = 1;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS1S2()
        {
            currentStagedqwb = 2;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS1S3()
        {
            currentStagedqwb = 3;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS1S4()
        {
            currentStagedqwb = 4;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS1S5()
        {
            currentStagedqwb = 5;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS2S1()
        {
            currentStagedqwb = 6;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS2S2()
        {
            currentStagedqwb = 7;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS2S3()
        {
            currentStagedqwb = 8;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS3S1()
        {
            currentStagedqwb = 9;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS3S2()
        {
            currentStagedqwb = 10;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS4S1()
        {
            currentStagedqwb = 11;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }

        public void SaveS4S2()
        {
            currentStagedqwb = 12;
            dqwbSaveData.current_stage = currentStagedqwb;
            Save();
        }
        #endregion          
    }
}

