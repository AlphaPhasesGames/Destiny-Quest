using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2PolkConcernSelectMan : MonoBehaviour
    {
        public Stage3Scene2TextMan textMan;

        public Button concernSelection1Laws;
        public Button concernSelection2Docs;
        public Button concernSelection3Outlawed;
        public Button concernSelection4Hunt;

        public bool concern1Correct;
        public bool concern2Correct;
        public bool concern3Correct;
        public bool concern4Incorrect;
        public bool runONce;
        public GameObject concern1BGSelected;
        public GameObject concern2BGSelected;
        public GameObject concern3BGSelected;
        public GameObject concern4BGSelected;

        private void Awake()
        {
            concernSelection1Laws.onClick.AddListener(ConcernSelectLawsButton);
            concernSelection2Docs.onClick.AddListener(ConcernSelectDocsButton);
            concernSelection3Outlawed.onClick.AddListener(ConcernSelectOutlawedButton);
            concernSelection4Hunt.onClick.AddListener(ConcernSelectHuntButton);
        }

        private void Update()
        {
            if(concern1Correct && concern2Correct && concern3Correct && !concern4Incorrect)
            {
                if (!runONce)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 7;
                    runONce = true;
                }

            }

            if (concern4Incorrect)
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 6;
            }
        }


        public void ConcernSelectLawsButton()
        {
            concern1Correct = !concern1Correct;
            concern1BGSelected.SetActive(concern1Correct);
        }

        public void ConcernSelectDocsButton()
        {
            concern2Correct = !concern2Correct;
            concern2BGSelected.SetActive(concern2Correct);
        }

        public void ConcernSelectOutlawedButton()
        {
            concern3Correct = !concern3Correct;
            concern3BGSelected.SetActive(concern3Correct);
        }

        public void ConcernSelectHuntButton()
        {
            concern4Incorrect = !concern4Incorrect;
            concern4BGSelected.SetActive(concern4Incorrect);
            textMan.ResetBools();
        }
    }
}
