using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene3LetterManager : MonoBehaviour
    {
        public Stage1Scene3TextMan s3TextMan;
        [Header("Letter Pages")]
        public GameObject[] letterPages; // Assign all your letter page UI images here
        public GameObject letterParent;
        [Header("Navigation")]
        public Button forwardButton;     // Your forward arrow button
        public Button backButton;        // Your back arrow button

        public Button page1TTS;
        public Button page2TTS;
        public Button page3TTS;
        public Button page4TTS;
        public Button page5TTS;

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
            page4TTS.onClick.AddListener(PlayTTSLetter4);
            page5TTS.onClick.AddListener(PlayTTSLetter5);
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
            s3TextMan.positionChanged = true;
            s3TextMan.arrayPos = 1;
        }

        public void PlayTTSLetter1()
        {
            LOLSDK.Instance.SpeakText("napoleonLetter1");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter2()
        {
            LOLSDK.Instance.SpeakText("napoleonLetter2");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSLetter3()
        {
            LOLSDK.Instance.SpeakText("napoleonLetter3");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter4()
        {
            LOLSDK.Instance.SpeakText("napoleonLetter4");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSLetter5()
        {
            LOLSDK.Instance.SpeakText("napoleonLetter5");
            Debug.Log("This TTS Worked");
        }
      
    }
}
