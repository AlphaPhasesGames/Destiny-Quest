using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4Scene2Setup : MonoBehaviour
    {
        // Start is called before the first frame update
        public bool runonce;

        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 12;
                MainGameManager.Instance.SaveS4S2();
                runonce = true;
            }
        }
    }
}
