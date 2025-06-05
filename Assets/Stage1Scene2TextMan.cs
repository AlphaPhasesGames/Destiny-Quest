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
        // public PatternQuestMain main;
        public PlayerMovement playerMoveScript;
        public GameObject s1s2Letter;
        public GameObject s1s2TommyLetter;
        public bool hasScrolled;
        public GameObject currentTextSection;
        public int arrayPos;
        public int maxLengthArray;
        public int minLengthArray = 1;

        public bool positionChanged; //= true;

        public GameObject[] modelArray;
        public GameObject textPanal;

        // public GameObject letterOpen;

        public bool panalOpen;
        public bool runOnce;
        public bool runOnce2;
        public bool submitOnce;
        public GameObject forwardParent;
        public Button forwardButton;
        public Button backwardsButton;

        public Button[] textButtons;
        public bool[] textBools;
        // public bool inventoryReadToBeOpen;
        public NavMeshAgent agent;

        private void Awake()
        {
            forwardButton.onClick.AddListener(ProgressTextForward);
            backwardsButton.onClick.AddListener(ProgressTextBack);
            //   main = GameObject.FindObjectOfType<PatternQuestMain>();
            for (int i = 0; i < textButtons.Length; i++)
            {
                int index = i + 1;  // Adjust index to match textButton number
                textButtons[i].onClick.AddListener(() => IntroTTSSpeak(index));
            }

            StartCoroutine(StartStage1());
          //  agent = GetComponent<NavMeshAgent>();
        }

        // Start is called before the first frame update
        void Start()
        {
            maxLengthArray = modelArray.Length;
            textBools = new bool[maxLengthArray];
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                StartCoroutine(OpenLetter());
            }

            // Only process if the position has changed
            if (positionChanged)
            {
                positionChanged = false; // Reset flag after processing


                // Deactivate all text objects, activate only the current one
                for (int i = 0; i < modelArray.Length; i++)
                {
                    modelArray[i].SetActive(i == arrayPos);
                }

                // Handle the current array position if not yet processed
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
                    StartCoroutine(OpenLetter());
                    playerMoveScript.enabled = false;
                    textPanal.gameObject.SetActive(true);
                    backwardsButton.gameObject.SetActive(false);
                    forwardParent.gameObject.SetActive(false);
                    SpeakText("stage1Text1");
                    Debug.Log("Array1Fires");
                    break;
            case 1:
                    textPanal.gameObject.SetActive(true);
                    StartCoroutine(MoveToBlankInvislbePanalUnit17());
                    SpeakText("stage1Text4"); break;
            case 2:
                    textPanal.gameObject.SetActive(true);
                    
                    StartCoroutine(MoveToTommyJefferson());
                    SpeakText("stage1Text5"); break;
                
            case 3:
                   
                    backwardsButton.gameObject.SetActive(false);
                    //textPanal.gameObject.SetActive(true);
                    StartCoroutine(OpenTommyLetter());
                    SpeakText("thomasJefferson1Pretext"); break;
                /*
    case 4:
        textPanal.gameObject.SetActive(true);
        //inventoryReadToBeOpen = true;
        break;
    case 5:
        textPanal.gameObject.SetActive(true);
        break;
    case 6:
        break;
    case 7:
        break;*/
                case 4:
                    textPanal.gameObject.SetActive(false);
                    agent.isStopped = false;
                    break;

            }
        }

        public void IntroTTSSpeak(int textIndex)
        {
            string textKey = $"stage1Text{textIndex}";
            LOLSDK.Instance.SpeakText(textKey);
            Debug.Log($"labText{textIndex} Button is pressed");
        }


        public void ProgressTextForward()
        {
            if (arrayPos < maxLengthArray - 1)
            {
                arrayPos++;
                positionChanged = true;
                hasScrolled = false;
                forwardButton.gameObject.SetActive(false);

                // Only run DelayTextButton if the next arrayPos is not 2
                if (arrayPos != 3)
                {
                 StartCoroutine(DelayTextButton());
               }

               // if (arrayPos != 0)
              //  {
             //       StartCoroutine(DelayTextButton());
             //   }
            }
        }


        public void ProgressTextBack()
        {

            if (arrayPos > minLengthArray)
            {
                arrayPos--;
                positionChanged = true; // Mark position as changed
                hasScrolled = false;
                Array.Fill(textBools, false);
            }
        }

        public void ResetPositionFlags()
        {
            Array.Fill(textBools, false); // Reset all boolean flags for text
            positionChanged = true;       // Mark position as changed for Update() processing
        }


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

            yield return new WaitForSeconds(3);
            forwardParent.gameObject.SetActive(true);
            forwardButton.gameObject.SetActive(true);
            Debug.Log("This coRoutine Runs");

        }

        public IEnumerator MoveToBlankInvislbePanalUnit17()
        {
            yield return new WaitForSeconds(5);
            playerMoveScript.enabled = true;
            textPanal.gameObject.SetActive(false);
            arrayPos = 4;
            Debug.Log("This start coRoutine Runs");

        }

        public IEnumerator OpenLetter()
        {
            yield return new WaitForSeconds(4);
            playerMoveScript.enabled = true;
            s1s2Letter.gameObject.SetActive(true);
            textPanal.gameObject.SetActive(false);
            arrayPos = 4;
            Debug.Log("This start coRoutine Runs well");

        }

        public IEnumerator OpenTommyLetter()
        {
            yield return new WaitForSeconds(4);
            playerMoveScript.enabled = true;
            s1s2TommyLetter.gameObject.SetActive(true);
            textPanal.gameObject.SetActive(false);
            arrayPos = 4;
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
          //`  forwardParent.gameObject.SetActive(true);
            arrayPos = 0;
            Debug.Log("This start coRoutine Runs");

        }

    }
}

