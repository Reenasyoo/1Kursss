using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honda : Car
{
    public Honda(string name) : base(name)
    {
        
    }
    
    public void Drag()
    {
        MonoBehaviour.print("race");
    }

    public override void GetGas()
    {
        MonoBehaviour.print("fillin up");
    }
}