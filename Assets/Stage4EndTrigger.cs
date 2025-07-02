using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4EndTrigger : MonoBehaviour
    {
        public Stage4Scene2TextMan textMan;
        public Stage4Scene2TreatyObject treatyScript;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (treatyScript.collectedTreaty)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 5;
                    Debug.Log("This fucntion fired");
                }

                if (!treatyScript.collectedTreaty)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 4;
                    Debug.Log("This fucntion fired");
                }

            }
        }
    }
}
