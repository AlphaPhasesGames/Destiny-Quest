using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage2WagonFixMiniGame : MonoBehaviour
    {
        public Stage2Scene1TextManager textMan;
        public GameObject wagonSceneItself;
        public GameObject wagonSceneParent;
        public Button wheelOnGround;
        public GameObject wheelFixed;
        public GameObject wheelToBeClicked;
        public Camera playerCam;
        public Camera wagonCam;
        public GameObject wagonPlayer;
        private void Awake()
        {
            wheelOnGround.onClick.AddListener(FixWagonButton);
        }



        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("Player"))
            {
                wagonSceneItself.gameObject.SetActive(true);
                playerCam.gameObject.SetActive(false);
                wagonCam.gameObject.SetActive(true);
                wagonPlayer.gameObject.SetActive(false);
                wheelOnGround.gameObject.SetActive(true);
                textMan.positionChanged = true;
                textMan.arrayPos = 4;
            }
        }

        public void FixWagonButton()
        {
            wheelFixed.gameObject.SetActive(true);
            wheelToBeClicked.gameObject.SetActive(false);
            wheelOnGround.gameObject.SetActive(true);
            StartCoroutine(MoveBackToPlayer());
            textMan.positionChanged = true;
            textMan.arrayPos = 9;
        }

        public IEnumerator MoveBackToPlayer()
        {
        
            yield return new WaitForSeconds(3);
            wagonSceneParent.gameObject.SetActive(false);
           
            playerCam.gameObject.SetActive(true);
            wagonCam.gameObject.SetActive(false);
            wagonPlayer.gameObject.SetActive(true);
        }
    }
}
