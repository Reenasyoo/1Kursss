using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ns_Grupa
{
    public class Factory : MonoBehaviour
    {
        public AttackRobot[] robots;

        public List<Transform> spawnLocations = new List<Transform>();
        
        private void Start()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                spawnLocations.Add(transform.GetChild(i).transform);
            }
            
            
            // Rifle rifle1 = new Rifle();
            // rifle1.SetName("Rifle");

            // Robot tempRobot = new Robot("first robot");
            // tempRobot.PrintName();
            //
            // Robot temp2 = new Robot("second rob");
            // temp2.PrintName();
            //
            // AttackRobot att = new AttackRobot("Att Rob", rifle1);
            // att.PrintName();
            // att.robotWeapon.Attack();

            // DefenceRobot robby = new DefenceRobot("Defo", rifle1);
            // AttackRobot atRob = new AttackRobot("Atter", rifle1);
            // Robot robi = new AttackRobot("attttt", rifle1);
            //
            // robby.Def();
            // atRob.Attack();
            // robi.PrintName();
        }
    }
}