using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Alpha.Phases.Destiny.Quest
{
    public class WaterSlider : MonoBehaviour
    {

        public Slider waterSlider;



        public void AddValueToSlider()
        {
            waterSlider.value++;
        }
    }
}
