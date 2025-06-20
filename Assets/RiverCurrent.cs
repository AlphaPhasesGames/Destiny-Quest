using UnityEngine;
namespace Alpha.Phases.Destiny.Quest
{
    public class RiverCurrent : MonoBehaviour
    {
        public Vector3 currentDirection = new Vector3(1, 0, 0); // direction of the flow
        public float currentStrength = 1f; // units per second

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                var agent = other.GetComponent<UnityEngine.AI.NavMeshAgent>();
                if (agent != null && agent.enabled)
                {
                    // Gently push player along current direction
                    agent.Move(currentDirection.normalized * currentStrength * Time.deltaTime);
                }
            }
        }
    }
}
