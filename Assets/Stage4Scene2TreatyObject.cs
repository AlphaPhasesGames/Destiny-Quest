using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4Scene2TreatyObject : MonoBehaviour
    {
        public Stage4Scene2TextMan textMan;
        public bool collectedTreaty;
        public GameObject treaty;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                collectedTreaty = true;
                treaty.gameObject.SetActive(false);
                textMan.positionChanged = true;
                textMan.arrayPos = 3;
                Debug.Log("This fucntion fired");
            }
        }
    }
}
