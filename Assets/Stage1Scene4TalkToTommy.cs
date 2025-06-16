
using UnityEngine;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene4TalkToTommy : MonoBehaviour
    {
        public Stage1Scene4TextMan textMan;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 1;
            }
        }
    }
}
