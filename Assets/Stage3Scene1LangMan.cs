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
            text4Task.text = defs["stage3Scene1Text4Task"];

            rule1.text = defs["stage3Scene1Rule1"];
            rule2.text = defs["stage3Scene1Rule2"];
            rule3.text = defs["stage3Scene1Rule3"];
            rule4.text = defs["stage3Scene1Rule4"];
            rule5.text = defs["stage3Scene1Rule5"];

            IsThisCorrect.text = defs["stage3Scene1IsThisCorrect"];
            rule1AnswerCorrectGoodPeople.text = defs["stage3Scene1Rule1Answer"];
            rule2AnswerCorrectMexicanCitizen.text = defs["stage3Scene1Rule2Answer"];
            rule3AnswerCorrectCatholicChurch.text = defs["stage3Scene1Rule3Answer"];
            rule4AnswerInCorrectHunt.text = defs["stage3Scene1Rule4Answer"];
            rule5AnswerInCorrectStayLimit.text = defs["stage3Scene1Rule5Answer"];

            text5End.text = defs["stage3Scene1TextEnd"];

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