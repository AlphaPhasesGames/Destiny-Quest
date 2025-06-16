using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene4CampStart : MonoBehaviour
    {
        public bool runonce;

        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 4;
                MainGameManager.Instance.SaveS1S4();
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
