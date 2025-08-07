using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene4LetterToMaW : MonoBehaviour
    {
        public Button closeLetter;
        public Button textExcerpt1TTS;
        public Button textExcerpt2TTS;
        public Button textExcerpt3TTS;

        public GameObject letterObject;
        public PlayerMovement playerMoveScript; // Handles player movement logic
        private void Awake()
        {
            closeLetter.onClick.AddListener(CloseLetter);
            textExcerpt1TTS.onClick.AddListener(SpeakTaskText1TTS);
            textExcerpt2TTS.onClick.AddListener(SpeakTaskText2TTS);
            textExcerpt3TTS.onClick.AddListener(SpeakTaskText3TTS);
        }


        public void SpeakTaskText1TTS()
        {
            LOLSDK.Instance.SpeakText("scene1Stage4ThomasJeffersonLetterToLaC1");
        }
        public void SpeakTaskText2TTS()
        {
            LOLSDK.Instance.SpeakText("scene1Stage4ThomasJeffersonLetterToLaC1");
        }
        public void SpeakTaskText3TTS()
        {
            LOLSDK.Instance.SpeakText("scene1Stage4ThomasJeffersonLetterToLaC1");
        }

        public void CloseLetter()
        {
            letterObject.gameObject.SetActive(false);
            playerMoveScript.enabled = true;
        }

    }
}
