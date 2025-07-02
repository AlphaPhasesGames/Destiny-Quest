using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Destiny.Quest
{
    public class EndGameLetterManager : MonoBehaviour
    {

        [Header("Letter Pages")]
        public GameObject[] letterPages; // Assign all your letter page UI images here
        public GameObject letterParent;
        [Header("Navigation")]
        public Button forwardButton;     // Your forward arrow button
        public Button backButton;        // Your back arrow button

        public Button page1TTS;
        public Button page1aTTS;
        public Button page2TTS;
        public Button page3TTS;
        public Button page4TTS;

        public GameObject finaltext;
        public Animator endFade;
        public GameObject fadeEnable;
        private int currentPage = 0;
        private void Start()
        {
            forwardButton.onClick.AddListener(OnForwardButtonClicked);
            backButton.onClick.AddListener(OnBackButtonClicked);

            page1TTS.onClick.AddListener(PlayTTSLetter1);
            page1aTTS.onClick.AddListener(PlayTTSLetter1a);
            page2TTS.onClick.AddListener(PlayTTSLetter2);
            page3TTS.onClick.AddListener(PlayTTSLetter3);
            page4TTS.onClick.AddListener(PlayTTSLetter4);

            ShowPage(0);
            StartCoroutine(StartLetter());
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

            if (index == 3)
            {
                StartCoroutine(RunFunctionAfterPage4Delay());
            }
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



        public void PlayTTSLetter1()
        {
            LOLSDK.Instance.SpeakText("endGame1");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter1a()
        {
            LOLSDK.Instance.SpeakText("endGame2");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter2()
        {
            LOLSDK.Instance.SpeakText("endGame3");
            Debug.Log("This TTS Worked");
        }
        public void PlayTTSLetter3()
        {
            LOLSDK.Instance.SpeakText("endGame4");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter4()
        {
            LOLSDK.Instance.SpeakText("endGame5");
            Debug.Log("This TTS Worked");
        }

        public IEnumerator StartLetter()
        {
            yield return new WaitForSeconds(2);
            letterParent.gameObject.SetActive(true);
        }
      
        public IEnumerator RunFunctionAfterPage4Delay()
        {
            yield return new WaitForSeconds(4);
            finaltext.gameObject.SetActive(true);
            yield return new WaitForSeconds(2);
            fadeEnable.gameObject.SetActive(true);
            endFade.SetBool("fadeEnd", true);
            LOLSDK.Instance.SubmitProgress(0, 100, 100);
            LOLSDK.Instance.CompleteGame();
        }
    }
}
