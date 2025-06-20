using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage2Scene1LangMan : MonoBehaviour
    {
        public TextMeshProUGUI text1;
        public TextMeshProUGUI text2;
        public TextMeshProUGUI text3;
        public TextMeshProUGUI text4;
        public TextMeshProUGUI text5;
        public TextMeshProUGUI text6;
        public TextMeshProUGUI text7;
        public TextMeshProUGUI text7Choice1;
        public TextMeshProUGUI text7Choice2;
        public TextMeshProUGUI text8;
        public TextMeshProUGUI text9;

        public TextMeshProUGUI letterPage1;
        public TextMeshProUGUI letterPage2;
        public TextMeshProUGUI letterPage3;
        public TextMeshProUGUI letterPage4;

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

            text1.text = defs["stage2Scene1Text1"];
            text2.text = defs["stage2Scene1Text2"];
            text3.text = defs["stage2Scene1Text3"];
            text4.text = defs["stage2Scene1Text4"];
            text5.text = defs["stage2Scene1Text5"];
            text6.text = defs["stage2Scene1Text6"];
            text7.text = defs["stage2Scene1Text7"];
            text7Choice1.text = defs["stage2Scene1Text7Choice1"];
            text7Choice2.text = defs["stage2Scene1Text7Choice2"];
            text8.text = defs["stage2Scene1Text8"];
            text9.text = defs["stage2Scene1Text9"];

            letterPage1.text = defs["oregonLetter1"];
            letterPage2.text = defs["oregonLetter2"];
            letterPage3.text = defs["oregonLetter3"];
            letterPage4.text = defs["oregonLetter4"];

            book1BP1.text = defs["book1BP1"];
            book1BP2.text = defs["book1BP2"];
            book1BP3.text = defs["book1BP3"];
            book1BP4.text = defs["book1BP4"];
            book1BP5.text = defs["book1BP5"];
            book1BP6.text = defs["book1BP6"];
            book2BP1.text = defs["book2BP1"];
            book2BP2.text = defs["book2BP2"];
            book2BP3.text = defs["book2BP3"];
            book2BP4.text = defs["book2BP4"];
            book3BP1.text = defs["book3BP1"];
            book3BP2.text = defs["book3BP2"];
            book3BP3.text = defs["book3BP3"];
            book3BP4.text = defs["book3BP4"];
            book4BP1.text = defs["book4BP1"];
            book4BP2.text = defs["book4BP2"];
            book4BP3.text = defs["book4BP3"];
            book4BP4.text = defs["book4BP4"];
            book5BP1.text = defs["book5BP1"];
            book5BP2.text = defs["book5BP2"];
            book5BP3.text = defs["book5BP3"];
            book5BP4.text = defs["book5BP4"];
            book5BP5.text = defs["book5BP5"];
            book5BP6.text = defs["book5BP6"];
        }
        

    }
}
