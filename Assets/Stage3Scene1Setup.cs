using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene1Setup : MonoBehaviour
    {
        // Start is called before the first frame update
        public bool runonce;
        public GameObject whiteFlashOut;
        public Animator flashAnim;

        private void Awake()
        {
            if (!runonce)
            {

                flashAnim.SetBool("flashOut", true);
                MainGameManager.Instance.currentStagedqwb = 9;
                MainGameManager.Instance.SaveS3S1();
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

