using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ns_Grupa
{
    [System.Serializable]
    public class AttackRobot : Robot, IDefenceRobot
    {
        
        public AttackRobot(string name, Rifle wep) : base(name, wep)
        {
            
        }
        
        public void Attack()
        {
            
        }
        
        public void Deflect()
        {
            MonoBehaviour.print($"{robotName} is deflect");
        }
    }
}