using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage2Scene2FoodCollect : MonoBehaviour
    {
        public FoodSlider foodSlider;
        public GameObject bushToRemove;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(bushToRemove);
                foodSlider.AddValueToSlider();
            }
        }
    }
}
