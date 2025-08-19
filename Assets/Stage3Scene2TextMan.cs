using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2TextMan : MonoBehaviour
    {
        public GameObject forwardParent;        // Parent object holding forward navigation UI
        public Stage3Scene2PolkConcernSelectMan choicesMan;
        public PlayerMovement playerMoveScript;
        public Stage3Scene2LetterManager stage3Scene2LetterMan;
        public Stage3Scene2Letter2Manager stage3Scene2Letter2Man;
        public GameObject currentTextSection;   // Currently active text display section
        public int arrayPos;                    // Current index in modelArray
        public int maxLengthArray;              // Total number of items in modelArray
        public int minLengthArray = 1;          // Minimum bound for backward navigation

        public GameObject citizens;

        public GameObject[] modelArray;         // Array of text panel GameObjects
        public GameObject textPanal;            // Main UI panel for text display
        public GameObject playerObject;
        public GameObject letterEnd;
        public GameObject letter;
      //  public GameObject taskHeader;
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

        public GameObject taskHeaderImage;
        public Button taskTTSButton;
        public Button taskTTSButton2; // Return to polk task
        public Button closeAnswersToTalkToCitizens;
        public Camera polkCam;
        public Camera playerCam;
        public SphereCollider polkCollider;
      //  public Button timeTravelButton;
        private void Awake()
        {
            // Hook up forward and back buttons to corresponding logic
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);
            taskTTSButton.onClick.AddListener(SpeakTask);
            taskTTSButton2.onClick.AddListener(SpeakTask2);
          //  timeTravelButton.onClick.AddListener(MoveToScene3);
            closeAnswersToTalkToCitizens.onClick.AddListener(CloseAnswers);
            // Setup TTS button listeners
            for (int i = 0; i < textButtons.Length; i++)
            {
                int index = i + 1;
                textButtons[i].onClick.AddListener(() => IntroTTSSpeak(index));
            }
            // Begin scene coroutine
            StartCoroutine(StartStage2Scene3());
        }

        void Start()
        {
            // Setup bounds based on model array
            maxLengthArray = modelArray.Length;
            textBools = new bool[maxLengthArray + 1]; // Add +1 to safely include index 11
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
                        LOLSDK.Instance.SubmitProgress(0, 72, 100);
                        submitOnce = true;
                    }
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(DelayTextButton());
                    break;
                case 1:

                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(RestartPlayer());
                    StartCoroutine(MoveToBlankInvislbePanalQuick());
             

                    break;

                case 2:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                  //  taskHeader.gameObject.SetActive(true);
                    StartCoroutine(OpenLetter());
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;

                case 3:
                    playerMoveScript.enabled = false;
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    // taskHeader.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit172());
                    break;

                case 4:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    polkCollider.enabled = true;
                    playerMoveScript.enabled = false;
                    StartCoroutine(MoveToBlankInvislbePanalQuick());
                    break;
               
                case 5: // Correct 1 Correct
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    taskHeaderImage.gameObject.SetActive(false);
                break;
                
                case 6: // Wrong
                     textPanal.gameObject.SetActive(true);
                     backwardsButton.gameObject.SetActive(false);
                     forwardParent.gameObject.SetActive(false);
                     choicesMan.concern4Incorrect = false;
                     choicesMan.concern4BGSelected.gameObject.SetActive(false);
                     StartCoroutine(MoveToBlankInvislbePanalReRouteTo5());
                     break;

                 case 7: // Right
                      textPanal.gameObject.SetActive(true);
                      backwardsButton.gameObject.SetActive(false);
                      StartCoroutine(DelayTextButton());
                      break;
                                
                  case 8:
                       StartCoroutine(DelayTextButton());
                       backwardsButton.gameObject.SetActive(true);
                       break;

                  case 9:

                       StartCoroutine(DelayTextButton());
                       break;

                  case 10: // decision 2 wrong
                       backwardsButton.gameObject.SetActive(false);
                       forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    StartCoroutine(OpenLetter2());
                          
                       break;
                           
                case 11: // decision 2 wrong
                    textPanal.gameObject.SetActive(false);
                    break;
            }
        }

        // Plays TTS for intro text buttons
        public void IntroTTSSpeak(int textIndex)
        {
            string textKey = $"stage3Scene2Text{textIndex}";
            LOLSDK.Instance.SpeakText(textKey);
            Debug.Log($"stage3Scene2Text{textIndex} Button is pressed");
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

        public IEnumerator DelayTextButton()
        {
            yield return new WaitForSeconds(5);
            forwardParent.gameObject.SetActive(true);
            forwardButton.gameObject.SetActive(true);
            Debug.Log("Forward Arrow Showing");
        }

        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(6);
            textPanal.gameObject.SetActive(false);
            arrayPos = 11;
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator RestartPlayer()
        {
            yield return new WaitForSeconds(5);
            playerMoveScript.enabled = true;
        }

        public IEnumerator MoveToBlankInvislbePanalUnit172()
        {
            yield return new WaitForSeconds(6);
            textPanal.gameObject.SetActive(false);
            playerObject.gameObject.SetActive(true);
            playerMoveScript.enabled = true;
            citizens.gameObject.SetActive(true);
            arrayPos = 11;
            taskHeaderImage.gameObject.SetActive(true);
            polkCam.gameObject.SetActive(false);
            playerCam.gameObject.SetActive(true);
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator MoveToBlankInvislbePanalQuick()
        {
            yield return new WaitForSeconds(2);
            playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 11;
            Debug.Log("This start coRoutine Runs");
        }


        public IEnumerator MoveToBlankInvislbePanalReRouteTo5()
        {
            yield return new WaitForSeconds(6);
            positionChanged = true;
            arrayPos = 5;
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator LoopToWrongAnswer()
        {
            yield return new WaitForSeconds(5);
            positionChanged = true;
            //  textPanal.gameObject.SetActive(true);
            arrayPos = 1;
            Debug.Log("This start function Runs");
        }

        public IEnumerator StartStage2Scene3()
        {
            yield return new WaitForSeconds(2);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start function Runs");
        }
        /*
        public void MoveToScene3()
        {
          
            LOLSDK.Instance.SubmitProgress(0, 76, 100);
            SceneManager.LoadScene("Stage4Scene1");
        }
        */
        public IEnumerator OpenLetter()
        {
            yield return new WaitForSeconds(5);
            stage3Scene2LetterMan.enabled = true;
            letter.gameObject.SetActive(true);
        }

        public IEnumerator OpenLetter2()
        {
            yield return new WaitForSeconds(5);
            stage3Scene2Letter2Man.enabled = true;
            letterEnd.gameObject.SetActive(true);
        }

        public void SpeakTask()
        {
            LOLSDK.Instance.SpeakText("stage3Scene2Task");
        }

        public void SpeakTask2()
        {
            LOLSDK.Instance.SpeakText("stage3Scene2Task2");
        }

        public void CloseAnswers()
        {
            StartCoroutine(ReEnableAustinCollider());
            polkCollider.enabled = false;
            textPanal.gameObject.SetActive(false);
            Debug.Log("Step 1 works");
            playerObject.gameObject.SetActive(true);
            playerMoveScript.enabled = true;
            Debug.Log("Step 2 works");
            //taskHeaderImage.gameObject.SetActive(true);
            polkCam.gameObject.SetActive(false);
            Debug.Log("Step 3 works");
            playerCam.gameObject.SetActive(true);
            ResetBools();
        }

        public IEnumerator ReEnableAustinCollider()
        {
            yield return new WaitForSeconds(4);
            polkCollider.enabled = true;
        }

    }
}

