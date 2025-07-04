using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using LoLSDK;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene2TextMan : MonoBehaviour
    {
        // References to other scripts and objects
        public PlayerMovement playerMoveScript; // Handles player movement logic
        public GameObject s1s2Letter;           // UI element for the first letter
        public GameObject s1s2TommyLetter;      // UI element for Thomas Jefferson's letter
        public GameObject task2PrioritiesLetter;
        public GameObject forwardParent;        // Parent object holding forward navigation UI
        public GameObject timeTravelUIImage;
        public GameObject playerObject;
        public SphereCollider tommyBox;

        public GameObject currentTextSection;   // Currently active text display section
        public int arrayPos;                    // Current index in modelArray
        public int maxLengthArray;              // Total number of items in modelArray
        public int minLengthArray = 1;          // Minimum bound for backward navigation

        public GameObject[] modelArray;         // Array of text panel GameObjects
        public GameObject textPanal;            // Main UI panel for text display

        public Camera playerCam;                // Player's main camera
        public Camera jeffersonCam;             // Camera for Thomas Jefferson scenes

        // State flags
        public bool positionChanged;            // Used to trigger updates when arrayPos changes
        public bool hasScrolled;                // Tracks if user has scrolled
        public bool panalOpen;                  // Tracks if panel is currently open
        public bool runOnce;                    // Generic single-use control flag
        public bool runOnce2;                   // Secondary single-use flag
        public bool submitOnce;                 // Used to prevent duplicate progress submissions

        public Button forwardButton;            // UI button for progressing forward
        public Button backwardsButton;          // UI button for going back

        //public Button[] textButtons;            // Optional buttons to play TTS
        public bool[] textBools;                // Track whether each arrayPos has already been processed
        public NavMeshAgent agent;              // Controls AI navigation

        public Button text1TTS;
        public Button TaskTTS; // task TTS
        public Button Task2TTS; // task TTS
        public Button IsThisCorrectTTS;
        public Button thisIsCorrectTTS;
        public Button thisIsInCorrectTTS;

        public Button tommyJeffersonPreTextTTS;
        public Button tommyJeffersonText2TTS;
        public Button tommyJeffersonText3TTS;
        public Button tommyJeffersonText4TTS;

        public Button crateMiniGameIsThisCorrectTTS; // task TTS
        public Button crateMiniGameThisIsInCorrectTTS; // task TTS


        public Button crateMiniGameThisIsCorrect1TTS; // task TTS
        public Button crateMiniGameThisIsCorrect2TTS; // task TTS
        public Button crateMiniGameThisIsCorrect3TTS; // task TTS

        public Button crateMiniGameCompleteTTS; // task TTS

       // public Button answer1TTS; // task TTS
       // public Button answer2TTS; // task TTS
       // public Button answer3TTS; // task TTS
       // public Button answer4TTS; // task TTS

        public Button moveToParisTTS;

        private void Awake()
        {
            // Hook up forward and back buttons to corresponding logic
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);
            /*
            // Setup TTS button listeners
            for (int i = 0; i < textButtons.Length; i++)
            {
                int index = i + 1;
                textButtons[i].onClick.AddListener(() => IntroTTSSpeak(index));
            }
            */

            text1TTS.onClick.AddListener(SpeakText1TTS); 
            TaskTTS.onClick.AddListener(SpeakTask1TTS); ; // task TTS
            Task2TTS.onClick.AddListener(SpeakTask2TTS); // task TTS
            IsThisCorrectTTS.onClick.AddListener(SpeakIsThisCorrectTTS);
            thisIsCorrectTTS.onClick.AddListener(SpeakThisIsCorrectTTS);
            thisIsInCorrectTTS.onClick.AddListener(SpeakThisIsInCorrectTTS);

            tommyJeffersonPreTextTTS.onClick.AddListener(SpeakTommy1TTS);

            tommyJeffersonText2TTS.onClick.AddListener(SpeakTommyWesternPriority1TTS);
            tommyJeffersonText3TTS.onClick.AddListener(SpeakTommyWesternPriority2TTS);
            tommyJeffersonText4TTS.onClick.AddListener(SpeakTommyWesternPriority3TTS);

            crateMiniGameIsThisCorrectTTS.onClick.AddListener(SpeakTask2QuestionTTS);
            crateMiniGameThisIsInCorrectTTS.onClick.AddListener(SpeakTask2QuestionIncorrectTTS);

            crateMiniGameThisIsCorrect1TTS.onClick.AddListener(SpeakTask2Correct1TTS);
            crateMiniGameThisIsCorrect2TTS.onClick.AddListener(SpeakTask2Correct2TTS);
            crateMiniGameThisIsCorrect3TTS.onClick.AddListener(SpeakTask2Correct3TTS);

            crateMiniGameCompleteTTS.onClick.AddListener(SpeakTask2CompleteTTS);

         //   answer1TTS.onClick.AddListener();
         //   answer2TTS.onClick.AddListener();
          //  answer3TTS.onClick.AddListener();
         //   answer4TTS.onClick.AddListener();

            moveToParisTTS.onClick.AddListener(MoveToParisTTS);
            // Begin scene coroutine
            StartCoroutine(StartStage1());
        }

        void Start()
        {
            // Setup bounds based on model array
            maxLengthArray = modelArray.Length;
            textBools = new bool[maxLengthArray];
        }

        void Update()
        {
            // Debug shortcut to trigger opening the first letter
            if (Input.GetKeyDown(KeyCode.J))
            {
                StartCoroutine(OpenLetter());
            }

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

        // Handles specific events for each array position
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
                    StartCoroutine(OpenLetter());
                    playerMoveScript.enabled = false;
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    Debug.Log("Array1Fires");
                    break;

                case 1:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;

                case 2:
                    playerMoveScript.enabled = false;
                    playerObject.gameObject.SetActive(false);
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToTommyJefferson());
                    break;

                case 3:
                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(OpenTommyLetter());
                    break;

                case 4:
                    playerMoveScript.enabled = false;
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(DelayTextButton());
                    break;

                case 5:
                    backwardsButton.gameObject.SetActive(true);
                    break;

                case 6:
                  
                    backwardsButton.gameObject.SetActive(false);
                    task2PrioritiesLetter.gameObject.SetActive(true);
                    playerObject.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanal());
                    break;

                case 7: // incorrect Mini game 2
                    textPanal.gameObject.SetActive(true);
                    agent.isStopped = false;
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    forwardParent.gameObject.SetActive(false);
                    break;

                case 8: // correct Mini game 2 1
                    textPanal.gameObject.SetActive(true);
                    agent.isStopped = false;
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;

                case 9: // correct Mini game 2 1
                    textPanal.gameObject.SetActive(true);
                    agent.isStopped = false;
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;

                case 10: // correct Mini game 2 1
                    textPanal.gameObject.SetActive(true);
                    agent.isStopped = false;
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;

                case 11:
                    textPanal.gameObject.SetActive(true);
                    tommyBox.enabled = true;
                    agent.isStopped = false;
                    task2PrioritiesLetter.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;

                case 12:
                    StopAllCoroutines();
                    positionChanged = true;
                    textPanal.gameObject.SetActive(true);
                    playerCam.gameObject.SetActive(false);
                    jeffersonCam.gameObject.SetActive(true);
                    agent.isStopped = true;
                    playerObject.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToParis());
                    break;

                case 13:
                    textPanal.gameObject.SetActive(false);
                    agent.isStopped = false;
                    break;
            }
        }
        /*
        // Plays TTS for intro text buttons
        public void IntroTTSSpeak(int textIndex)
        {
            string textKey = $"stage1Text{textIndex}";
            LOLSDK.Instance.SpeakText(textKey);
            Debug.Log($"labText{textIndex} Button is pressed");
        }
        */
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
            arrayPos = 13;
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator MoveToBlankInvislbePanal()
        {
            yield return new WaitForSeconds(5);
            playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 13;
            jeffersonCam.gameObject.SetActive(false);
            playerCam.gameObject.SetActive(true);
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator OpenLetter()
        {
            yield return new WaitForSeconds(4);
            playerMoveScript.enabled = true;
            s1s2Letter.gameObject.SetActive(true);
            textPanal.gameObject.SetActive(false);
            arrayPos = 13;
            Debug.Log("This start coRoutine Runs well");
        }

        public IEnumerator OpenTommyLetter()
        {
            yield return new WaitForSeconds(4);
            playerMoveScript.enabled = false;
            s1s2TommyLetter.gameObject.SetActive(true);
            textPanal.gameObject.SetActive(false);
            arrayPos = 13;
            Debug.Log("This start coRoutine Runs well");
        }

        public IEnumerator MoveToBlank()
        {
            yield return new WaitForSeconds(3);
            positionChanged = true;
            playerMoveScript.enabled = false;
            arrayPos = 13;
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

        public IEnumerator StartStage1()
        {
            yield return new WaitForSeconds(2);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start function Runs");
        }

        public IEnumerator MoveToParis()
        {
            yield return new WaitForSeconds(6);
            timeTravelUIImage.gameObject.SetActive(true);
            // positionChanged = true;
            LOLSDK.Instance.SubmitProgress(0, 14, 100);
            Debug.Log("This start coRoutine Runs");
        }

        private void SpeakText1TTS()
        {
            LOLSDK.Instance.SpeakText("stage1Text1");
        }

        private void SpeakTask1TTS()
        {
            LOLSDK.Instance.SpeakText("stage1Text2");
        }

        private void SpeakTask2TTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene2MiniGame2Text");
        }

        private void SpeakIsThisCorrectTTS()
        {
            LOLSDK.Instance.SpeakText("stage1Text3");
        }

        private void SpeakThisIsCorrectTTS()
        {
            LOLSDK.Instance.SpeakText("stage1Text5");
        }


        private void SpeakThisIsInCorrectTTS()
        {
            LOLSDK.Instance.SpeakText("stage1Text4");
        }
        private void SpeakTommy1TTS()
        {
            LOLSDK.Instance.SpeakText("stage1thomasJefferson1Pretext");
        }
        private void SpeakTommyWesternPriority1TTS()
        {
            LOLSDK.Instance.SpeakText("stage1thomasJeffersonWesternPrior1");
        }

        private void SpeakTommyWesternPriority2TTS()
        {
            LOLSDK.Instance.SpeakText("stage1thomasJeffersonWesternPrior2");
        }

        private void SpeakTommyWesternPriority3TTS()
        {
            LOLSDK.Instance.SpeakText("stage1thomasJeffersonWesternPrior3");
        }

        private void SpeakTask2QuestionTTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene2MiniGame2Question");
        }

        private void SpeakTask2QuestionIncorrectTTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene2MiniGame2InCorrect");
        }

        private void SpeakTask2Correct1TTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene2MiniGame2Correct1");
        }

        private void SpeakTask2Correct2TTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene2MiniGame2Correct2");
        }

        private void SpeakTask2Correct3TTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene2MiniGame2Correct3");
        }

        private void SpeakTask2CompleteTTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene2MiniGame2Complete");
        }

        private void MoveToParisTTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene2MoveToParis");
        }
    }
}






