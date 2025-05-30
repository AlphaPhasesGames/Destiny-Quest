using UnityEngine;
using UnityEngine.AI;

namespace Alpha.Phases.Destiny.Quest
{
    public class PlayerMovement : MonoBehaviour
    {
        private NavMeshAgent agent; // Reference to the NavMeshAgent component

        void Awake()
        {
            // Cache the NavMeshAgent component at startup
            agent = GetComponent<NavMeshAgent>();
        }
        void Update()
        {
            HandleInput();
        }
        /// <summary>
        /// Detects input based on platform and calls movement method.
        /// </summary>
        private void HandleInput()
        {
#if UNITY_EDITOR || UNITY_STANDALONE
            // Handle mouse input (Editor or Desktop builds)
            if (Input.GetMouseButtonDown(0))
            {
                TryMoveTo(Input.mousePosition);
            }
#elif UNITY_IOS || UNITY_ANDROID
        // Handle first touch input (Mobile builds)
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            TryMoveTo(Input.GetTouch(0).position);
        }
#endif
        }

        /// <summary>
        /// Raycasts into the scene from a screen position and moves the agent if it hits a valid point.
        /// </summary>
        /// <param name="screenPosition">The screen position of the input (mouse or touch).</param>
        private void TryMoveTo(Vector2 screenPosition)
        {
            // Convert 2D screen position into a ray pointing into the scene
            Ray ray = Camera.main.ScreenPointToRay(screenPosition);
            RaycastHit hit;

            // Check if the ray hits something in the world
            if (Physics.Raycast(ray, out hit))
            {
                // Move the agent to the hit point on the NavMesh
                agent.SetDestination(hit.point);
            }
        }
    }
}