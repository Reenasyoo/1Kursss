using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAttackRobot : AttackRobot
{
    
    public BigAttackRobot(string name, Weapon weapon) : base(name, weapon)
    {
        base.robotWeapon = weapon;
    }

    public override void Attack()
    {
        base.Attack();
        base.Attack();
    }
}
