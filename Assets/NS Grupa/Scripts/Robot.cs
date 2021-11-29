using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ns_Grupa
{
    [System.Serializable]
    public class Robot
    {
        public string robotName = "Robot #0";
        public Rifle robotWeapon;

        public Robot(string name, Rifle wep) // Constructor 
        {
            this.robotName = name;
            this.robotWeapon = wep;
        }
        
        public void PrintName()
        {
            MonoBehaviour.print(robotName);
        }
    }
}