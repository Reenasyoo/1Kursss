using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    protected string weaponName = "Weapon #0";
    public int attackStrength = 10;
    
    public void PrintName()
    {
        MonoBehaviour.print(weaponName);
    }

    public abstract void Attack();

    public virtual void SetName(string name)
    {
        this.weaponName = name;
    }

    public void SetAttackStrength(int strength)
    {
        attackStrength = strength;
    }
    
}

