using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene4LangMan : MonoBehaviour
    {
        public TextMeshProUGUI stageStartText;
        public TextMeshProUGUI stage1Scene4Text1;
        public TextMeshProUGUI stage1Scene4Text2;
        public TextMeshProUGUI stage1Scene4Text3;
        public TextMeshProUGUI stage1Scene4Text4;
        public TextMeshProUGUI stage1Scene4Text5;
        public TextMeshProUGUI stage1Scene4Text6;
        public TextMeshProUGUI stage1Scene4Text7;
        public TextMeshProUGUI stage1Scene4Letter1;
        public TextMeshProUGUI stage1Scene4Letter2;
        public TextMeshProUGUI stage1Scene4Letter3;

        public TextMeshProUGUI book1Title;
        public TextMeshProUGUI book2Title;
        public TextMeshProUGUI book3Title;
        public TextMeshProUGUI book4Title;

        public TextMeshProUGUI referenceButton;
        public TextMeshProUGUI referenceButton2;
        public TextMeshProUGUI referenceButton3;
        public TextMeshProUGUI referenceButton4;
        public TextMeshProUGUI citationBook1Info1;
        public TextMeshProUGUI citationBook2Info1;
        public TextMeshProUGUI citationBook2Info2;
        public TextMeshProUGUI citationBook2Info3;
        public TextMeshProUGUI citationBook2Info4;
        public TextMeshProUGUI citationBook3Info;
        public TextMeshProUGUI citationBook4Infoa;
        public TextMeshProUGUI citationBook4Infob;

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
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;


            book1Title.text = defs["book1Title"];
            book2Title.text = defs["book2Title"];
            book3Title.text = defs["book3Title"];
            book4Title.text = defs["book4Title"];

            referenceButton.text = defs["referenceButton"];
            referenceButton2.text = defs["referenceButton"];
            referenceButton3.text = defs["referenceButton"];
            referenceButton4.text = defs["referenceButton"];

            citationBook1Info1.text = defs["citationInfoBook1"];

            citationBook2Info1.text = defs["citationInfoBook2a"];
            citationBook2Info2.text = defs["citationInfoBook2b"];
            citationBook2Info3.text = defs["citationInfoBook2c"];
            citationBook2Info4.text = defs["citationInfoBook2d"];
            citationBook3Info.text = defs["citationInfoBook3"];
            citationBook4Infoa.text = defs["citationInfoBook3"];
            citationBook4Infob.text = defs["citationInfoBook4"];
            stageStartText.text = defs["stage1Scene4Text1"];
            stage1Scene4Text1.text = defs["stage1Scene4Text2"];
            stage1Scene4Text2.text = defs["stage1Scene4Text3"];
            stage1Scene4Text3.text = defs["stage1Scene4Text4"];
            stage1Scene4Text4.text = defs["stage1Scene4Text5"];
            stage1Scene4Text5.text = defs["stage1Scene4Text6"];
            stage1Scene4Text6.text = defs["stage1Scene4Text7"];
            stage1Scene4Text7.text = defs["stage1Scene4Text8"];
            stage1Scene4Letter1.text = defs["politicalEcoCultureLetter1"];
            stage1Scene4Letter2.text = defs["politicalEcoCultureLetter2"];
            stage1Scene4Letter3.text = defs["politicalEcoCultureLetter3"];


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
        }
    }
}
