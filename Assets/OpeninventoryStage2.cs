using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
namespace Alpha.Phases.Destiny.Quest
{
    public class OpeninventoryStage2 : MonoBehaviour
    {
        // this script holds the main meat of the inventory
        // public TUSOMLobby1TextMan tusomTextMan;
        public GameObject invUIPanal; // declare gameobject for UI inventory panal
                                      //  public Stage1Scene1LabTextBox textMan;
        public Button openInv;
        public Button closeInv;

        public Button openBook1;
        public Button closeBook1;
        public Button openBook2;
        public Button closeBook2;
        public Button openBook3;
        public Button closeBook3;
        public Button openBook4;
        public Button closeBook4;
        public Button openBook5;
        public Button closeBook5;
        // public Button citation1Button;

        public GameObject book1;
        public GameObject book2;
        public GameObject book3;
        public GameObject book4;
        public GameObject book5;
        [SerializeField]
        public bool isInvOpen; // bool to check is the inventory is open 
        public bool stopRepeat;
        public bool stopRepeat2;
        public bool book1Read;
        public bool book1Closed;
        public bool inventoryReadToBeOpen;

        public Button ttsBulletPoint1;
        public Button ttsBulletPoint2;
        public Button ttsBulletPoint3;
        public Button ttsBulletPoint4;
        public Button ttsBulletPoint5;
        public Button ttsBulletPoint6;

        public Button ttsBulletPoint1Book2;
        public Button ttsBulletPoint2Book2;
        public Button ttsBulletPoint3Book2;
        public Button ttsBulletPoint4Book2;

        public Button ttsBulletPoint1Book3;
        public Button ttsBulletPoint2Book3;
        public Button ttsBulletPoint3Book3;
        public Button ttsBulletPoint4Book3;

        public Button ttsBulletPoint1Book4;
        public Button ttsBulletPoint2Book4;
        public Button ttsBulletPoint3Book4;
        public Button ttsBulletPoint4Book4;

        public Button ttsBulletPoint1Book5;
        public Button ttsBulletPoint2Book5;
        public Button ttsBulletPoint3Book5;
        public Button ttsBulletPoint4Book5;
        public Button ttsBulletPoint5Book5;
        public Button ttsBulletPoint6Book5;



        private void Awake()
        {
            openInv.onClick.AddListener(OpenInventory);
            closeInv.onClick.AddListener(OpenInventory);

            openBook1.onClick.AddListener(OpenBook1ManifestDestiny);
            closeBook1.onClick.AddListener(CloseBook1ManifestDestiny);
            openBook2.onClick.AddListener(OpenBook2DiplomacyAndStratergies);
            closeBook2.onClick.AddListener(CloseBook2iplomacyAndStratergies);
            openBook3.onClick.AddListener(OpenBook3Louisiana);
            closeBook3.onClick.AddListener(CloseBook3Louisiana);
            openBook4.onClick.AddListener(OpenBook4Motivations);
            closeBook4.onClick.AddListener(CloseBook4Motivations);
            openBook5.onClick.AddListener(OpenBook5OregonTrail);
            closeBook5.onClick.AddListener(CloseBook5OregonTrail);

            ttsBulletPoint1.onClick.AddListener(PlayTTSBulletPoint1);
            ttsBulletPoint2.onClick.AddListener(PlayTTSBulletPoint2);
            ttsBulletPoint3.onClick.AddListener(PlayTTSBulletPoint3);
            ttsBulletPoint4.onClick.AddListener(PlayTTSBulletPoint4);
            ttsBulletPoint5.onClick.AddListener(PlayTTSBulletPoint5);
            ttsBulletPoint6.onClick.AddListener(PlayTTSBulletPoint6);

            ttsBulletPoint1Book2.onClick.AddListener(PlayTTSBook2BulletPoint1);
            ttsBulletPoint2Book2.onClick.AddListener(PlayTTSBook2BulletPoint2);
            ttsBulletPoint3Book2.onClick.AddListener(PlayTTSBook2BulletPoint3);
            ttsBulletPoint4Book2.onClick.AddListener(PlayTTSBook2BulletPoint4);

            ttsBulletPoint1Book3.onClick.AddListener(PlayTTSBook3BulletPoint1);
            ttsBulletPoint2Book3.onClick.AddListener(PlayTTSBook3BulletPoint2);
            ttsBulletPoint3Book3.onClick.AddListener(PlayTTSBook3BulletPoint3);
            ttsBulletPoint4Book3.onClick.AddListener(PlayTTSBook3BulletPoint4);

            ttsBulletPoint1Book4.onClick.AddListener(PlayTTSBook4BulletPoint1);
            ttsBulletPoint2Book4.onClick.AddListener(PlayTTSBook4BulletPoint2);
            ttsBulletPoint3Book4.onClick.AddListener(PlayTTSBook4BulletPoint3);
            ttsBulletPoint4Book4.onClick.AddListener(PlayTTSBook4BulletPoint4);

            ttsBulletPoint1Book5.onClick.AddListener(PlayTTSBulletPoint1Book5);
            ttsBulletPoint2Book5.onClick.AddListener(PlayTTSBulletPoint2Book5);
            ttsBulletPoint3Book5.onClick.AddListener(PlayTTSBulletPoint3Book5);
            ttsBulletPoint4Book5.onClick.AddListener(PlayTTSBulletPoint4Book5);
            ttsBulletPoint5Book5.onClick.AddListener(PlayTTSBulletPoint5Book5);
            ttsBulletPoint6Book5.onClick.AddListener(PlayTTSBulletPoint6Book5);
        }
        // Update is called once per frame
        void Update()
        {

            if (isInvOpen) // if inventory is open
            {
                if (!stopRepeat) // if stopRepeat bool is fasle, execute code
                {
                    invUIPanal.gameObject.SetActive(true); // enable the INV UI
                    Debug.Log("Inv Consta Loading");
                    stopRepeat = true; // set stop repeat true to stop it firing over and over
                    // robCont.StopRobotMoving(); // Stops the robot when inventory is open
                }
            }
            else
            {
                if (!stopRepeat2) // if stopRepeat 2 is false
                {
                    invUIPanal.gameObject.SetActive(false); // hide INV UI
                    Debug.Log("Inv Consta Resetting");
                    stopRepeat2 = true; // set stopRepeat 2 to true to stop it firing over and over
                }
            }
        }

