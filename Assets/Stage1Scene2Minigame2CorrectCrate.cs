using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene2Minigame2CorrectCrate : MonoBehaviour
    {
        public Stage1Scene2TextMan textMan;
        public Stage1Scene2MinigameBoolManager boolMan;
        public GameObject signText;
        public GameObject signObject;
        public GameObject signQuestion;
        public Button correctButton;
        public Button incorrectButton;
        public GameObject tickImage;
        private void Awake()
        {
            correctButton.onClick.AddListener(CorrectButton);
            incorrectButton.onClick.AddListener(IncorrectButton);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
              
                    signText.gameObject.SetActive(true);
                    signQuestion.gameObject.SetActive(true);
                    correctButton.gameObject.SetActive(true);
                    incorrectButton.gameObject.SetActive(true);

                  
              
            }
        }
        // This function controls the correct and incorrect buttons.
        // this sign has the wrong answer to the assesment section on it
        // So Correct button means the Tick button but the incorrect answer
        // the incorrect button means the cross and pressing it closes all buttons and text panals and gives control back to the player
        public void CorrectButton()
        {
            tickImage.gameObject.SetActive(true);
            textMan.textBools[1] = false;
            textMan.positionChanged = true;
            signObject.gameObject.SetActive(false);
            signText.gameObject.SetActive(false);
            signQuestion.gameObject.SetActive(false);
            correctButton.gameObject.SetActive(false);
            incorrectButton.gameObject.SetActive(false);
            textMan.arrayPos = 8; // this text box closes the text panal and players can look for a new sign
          
            boolMan.priority1 = true;
        }
        public void IncorrectButton()
        {

          //  signObject.gameObject.SetActive(false);
            textMan.positionChanged = true;
            signText.gameObject.SetActive(false);
            signQuestion.gameObject.SetActive(false);
            correctButton.gameObject.SetActive(false);
            incorrectButton.gameObject.SetActive(false);
            textMan.arrayPos = 13;
        }

    }
}
