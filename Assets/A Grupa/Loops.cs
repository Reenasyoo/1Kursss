using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int[] intArray = { 1, 3, 4, 7, 55, 420, 1337 };

    void Start()
    {
        // WhileLoop();
        // DoWhileLoop();
        // ForLoop();
        // TwoForLoop();
        // ArrayCheck();
        // PrintArray();
        SwitchFunc();
    }


    private void ArrayCheck()
    {

        intArray[3] = 111;
        int  x = intArray[6];

        print($"X ir : {x}");
    }

    private void PrintArray()
    {
        print($"Array length : {intArray.Length}");

        for(int i = 0; i < intArray.Length; i++)
        {
            print($"X is : {intArray[i]}");
        }
    }

    private void WhileLoop()
    {
        int a = 0;
        while( a < 10)
        {   
            a++;
            print($"A is : { a } ");
            // print("A ir :" + a);
            // if(a == 5)
            // {
            //     print("A ir 5");
            //     break;
            // }
        }
         /*
        while()
        {

        }
    */
    }
   
    private void DoWhileLoop()
    {
        int a = 0;
        do
        {
            print($"A is : { a } ");
            a++;
        } while (a < 10);
    }

    private void ForLoop()
    {

        for(int i = 0; i < 10; i++)
        {
            print($"I is : { i } ");
        }

        // for(int i = 0; i < 10; i+=2)
        // {
        //     print($"I is : { i } ");
        // }

        // int i;
        // for(i = 0; i < 10; i++)
        // {
        //     print($"I is : { i } ");
        // }
    }

    private void TwoForLoop()
    {
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                print($"I is : { i }, J is : {j} ");
                WhileLoop();
            }
        }
    }


    private void SwitchFunc()
    {
        int x = 2;

        switch(x)
        {
            case 0:  // if ( x == 0)
                print(x);
                WhileLoop();
                break;
            case 1: // if( x == 1)
                print(x);
                ForLoop();
                break;
            default:
                print("def");
                break;
        }


    }
}
