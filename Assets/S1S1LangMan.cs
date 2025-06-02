using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class S1S1LangMan : MonoBehaviour
    {
        public TextMeshProUGUI newGameText;
        public TextMeshProUGUI continueGameText;
        public TextMeshProUGUI iPadButton;
        public TextMeshProUGUI continueButton;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            newGameText.text = defs["newGame"];
            continueGameText.text = defs["continue"];
            iPadButton.text = defs["ipadButton"];
            continueButton.text = defs["chromebookButton"];
        }
    }
}
