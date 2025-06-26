using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2TriggerPolk : MonoBehaviour
    {

        public Stage3Scene2TextMan textMan;
        public Camera polkCam;
        public Camera playerCam;
        public Stage3Scene2MinigameManager miniManager;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (miniManager.amountOfConcerns < 4)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 2;
                }

                if (miniManager.amountOfConcerns > 3)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 5;
                }

                polkCam.gameObject.SetActive(true);
                playerCam.gameObject.SetActive(false);
            }
        }


    }
}
