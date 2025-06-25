using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene1MiniGameManager : MonoBehaviour
    {
        public Stage3Scene1TextMan textman;

        public Button correct1HardWorking;
        public Button correct2Citizen;
        public Button correct3Catholic;
        public Button incorrect4Hunting;
        public Button incorrect5StayLimit;

        public GameObject correct1Paper;
        public Button correctTick;
        public Button incorrectCross;

        public GameObject correct2Paper;
        public Button correct2Tick;
        public Button incorrect2Cross;

        public GameObject correct3Paper;
        public Button correct3Tick;
        public Button incorrect3Cross;

        public GameObject correct4Paper;
        public Button correct4Tick;
        public Button incorrect4Cross;

        public GameObject correct5Paper;
        public Button correct5Tick;
        public Button incorrect5Cross;

        public bool correct1;
        public bool correct2;
        public bool correct3;

        public GameObject tick1;
        public GameObject tick2;
        public GameObject tick3;

        private void Awake()
        {
            correct1HardWorking.onClick.AddListener(FindCorrect1);
            correct2Citizen.onClick.AddListener(FindCorrect2);
            correct3Catholic.onClick.AddListener(FindCorrect3);
            incorrect4Hunting.onClick.AddListener(FindInCorrect4);
            incorrect5StayLimit.onClick.AddListener(FindInCorrect5);

            correctTick.onClick.AddListener(GetCorrect1Correct);
            correct2Tick.onClick.AddListener(GetCorrect2Correct);
            correct3Tick.onClick.AddListener(GetCorrect3Correct);
            correct4Tick.onClick.AddListener(GetCorrect4InCorrect);
            correct5Tick.onClick.AddListener(GetCorrect5InCorrect);

            incorrectCross.onClick.AddListener(GetAnyIncorrect);
            incorrect2Cross.onClick.AddListener(GetAnyIncorrect2);
            incorrect3Cross.onClick.AddListener(GetAnyIncorrect3);
            incorrect4Cross.onClick.AddListener(GetAnyIncorrect4);
            incorrect5Cross.onClick.AddListener(GetAnyIncorrect5);

        }

        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            if(correct1 && correct2 && correct3)
            {
                StartCoroutine(CompleteStage());
            }
        }

        public void FindCorrect1() 
        {
            textman.positionChanged = true;
            correct1Paper.gameObject.SetActive(true);
            textman.arrayPos = 3;
            textman.ResetBools();
        }

        public void FindCorrect2()
        {
            textman.positionChanged = true;
            correct2Paper.gameObject.SetActive(true);
            textman.arrayPos = 3;
            textman.ResetBools();
        }

        public void FindCorrect3()
        {
            correct3Paper.gameObject.SetActive(true);
            textman.positionChanged = true;
            textman.arrayPos = 3;
            textman.ResetBools();
        }

        public void FindInCorrect4()
        {
            correct4Paper.gameObject.SetActive(true);
            textman.positionChanged = true;
            textman.arrayPos = 3;
            textman.ResetBools();
        }

        public void FindInCorrect5()
        {
            correct5Paper.gameObject.SetActive(true);
            textman.positionChanged = true;
            textman.arrayPos = 3;
            textman.ResetBools();
        }

        public void GetCorrect1Correct()
        {
            correct1Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 4;
            tick1.gameObject.SetActive(true);
            correct1 = true;
        }

        public void GetCorrect2Correct()
        {
            correct2Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 5;
            tick2.gameObject.SetActive(true);
            correct2 = true;
        }

        public void GetCorrect3Correct()
        {
            correct3Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 6;
            tick3.gameObject.SetActive(true);
            correct3 = true;
        }

        public void GetCorrect4InCorrect()
        {
            correct4Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 7;
        }

        public void GetCorrect5InCorrect()
        {
            correct5Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 8;
        }

        public void GetAnyIncorrect()
        {
            correct1Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 11;
        }

        public void GetAnyIncorrect2()
        {
            correct2Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 11;
        }

        public void GetAnyIncorrect3()
        {
            correct3Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 11;
        }

        public void GetAnyIncorrect4()
        {
            correct4Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 11;
        }

        public void GetAnyIncorrect5()
        {
            correct5Paper.gameObject.SetActive(false);
            textman.positionChanged = true;
            textman.arrayPos = 11;
        }

        public IEnumerator CompleteStage()
        {
            yield return new WaitForSeconds(6);
            textman.positionChanged = true;
            textman.arrayPos = 9;
        }
    }
}
