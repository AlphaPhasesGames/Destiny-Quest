using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Destiny.Quest
{
    public class TopDownCamFollowPlayer : MonoBehaviour
    {
        public Transform player;          // Drag your player here
        public Vector3 offset = new Vector3(0f, 10f, 0f); // Height above player

        void LateUpdate()
        {
            if (player == null) return;

            // Follow the player's position only, without rotation
            transform.position = player.position + offset;

            // Optional: lock rotation to top-down looking straight down
            transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        }
    }
}
