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
        public TextMeshProUGUI book2BP1;
        public TextMeshProUGUI book2BP2;
        public TextMeshProUGUI book2BP3;
        public TextMeshProUGUI book2BP4;
        public TextMeshProUGUI referenceButton;
        public TextMeshProUGUI citationInfo;
        public TextMeshProUGUI jeffersonPreText;
        public TextMeshProUGUI letterSection1;
        public TextMeshProUGUI letterSection2;
        public TextMeshProUGUI letterSection3;
        public TextMeshProUGUI letterSection4;
        public TextMeshProUGUI jeffersonWP1;
        public TextMeshProUGUI jeffersonWP2;
        public TextMeshProUGUI jeffersonWP3;
        public TextMeshProUGUI Letter2Text;
        public TextMeshProUGUI miniGame2Question;
        public TextMeshProUGUI miniGame2Correct1;
        public TextMeshProUGUI miniGame2Correct2;
        public TextMeshProUGUI miniGame2Correct3;
        public TextMeshProUGUI miniGame2Incorrect;
        public TextMeshProUGUI miniGame2Answer1;
        public TextMeshProUGUI miniGame2Answer2;
        public TextMeshProUGUI miniGame2Answer3;
        public TextMeshProUGUI miniGame2Answer4;
        public TextMeshProUGUI miniGame2Complete;
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
            book2BP1.text = defs["book2BP1"];
            book2BP2.text = defs["book2BP2"];
            book2BP3.text = defs["book2BP3"];
            book2BP4.text = defs["book2BP4"];
            referenceButton.text = defs["referenceButton"];
            citationInfo.text = defs["citationInfoBook1"];
            jeffersonPreText.text = defs["thomasJefferson1Pretext"];
            letterSection1.text = defs["thomasJefferson1Letter1"];
            letterSection2.text = defs["thomasJefferson2Letter2"];
            letterSection3.text = defs["thomasJefferson3Letter3"];
            letterSection4.text = defs["thomasJefferson4Letter4"];
            jeffersonWP1.text = defs["thomasJeffersonWesternPrior1"];
            jeffersonWP2.text = defs["thomasJeffersonWesternPrior2"];
            jeffersonWP3.text = defs["thomasJeffersonWesternPrior3"];
            Letter2Text.text = defs["Stage1Scene2MiniGame2Text"];
            miniGame2Question.text = defs["Stage1Scene2MiniGame2Question"];
            miniGame2Correct1.text = defs["Stage1Scene2MiniGame2Correct1"];
            miniGame2Correct2.text = defs["Stage1Scene2MiniGame2Correct2"];
            miniGame2Correct3.text = defs["Stage1Scene2MiniGame2Correct3"];
            miniGame2Incorrect.text = defs["Stage1Scene2MiniGame2InCorrect"];
            miniGame2Answer1.text = defs["Stage1Scene2MiniGame2Answer1"];
            miniGame2Answer2.text = defs["Stage1Scene2MiniGame2Answer2"];
            miniGame2Answer3.text = defs["Stage1Scene2MiniGame2Answer3"];
            miniGame2Answer4.text = defs["Stage1Scene2MiniGame2Answer4"];
            miniGame2Complete.text = defs["Stage1Scene2MiniGame2Complete"];
    }
    }
}
