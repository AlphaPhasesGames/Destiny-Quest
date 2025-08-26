using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage2Scene2EndChoice : MonoBehaviour
    {
        public Stage2Scene2TextManager textman;
        public FoodSlider foodSlider;
        public GameObject endSceneItself;
        public Button right;
        public Button wrong;
        public Button closeWarningBox;
        public Camera playerCam;
        public Camera EndCam;
        public GameObject wagonPlayer;
        public GameObject notEnoughFoodWarningBox;

        private void Awake()
        {
            right.onClick.AddListener(Wrong);
            wrong.onClick.AddListener(Right);
            closeWarningBox.onClick.AddListener(CloseWarning);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {

                if(foodSlider.foodSlider.value < 6)
                {
                    notEnoughFoodWarningBox.gameObject.SetActive(true);
                }

                if (foodSlider.foodSlider.value > 5)
                {
                    endSceneItself.gameObject.SetActive(true);
                    playerCam.gameObject.SetActive(false);
                    EndCam.gameObject.SetActive(true);
                    wagonPlayer.gameObject.SetActive(false);
                    textman.positionChanged = true;
                    textman.arrayPos = 1;
                }

               
            }
        }

        public void Wrong()
        {
            textman.ResetBools();
            textman.positionChanged = true;
            textman.arrayPos = 2;
        }

        public void Right()
        {
            textman.positionChanged = true;
             textman.arrayPos = 3;
        }

        public void CloseWarning()
        {
            notEnoughFoodWarningBox.gameObject.SetActive(false);
        }
    }
}