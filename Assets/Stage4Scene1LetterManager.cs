using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4Scene1LetterManager : MonoBehaviour
    {
        public Stage4TextMan s4TextMan;
        [Header("Letter Pages")]
        public GameObject[] letterPages; // Assign all your letter page UI images here
        public GameObject letterParent;
        [Header("Navigation")]
        public Button forwardButton;     // Your forward arrow button
        public Button backButton;        // Your back arrow button

        public Button page1TTS;
        public Button page1TTSa;
        public Button page2TTS;
        public Button page2TTSa;
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
            page2TTS.onClick.AddListener(PlayTTSLetter2);
            page2TTS.onClick.AddListener(PlayTTSLetter2a);
            page3TTS.onClick.AddListener(PlayTTSLetter3);
            page3TTSa.onClick.AddListener(PlayTTSLetter3a);

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
            s4TextMan.positionChanged = true;
            s4TextMan.arrayPos = 2;
        }




        public void PlayTTSLetter1()
        {
            LOLSDK.Instance.SpeakText("treatyLetter1a");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSLetter1a()
        {
            LOLSDK.Instance.SpeakText("treatyLetter1b");
            Debug.Log("This TTS Worked");
        }
        public void PlayTTSLetter2()
        {
            LOLSDK.Instance.SpeakText("treatyLetter2a");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter2a()
        {
            LOLSDK.Instance.SpeakText("treatyLetter2b");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSLetter3()
        {
            LOLSDK.Instance.SpeakText("treatyLetter3a");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSLetter3a()
        {
            LOLSDK.Instance.SpeakText("treatyLetter3b");
            Debug.Log("This TTS Worked");
        }

    }
}
