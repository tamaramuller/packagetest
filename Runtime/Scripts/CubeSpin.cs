using UnityEngine;

namespace com.yourusername.packagetest
{
    public class AdvancedCubeSpin : MonoBehaviour
    {
        public bool newVersionasd;
        [Tooltip("Rotation speed in degrees per second")]
        public float rotationSpeed = 100f;
        public bool dsjélkfjlaséjfslédfjléfj;

        [Tooltip("Use world axis for rotation instead of local axis")]
        public bool useWorldAxis = true; // New property

        private void Update()
        {
            // Example breaking change: Fixed axis rotation, no longer configurable
            Vector3 axis = useWorldAxis ? Vector3.up : transform.up; // Modified axis behavior
            transform.Rotate(axis, rotationSpeed * Time.deltaTime);
        }
    }
}