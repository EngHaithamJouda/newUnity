using UnityEngine;

namespace Assignment16
{
    public class Character_1Test : MonoBehaviour
    {
        void Start()
        {
            Character_1[] characters = new Character_1[2];

            Position soldierPosition = new Position(0, 0, 0);
            Soldier soldier = new Soldier("John", 100, soldierPosition);
            characters[0] = soldier;  

            Position officerPosition = new Position(5, 0, 0);
            Officer officer = new Officer("Smith", 100, officerPosition);
            characters[1] = officer;  

            Gun rifle = new Gun("Rifle", 20, 5);

            Debug.Log("Displaying all characters' info:");
            foreach (var character in characters)
            {
                character.DisplayInfo();
            }

            Debug.Log("\nSoldier attacks Officer with Rifle:");
            soldier.Attack(rifle.GunDamage, officer, rifle);
            officer.DisplayInfo();

            Debug.Log("\nTesting Gun Shooting:");
            for (int i = 0; i < 6; i++)
            {
                rifle.Shoot();
            }

            Debug.Log("\nReloading the Rifle:");
            rifle.Reload(3);

            rifle.Shoot();

            Debug.Log("\nFinal characters' info after actions:");
            foreach (var character in characters)
            {
                character.DisplayInfo();
            }
        }
    }
}
