using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2MinigameManager : MonoBehaviour
    {

        public int amountOfConcerns;
        public Stage3Scene2TextMan textMan;
        public bool runOnce;
        private void Update()
        {
            if (!runOnce)
            {
                if (amountOfConcerns == 4)
                {
                    textMan.positionChanged = true;
                    textMan.arrayPos = 4;
                    runOnce = true;
                }
            }
            
        }

    }
}
