using UnityEngine;

public class Bembis : Car, IDrivable
{
    public string carName = "aa";
    public Bembis(string name) : base(name)
    {
        
    }

    public void Drift()
    {
        MonoBehaviour.print("drift");
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
