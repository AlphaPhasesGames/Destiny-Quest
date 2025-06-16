using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene5LangManager : MonoBehaviour
    {
        public TextMeshProUGUI keyAmerica;
        public TextMeshProUGUI keyLouisana;
        public TextMeshProUGUI keySpanishTerritory;
        public TextMeshProUGUI keyFlorida;
        public TextMeshProUGUI mapStartIllinois;
        public TextMeshProUGUI mapPoint1Mississippi;
        public TextMeshProUGUI mapPoint2RockMountains;
        public TextMeshProUGUI mapPoint3Pacific;

        public TextMeshProUGUI mapText1;
        public TextMeshProUGUI mapText2;
        public TextMeshProUGUI mapText3;
        public TextMeshProUGUI mapText4;
        public TextMeshProUGUI mapChoiceText1;
        public TextMeshProUGUI mapChoiceDecision1;
        public TextMeshProUGUI mapChoiceDecision2;
        public TextMeshProUGUI mapChoiceDecision3;
        public TextMeshProUGUI mapChoiceDecision4;
        public TextMeshProUGUI mapDecisionAnswerWrong;
        public TextMeshProUGUI mapDecisionAnswerRight;
        public TextMeshProUGUI mapChoice2Text;
        public TextMeshProUGUI mapChoice2Decision1;
        public TextMeshProUGUI mapChoice2Decision2;
       // public TextMeshProUGUI mapChoice2Decision3;
        public TextMeshProUGUI mapDecision2AnswerWrong;
        public TextMeshProUGUI mapDecision2AnswerRight;
        public TextMeshProUGUI mapChoice3Text;
        public TextMeshProUGUI mapChoice3Decision1;
        public TextMeshProUGUI mapChoice3Decision2;
        public TextMeshProUGUI mapChoice3Decision3;
        public TextMeshProUGUI mapDecision3AnswerWrong1;
        public TextMeshProUGUI mapDecision3AnswerWrong2;
        public TextMeshProUGUI mapDecision3AnswerRight;
        public TextMeshProUGUI mapGameComplete1;
        public TextMeshProUGUI mapGameComplete2;

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
            keyAmerica.text = defs["mapKeyAmerica"];
            keyLouisana.text = defs["mapKeyLouisiana"];
            keySpanishTerritory.text = defs["mapKeySpanish"];
            keyFlorida.text = defs["mapKeyFlorida"];
            mapStartIllinois.text = defs["mapStartIllinois"];
            mapPoint1Mississippi.text = defs["mapPoint1Mississippi"];
            mapPoint2RockMountains.text = defs["mapPoint2RockyMountain"];
            mapPoint3Pacific.text = defs["mapPoint3PacificCoast"];

            mapText1.text = defs["maptext1"];
            mapText2.text = defs["maptext2"];
            mapText3.text = defs["maptext3"];
            mapText4.text = defs["maptext4"];
            mapChoiceText1.text = defs["mapDecisionText1"];
            mapChoiceDecision1.text = defs["mapDecisionAnswer1North"];
            mapChoiceDecision2.text = defs["mapDecisionAnswer2South"];
            mapChoiceDecision3.text = defs["mapDecisionAnswer3East"];
            mapChoiceDecision4.text = defs["mapDecisionAnswer4West"];
            mapDecisionAnswerWrong.text = defs["mapDecisionAnswerWrong"];
            mapDecisionAnswerRight.text = defs["mapDecisionAnswerCorrect"];
            mapChoice2Text.text = defs["mapDecision2Text1"];
            mapChoice2Decision1.text = defs["mapDecision2Answer1"];
            mapChoice2Decision2.text = defs["mapDecision2Answer2"];
         //   mapChoice2Decision3.text = defs["mapDecision2Answer3"];
            mapDecision2AnswerWrong.text = defs["mapDecision2AnswerWrong"];
            mapDecision2AnswerRight.text = defs["mapDecision2AnswerCorrect"];
            mapChoice3Text.text = defs["mapDecision3Text1"];
            mapChoice3Decision1.text = defs["mapDecision3Answer1"];
            mapChoice3Decision2.text = defs["mapDecision3Answer2"];
            mapChoice3Decision3.text = defs["mapDecision3Answer3"];
            mapDecision3AnswerWrong1.text = defs["mapDecision3AnswerWrong1"];
            mapDecision3AnswerWrong2.text = defs["mapDecision3AnswerWrong2"];
            mapDecision3AnswerRight.text = defs["mapDecision3AnswerCorrect"];
            mapGameComplete1.text = defs["mapComplete"];
            mapGameComplete2.text = defs["mapComplete2"];

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
