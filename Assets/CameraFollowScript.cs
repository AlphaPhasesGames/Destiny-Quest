using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Destiny.Quest
{
    public class CameraFollowScript : MonoBehaviour
    {
        public Transform target; // The thing to follow
        public float smoothSpeed = 0.125f;
        public Vector3 offset;

        void LateUpdate()
        {
            if (target == null) return;

            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }

        public void SetTarget(Transform newTarget)
        {
            target = newTarget;
        }
    }
}
