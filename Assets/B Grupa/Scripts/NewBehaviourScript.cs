using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Accessor type / value type / value name / value
    public int a = 3; // Integer 1,2,3 -1,-2,-3
    public float b = 0f; // Float 1.01f, 6.9f, 13.37f, -1.1f
    private string c = "a"; // String "aaaaa", "suns", "hello world!"
    private bool d = false; // Boolean true / false
    
    // + - * /
    
    // Accessor type / Return type / function name / function parameter/s / function body
    private void Start()
    {
        // MyFunc(); // Function call
        // MyFunc2();
        // SetFloat(b); 
    }

    private void MyFunc() // Function declaration
    {
        print(a);
    }
    
    public void MyFunc2()
    {
        // print(ReturnInt());
       // SetFloat(b); 
       Math();
    }
    
    // ReturnInt
    private int ReturnInt()
    {
        return a;
    }
    //          parameter type / parameter name
    private void SetFloat(float param)
    {
        float bb = param;
        print(bb);
    }

    private void Math()
    {
        int res = a * 2;
        print(res);
    }
}
/*
-izveidot 2 fukcijas -(void) "Foo"  un 
    (int) "Bar" (int)
-Fucija "Bar" izdara saskaitisanu ar parametru 
    un to atgriez - saskaita ar 3
-pielikt pie pogas "Foo" funkciju kas 
    izsauc "Bar" funkciju
*/