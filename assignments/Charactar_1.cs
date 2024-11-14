using UnityEngine;

namespace Assignment16
{
    public class Character_1
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get => health;
            set => health = Mathf.Clamp(value, 0, 100);
        }

        public Character_1(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }

        public Character_1() : this("No name", 100, new Position(0, 0, 0)) { }

        public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {name}, Health: {Health}");
            position.PrintPosition();
        }

        public void Attack(int damage, Character_1 target)
        {
            target.TakeDamage(damage);
        }

        public void Attack(int damage, Character_1 target, Gun attackType)
        {
            attackType.GunDamage = damage;
            Debug.Log($"Attack Type: {attackType.GunName} with damage {attackType.GunDamage}");
            target.TakeDamage(damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Debug.Log($"{name} takes {damage} damage. Remaining Health: {Health}");
        }
    }
}
