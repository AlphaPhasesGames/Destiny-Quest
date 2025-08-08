using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Destiny.Quest
{
    public class Stage2Scene1CollectWater : MonoBehaviour
    {
        public WaterSlider waterSlider;
        public GameObject bucketToRemove;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(bucketToRemove);
                waterSlider.AddValueToSlider();
            }
        }
    }
}
