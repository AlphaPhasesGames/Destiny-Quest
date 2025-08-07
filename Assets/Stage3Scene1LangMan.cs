using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene1LangMan : MonoBehaviour
    {
        public TextMeshProUGUI text1;
        public TextMeshProUGUI text2;

        public TextMeshProUGUI letter1Head;
        public TextMeshProUGUI letter1;
        public TextMeshProUGUI letter2Head;
        public TextMeshProUGUI letter2;
        public TextMeshProUGUI letter3Head;
        public TextMeshProUGUI letter3;

        public TextMeshProUGUI text3;
        public TextMeshProUGUI text4Task;

        public TextMeshProUGUI book1Title;
        public TextMeshProUGUI book2Title;
        public TextMeshProUGUI book3Title;
        public TextMeshProUGUI book4Title;
        public TextMeshProUGUI book5Title;
        public TextMeshProUGUI book6Title;

        public TextMeshProUGUI referenceButton;
        public TextMeshProUGUI referenceButton2;
        public TextMeshProUGUI referenceButton3;
        public TextMeshProUGUI referenceButton4;
        public TextMeshProUGUI referenceButton5;
        public TextMeshProUGUI referenceButton6;

        public TextMeshProUGUI citationBook1Info1;
        public TextMeshProUGUI citationBook2Info1;
        public TextMeshProUGUI citationBook2Info2;
        public TextMeshProUGUI citationBook2Info3;
        public TextMeshProUGUI citationBook2Info4;
        public TextMeshProUGUI citationBook3Info;
        public TextMeshProUGUI citationBook4Infoa;
        public TextMeshProUGUI citationBook4Infob;
        public TextMeshProUGUI citationBook4InfoCLetterToLaCTitle;
        public TextMeshProUGUI citationBook4InfoCLetterToLaCCitation;
        public TextMeshProUGUI citationBook5Info;
        public TextMeshProUGUI citationBook5bInfoTitle;
        public TextMeshProUGUI citationBook5bSource;
        public TextMeshProUGUI citationBook5bCredit;

        public TextMeshProUGUI citationBook6Info;

        public TextMeshProUGUI rule1;
        public TextMeshProUGUI rule2;
        public TextMeshProUGUI rule3;
        public TextMeshProUGUI rule4;
        public TextMeshProUGUI rule5;

        public TextMeshProUGUI IsThisCorrect;

        public TextMeshProUGUI rule1AnswerCorrectGoodPeople;
        public TextMeshProUGUI rule2AnswerCorrectMexicanCitizen;
        public TextMeshProUGUI rule3AnswerCorrectCatholicChurch;
        public TextMeshProUGUI rule4AnswerInCorrectHunt;
        public TextMeshProUGUI rule5AnswerInCorrectStayLimit;

        public TextMeshProUGUI text5End;

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

        // Start is called before the first frame update
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            text1.text = defs["stage3Scene1Text1"];
            text2.text = defs["stage3Scene1Text2"];

            letter1Head.text = defs["texasLetter1header"];
            letter1.text = defs["texasLetter1"];
            letter2Head.text = defs["texasLetter2header"];
            letter2.text = defs["texasLetter2"];
            letter3Head.text = defs["texasLetter3header"];
            letter3.text = defs["texasLetter3"];

            text3.text = defs["stage3Scene1Text3"];
            text4Task.text = defs["stage3Scene1TextTask"]; // task

            book1Title.text = defs["book1Title"];
            book2Title.text = defs["book2Title"];
            book3Title.text = defs["book3Title"];
            book4Title.text = defs["book4Title"];
            book5Title.text = defs["book5Title"];
            book6Title.text = defs["book6Title"];

            referenceButton.text = defs["referenceButton"];
            referenceButton2.text = defs["referenceButton"];
            referenceButton3.text = defs["referenceButton"];
            referenceButton4.text = defs["referenceButton"];
            referenceButton5.text = defs["referenceButton"];
            referenceButton6.text = defs["referenceButton"];

            citationBook1Info1.text = defs["citationInfoBook1"];

            citationBook2Info1.text = defs["citationInfoBook2a"];
            citationBook2Info2.text = defs["citationInfoBook2b"];
            citationBook2Info3.text = defs["citationInfoBook2c"];
            citationBook2Info4.text = defs["citationInfoBook2d"];
            citationBook3Info.text = defs["citationInfoBook3"];
            citationBook4Infoa.text = defs["citationInfoBook3"];
            citationBook4Infob.text = defs["citationInfoBook4"];
            citationBook4InfoCLetterToLaCTitle.text = defs["citationInfoBook4aTitle"];
            citationBook4InfoCLetterToLaCCitation.text = defs["citationInfoBook4aCitation"];
            citationBook5Info.text = defs["citationInfoBook5"];
            citationBook5bInfoTitle.text = defs["citationInfoBook5aTitle"];
            citationBook5bSource.text = defs["citationInfoBook5aSource"];
            citationBook5bCredit.text = defs["citationInfoBook5aCredit"];

            citationBook6Info.text = defs["citationInfoBook6"];

            rule1.text = defs["stage3Scene1Rule1"];
            rule2.text = defs["stage3Scene1Rule2"];
            rule3.text = defs["stage3Scene1Rule3"];
            rule4.text = defs["stage3Scene1Rule4"];
            rule5.text = defs["stage3Scene1Rule5"];

            IsThisCorrect.text = defs["stage3Scene1Text4"];
            rule1AnswerCorrectGoodPeople.text = defs["stage3Scene1Text5"];
            rule2AnswerCorrectMexicanCitizen.text = defs["stage3Scene1Text6"];
            rule3AnswerCorrectCatholicChurch.text = defs["stage3Scene1Text7"];
            rule4AnswerInCorrectHunt.text = defs["stage3Scene1Text8"];
            rule5AnswerInCorrectStayLimit.text = defs["stage3Scene1Text9"];

            text5End.text = defs["stage3Scene1Text10"];

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

        }
    }
}