using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene5JournalManager : MonoBehaviour
    {
        public Button closeJournal;
        public GameObject journalPaper;
        public GameObject journalEntry1;
        public GameObject journalEntry2;
        public GameObject journalEntry3;
        public GameObject forwardParentButton;
        public GameObject forwardChildButton;
        private void Awake()
        {
            closeJournal.onClick.AddListener(CloseText1);

        }



        public void CloseText1()
        {
            journalPaper.gameObject.SetActive(false);
            journalEntry1.gameObject.SetActive(false);
            journalEntry2.gameObject.SetActive(false);
            journalEntry3.gameObject.SetActive(false);
            forwardParentButton.gameObject.SetActive(true);
            forwardChildButton.gameObject.SetActive(true);
        }
    }
}
