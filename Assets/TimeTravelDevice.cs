using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;

namespace Alpha.Phases.Destiny.Quest
{
    public class TimeTravelDevice : MonoBehaviour
    {
        public Animator flashScreen;
        public Button timeTravelButton;
        public GameObject flashImage;
        // Start is called before the first frame update
        void Start()
        {
            timeTravelButton.onClick.AddListener(TimeTravelFlash);
        }

        public void TimeTravelFlash()
        {
            flashImage.gameObject.SetActive(true);
            flashScreen.SetBool("flash", true);
            StartCoroutine(ChangeScene());
        }

        public IEnumerator ChangeScene()
        {
            yield return new WaitForSeconds(1);
            LOLSDK.Instance.SubmitProgress(0, 12, 100);
            SceneManager.LoadScene("ParisStudy");
        }
        public void ChangeStage()
        {

      
        }
    }
}
