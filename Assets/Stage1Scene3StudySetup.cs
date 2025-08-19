using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene3StudySetup : MonoBehaviour
    {
        public bool runonce;
        public GameObject whiteFlashOut;
        public Animator flashAnim;
        private void Awake()
        {
            if (!runonce)
            {
                flashAnim.SetBool("flashOut", true);
                MainGameManager.Instance.currentStagedqwb = 3;
                MainGameManager.Instance.SaveS1S3();
                runonce = true;
                StartCoroutine(RemoveFlash());
            }
        }

        public IEnumerator RemoveFlash()
        {
            yield return new WaitForSeconds(1);
            whiteFlashOut.gameObject.SetActive(false);
        }
    }
    
}
