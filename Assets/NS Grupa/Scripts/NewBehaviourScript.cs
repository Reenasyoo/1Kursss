using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // accesor type / variable,value type / variable name / value
    private int a = 1; // veseli skaitli
    private float b = 0.0f; // decimalskaitli
    private string c = "arnis"; // teksts
    private bool d = false; // true false

    // accesor type / return type / function name / fucntion parameter declaration / function body
    private void MyFunc (int param, float param2) { } // function declaration
    //      parameter type / parameter name

    // + - * / < > ()

    public int ab = 0;



    private void Start()
    {
        print(Foo());
        float aab = a / ab;
        Debug.Log ( "AAB : " + aab.ToString("f2"));

        print("A :" + MyFunc3());
        print("AB : " + ab);
        MyFunc5(ab); // a = ab / a = param
        print("New a :" + a);
        MyFunc6("Suns");
        
        // MyFunc2(); // function call
    }
    

    private void MyFunc2 () 
    {
        print("dfgujshjhdgsgfjsdfxju");
        print("dfgujgfjsdfxju");
    }

    private int MyFunc3()
    {
        return a; // vertības atgriešana
    }   

    private string MyFunc4()
    {
        return c;
    }

    private void MyFunc5 (int param)
    {
        a = param;
    }

    private void MyFunc6(string param)
    {
        c = param;
    }

    private void Foo()
    {

    }

}

// izveidot string funckiju kas atgriez vērtību - c

// izveidot funkciju kas nomainītu c vērtību uz - suns - izmantojot parametru

/*

    private float MyFunc3()
    {
        return 0.0f;
    }
    private string MyFunc3()
    {
        return "sum string";
    }
    private bool MyFunc3()
    {
        return true;
    } 

*/

/*
-izveidot 2 fukcijas -(void) "Foo"  un 
    (int) "Bar" (int)
-Fucija "Bar" izdara saskaitisanu ar parametru 
    un to atgriez - saskaita ar 3
-pielikt pie pogas "Foo" funkciju kas 
    izsauc "Bar" funkciju
*/