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

        public Button journalEntry1TTS;         
        public Button journalEntry2TTS;
        public Button journalEntry3TTS;
        public Button journalEntry4TTS;
        private void Awake()
        {
            closeJournal.onClick.AddListener(CloseText1);
            journalEntry1TTS.onClick.AddListener(PlayJournal1TTS);
            journalEntry2TTS.onClick.AddListener(PlayJournal2TTS);
            journalEntry3TTS.onClick.AddListener(PlayJournal3TTS);
            journalEntry4TTS.onClick.AddListener(PlayJournal4TTS);
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

        public void PlayJournal1TTS()
        {
            LOLSDK.Instance.SpeakText("mapJournalEntry1");
        }

        public void PlayJournal2TTS()
        {
            LOLSDK.Instance.SpeakText("mapJournalEntry2");
        }

        public void PlayJournal3TTS()
        {
            LOLSDK.Instance.SpeakText("mapJournalEntry3");
        }

        public void PlayJournal4TTS()
        {
            LOLSDK.Instance.SpeakText("mapJournalEntry4");
        }
    }
}
