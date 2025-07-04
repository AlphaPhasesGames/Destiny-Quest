using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene2MinigameBoolManager : MonoBehaviour
    {
        public bool priority1;
        public bool priority2;
        public bool priority3;
        public Stage1Scene2TextMan textMan;
        public bool runONce;

        private void Update()
        {
            if (!runONce)
            {
                if (priority1 && priority2 && priority3)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 11;
                    runONce = true;
                }
            }
           
        }
    }
}
