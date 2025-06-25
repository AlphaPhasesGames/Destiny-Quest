using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2Setup : MonoBehaviour
    {
        // Start is called before the first frame update
        public bool runonce;

        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 10;
                MainGameManager.Instance.SaveS3S2();
                runonce = true;
            }
        }
    }
}
