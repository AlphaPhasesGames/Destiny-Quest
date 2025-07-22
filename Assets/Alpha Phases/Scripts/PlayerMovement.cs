using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

namespace Alpha.Phases.Destiny.Quest
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float rotateSpeed = 120f;

        private CharacterController controller;
        private float fixedY; // Cached starting Y value

        void Start()
        {
            controller = GetComponent<CharacterController>();
            fixedY = transform.position.y; // Store initial Y position
        }

        void Update()
        {
            // Rotation input: A/D or Left/Right Arrow
            float rotateInput = Input.GetAxis("Horizontal");
            transform.Rotate(0, rotateInput * rotateSpeed * Time.deltaTime, 0);

            // Forward/backward movement: W/S or Up/Down Arrow
            float moveInput = Input.GetAxis("Vertical");
            Vector3 move = transform.forward * moveInput;

            controller.Move(move * moveSpeed * Time.deltaTime);

            // Re-lock Y position
            Vector3 pos = transform.position;
            transform.position = new Vector3(pos.x, fixedY, pos.z);
        }
    }
}