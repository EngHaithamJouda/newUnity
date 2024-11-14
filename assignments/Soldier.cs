using UnityEngine;

namespace Assignment16
{
    public class Soldier : Character_1
    {
        public Soldier(string name, int health, Position position) : base(name, health, position) { }
        public Soldier() : base() { }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
}
