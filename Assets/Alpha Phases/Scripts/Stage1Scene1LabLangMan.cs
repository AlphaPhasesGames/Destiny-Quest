using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using TMPro;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene1LabLangMan : MonoBehaviour
    {
         //public TextMeshProUGUI testText;
         public TextMeshProUGUI labText1;
         public TextMeshProUGUI labText2;
         public TextMeshProUGUI labText3;
         public TextMeshProUGUI labText4;
        
         public TextMeshProUGUI labText5;
         public TextMeshProUGUI labText6;
         public TextMeshProUGUI labText7;
         public TextMeshProUGUI labText8;
        public TextMeshProUGUI labText9;
        public TextMeshProUGUI labText10;
        public TextMeshProUGUI labText11;
        public TextMeshProUGUI labText12;
        public TextMeshProUGUI book1BP1;
        public TextMeshProUGUI book1BP2;
        public TextMeshProUGUI book1BP3;
        public TextMeshProUGUI book1BP4;
        public TextMeshProUGUI book1BP5;
        public TextMeshProUGUI book1BP6;
        public TextMeshProUGUI reference;
        public TextMeshProUGUI citation;
        /*
         public TextMeshProUGUI labText8;
         public TextMeshProUGUI labText9;
         public TextMeshProUGUI labText10;
         public TextMeshProUGUI labText11;
         public TextMeshProUGUI labText12;
         public TextMeshProUGUI labText13;
         public TextMeshProUGUI labText14;
        */

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            labText1.text = defs["labText1"];
            labText2.text = defs["labText2"];
            labText3.text = defs["labText3"];
            labText4.text = defs["labText4"];
            labText5.text = defs["labText5"];
            labText6.text = defs["labText6"];
            labText7.text = defs["labText7"];
            labText8.text = defs["labText8"];
            labText9.text = defs["labText9"];
            labText10.text = defs["labText10"];
            labText11.text = defs["labText11"];
            labText12.text = defs["labText12"];
            book1BP1.text = defs["book1BP1"];
            book1BP2.text = defs["book1BP2"];
            book1BP3.text = defs["book1BP3"];
            book1BP4.text = defs["book1BP4"];
            book1BP5.text = defs["book1BP5"];
            book1BP6.text = defs["book1BP6"];
            reference.text = defs["referenceButton"];
            citation.text = defs["citationInfoBook1"];
        }

        /*
         *    labText1.text = defs["labText1"];
        labText2.text = defs["labText2"];
        labText3.text = defs["labText3"];
        labText4.text = defs["labText4"];
        labText5.text = defs["labText5"];
        labText6.text = defs["labText6"];
        labText7.text = defs["labText7"];
        labText8.text = defs["labText8"];
        labText9.text = defs["labText9"];
        labText10.text = defs["labText10"];
        labText11.text = defs["labText11"];
        labText12.text = defs["labText12"];
        labText13.text = defs["labText13"];
        labText14.text = defs["labText14"];
        */
    }
}
    


