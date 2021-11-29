using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ns_Grupa
{
    [System.Serializable]
    public class Rifle : Weapon
    {
        public override void Attack()
        {
            // base.Attack();
            MonoBehaviour.print($"{ weaponName} is firing");
        }
    }
}
