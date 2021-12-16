using System;
using UnityEngine;

[Serializable]
public class Car
{
    public string carName = "Car #0";

    public Car(string name) // Constructor
    {
        carName = name;
    }

    public void PrintName()
    {
        MonoBehaviour.print(carName);
    }

    public void SetName(string name)
    {
        carName = name;
    }

    //public virtual void Drive()
    //{
      //  MonoBehaviour.print("drive");
    //}

    public virtual void GetGas()
    {
        
    }
}
