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
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;

            stageStartText.text = defs["Stage1Scene3Start"];
            letter1.text = defs["napoleonLetter1"];
            letter2.text = defs["napoleonLetter2"];
            letter3.text = defs["napoleonLetter3"];
            letter4.text = defs["napoleonLetter4"];
            letter5.text = defs["napoleonLetter5"];
            stageText2StartTalks.text = defs["Stage1Scene3Talks"];
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
        }
    }
}
