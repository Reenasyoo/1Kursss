using UnityEngine;

public class Factory : MonoBehaviour
{
    private void Start()
    {
        // IDefenceRobot defRob = new DefenceRobot("Deflecter");
        // IDefenceRobot bigDef = new BigDefenceRobot("Big Def");
        // defRob.Deflect();
        // bigDef.Deflect();
    }


    public void CreateAttackers()
    {
        Rifle rifle = new Rifle();
        rifle.SetName("AR Cool");
        rifle.PrintName();

        Rifle akRifle = new Rifle();
        akRifle.SetName("AK");
        akRifle.SetAttackStrength(20);

        
        AttackRobot attRob = new AttackRobot("Attacker", rifle);
        BigAttackRobot bigRob = new BigAttackRobot("Big Rob", akRifle);

        attRob.Attack();
        bigRob.Attack();
    }
}
