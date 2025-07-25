using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2MinigameManager : MonoBehaviour
    {
        public GameObject task1ToDisable;
        public GameObject task2ToShow;
        public int amountOfConcerns;
        public Stage3Scene2TextMan textMan;
        public bool runOnce;
        private void Update()
        {
            if (!runOnce)
            {
                if (amountOfConcerns == 4)
                {
                    task1ToDisable.gameObject.SetActive(false);
                    task2ToShow.gameObject.SetActive(true);
                    textMan.positionChanged = true;
                    textMan.arrayPos = 4;
                    runOnce = true;
                }
            }
            
        }






    }
}
