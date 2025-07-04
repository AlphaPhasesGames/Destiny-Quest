using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

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
            CheckIfArrived();
        }

        /// <summary>
        /// Detects input based on platform and calls movement method.
        /// </summary>
        private void HandleInput()
        {
//#if UNITY_EDITOR || UNITY_STANDALONE
            // Handle mouse input (Editor or Desktop builds)
            if (Input.GetMouseButtonDown(0))
            {
                if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
                    return;

                TryMoveTo(Input.mousePosition);
            }
//#elif UNITY_IOS || UNITY_ANDROID
            // Handle first touch input (Mobile builds)
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                    return;

                TryMoveTo(Input.GetTouch(0).position);
            }
//#endif
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
                agent.isStopped = false; // Ensure the agent is active
            }
        }

        /// <summary>
        /// Checks if the agent has reached its destination and stops it to prevent circling.
        /// </summary>
        private void CheckIfArrived()
        {
            if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    agent.isStopped = true;
                    agent.velocity = Vector3.zero;
                }
            }
        }
    }
}
