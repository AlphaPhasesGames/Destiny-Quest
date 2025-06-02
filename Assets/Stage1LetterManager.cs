using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1LetterManager : MonoBehaviour
    {
        public Stage1Scene1LabTextBox s1TextMan;
        [Header("Letter Pages")]
        public GameObject[] letterPages; // Assign all your letter page UI images here
        public GameObject letterParent;
        [Header("Navigation")]
        public Button forwardButton;     // Your forward arrow button
        public Button backButton;        // Your back arrow button

        public Button page1TTS;
        public Button page2TTS;
        public Button page3TTS;

        private int currentPage = 0;
        public Button closeButton;
        private void Start()
        {
            forwardButton.onClick.AddListener(OnForwardButtonClicked);
            backButton.onClick.AddListener(OnBackButtonClicked);
            closeButton.onClick.AddListener(CloseLetter);

            page1TTS.onClick.AddListener(PlayTTSLetter1);
            page2TTS.onClick.AddListener(PlayTTSLetter2);
            page3TTS.onClick.AddListener(PlayTTSLetter3);
        }

        public void ShowPage(int index)
        {
            currentPage = index;

            // Hide all pages
            for (int i = 0; i < letterPages.Length; i++)
                letterPages[i].SetActive(false);

            // Show the current page
            letterPages[index].SetActive(true);

            // Handle forward button visibility
            forwardButton.gameObject.SetActive(false);
            if (index < letterPages.Length - 1)
                StartCoroutine(EnableForwardButtonAfterDelay(5f));

            // Handle back button visibility (only show on page 1+)
            backButton.gameObject.SetActive(index > 0);
        }

        public void OnForwardButtonClicked()
        {
            if (currentPage < letterPages.Length - 1)
            {
                currentPage++;
                ShowPage(currentPage);
            }
        }

        public void OnBackButtonClicked()
        {
            if (currentPage > 0)
            {
                currentPage--;
                ShowPage(currentPage);
            }
        }

        private IEnumerator EnableForwardButtonAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            forwardButton.gameObject.SetActive(true);
        }

        public void CloseLetter()
        {
            letterParent.gameObject.SetActive(false);
            s1TextMan.positionChanged = true;
            s1TextMan.arrayPos = 4;
        }
        
        public void PlayTTSLetter1()
        {
            LOLSDK.Instance.SpeakText("labText6");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter2()
        {
            LOLSDK.Instance.SpeakText("labText7");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSLetter3()
        {
            LOLSDK.Instance.SpeakText("labText8");
            Debug.Log("This TTS Worked");
        }
    }
}