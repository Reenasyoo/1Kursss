using UnityEngine;

public class DefenceRobot : Robot, IDefenceRobot
{
    public int defenceStrenght = 5;

    public DefenceRobot(string name) : base( name )
    {
        
    }

    public void Deflect()
    {
        MonoBehaviour.print($"{robotName} is deflecting");
    }
}