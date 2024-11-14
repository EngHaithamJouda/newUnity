using UnityEngine;

namespace Assignment16
{
    public class Gun
    {
        private string gunName;
        private int gunDamage;
        private int gunBullets;

        public Gun(string name, int damage, int bullets)
        {
            gunName = name;
            gunDamage = damage;
            gunBullets = bullets;
        }

        public string GunName
        {
            get { return gunName; }
            set { gunName = value; }
        }

        public int GunDamage
        {
            get { return gunDamage; }
            set { gunDamage = value; }
        }

        public int GunBullets
        {
            get { return gunBullets; }
            set { gunBullets = value; }
        }

        public void Shoot()
        {
            if (gunBullets > 0)
            {
                gunBullets--;
                Debug.Log("Shot fired! Bullets remaining: " + gunBullets);
            }
            else
            {
                Debug.Log("No bullets left!");
            }
        }

        public void Reload(int bullets)
        {
            gunBullets += bullets;
            Debug.Log("Gun reloaded! Total bullets: " + gunBullets);
        }
    }
}
