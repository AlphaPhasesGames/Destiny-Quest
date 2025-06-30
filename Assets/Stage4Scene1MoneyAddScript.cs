using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LoLSDK;
using UnityEngine.SceneManagement;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage4Scene1MoneyAddScript : MonoBehaviour
    {
        public Stage4TextMan textMan;
        public Button moneyUP;
        public Button moneyDown;

        public Button confirm;

        public int moneyValue;
        public TextMeshProUGUI moneyOnScreen;

        private void Awake()
        {
            moneyUP.onClick.AddListener(IncreaseMoney);
            moneyDown.onClick.AddListener(DecreaseMoney);
            confirm.onClick.AddListener(ConfirmValue);
        }

        private void Update()
        {
            moneyOnScreen.text = moneyValue.ToString();
        }


        public void IncreaseMoney()
        {
            moneyValue++;
        }
        public void DecreaseMoney()
        {
            moneyValue--;
        }

        public void ConfirmValue()
        {
            if(moneyValue == 15)
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 6;
            }

            else
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 7;
            }
        }

    }
}
