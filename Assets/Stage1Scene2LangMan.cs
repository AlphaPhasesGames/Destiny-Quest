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

        public TextMeshProUGUI book1Name;
        public TextMeshProUGUI book2Name;

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
        public TextMeshProUGUI referenceButton2;
        public TextMeshProUGUI citationBook1Info1;
        public TextMeshProUGUI citationBook2Info1;
        public TextMeshProUGUI citationBook2Info2;
        public TextMeshProUGUI citationBook2Info3;
        public TextMeshProUGUI citationBook2Info4;
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
        public TextMeshProUGUI miniGame2MoveToParis;
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

            book1Name.text = defs["book1Title"];
            book2Name.text = defs["book2Title"];

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
            referenceButton2.text = defs["referenceButton"];
            citationBook1Info1.text = defs["citationInfoBook2a"];
            citationBook2Info1.text = defs["citationInfoBook2a"];
            citationBook2Info2.text = defs["citationInfoBook2b"];
            citationBook2Info3.text = defs["citationInfoBook2c"];
            citationBook2Info4.text = defs["citationInfoBook2d"];
            jeffersonPreText.text = defs["stage1thomasJefferson1Pretext"];
            letterSection1.text = defs["stage1thomasJefferson1Letter1"];
            letterSection2.text = defs["stage1thomasJefferson2Letter2"];
            letterSection3.text = defs["stage1thomasJefferson3Letter3"];
            letterSection4.text = defs["stage1thomasJefferson4Letter4"];
            jeffersonWP1.text = defs["stage1thomasJeffersonWesternPrior1"];
            jeffersonWP2.text = defs["stage1thomasJeffersonWesternPrior2"];
            jeffersonWP3.text = defs["stage1thomasJeffersonWesternPrior3"];
            Letter2Text.text = defs["stage1Scene2MiniGame2Text"];
            miniGame2Question.text = defs["stage1Scene2MiniGame2Question"];
            miniGame2Correct1.text = defs["stage1Scene2MiniGame2Correct1"];
            miniGame2Correct2.text = defs["stage1Scene2MiniGame2Correct2"];
            miniGame2Correct3.text = defs["stage1Scene2MiniGame2Correct3"];
            miniGame2Incorrect.text = defs["stage1Scene2MiniGame2InCorrect"];
            miniGame2Answer1.text = defs["stage1Scene2MiniGame2Answer1"];
            miniGame2Answer2.text = defs["stage1Scene2MiniGame2Answer2"];
            miniGame2Answer3.text = defs["stage1Scene2MiniGame2Answer3"];
            miniGame2Answer4.text = defs["stage1Scene2MiniGame2Answer4"];
            miniGame2Complete.text = defs["stage1Scene2MiniGame2Complete"];
            miniGame2MoveToParis.text = defs["stage1Scene2MoveToParis"];
    }
    }
}
