using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene4TextMan : MonoBehaviour
    {
        // References to other scripts and objects
        public PlayerMovement playerMoveScript; // Handles player movement logic
        public GameObject s1s4Letter;           // UI element for the first letter
      
        public GameObject forwardParent;        // Parent object holding forward navigation UI
        public GameObject s1s4TommyLetter;      // UI element for Thomas Jefferson's letter

        public Animator lewisWave1;
        public Animator clarkWave1;

        public GameObject playerObject;
        public BoxCollider tommyBox;

        public GameObject currentTextSection;   // Currently active text display section
        public int arrayPos;                    // Current index in modelArray
        public int maxLengthArray;              // Total number of items in modelArray
        public int minLengthArray = 1;          // Minimum bound for backward navigation

        public GameObject[] modelArray;         // Array of text panel GameObjects
        public GameObject textPanal;            // Main UI panel for text display

        public Camera playerCam;                // Player's main camera
        public Camera jeffersonCam;             // Camera for Thomas Jefferson scenes
        public Camera lewisClarkCam;
        // State flags
        public bool positionChanged;            // Used to trigger updates when arrayPos changes
        public bool hasScrolled;                // Tracks if user has scrolled
        public bool panalOpen;                  // Tracks if panel is currently open
        public bool runOnce;                    // Generic single-use control flag
        public bool runOnce2;                   // Secondary single-use flag
        public bool submitOnce;                 // Used to prevent duplicate progress submissions

        public Button forwardButton;            // UI button for progressing forward
        public Button backwardsButton;          // UI button for going back

        public Button[] textButtons;            // Optional buttons to play TTS
        public bool[] textBools;                // Track whether each arrayPos has already been processed
        public NavMeshAgent agent;              // Controls AI navigation

        private void Awake()
        {
            // Hook up forward and back buttons to corresponding logic
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);

            // Setup TTS button listeners
            for (int i = 0; i < textButtons.Length; i++)
            {
                int index = i + 1;
                textButtons[i].onClick.AddListener(() => IntroTTSSpeak(index));
            }

            // Begin scene coroutine
            StartCoroutine(StartStage1Scene4());
        }

        void Start()
        {
            // Setup bounds based on model array
            maxLengthArray = modelArray.Length;
            textBools = new bool[maxLengthArray];
        }

        void Update()
        {
          
            // If arrayPos has changed, update UI
            if (positionChanged)
            {
                positionChanged = false; // Reset flag

                // Activate only the current model object
                for (int i = 0; i < modelArray.Length; i++)
                {
                    modelArray[i].SetActive(i == arrayPos);
                }

                // Only trigger array logic once
                if (!textBools[arrayPos])
                {
                    HandleArrayPosActions();
                    textBools[arrayPos] = true;
                }
            }
        }

        private void HandleArrayPosActions()
        {
            switch (arrayPos)
            {
                case 0:
                    if (!submitOnce)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 10, 100);
                        submitOnce = true;
                    }
                 
                    playerMoveScript.enabled = false;
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    SpeakText("stage1Text1");
                    StartCoroutine(OpenLetter());
                    Debug.Log("Array1Fires");
                    break;

                case 1:
                    textPanal.gameObject.SetActive(true);
                    playerCam.gameObject.SetActive(false);
                    jeffersonCam.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    playerMoveScript.enabled = false;
                    SpeakText("stage1Text4");
                    break;
                    agent.isStopped = false;
                case 2:
                                                    
                    SpeakText("stage1Text5");
                    break;

                case 3:
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(OpenTommyLetter());
                    SpeakText("thomasJefferson1Pretext");
                    break;

                case 4:
                    //playerMoveScript.enabled = false;
                    jeffersonCam.gameObject.SetActive(false);
                    lewisClarkCam.gameObject.SetActive(true);
                    lewisWave1.SetBool("wave2", true);
                    clarkWave1.SetBool("wave1", true);
                    textPanal.gameObject.SetActive(true);
                    forwardParent.gameObject.SetActive(true);
                    forwardButton.gameObject.SetActive(true);
                    break;

                case 5:
                    jeffersonCam.gameObject.SetActive(true);
                    lewisClarkCam.gameObject.SetActive(false);
                    lewisWave1.SetBool("isIdle", true);
                    clarkWave1.SetBool("isIdle", true);
                    backwardsButton.gameObject.SetActive(true);
                    break;

                case 6:
                    
                   break;

                case 7: // incorrect Mini game 2
                 
                    agent.isStopped = false;
                    StartCoroutine(MoveToBlankInvislbePanal());
                    break;

                                      

                case 8:
                    textPanal.gameObject.SetActive(false);
                    agent.isStopped = false;
                    break;
            }
        }

        // Plays TTS for intro text buttons
        public void IntroTTSSpeak(int textIndex)
        {
            string textKey = $"stage1Text{textIndex}";
            LOLSDK.Instance.SpeakText(textKey);
            Debug.Log($"labText{textIndex} Button is pressed");
        }

        // Progress forward through array
        public void ProgressTextForward()
        {
            if (arrayPos < maxLengthArray - 1)
            {
                arrayPos++;
                positionChanged = true;
                hasScrolled = false;
                forwardButton.gameObject.SetActive(false);

                if (arrayPos != 3)
                {
                    StartCoroutine(DelayTextButton());
                }
            }
        }

        // Progress backward through array
        public void ProgressTextBack()
        {
            if (arrayPos > minLengthArray)
            {
                arrayPos--;
                positionChanged = true;
                hasScrolled = false;
                Array.Fill(textBools, false); // Reset so actions can re-fire
            }
        }

        // Resets state to reprocess current position
        public void ResetPositionFlags()
        {
            Array.Fill(textBools, false);
            positionChanged = true;
        }

        // Helper to speak any string key
        private void SpeakText(string textKey)
        {
            LOLSDK.Instance.SpeakText(textKey);
        }

        public void ResetBools()
        {
            Array.Fill(textBools, false);
        }

        // Waits before showing forward button (used for pacing)
        public IEnumerator DelayTextButton()
        {
            yield return new WaitForSeconds(5);
            forwardParent.gameObject.SetActive(true);
            forwardButton.gameObject.SetActive(true);
            Debug.Log("Forward Arrow Showing");
        }

        // Letter and transition routines:

        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(5);
            playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 8;
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator MoveToBlankInvislbePanal()
        {
            yield return new WaitForSeconds(5);
            playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 8;
            SceneManager.LoadScene("Stage1Scene5Map");
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator OpenLetter()
        {
            yield return new WaitForSeconds(4);
            playerMoveScript.enabled = true;
            s1s4Letter.gameObject.SetActive(true);
            textPanal.gameObject.SetActive(false);
            arrayPos = 8;
            Debug.Log("This start coRoutine Runs well");
        }

        public IEnumerator OpenTommyLetter()
        {
            yield return new WaitForSeconds(4);
            playerMoveScript.enabled = false;
            s1s4TommyLetter.gameObject.SetActive(true);
            textPanal.gameObject.SetActive(false);
            arrayPos = 8;
            Debug.Log("This start coRoutine Runs well");
        }

        public IEnumerator MoveToBlank()
        {
            yield return new WaitForSeconds(3);
            positionChanged = true;
            playerMoveScript.enabled = false;
            arrayPos = 8;
            Debug.Log("This start coRoutine Runs well");
        }

        public IEnumerator MoveToTommyJefferson()
        {
            yield return new WaitForSeconds(3);
            positionChanged = true;
            playerMoveScript.enabled = false;
            arrayPos = 3;
            Debug.Log("This start coRoutine Runs well");
        }

        public IEnumerator StartStage1Scene4()
        {
            yield return new WaitForSeconds(2);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start function Runs");
        }

       
    }
}