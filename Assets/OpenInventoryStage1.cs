using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Alpha.Phases.Destiny.Quest
{
    public class OpenInventoryStage1 : MonoBehaviour
    {
        // this script holds the main meat of the inventory
        // public TUSOMLobby1TextMan tusomTextMan;
        public GameObject invUIPanal; // declare gameobject for UI inventory panal

        public Button openInv;
        public Button closeInv;

        [SerializeField]
        public bool isInvOpen; // bool to check is the inventory is open 
        public bool stopRepeat;
        public bool stopRepeat2;

        private void Awake()
        {
            openInv.onClick.AddListener(OpenInventory);
            closeInv.onClick.AddListener(OpenInventory);

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

    }
}