using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4Scene2TextMan : MonoBehaviour
    {
        public GameObject forwardParent;        // Parent object holding forward navigation UI
        public PlayerMovement playerMove;
        public GameObject currentTextSection;   // Currently active text display section
        public int arrayPos;                    // Current index in modelArray
        public int maxLengthArray;              // Total number of items in modelArray
        public int minLengthArray = 1;          // Minimum bound for backward navigation

        public GameObject[] modelArray;         // Array of text panel GameObjects
        public GameObject textPanal;            // Main UI panel for text display

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
            StartCoroutine(StartStage4Scene1());
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
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    Debug.Log("Array1Fires");
                    break;
                case 1:

                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(DelayTextButton());
                    break;
                case 2:
     
                    backwardsButton.gameObject.SetActive(true);
                    playerMove.enabled = true;
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;
                case 3:

                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;
                case 4:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    break;
                case 5:
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    StartCoroutine(MoveToScene4Stage1());
                    break;

                case 6:
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
            yield return new WaitForSeconds(5);
            textPanal.gameObject.SetActive(false);
            arrayPos = 6;
            playerMove.enabled = true;
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

        public IEnumerator StartStage4Scene1()
        {
            yield return new WaitForSeconds(2);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start function Runs");
        }

        public IEnumerator MoveToScene4Stage1()
        {
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene("SigningScene");
        }



        public IEnumerator MoveToEnd()
        {
            yield return new WaitForSeconds(5);
            positionChanged = true;
            arrayPos = 8;
        }


    }
}
