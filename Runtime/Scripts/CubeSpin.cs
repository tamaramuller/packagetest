using UnityEngine;

namespace com.yourusername.packagetest
{
    public class CubeSpin : MonoBehaviour
    {
        [Tooltip("Rotation speed in degrees per second")]
        public float rotationSpeed = 100f;

        [Tooltip("Rotation axis")]
        public Vector3 rotationAxis = Vector3.up;

        private void Update()
        {
            // Rotate the object around the specified axis
            transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
        }
    }
}