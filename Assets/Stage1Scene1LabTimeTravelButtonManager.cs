using System.Collections;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene1LabTimeTravelButtonManager : MonoBehaviour
    {

        public Button timeTravelButton;
        // Start is called before the first frame update
        void Start()
        {
            timeTravelButton.onClick.AddListener(ChangeStage);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ChangeStage()
        {
            SceneManager.LoadScene("Stage1Camp");
            LOLSDK.Instance.SubmitProgress(0, 5, 100);
        }
    }
}
