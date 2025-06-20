using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene5TextManager : MonoBehaviour
    {
        // References to other scripts and objects
     


        public GameObject forwardParent;        // Parent object holding forward navigation UI
      
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
      //  public NavMeshAgent agent;              // Controls AI navigation

        public Button choice1Answer1North;
        public Button choice1Answer2East;
        public Button choice1Answer3South;
        public Button choice1Answer4West;

        public Button choice2Answer1ByForce;
        public Button choice2Answer2Freindly;

        public Animator moveToMississipi;
    

        public Button choice3Answer1GodsPlan;
        public Button choice3Answer2StayHere;
        public Button choice3Answer3GoHome;

        public Button moveToNextStage;
        private void Awake()
        {
            // Hook up forward and back buttons to corresponding logic
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);

            choice1Answer1North.onClick.AddListener(Choice1ButtonNorth);
            choice1Answer2East.onClick.AddListener(Choice1ButtonEast);
            choice1Answer3South.onClick.AddListener(Choice1ButtonSouth);
            choice1Answer4West.onClick.AddListener(Choice1ButtonWest);

            choice2Answer1ByForce.onClick.AddListener(Choice2ButtonByForce);
            choice2Answer2Freindly.onClick.AddListener(Choice2ButtonFreindly);

            choice3Answer1GodsPlan.onClick.AddListener(Choice3ButtonGodplan);
            choice3Answer2StayHere.onClick.AddListener(Choice3ButtonStayHere);
            choice3Answer3GoHome.onClick.AddListener(Choice3ButtonGoHome);

            moveToNextStage.onClick.AddListener(MoveToOregon);
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

                   
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(true);
                    SpeakText("stage1Text1");
               
                    Debug.Log("Array1Fires");
                    break;

                case 1:
                    backwardsButton.gameObject.SetActive(true);
                    SpeakText("stage1Text4");
                    break;
               
                case 2:

                    SpeakText("stage1Text5");
                    break;

                case 3:
                   
                   
                    SpeakText("thomasJefferson1Pretext");
                    break;

                case 4:
                   
                    forwardParent.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(false);
                    break;
                case 5: // decision 2 wrong

                    backwardsButton.gameObject.SetActive(false);
                    break;
                case 6: // // decision 2 right
                    moveToMississipi.SetBool("step1", true);
                    break;
                case 7:
                    forwardParent.gameObject.SetActive(false);
                    backwardsButton.gameObject.SetActive(false);
                    break;
                case 8: 
                  
                    break;
                case 9:
                    moveToMississipi.SetBool("step2", true);
                    break;
                case 10: // Decision 3

                    break;
                case 11: // Decision 3 Wrong 1

                    backwardsButton.gameObject.SetActive(false);
                    break;
                case 12: // Decision 3 Wrong 2

                    break;
                case 13: // Decision 3 right
                    moveToMississipi.SetBool("step3", true);
                    break;

                case 14: // complete 1

                    break;

                case 15: // complete 2

                    break;

                case 16: // Empty

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

                if (arrayPos != 8)
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
            textPanal.gameObject.SetActive(false);
            arrayPos = 8;
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator MoveToBlankInvislbePanal()
        {
            yield return new WaitForSeconds(5);
            textPanal.gameObject.SetActive(false);
            arrayPos = 8;
            SceneManager.LoadScene("Stage1Scene5Map");
            Debug.Log("This start coRoutine Runs");
        }

        public IEnumerator StartStage1Scene4()
        {
            yield return new WaitForSeconds(2);
            positionChanged = true;
            textPanal.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start function Runs");
        }

        public IEnumerator ReturnToDecision1()
        {
            yield return new WaitForSeconds(5);
            positionChanged = true;
            arrayPos = 4;
        }

        public IEnumerator MoveFromDecision1()
        {
            yield return new WaitForSeconds(6);
            positionChanged = true;
            arrayPos = 7;
        }

        public void Choice1ButtonNorth()
        {
            positionChanged = true;
            arrayPos = 5;
            StartCoroutine(ReturnToDecision1());
        }

        public void Choice1ButtonEast()
        {
            positionChanged = true;
            arrayPos = 5;
            StartCoroutine(ReturnToDecision1());
        }

        public void Choice1ButtonSouth()
        {
            positionChanged = true;
            arrayPos = 5;
            StartCoroutine(ReturnToDecision1());
        }

        public void Choice1ButtonWest()
        {
            positionChanged = true;
            arrayPos = 6;
        }

        public IEnumerator ReturnToDecision2()
        {
            yield return new WaitForSeconds(5);
            positionChanged = true;
            arrayPos = 7;
        }

        public IEnumerator MoveFromDecision2()
        {
            yield return new WaitForSeconds(6);
            positionChanged = true;
            arrayPos = 10;
        }

        public void Choice2ButtonByForce()
        {
            StartCoroutine(ReturnToDecision2());
            positionChanged = true;
            arrayPos = 8;
        }

        public void Choice2ButtonFreindly()
        {
            positionChanged = true;
            arrayPos = 9;
        }

        public IEnumerator ReturnToDecision3()
        {
            yield return new WaitForSeconds(5);
            positionChanged = true;
            arrayPos = 10;
        }

        public IEnumerator MoveFromDecision3()
        {
            yield return new WaitForSeconds(6);
            positionChanged = true;
            arrayPos = 14;
        }

        public void Choice3ButtonGodplan()
        {
            positionChanged = true;
            arrayPos = 13;
           
        }

        public void Choice3ButtonStayHere()
        {
            positionChanged = true;
            arrayPos = 11;
            StartCoroutine(ReturnToDecision3());
        }

        public void Choice3ButtonGoHome()
        {
            positionChanged = true;
            arrayPos = 12;
            StartCoroutine(ReturnToDecision3());
        }

        public void MoveToOregon()
        {
            SceneManager.LoadScene("Stage2Scene1");
        }
    }
}
