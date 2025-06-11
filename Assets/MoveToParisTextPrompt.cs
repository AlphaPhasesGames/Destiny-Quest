using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class MoveToParisTextPrompt : MonoBehaviour
    {
        public bool runOnce;
        public Stage1Scene2TextMan textMan;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!runOnce)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 12;
                    runOnce = true;
                }
               
            }
        }
    }
}
