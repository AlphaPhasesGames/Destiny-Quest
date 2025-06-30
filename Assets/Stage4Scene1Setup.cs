using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4Scene1Setup : MonoBehaviour
    {
        public bool runonce;

        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 11;
                MainGameManager.Instance.SaveS4S1();
                runonce = true;
            }
        }
    }
}
