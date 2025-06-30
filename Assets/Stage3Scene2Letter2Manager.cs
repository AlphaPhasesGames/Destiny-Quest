using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage3Scene2Letter2Manager : MonoBehaviour
    {
        public Stage3Scene2TextMan s3TextMan;
        [Header("Letter Pages")]
        public GameObject[] letterPages; // Assign all your letter page UI images here
        public GameObject letterParent;
        [Header("Navigation")]
        public Button forwardButton;     // Your forward arrow button
        public Button backButton;        // Your back arrow button

        public Button page1TTS;
        public Button page1TTSa;
        public Button page2TTS;
        public Button page3TTS;
        public Button page3TTSa;

        private int currentPage = 0;
        public Button closeButton;
        private void Start()
        {
            forwardButton.onClick.AddListener(OnForwardButtonClicked);
            backButton.onClick.AddListener(OnBackButtonClicked);
            closeButton.onClick.AddListener(CloseLetter);

            page1TTS.onClick.AddListener(PlayTTSLetter3);
            page1TTSa.onClick.AddListener(PlayTTSLetter3a);
            page2TTS.onClick.AddListener(PlayTTSLetter4);
            page3TTS.onClick.AddListener(PlayTTSLetter5);
            page3TTSa.onClick.AddListener(PlayTTSLetter5a);

            ShowPage(0);
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
            SceneManager.LoadScene("Stage3Scene3");
        }




        public void PlayTTSLetter3()
        {
            LOLSDK.Instance.SpeakText("mexicoLetter3a");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSLetter3a()
        {
            LOLSDK.Instance.SpeakText("mexicoLetter3b");
            Debug.Log("This TTS Worked");
        }
        public void PlayTTSLetter4()
        {
            LOLSDK.Instance.SpeakText("mexicoLetter4a");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter5()
        {
            LOLSDK.Instance.SpeakText("mexicoLetter5a");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSLetter5a()
        {
            LOLSDK.Instance.SpeakText("mexicoLetter5b");
            Debug.Log("This TTS Worked");
        }

    }
}
