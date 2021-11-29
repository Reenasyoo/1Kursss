using UnityEngine;

public class AttackRobot : Robot
{
   protected Weapon robotWeapon;

   public AttackRobot(string name, Weapon weapon) : base( name)
   {
      this.robotWeapon = weapon;
   }

   public virtual void Attack()
   {
      MonoBehaviour.print($"{robotName} is attacking. - Damage : {robotWeapon.attackStrength}");
   }
   
}
