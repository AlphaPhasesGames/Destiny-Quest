using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage2Scene1Setup : MonoBehaviour
    {
        public bool runonce;

        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 6;
                MainGameManager.Instance.SaveS2S1();
                runonce = true;
            }
        }
    }
}