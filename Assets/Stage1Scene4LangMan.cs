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

            stageStartText.text = defs["startScene1Stage4"];
            stage1Scene4Text1.text = defs["stage1Scene4Text1"];
            stage1Scene4Text2.text = defs["stage1Scene4Text2"];
            stage1Scene4Text3.text = defs["stage1Scene4Text3"];
            stage1Scene4Text4.text = defs["stage1Scene4Text4"];
            stage1Scene4Text5.text = defs["stage1Scene4Text5"];
            stage1Scene4Text6.text = defs["stage1Scene4Text6"];
            stage1Scene4Text7.text = defs["stage1Scene4Text7"];
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
