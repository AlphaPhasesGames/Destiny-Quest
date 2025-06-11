using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene2StopAtSign3 : MonoBehaviour
    {
        // References to UI and scene objects
        public Stage1Scene2TextMan textMan;
        public GameObject signText;
        public GameObject signObject;
        public GameObject signQuestion;
        public GameObject letterTask;
        public GameObject signParent;
        public Button correctButton;
        public Button incorrectButton;
        public Animator tommyJ;
        public PlayerMovement player;
        // Reference to player's NavMeshAgent
        private NavMeshAgent agent;

        // References to cameras (not currently used in this script, but likely used elsewhere)
        public Camera playerCam;
        public Camera jeffersonCam;

        private void Awake()
        {
            // Assign listener functions to buttons
            correctButton.onClick.AddListener(CorrectButton);
            incorrectButton.onClick.AddListener(IncorrectButton);
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check if the player entered the trigger area
            if (other.CompareTag("Player"))
            {
                // Get the player's NavMeshAgent
                agent = other.GetComponent<NavMeshAgent>();
                if (agent != null)
                {
                    // Show the sign text and question UI
                    signText.gameObject.SetActive(true);
                    signQuestion.gameObject.SetActive(true);
                    correctButton.gameObject.SetActive(true);
                    incorrectButton.gameObject.SetActive(true);
                    player.enabled = false;
                    // Stop the player's movement
                    agent.isStopped = true;
                    agent.velocity = Vector3.zero;
                }
            }
        }

        // Called when the "Correct" button is pressed.
        // NOTE: In this case, "correct" refers to selecting the tick button — but the answer is actually correct.
        public void CorrectButton()
        {
            // Update the text manager to move to the next dialogue
            textMan.textBools[1] = false;
            textMan.positionChanged = true;

            // Hide the sign and all UI elements
            signObject.gameObject.SetActive(false);
            signText.gameObject.SetActive(false);
            signQuestion.gameObject.SetActive(false);
            correctButton.gameObject.SetActive(false);
            incorrectButton.gameObject.SetActive(false);
            letterTask.gameObject.SetActive(false);
            signParent.gameObject.SetActive(false);
            // Set the text manager to play the next text box (array index 2)
            textMan.arrayPos = 2;

            // Resume player movement if agent exists
            if (agent != null)
            {
                agent.isStopped = false;
            }

            // Clear the agent reference
            agent = null;

            // Trigger Jefferson's walking animation
            playerCam.gameObject.SetActive(false);
            jeffersonCam.gameObject.SetActive(true);
            tommyJ.SetBool("Walk", true);
        }

        // Called when the "Incorrect" button is pressed.
        // This represents pressing the cross (X) to correctly reject the correct answer.
        public void IncorrectButton()
        {
            // Hide all UI elements
            signText.gameObject.SetActive(false);
            signQuestion.gameObject.SetActive(false);
            correctButton.gameObject.SetActive(false);
            incorrectButton.gameObject.SetActive(false);

            // Resume player movement if agent exists
            if (agent != null)
            {
                agent.isStopped = false;
            }

            // Clear the agent reference
            agent = null;
        }
    }
}