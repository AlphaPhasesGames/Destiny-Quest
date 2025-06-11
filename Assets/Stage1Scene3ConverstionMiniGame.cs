using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage1Scene3ConverstionMiniGame : MonoBehaviour
    {
        public Stage1Scene3TextMan textMan;

        public GameObject minigameCanvas;
        public GameObject napoleon1Choices;
        public GameObject monroe1Choices;
        public GameObject napoleon2Choices;
        public GameObject monroe2Choices;

        public Button napoConvoButton1A;
        public Button napoConvoButton1B;

        public Button monroeConvoButton1A;
        public Button monroeConvoButton1B;

        public Button napoConvoButton2A;
        public Button napoConvoButton2B;

        public Button monroeConvoButton2A;
        public Button monroeConvoButton2B;

        public Animator napoAnim;
        public Animator monroeAnim;

        public Camera napoleonCam;             // Camera for Napoleon scenes
        public Camera MonroeCam;             // Camera for James Monroe scenes
        private void Start()
        {

            napoConvoButton1A.onClick.AddListener(NapoConvoChoice1A);
            napoConvoButton1B.onClick.AddListener(NapoConvoChoice1B);
            napoConvoButton2A.onClick.AddListener(NapoConvoChoice2A);
            napoConvoButton2B.onClick.AddListener(NapoConvoChoice2B);
           
            monroeConvoButton1A.onClick.AddListener(MonroeConvoChoice1A);
            monroeConvoButton1B.onClick.AddListener(MonroeConvoChoice1B);
            monroeConvoButton2A.onClick.AddListener(MonroeConvoChoice2A);
            monroeConvoButton2B.onClick.AddListener(MonroeConvoChoice2B);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void NapoConvoChoice1A()
        {
            napoleon1Choices.gameObject.SetActive(false);
            monroe1Choices.gameObject.SetActive(true);
            napoAnim.Play("Idle");
            monroeAnim.SetBool("monStart", true);
            napoleonCam.gameObject.SetActive(false);
            MonroeCam.gameObject.SetActive(true);
        }

        public void NapoConvoChoice1B()
        {
            napoleon1Choices.gameObject.SetActive(false);
            monroe1Choices.gameObject.SetActive(true);
            napoAnim.Play("Idle");
            monroeAnim.SetBool("monStart", true);
            napoleonCam.gameObject.SetActive(false);
            MonroeCam.gameObject.SetActive(true);
        }

        public void MonroeConvoChoice1A()
        {
            napoleon2Choices.gameObject.SetActive(true);
            monroe1Choices.gameObject.SetActive(false);
            monroeAnim.Play("Idle");
            napoAnim.SetBool("nepoStart", true);
            napoleonCam.gameObject.SetActive(true);
            MonroeCam.gameObject.SetActive(false);
        }

        public void MonroeConvoChoice1B()
        {
            napoleon2Choices.gameObject.SetActive(true);
            monroe1Choices.gameObject.SetActive(false);
            monroeAnim.Play("Idle");
            napoAnim.SetBool("nepoStart", true);
            napoleonCam.gameObject.SetActive(true);
            MonroeCam.gameObject.SetActive(false);
        }

      

        public void NapoConvoChoice2A()
        {
            napoleon2Choices.gameObject.SetActive(false);
            monroe2Choices.gameObject.SetActive(true);
            napoAnim.Play("Idle");
            monroeAnim.SetBool("monStart", true);
            napoleonCam.gameObject.SetActive(false);
            MonroeCam.gameObject.SetActive(true);
        }

        public void NapoConvoChoice2B()
        {
            napoleon2Choices.gameObject.SetActive(false);
            monroe2Choices.gameObject.SetActive(true);
            napoAnim.Play("Idle");
            monroeAnim.SetBool("monStart", true);
            napoleonCam.gameObject.SetActive(false);
            MonroeCam.gameObject.SetActive(true);
        }

        public void MonroeConvoChoice2A() // correct
        {
            monroe2Choices.gameObject.SetActive(false);
            textMan.positionChanged = true;
       
            textMan.arrayPos = 3;
            textMan.ResetBools();
            // monroeAnim.Play("Idle");
            // napoAnim.SetBool("nepoStart", true);

        }

        public void MonroeConvoChoice2B() // incorrect
        {
            monroe2Choices.gameObject.SetActive(false);
            textMan.positionChanged = true;

            textMan.arrayPos = 2;
            textMan.ResetBools();
            //monroeAnim.Play("Idle");
            //  napoAnim.SetBool("nepoStart", true);
        }
    }
}