        //Function for opening the inventory
        public void OpenInventory()
        {
            isInvOpen = !isInvOpen; // if inventory is closed, open. If open, then close it
            stopRepeat = false; // Set stopRepeat bool to false
            stopRepeat2 = false; // set stoprepeat bool to true

        }

        public void OpenBook1ManifestDestiny()
        {
            book1.gameObject.SetActive(true);

        }

        public void CloseBook1ManifestDestiny()
        {
            book1.gameObject.SetActive(false);
        }

        public void OpenBook2DiplomacyAndStratergies()
        {
            book2.gameObject.SetActive(true);

        }

        public void CloseBook2iplomacyAndStratergies()
        {
            book2.gameObject.SetActive(false);
        }

        public void OpenBook3Louisiana()
        {
            book3.gameObject.SetActive(true);

        }

        public void CloseBook3Louisiana()
        {
            book3.gameObject.SetActive(false);
        }

        public void OpenBook4Motivations()
        {
            book4.gameObject.SetActive(true);

        }

        public void CloseBook4Motivations()
        {
            book4.gameObject.SetActive(false);
        }

        public void OpenBook5OregonTrail()
        {
            book5.gameObject.SetActive(true);

        }

        public void CloseBook5OregonTrail()
        {
            book5.gameObject.SetActive(false);
        }

        public void PlayTTSBulletPoint1()
        {
            LOLSDK.Instance.SpeakText("book1BP1");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBulletPoint2()
        {
            LOLSDK.Instance.SpeakText("book1BP2");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBulletPoint3()
        {
            LOLSDK.Instance.SpeakText("book1BP3");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBulletPoint4()
        {
            LOLSDK.Instance.SpeakText("book1BP4");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSBulletPoint5()
        {
            LOLSDK.Instance.SpeakText("book1BP5");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBulletPoint6()
        {
            LOLSDK.Instance.SpeakText("book1BP6");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSBook2BulletPoint1()
        {
            LOLSDK.Instance.SpeakText("book2BP1");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook2BulletPoint2()
        {
            LOLSDK.Instance.SpeakText("book2BP2");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook2BulletPoint3()
        {
            LOLSDK.Instance.SpeakText("book2BP3");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook2BulletPoint4()
        {
            LOLSDK.Instance.SpeakText("book2BP4");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSBook3BulletPoint1()
        {
            LOLSDK.Instance.SpeakText("book3BP1");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook3BulletPoint2()
        {
            LOLSDK.Instance.SpeakText("book3BP2");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook3BulletPoint3()
        {
            LOLSDK.Instance.SpeakText("book3BP3");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook3BulletPoint4()
        {
            LOLSDK.Instance.SpeakText("book3BP4");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook4BulletPoint1()
        {
            LOLSDK.Instance.SpeakText("book4BP1");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook4BulletPoint2()
        {
            LOLSDK.Instance.SpeakText("book4BP2");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook4BulletPoint3()
        {
            LOLSDK.Instance.SpeakText("book4BP3");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBook4BulletPoint4()
        {
            LOLSDK.Instance.SpeakText("book4BP4");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSBulletPoint1Book5()
        {
            LOLSDK.Instance.SpeakText("book5BP1");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBulletPoint2Book5()
        {
            LOLSDK.Instance.SpeakText("book5BP2");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBulletPoint3Book5()
        {
            LOLSDK.Instance.SpeakText("book5BP3");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBulletPoint4Book5()
        {
            LOLSDK.Instance.SpeakText("book5BP4");
            Debug.Log("This TTS Worked");
        }


        public void PlayTTSBulletPoint5Book5()
        {
            LOLSDK.Instance.SpeakText("book5BP5");
            Debug.Log("This TTS Worked");
        }

        public void PlayTTSBulletPoint6Book5()
        {
            LOLSDK.Instance.SpeakText("book5BP6");
            Debug.Log("This TTS Worked");
        }

    }
}
