using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4Scene1Banker : MonoBehaviour
    {
        public Stage4TextMan textMan;
        public Camera playerCam;
        public Camera bankerCam;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 3;
                playerCam.gameObject.SetActive(false);
                bankerCam.gameObject.SetActive(true);
            }
        }
    }
}
