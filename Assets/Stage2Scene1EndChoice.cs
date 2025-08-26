using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage2Scene1EndChoice : MonoBehaviour
    {
        public Stage2Scene1TextManager textman;
        public WaterSlider waterSlider;
        public GameObject endSceneItself;
        public Button right;
        public Button wrong;
        public Camera playerCam;
        public Camera EndCam;
        public GameObject wagonPlayer;
        public GameObject waterWarningBox;
        private void Awake()
        {
            right.onClick.AddListener(EndScene);
            wrong.onClick.AddListener(WrongAnswer);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {

                if(waterSlider.waterSlider.value < 6)
                {
                    waterWarningBox.gameObject.SetActive(true);
                }
                if (waterSlider.waterSlider.value > 5)
                {

                    endSceneItself.gameObject.SetActive(true);
                    playerCam.gameObject.SetActive(false);
                    EndCam.gameObject.SetActive(true);
                    wagonPlayer.gameObject.SetActive(false);
                    wrong.gameObject.SetActive(true);
                    right.gameObject.SetActive(true);
                    textman.positionChanged = true;
                    textman.arrayPos = 5;
                }

               
            }
        }

        public void EndScene()
        {
            textman.positionChanged = true;
            textman.arrayPos = 8;
        }

        public void WrongAnswer()
        {
            textman.positionChanged = true;
            textman.arrayPos = 7;
        }
    }
}   