using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2LangMan : MonoBehaviour
    {

        public TextMeshProUGUI text1;
        public TextMeshProUGUI text2;
        public TextMeshProUGUI text3;
        public TextMeshProUGUI text4;
        public TextMeshProUGUI textBackToPolk;

        public TextMeshProUGUI concernLaw;
        public TextMeshProUGUI concernDocs;
        public TextMeshProUGUI concernOutlawed;
        public TextMeshProUGUI concernHunt;

        public TextMeshProUGUI concernLawButtonText;
        public TextMeshProUGUI concernDocsButtonText;
        public TextMeshProUGUI concernOutlawedButtonText;
        public TextMeshProUGUI concernHuntButtonText;

        public TextMeshProUGUI text4SelectConcerns;
        public TextMeshProUGUI text5WrongConcerns;
        public TextMeshProUGUI text6RightConcerns;
        public TextMeshProUGUI text7;
        public TextMeshProUGUI text8;
        public TextMeshProUGUI text9;


        public TextMeshProUGUI letter1Head;
        public TextMeshProUGUI letter1a;
        public TextMeshProUGUI letter1b;
        public TextMeshProUGUI letter2Head;
        public TextMeshProUGUI letter2a;
        public TextMeshProUGUI letter2b;
        public TextMeshProUGUI letter3Head;
        public TextMeshProUGUI letter3a;
        public TextMeshProUGUI letter3b;
        public TextMeshProUGUI letter4Head;
        public TextMeshProUGUI letter4a;
        public TextMeshProUGUI letter5Head;
        public TextMeshProUGUI letter5a;
        public TextMeshProUGUI letter5b;

        public TextMeshProUGUI book1BP1;
        public TextMeshProUGUI book1BP2;
        public TextMeshProUGUI book1BP3;
        public TextMeshProUGUI book1BP4;
        public TextMeshProUGUI book1BP5;
        public TextMeshProUGUI book1BP6;
        public TextMeshProUGUI book2BP1;
        public TextMeshProUGUI book2BP2;
        public TextMeshProUGUI book2BP3;
        public TextMeshProUGUI book2BP4;
        public TextMeshProUGUI book3BP1;
        public TextMeshProUGUI book3BP2;
        public TextMeshProUGUI book3BP3;
        public TextMeshProUGUI book3BP4;
        public TextMeshProUGUI book4BP1;
        public TextMeshProUGUI book4BP2;
        public TextMeshProUGUI book4BP3;
        public TextMeshProUGUI book4BP4;
        public TextMeshProUGUI book5BP1;
        public TextMeshProUGUI book5BP2;
        public TextMeshProUGUI book5BP3;
        public TextMeshProUGUI book5BP4;
        public TextMeshProUGUI book5BP5;
        public TextMeshProUGUI book5BP6;
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            text1.text = defs["stage3Scene2Text1"];
            text2.text = defs["stage3Scene2Text2"];
            text3.text = defs["stage3Scene2Text3"];
            text4.text = defs["stage3Scene2Text4"];

            concernLaw.text = defs["stage3Scene2UsConcern1Laws"];
            concernDocs.text = defs["stage3Scene2UsConcern2Docs"];
            concernOutlawed.text = defs["stage3Scene2UsConcern3Outlawed"];
            concernHunt.text = defs["stage3Scene2UsConcern4Hunt"];

            concernLawButtonText.text = defs["stage3Scene2UsConcern1Laws"];
            concernDocsButtonText.text = defs["stage3Scene2UsConcern2Docs"];
            concernOutlawedButtonText.text = defs["stage3Scene2UsConcern3Outlawed"];
            concernHuntButtonText.text = defs["stage3Scene2UsConcern4Hunt"];

            textBackToPolk.text = defs["stage3Scene2ReturnToPolk"];

            text4SelectConcerns.text = defs["stage3Scene2Text4Select"];
            text5WrongConcerns.text = defs["stage3Scene2Text5Wrong"];
            text6RightConcerns.text = defs["stage3Scene2Text6Correct"];
            text7.text = defs["stage3Scene2Text7"];
            text8.text =defs["stage3Scene2Text8"];
            text9.text = defs["stage3Scene2Text9End"];

            letter1Head.text = defs["mexicoLetter1header"];
            letter1a.text = defs["mexicoLetter1a"];
            letter1b.text = defs["mexicoLetter1b"];
            letter2Head.text = defs["mexicoLetter2header"];
            letter2a.text = defs["mexicoLetter2a"];
            letter2b.text = defs["mexicoLetter2b"];
            letter3Head.text = defs["mexicoLetter3header"];
            letter3a.text = defs["mexicoLetter3a"];
            letter3b.text = defs["mexicoLetter3b"];
            letter4Head.text = defs["mexicoLetter4header"];
            letter4a.text = defs["mexicoLetter4a"];
            letter5Head.text = defs["mexicoLetter3header"];
            letter5a.text = defs["mexicoLetter5a"];
            letter5b.text = defs["mexicoLetter5b"];

        }
    }
}
