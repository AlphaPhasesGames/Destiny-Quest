using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Alpha.Phases.Destiny.Quest
{

    public class Book1InventoryNameShow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public GameObject textPanel; // Assign your panel in the inspector

        void Start()
        {
            if (textPanel != null)
                textPanel.SetActive(false); // Hide panel initially
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (textPanel != null)
                textPanel.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (textPanel != null)
                textPanel.SetActive(false);
        }

    }
}

