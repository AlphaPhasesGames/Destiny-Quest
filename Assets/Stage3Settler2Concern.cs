using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Settler2Concern : MonoBehaviour
    {
        public GameObject concern;
        public Button closeConcern;
        public Camera citizenCam;
        public Camera playerCam;
        public Stage3Scene2MinigameManager miniMan;
        public bool runOnce;
        public BoxCollider collider;
        private void Awake()
        {
            closeConcern.onClick.AddListener(CloseConcern);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                concern.gameObject.SetActive(true);
                citizenCam.gameObject.SetActive(true);
                playerCam.gameObject.SetActive(false);
            }
        }

        public void CloseConcern()
        {
            if (!runOnce)
            {
                concern.gameObject.SetActive(false);
                citizenCam.gameObject.SetActive(false);
                playerCam.gameObject.SetActive(true);
                miniMan.amountOfConcerns++;
                collider.enabled = false;
                runOnce = true;
            }
           
        }

    }
}
