using UnityEngine;
using UnityEngine.UI;
using LoLSDK;

namespace Alpha.Phases.Destiny.Quest
{
    /// <summary>
    /// Handles platform selection UI (iPad or Laptop) in the main menu.
    /// </summary>
    public class MainMenuChooseIpadChromebook : MonoBehaviour
    {
        [Header("UI Buttons")]
        public Button iPad;
        public Button laptop;

        [Header("Reference to Game Manager")]
        public MainGameManager dqwbMain;

        void Start()
        {
            // Register click events for each button
            iPad.onClick.AddListener(OnIPadChosen);
            laptop.onClick.AddListener(OnLaptopChosen);
        }

        /// <summary>
        /// Called when the iPad button is selected.
        /// Sets game state to iPad and hides the buttons.
        /// </summary>
        private void OnIPadChosen()
        {
            HideButtons();
            dqwbMain.iPadChosen = true; // Update game manager state
        }

        /// <summary>
        /// Called when the Laptop button is selected.
        /// Hides the buttons. You can expand this with laptop-specific logic.
        /// </summary>
        private void OnLaptopChosen()
        {
            HideButtons();
            // Add any Chromebook-specific setup here if needed
        }

        /// <summary>
        /// Hides both UI buttons after a choice is made.
        /// </summary>
        private void HideButtons()
        {
            iPad.gameObject.SetActive(false);
            laptop.gameObject.SetActive(false);
        }
    }
}