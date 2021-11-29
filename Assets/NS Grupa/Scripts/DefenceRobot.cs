using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ns_Grupa
{
    public class DefenceRobot : Robot, IDefenceRobot
    {
        public DefenceRobot(string name, Rifle wep) : base(name, wep)
        {
            
        }

        public void Deflect()
        {
            MonoBehaviour.print($"{robotName} is deflect");
        }

        public void Def()
        {
            
        }
    }
}