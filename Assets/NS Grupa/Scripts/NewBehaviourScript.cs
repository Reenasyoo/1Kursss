using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // accesor type / variable,value type / variable name / value
    private int a = 0; // veseli skaitli
    private float b = 0.0f; // decimalskaitli
    private string c = "a"; // teksts
    private bool d = false; // true false

    // accesor type / return type / function name / fucntion parameter declaration / function body
    private void MyFunc (int param, float param2) { } // function declaration
    //      parameter type / parameter name

    // + - * / < > ()

    public int ab = 0;

    public int strenght = 0;
    public int strenghtModifier = 0;
    public string outputText;
    public InputField inputText;
    public Text textComponent;
    public Text strenghtText;

    private void Start()
    {

        // // float aab = a / ab;
        // Debug.Log ( "AAB : " + aab.ToString("f2"));

        // print("A :" + MyFunc3());
        // print("AB : " + ab);
        // MyFunc5(ab); // a = ab / a = param
        // print("New a :" + a);
        // MyFunc6("Suns");
        
        // // MyFunc2(); // function call
        DoubleForLoop();
    }

    private void Statements()
    {
        int a = 3;
        int b = 2;
        int c = 1;

        // || - or sign
        // && - and sign

        if( a > b && b == 3)
        {
            print("equal");
        }
        else if( c > b || a == 3)
        {
            print("not");
        }
        else
        {
            print("uff");
        }
    }

    private void SwitchStatement()
    {
        int x = 3425;

        switch(x)
        {
            case 0:
                print("equal");
                break;
            case 1:
                print("not");
                break;
            case 2:
                print("uff");
                break;
            default :
                print("def");
                break;
        }
    }

    public void UpdateText(Text textComp, string text)
    {
        textComp.text = text;
    }

    public void SaveText()
    {
        strenghtModifier = int.Parse(inputText.text);
        outputText = "My name is : " + inputText.text;

        UpdateText(textComponent, outputText);
    }

    public void AddStrenght()
    {
        // strenght = strenght +2;
        // strenght += 1;
        // strenght =+ 1; 
        // strenght++; // +1
        strenght += strenghtModifier;
        UpdateText(strenghtText, strenght.ToString());
    }

    public void RemoveStrenght()
    {
        if( strenght > 0 )
        {
            strenght -= strenghtModifier;
        }
        // strenght--;
        UpdateText(strenghtText, strenght.ToString());
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



    private void uzd1()
    {
        int a = 1;
        int b = 2;

        if( a == b)
        {
            print("vienadi");
        }
        else
        {
            print("nav vienadi");
        }
    }

    private void uzd2()
    {
        int a = -2;

        if( a > 0)
        {
            print("pozitivs");
        }
        else
        {
            print("negativs");
        }
    }

    private void uzd3()
    {
        int a = 3;
        int reminder = a % 2;
        if( reminder == 0)
        {
            print("para");
        }
        else
        {
            print("nepara");
        }
    }

    private void uzd4()
    {
        int a = 2;
        int b = 4;
        int c = 3;

        if( a > b)
        {
            if(a > c)
            {
                print("a");
            }
        }
        else if( b > c)
        {
            print("b");
        }
        else
        {
            print("c");
        }


        if( a > b && a > c)
        {
            print("a");
        }
        else if( b > c)
        {
            print("b");
        }
        else
        {
            print("c");
        }
    }

    private void WhileLoop()
    {
        int x = 0;
        while( x < 5)
        {
            x++;
            print("a : " + x);
        }
    }

    private void DoWhileLoop()
    {
        int x = 0;
        do
        {
            print("a : " + x);
           x++;
        } while (x < 5);
    }

    private void ForLoop()
    {
        for(int i = 0; i < 5; i++)
        {
            print("a : " + i);
        }
    }

    private void DoubleForLoop()
    {
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                // print("i : " + i + ",  j : " + j);
                print($" i : {i} , j : {j}");
            }
        }
    }

    private void Uzd5()
    {
        int x = 0;
        while (x < 10)
        {
            print("man garso ramen");
            x++;
        }
        
        for (int i = 0; i < 10; i++)
        {
            print("man garso ramen");
        }
    }

    private void Uzd6()
    {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum = sum + i;
        }
        print(sum);
    }
}

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