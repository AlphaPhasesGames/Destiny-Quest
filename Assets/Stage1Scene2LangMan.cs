using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene2LangMan : MonoBehaviour
    {
        public TextMeshProUGUI stageStartText;
        public TextMeshProUGUI sign1TextIncorrect;
        public TextMeshProUGUI sign2TextCorrect;
        public TextMeshProUGUI sign3TextIncorrect;
        public TextMeshProUGUI LetterText;
        public TextMeshProUGUI signQuestion;
        public TextMeshProUGUI signCorrect;
        public TextMeshProUGUI signIncorrect;
        public TextMeshProUGUI book1BP1;
        public TextMeshProUGUI book1BP2;
        public TextMeshProUGUI book1BP3;
        public TextMeshProUGUI book1BP4;
        public TextMeshProUGUI book1BP5;
        public TextMeshProUGUI book1BP6;
        public TextMeshProUGUI referenceButton;
        public TextMeshProUGUI citationInfo;
        public TextMeshProUGUI jeffersonPreText;
        public TextMeshProUGUI letterSection1;
        public TextMeshProUGUI letterSection2;
        public TextMeshProUGUI letterSection3;
        public TextMeshProUGUI letterSection4;
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            stageStartText.text = defs["stage1Text1"];
            LetterText.text = defs["stage1Text2"];
            signQuestion.text = defs["stage1Text3"];
            signIncorrect.text = defs["stage1Text4"];
            signCorrect.text = defs["stage1Text5"];
            sign1TextIncorrect.text = defs["signText2"];
            sign2TextCorrect.text = defs["signText1"];
            sign3TextIncorrect.text = defs["signText3"];
            book1BP1.text = defs["book1BP1"];
            book1BP2.text = defs["book1BP2"];
            book1BP3.text = defs["book1BP3"];
            book1BP4.text = defs["book1BP4"];
            book1BP5.text = defs["book1BP5"];
            book1BP6.text = defs["book1BP6"];
            referenceButton.text = defs["referenceButton"];
            citationInfo.text = defs["citationInfoBook1"];
            jeffersonPreText.text = defs["thomasJefferson1Pretext"];
            letterSection1.text = defs["thomasJefferson1Letter1"];
            letterSection2.text = defs["thomasJefferson1Letter2"];
            letterSection3.text = defs["thomasJefferson1Letter3"];
            letterSection4.text = defs["thomasJefferson1Letter4"];
        }
    }
}
