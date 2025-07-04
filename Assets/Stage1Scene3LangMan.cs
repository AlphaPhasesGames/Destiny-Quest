using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene3LangMan : MonoBehaviour
    {
        public TextMeshProUGUI stageStartText;
        public TextMeshProUGUI stageText2StartTalks;
        public TextMeshProUGUI letter1;
        public TextMeshProUGUI letter2;
        public TextMeshProUGUI letter3;
        public TextMeshProUGUI letter4;
        public TextMeshProUGUI letter5;
        public TextMeshProUGUI task;
        public TextMeshProUGUI napoleonName;
        public TextMeshProUGUI monroeName;
        public TextMeshProUGUI napoleonNameB;
        public TextMeshProUGUI monroeNameB;
        public TextMeshProUGUI choiceA;
        public TextMeshProUGUI choiceB;
        public TextMeshProUGUI napleonChoice1A;
        public TextMeshProUGUI napleonChoice1B;
        public TextMeshProUGUI monroeChoice1A;
        public TextMeshProUGUI monroeChoice1B;
        public TextMeshProUGUI napleonChoice2A;
        public TextMeshProUGUI napleonChoice2B;
        public TextMeshProUGUI monroeChoice2A;
        public TextMeshProUGUI monroeChoice2B;
        public TextMeshProUGUI monroeFinalChoiceA;
        public TextMeshProUGUI monroeFinalChoiceB;
        public TextMeshProUGUI moveToStage1Scene4;

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

        public TextMeshProUGUI book1Title;
        public TextMeshProUGUI book2Title;
        public TextMeshProUGUI book3Title;

        public TextMeshProUGUI referenceButton;
        public TextMeshProUGUI referenceButton2;
        public TextMeshProUGUI referenceButton3;
        public TextMeshProUGUI citationBook1Info1;
        public TextMeshProUGUI citationBook2Info1;
        public TextMeshProUGUI citationBook2Info2;
        public TextMeshProUGUI citationBook2Info3;
        public TextMeshProUGUI citationBook2Info4;
        public TextMeshProUGUI citationBook3Info;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            book1Title.text = defs["book1Title"];
            book2Title.text = defs["book2Title"];
            book3Title.text = defs["book3Title"];

            referenceButton.text = defs["referenceButton"];
            referenceButton2.text = defs["referenceButton"];
            referenceButton3.text = defs["referenceButton"];

            citationBook1Info1.text = defs["citationInfoBook1"];

            citationBook2Info1.text = defs["citationInfoBook2a"];
            citationBook2Info2.text = defs["citationInfoBook2b"];
            citationBook2Info3.text = defs["citationInfoBook2c"];
            citationBook2Info4.text = defs["citationInfoBook2d"];
            citationBook3Info.text = defs["citationInfoBook3"];


            stageStartText.text = defs["stage1Scene3Start"];
            letter1.text = defs["napoleonLetter1"];
            letter2.text = defs["napoleonLetter2"];
            letter3.text = defs["napoleonLetter3"];
            letter4.text = defs["napoleonLetter4"];
            letter5.text = defs["napoleonLetter5"];
            stageText2StartTalks.text = defs["stage1Scene3Talks"];
            task.text = defs["taskStage1Scene3"];
            napoleonName.text = defs["napoleonName"];
            monroeName.text = defs["jamesMonroeName"];
            napoleonNameB.text = defs["napoleonName"];
            monroeNameB.text = defs["jamesMonroeName"];
            choiceA.text = defs["choiceA"];
            choiceB.text = defs["choiceB"];
            napleonChoice1A.text = defs["napoleonChoice1a"];
            napleonChoice1B.text = defs["napoleonChoice1b"];
            monroeChoice1A.text = defs["monroeChoice1a"];
            monroeChoice1B.text = defs["monroeChoice1b"];
            napleonChoice2A.text = defs["napoleonChoice2a"];
            napleonChoice2B.text = defs["napoleonChoice2b"];
            monroeChoice2A.text = defs["monroeChoice2a"];
            monroeChoice2B.text = defs["monroeChoice2b"];
            monroeFinalChoiceA.text = defs["monroeChoiceBuyLouisiana"];
            monroeFinalChoiceB.text = defs["monroeChoiceBuyOrleans"];
            moveToStage1Scene4.text = defs["textToMoveToScene1Stage4"];

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
        }
    }
}
