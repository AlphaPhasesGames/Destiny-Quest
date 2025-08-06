using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class SigningPageLangMan : MonoBehaviour
    {

        public TextMeshProUGUI letterpage1;
        public TextMeshProUGUI letterpage1a;
        public TextMeshProUGUI letterpage2;
        public TextMeshProUGUI letterpage3;
        public TextMeshProUGUI letterpage4;

        public TextMeshProUGUI signingText1BeforeMexcianCession;
        public TextMeshProUGUI signingText1AfterMexcianCession;
        public TextMeshProUGUI thankYouForPlaying;
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            letterpage1.text = defs["endGame1"];
            letterpage1a.text = defs["endGame2"];
            letterpage2.text = defs["endGame3"];
            letterpage3.text = defs["endGame4"];
            letterpage4.text = defs["endGame5"];

            signingText1BeforeMexcianCession.text = defs["signingScreenText1"];
            signingText1AfterMexcianCession.text = defs["signingScreenText2"];
            thankYouForPlaying.text = defs["signingScreenText3"];

        }
    }
}
