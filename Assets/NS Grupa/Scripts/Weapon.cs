
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ns_Grupa
{
    [System.Serializable]
    public abstract class Weapon
    {
        public string weaponName = "Weapon #0";
        public int damage = 10;
        
        public void PrintName()
        {
            MonoBehaviour.print(weaponName);
        }

        public void SetName(string name)
        {
            weaponName = name;
        }

        public abstract void Attack();
    }
}