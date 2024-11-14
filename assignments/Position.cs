using UnityEngine;

namespace Assignment16
{
    public struct Position
    {
        public float x, y, z;

        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void PrintPosition()
        {
            Debug.Log($"Position - X: {x}, Y: {y}, Z: {z}");
        }
    }
}   
