using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class SetupStage2Scene3 : MonoBehaviour
    {
        public bool runonce;

        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 8;
                MainGameManager.Instance.SaveS2S3();
                runonce = true;
            }


        }

    }
}
