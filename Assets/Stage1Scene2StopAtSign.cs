using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene2StopAtSign : MonoBehaviour
    {
        public Stage1Scene2TextMan textMan;
        public GameObject signText;
        public GameObject signObject;
        public GameObject signQuestion;
        public Button correctButton;
        public Button incorrectButton;

        private NavMeshAgent agent;
        private void Awake()
        {
            correctButton.onClick.AddListener(CorrectButton);
            incorrectButton.onClick.AddListener(IncorrectButton);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                agent = other.GetComponent<NavMeshAgent>();
                if (agent != null)
                {
                    signText.gameObject.SetActive(true);
                    signQuestion.gameObject.SetActive(true);
                    correctButton.gameObject.SetActive(true);
                    incorrectButton.gameObject.SetActive(true);
                   
                    agent.isStopped = true;
                    agent.velocity = Vector3.zero;
                }
            }
        }
        // This function controls the correct and incorrect buttons.
        // this sign has the wrong answer to the assesment section on it
        // So Correct button means the Tick button but the incorrect answer
        // the incorrect button means the cross and pressing it closes all buttons and text panals and gives control back to the player
        public void CorrectButton()
        {
            textMan.textBools[1] = false;
            textMan.positionChanged = true;
            signObject.gameObject.SetActive(false);
            signText.gameObject.SetActive(false);
            signQuestion.gameObject.SetActive(false);
            correctButton.gameObject.SetActive(false);
            incorrectButton.gameObject.SetActive(false);
            textMan.arrayPos = 1; // this text box closes the text panal and players can look for a new sign
            if (agent != null)
            {
                agent.isStopped = false;
            }
            agent = null;
        }
        public void IncorrectButton()
        {
           
            signObject.gameObject.SetActive(false);
            textMan.positionChanged = true;
            signText.gameObject.SetActive(false);
            signQuestion.gameObject.SetActive(false);
            correctButton.gameObject.SetActive(false);
            incorrectButton.gameObject.SetActive(false);
            textMan.arrayPos = 13;
            if (agent != null)
            {
                agent.isStopped = false;
            }
            agent = null;
        }

    }
}
