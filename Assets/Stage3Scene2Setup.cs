using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2Setup : MonoBehaviour
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
                MainGameManager.Instance.currentStagedqwb = 10;
                MainGameManager.Instance.SaveS3S2();
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
