using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class FoodSlider : MonoBehaviour
    {
        public Button closeFoodTaskBox;
        public GameObject foodTaskBox;
        public Slider foodSlider;

        private void Awake()
        {
            closeFoodTaskBox.onClick.AddListener(NotEnoughWater);
        }
        public void AddValueToSlider()
        {
            foodSlider.value++;
        }

        public void NotEnoughWater()
        {
            foodTaskBox.gameObject.SetActive(false);
        }
    }
}
