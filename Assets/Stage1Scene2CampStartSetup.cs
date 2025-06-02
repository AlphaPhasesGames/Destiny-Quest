using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene2CampStartSetup : MonoBehaviour
    {

        public bool runonce;

        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 2;
                MainGameManager.Instance.SaveS1S2();
            }

           
        }
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
