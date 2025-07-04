using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using LoLSDK;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene3TextMan : MonoBehaviour
    {

        // References to other scripts and objects
    
        public GameObject s1s2Letter;           // UI element for the first letter
        public Stage1Scene3ConverstionMiniGame minigame;
        public GameObject forwardParent;        // Parent object holding forward navigation UI
        public GameObject timeTravelUIImage;
       
        public GameObject playerObject;
        public GameObject task;
        public GameObject minigameUI;
        public GameObject currentTextSection;   // Currently active text display section
        public int arrayPos;                    // Current index in modelArray
        public int maxLengthArray;              // Total number of items in modelArray
        public int minLengthArray = 1;          // Minimum bound for backward navigation

        public GameObject[] modelArray;         // Array of text panel GameObjects
        public GameObject textPanal;            // Main UI panel for text display

        public Camera playerCam;                // Player's main camera
        public Camera napoleonCam;             // Camera for Napoleon scenes
        public Camera MonroeCam;             // Camera for James Monroe scenes
        // State flags
        public bool positionChanged;            // Used to trigger updates when arrayPos changes
        public bool hasScrolled;                // Tracks if user has scrolled
        public bool panalOpen;                  // Tracks if panel is currently open
        public bool runOnce;                    // Generic single-use control flag
        public bool runOnce2;                   // Secondary single-use flag
        public bool submitOnce;                 // Used to prevent duplicate progress submissions

        public Button forwardButton;            // UI button for progressing forward
        public Button backwardsButton;          // UI button for going back

       // public Button[] textButtons;            // Optional buttons to play TTS
        public bool[] textBools;                // Track whether each arrayPos has already been processed

        public Animator napoAnim;

        public Button stageText1TTS;
        public Button stageText2TTS;
        public Button stageTaskTTS;
        public Button stageTextBuyLouisiana;
        public Button stageTextBuyOrleans;
        public Button stageText4TTS;


        private void Awake()
        {
            // Hook up forward and back buttons to corresponding logic
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);

            stageTaskTTS.onClick.AddListener(SpeakTask1TTS);

            stageText1TTS.onClick.AddListener(SpeakText1TTS);
            stageText2TTS.onClick.AddListener(SpeakText2TTS);

            stageTextBuyLouisiana.onClick.AddListener(SpeakThisIsCorrectTTS);
            stageTextBuyOrleans.onClick.AddListener(SpeakThisIsInCorrectTTS);
            stageText4TTS.onClick.AddListener(SpeakText2FinalTTS);
            /*
            // Setup TTS button listeners
            for (int i = 0; i < textButtons.Length; i++)
            {
                int index = i + 1;
                textButtons[i].onClick.AddListener(() => IntroTTSSpeak(index));
            }
            */
            // Begin scene coroutine
            StartCoroutine(StartStage1S3());
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



        // Handles specific events for each array position
        private void HandleArrayPosActions()
        {
            switch (arrayPos)
            {
                case 0:
                    if (!submitOnce)
                    {
                        LOLSDK.Instance.SubmitProgress(0, 40, 100);
                        submitOnce = true;
                    }                                 
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    Debug.Log("Array1Fires");
                    StartCoroutine(OpenLetter());
                    break; 

                case 1:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToNapoleon());
                    break;

                case 2:// incorrect
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToNapoleon());
                    break;

                case 3: // correct
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToFinalText());
                    break;
                case 4: // correct
                    textPanal.gameObject.SetActive(true);
                    minigameUI.gameObject.SetActive(false);
                    timeTravelUIImage.gameObject.SetActive(true);
                   
                    break;
                case 5:
                    textPanal.gameObject.SetActive(false);
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

        public IEnumerator OpenLetter()
        {
            yield return new WaitForSeconds(6);
            s1s2Letter.gameObject.SetActive(true);
            textPanal.gameObject.SetActive(false);
            arrayPos = 5;
            Debug.Log("This start coRoutine Runs well");
        }

        public IEnumerator StartStage1S3()
        {
            yield return new WaitForSeconds(2);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start coRoutine Runs");
        }


        public IEnumerator MoveToBlankInvislbePanal()
        {
            yield return new WaitForSeconds(5);
            textPanal.gameObject.SetActive(false);
            arrayPos = 5;
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator MoveToFinalText()
        {
            yield return new WaitForSeconds(6);
            positionChanged = true;
            //textPanal.gameObject.SetActive(false);
            arrayPos = 4;
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator MoveToNapoleon()
        {
            yield return new WaitForSeconds(5);
            playerCam.gameObject.SetActive(false);
            napoleonCam.gameObject.SetActive(true);
            textPanal.gameObject.SetActive(false);
            minigame.minigameCanvas.gameObject.SetActive(true);
            minigame.napoleon1Choices.gameObject.SetActive(true);
            task.gameObject.SetActive(true);
            napoAnim.SetBool("napoStart", true);
            arrayPos = 5;
            Debug.Log("This start coRoutine Runs");
        }

        private void SpeakText1TTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene3Start");
        }

        private void SpeakTask1TTS()
        {
            LOLSDK.Instance.SpeakText("taskStage1Scene3");
        }

        private void SpeakText2TTS()
        {
            LOLSDK.Instance.SpeakText("stage1Scene3Talks");
        }

        private void SpeakThisIsCorrectTTS()
        {
            LOLSDK.Instance.SpeakText("monroeChoiceBuyLouisiana");
        }

        private void SpeakThisIsInCorrectTTS()
        {
            LOLSDK.Instance.SpeakText("monroeChoiceBuyOrleans");
        }

        private void SpeakText2FinalTTS()
        {
            LOLSDK.Instance.SpeakText("textToMoveToScene1Stage4");
        }

    }
}
