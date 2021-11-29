using UnityEngine;

public class Robot
{
    protected string robotName = "Robot #0";

    // Class constructor
    public Robot(string name)
    {
        this.robotName = name;
    }
   
    public void PrintName()
    {
        MonoBehaviour.print(robotName);
    }
}
