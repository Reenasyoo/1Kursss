using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public int a = 0; // 1,2,3 -1,2,3 
    public int aaa = 2;
    private float b = 0f; // 1.4, 6.9, 4.2,
    private string d = "afsda";
    protected bool c = false; // true, false
    // + - * / () 
    private void Start()
    {
        // print("hello");
         // print(a);
        // print(ReturnIntPrivate());
        // Math();
        FuncWithParam(5);
    }
    public void Math()
    {
        int c = a + aaa;
        print(c);
    }
    public void FuncWithParam(int param)
    {
        print(param);
    }
    private float ReturnIntPrivate()
    {
        int returnInt = 0;
        return returnInt;
    }
    public float ReturnIntPublic()
    {
        return a;
    }


    public int Bar(int param)
    {
        int c = 3 + param;
        return c;
    }

    public void Foo()
    {
        print(Bar(5));
    }
}
