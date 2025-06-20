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
        public GameObject endSceneItself;
        public Button right;
        public Button wrong;
        public Camera playerCam;
        public Camera EndCam;
        public GameObject wagonPlayer;


        private void Awake()
        {
            right.onClick.AddListener(Wrong);
            wrong.onClick.AddListener(Right);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                endSceneItself.gameObject.SetActive(true);
                playerCam.gameObject.SetActive(false);
                EndCam.gameObject.SetActive(true);
                wagonPlayer.gameObject.SetActive(false);
               // wrong.gameObject.SetActive(true);
              //  right.gameObject.SetActive(true);
                textman.positionChanged = true;
                textman.arrayPos = 1;
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
    }
}