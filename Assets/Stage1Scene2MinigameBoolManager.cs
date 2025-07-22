using UnityEngine;
using System.Collections;
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
                    StartCoroutine(DelayCompleteText());
                    runONce = true;
                }
            }
           
        }


        public IEnumerator DelayCompleteText()
        {
            yield return new WaitForSeconds(5f);
            textMan.positionChanged = true;
            textMan.arrayPos = 11;
        }

    }
}
