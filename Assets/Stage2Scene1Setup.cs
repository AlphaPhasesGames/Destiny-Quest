using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage2Scene1Setup : MonoBehaviour
    {
        public bool runonce;
        public GameObject whiteFlashOut;
        public Animator flashAnim;


        private void Awake()
        {
            if (!runonce)
            {

                flashAnim.SetBool("flashOut", true);
                MainGameManager.Instance.currentStagedqwb = 6;
                MainGameManager.Instance.SaveS2S1();
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