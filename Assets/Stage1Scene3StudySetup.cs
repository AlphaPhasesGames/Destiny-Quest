using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene3StudySetup : MonoBehaviour
    {
        public bool runonce;

        private void Awake()
        {
            if (!runonce)
            {
                MainGameManager.Instance.currentStagedqwb = 3;
                MainGameManager.Instance.SaveS1S3();
            }


        }
    }
}
