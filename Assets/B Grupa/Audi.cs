using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audi : Car, IDrivable
{
    public Audi(string name) : base(name)
    {
        
    }

    public void Drag()
    {
        MonoBehaviour.print("race");
    }

    public void Drive()
    {
        MonoBehaviour.print("fast");
    }

    public override void GetGas()
    {
        MonoBehaviour.print("fillin up");
    }
}
