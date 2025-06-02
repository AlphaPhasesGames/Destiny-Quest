using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alpha.Phases.Destiny.Quest
{
    public class CollectEnvelopeAndDeviceTrigger : MonoBehaviour
    {

        public GameObject envelope;
        public GameObject timeDevice;
        public Stage1Scene1LabTextBox stage1Text;
        public bool runOnce;
        // Start is called before the first frame update
 

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (!runOnce)
                {
                    Destroy(timeDevice);
                    Destroy(envelope);
                    runOnce = true;
                    stage1Text.positionChanged = true;
                    stage1Text.arrayPos = 3;
                }
               
       
            }
        }
    }
}
