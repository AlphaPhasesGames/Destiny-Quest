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

        [Header("Wagon Wheels")]
        public Transform leftWheel;
        public Transform rightWheel;
        [Tooltip("Wheel radius in meters—used to match spin to distance.")]
        public float wheelRadius = 0.45f;
        [Tooltip("Fine-tune spin (1 = physically correct).")]
        public float wheelSpinMultiplier = 1f;
        [Tooltip("Flip if your wheels spin the wrong way.")]
        public bool invertWheelSpin = false;

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

            // Spin wheels for both forward 
            if (Mathf.Abs(moveInput) > 0.001f && wheelRadius > 0f)
            {
                // Signed distance this frame (negative when reversing)
                float distance = moveSpeed * Time.deltaTime * moveInput;

                // Convert linear distance to angular rotation (degrees)
                float angle = (distance / (2f * Mathf.PI * wheelRadius)) * 360f * wheelSpinMultiplier;

                // Optional flip if your local axis is opposite
                if (invertWheelSpin) angle = -angle;

                // Rotate around local X. If your model uses Z, swap to Rotate(0,0,angle).
                if (leftWheel) leftWheel.Rotate(angle, 0f, 0f, Space.Self);
                if (rightWheel) rightWheel.Rotate(angle, 0f, 0f, Space.Self);
            }

            // Re-lock Y position
            Vector3 pos = transform.position;
            transform.position = new Vector3(pos.x, fixedY, pos.z);
        }
    }
}
