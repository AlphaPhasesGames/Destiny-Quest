
using UnityEngine;


namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene4TalkToTommy : MonoBehaviour
    {
        public Stage1Scene4TextMan textMan;
        public GameObject playerModel;
        public GameObject taskToHide;
        public Animator jeffersonMove;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                taskToHide.gameObject.SetActive(false);
                textMan.positionChanged = true;
                textMan.arrayPos = 1;
                playerModel.gameObject.SetActive(false);
                jeffersonMove.SetTrigger("jeffersonStart");
            }
        }
    }
}
