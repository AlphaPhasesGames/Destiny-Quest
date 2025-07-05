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
        public TextMeshProUGUI keyUnclaimed;
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
            keyAmerica.text = defs["mapKeyAmerica"];
            keyLouisana.text = defs["mapKeyLouisiana"];
            keySpanishTerritory.text = defs["mapKeySpanish"];
            keyFlorida.text = defs["mapKeyFlorida"];
            keyUnclaimed.text = defs["mapKeyUnclaimed"];
            mapStartIllinois.text = defs["mapStartIllinois"];
            mapPoint1Mississippi.text = defs["mapPoint1Mississippi"];
            mapPoint2RockMountains.text = defs["mapPoint2RockyMountain"];
            mapPoint3Pacific.text = defs["mapPoint3PacificCoast"];

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


            mapText1.text = defs["maptext1"];
            mapText2.text = defs["maptext2"];
            mapText3.text = defs["maptext3"];
            mapText4.text = defs["maptext4"];
            mapChoiceText1.text = defs["maptext5"];
            mapChoiceDecision1.text = defs["mapDecisionAnswer1North"];
            mapChoiceDecision2.text = defs["mapDecisionAnswer2South"];
            mapChoiceDecision3.text = defs["mapDecisionAnswer3East"];
            mapChoiceDecision4.text = defs["mapDecisionAnswer4West"];
            mapDecisionAnswerWrong.text = defs["maptext6"];
            mapDecisionAnswerRight.text = defs["maptext7"];
            mapChoice2Text.text = defs["maptext8"];
            mapChoice2Decision1.text = defs["mapDecision2Answer1"];
            mapChoice2Decision2.text = defs["mapDecision2Answer2"];
         //   mapChoice2Decision3.text = defs["mapDecision2Answer3"];
            mapDecision2AnswerWrong.text = defs["maptext9"];
            mapDecision2AnswerRight.text = defs["maptext10"];
            mapChoice3Text.text = defs["maptext11"];
            mapChoice3Decision1.text = defs["mapDecision3Answer1"];
            mapChoice3Decision2.text = defs["mapDecision3Answer2"];
            mapChoice3Decision3.text = defs["mapDecision3Answer3"];
            mapDecision3AnswerWrong1.text = defs["maptext12"];
            mapDecision3AnswerWrong2.text = defs["maptext13"];
            mapDecision3AnswerRight.text = defs["maptext14"];
            mapGameComplete1.text = defs["maptext15"];
            mapGameComplete2.text = defs["maptext16"];

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
