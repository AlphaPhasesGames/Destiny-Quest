using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4LangMan : MonoBehaviour
    {
        public TextMeshProUGUI text1;
        public TextMeshProUGUI text2;
        public TextMeshProUGUI text3;
        public TextMeshProUGUI text4;
        public TextMeshProUGUI text5;
        public TextMeshProUGUI text6;
        public TextMeshProUGUI text7;
        public TextMeshProUGUI text8;
        public TextMeshProUGUI text9;

        public TextMeshProUGUI letter1a;
        public TextMeshProUGUI letter1b;

        public TextMeshProUGUI letter2a;
        public TextMeshProUGUI letter2b;

        public TextMeshProUGUI letter3a;
        public TextMeshProUGUI letter3b;

        public TextMeshProUGUI book1Title;
        public TextMeshProUGUI book2Title;
        public TextMeshProUGUI book3Title;
        public TextMeshProUGUI book4Title;
        public TextMeshProUGUI book5Title;
        public TextMeshProUGUI book6Title;
        public TextMeshProUGUI book7Title;
        public TextMeshProUGUI book8Title;
        public TextMeshProUGUI book9Title;

        public TextMeshProUGUI referenceButton;
        public TextMeshProUGUI referenceButton2;
        public TextMeshProUGUI referenceButton3;
        public TextMeshProUGUI referenceButton4;
        public TextMeshProUGUI referenceButton5;
        public TextMeshProUGUI referenceButton6;
        public TextMeshProUGUI referenceButton7;
        public TextMeshProUGUI referenceButton8;
        public TextMeshProUGUI referenceButton9;

        public TextMeshProUGUI citationBook1Info1;
        public TextMeshProUGUI citationBook2Info1;
        public TextMeshProUGUI citationBook2Info2;
        public TextMeshProUGUI citationBook2Info3;
        public TextMeshProUGUI citationBook2Info4;
        public TextMeshProUGUI citationBook3Info;
        public TextMeshProUGUI citationBook4Infoa;
        public TextMeshProUGUI citationBook4Infob;
        public TextMeshProUGUI citationBook5Info;
        public TextMeshProUGUI citationBook6Info;
        public TextMeshProUGUI citationBook7Info;
        public TextMeshProUGUI citationBook8aInfo;
        public TextMeshProUGUI citationBook8bInfo;
        public TextMeshProUGUI citationBook8cInfo;

        public TextMeshProUGUI citationBook9Info;
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
        public TextMeshProUGUI book6BP1;
        public TextMeshProUGUI book6BP2;
        public TextMeshProUGUI book6BP3;
        public TextMeshProUGUI book6BP4;
        public TextMeshProUGUI book6BP5;
        public TextMeshProUGUI book6BP6;
        public TextMeshProUGUI book7BP1;
        public TextMeshProUGUI book7BP2;
        public TextMeshProUGUI book7BP3;
        public TextMeshProUGUI book7BP4;
        public TextMeshProUGUI book7BP5;
        public TextMeshProUGUI book7BP6;
        public TextMeshProUGUI book8BP1;
        public TextMeshProUGUI book8BP2;
        public TextMeshProUGUI book8BP3;
        public TextMeshProUGUI book8BP4;
        public TextMeshProUGUI book8BP5;
        public TextMeshProUGUI book8BP6;
        public TextMeshProUGUI book9BP1;
        public TextMeshProUGUI book9BP2;
        public TextMeshProUGUI book9BP3;
        public TextMeshProUGUI book9BP4;
        public TextMeshProUGUI book9BP5;
        public TextMeshProUGUI book9BP6;
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            text1.text = defs["stage4Scene1Text1"];
            text2.text = defs["stage4Scene1Text2"];
            text3.text = defs["stage4Scene1Text3"];
            text4.text = defs["stage4Scene1Text4"];
            text5.text = defs["stage4Scene1Text5"];

            text6.text = defs["stage4Scene1Text6"];
            text7.text = defs["stage4Scene1Text7"];
            text8.text = defs["stage4Scene1Text9"];
            text9.text = defs["stage4Scene1Text8"];

            letter1a.text = defs["treatyLetter1a"];
            letter1b.text = defs["treatyLetter1b"];

            letter2a.text = defs["treatyLetter2a"];
            letter2b.text = defs["treatyLetter2b"];

            letter3a.text = defs["treatyLetter3a"];
            letter3b.text = defs["treatyLetter3b"];


            book1Title.text = defs["book1Title"];
            book2Title.text = defs["book2Title"];
            book3Title.text = defs["book3Title"];
            book4Title.text = defs["book4Title"];
            book5Title.text = defs["book5Title"];
            book6Title.text = defs["book6Title"];
            book7Title.text = defs["book7Title"];
            book8Title.text = defs["book8Title"];
            book9Title.text = defs["book9Title"];



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

            book6BP1.text = defs["book6P1"];
            book6BP2.text = defs["book6BP2"];
            book6BP3.text = defs["book6BP3"];
            book6BP4.text = defs["book6BP4"];
            book6BP5.text = defs["book6BP5"];
            book6BP6.text = defs["book6BP6"];


            book7BP1.text = defs["book7P1"];
            book7BP2.text = defs["book7BP2"];
            book7BP3.text = defs["book7BP3"];
            book7BP4.text = defs["book7BP4"];
            book7BP5.text = defs["book7BP5"];
            book7BP6.text = defs["book7BP6"];

            book8BP1.text = defs["book8P1"];
            book8BP2.text = defs["book8BP2"];
            book8BP3.text = defs["book8BP3"];
            book8BP4.text = defs["book8BP4"];
            book8BP5.text = defs["book8BP5"];
            book8BP6.text = defs["book8BP6"];


            book9BP1.text = defs["book9P1"];
            book9BP2.text = defs["book9BP2"];
            book9BP3.text = defs["book9BP3"];
            book9BP4.text = defs["book9BP4"];
            book9BP5.text = defs["book9BP5"];
            book9BP6.text = defs["book9BP6"];

            referenceButton.text = defs["referenceButton"];
            referenceButton2.text = defs["referenceButton"];
            referenceButton3.text = defs["referenceButton"];
            referenceButton4.text = defs["referenceButton"];
            referenceButton5.text = defs["referenceButton"];
            referenceButton6.text = defs["referenceButton"];
            referenceButton7.text = defs["referenceButton"];
            referenceButton8.text = defs["referenceButton"];
            referenceButton9.text = defs["referenceButton"];

            citationBook1Info1.text = defs["citationInfoBook1"];

            citationBook2Info1.text = defs["citationInfoBook2a"];
            citationBook2Info2.text = defs["citationInfoBook2b"];
            citationBook2Info3.text = defs["citationInfoBook2c"];
            citationBook2Info4.text = defs["citationInfoBook2d"];
            citationBook3Info.text = defs["citationInfoBook3"];
            citationBook4Infoa.text = defs["citationInfoBook4"]; // not a mistake, same as the previous stage for one of the citations
            citationBook5Info.text = defs["citationInfoBook5"];
            citationBook6Info.text = defs["citationInfoBook6"];
            citationBook7Info.text = defs["citationInfoBook7"];
            citationBook8aInfo.text = defs["citationInfoBook8"];
            citationBook8bInfo.text = defs["citationInfoBook8b"];
            citationBook8cInfo.text = defs["citationInfoBook8c"];
            citationBook9Info.text = defs["citationInfoBook9"];
        }
    }
}
