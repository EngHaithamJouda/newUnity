using UnityEngine;

namespace Assignment16
{
    public class Character_1Test : MonoBehaviour
    {
        void Start()
        {
            Position soldierPosition = new Position(0, 0, 0);
            Soldier soldier = new Soldier("John", 100, soldierPosition);

            Position officerPosition = new Position(5, 0, 0);
            Officer officer = new Officer("Smith", 100, officerPosition);

            Gun rifle = new Gun("Rifle", 20, 5);
            
            soldier.DisplayInfo();
            officer.DisplayInfo();

            // هجوم الجندي على الضابط باستخدام السلاح
            //=================================================
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
            soldier.DisplayInfo();
            officer.DisplayInfo();
        }
    }
}
