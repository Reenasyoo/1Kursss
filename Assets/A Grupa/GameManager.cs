using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster
    {
        public int health = 10;
        public int attackStrenght = 2;
    }

public class GameManager : MonoBehaviour
{   
    public Text outputText;
    public Text batHealthText;

    public int health = 0;
    public int attackStrenght = 2;

    public Monster bat = new Monster();

    void Start()
    {
        health = 10;
        RefreshText();
        RefreshBatText();
    }

    public void UpHealth()
    {
        health++;
        RefreshText();
    }

    public int DownHealth(int tempHealth)
    {
        if( tempHealth <= 0 )
        {
            tempHealth = 0;
        }
        return tempHealth;
    }

    public void RefreshText()
    {
        outputText.text = "Player health: " + health.ToString();
    }

    public void RefreshBatText()
    {
        batHealthText.text = "Bat health: " + bat.health.ToString();
    }

    public void Attack()
    {
        int attack = Random.Range(0, attackStrenght +1);
        bat.health -= attack;
        bat.health = DownHealth(bat.health);

        GetDamage();
        RefreshText();
        RefreshBatText();

        print(attack);
    }

    public void GetDamage()
    {
        int attack = Random.Range(0, bat.attackStrenght +1);
        health -= attack;
        health = DownHealth(health);
        print("Damage : " + attack);
    }
}


/*
    void Test()
    {
        int a = 0;
        int b = 1;
        int c = 2;

        bool isTrue = true;

        if(isTrue)
        {

        }

        if(isTrue == false)
        {

        }

        if( a == b || b == c) // &&
        {
            print("i");
        }
        else if( a > b)
        {
            print("t");
        }
        else if( a < b)
        {
            print("d");
        }
        else
        {
            print("e");
        }
    }




    void Func1()
    {
        int a = 1;
        int b = 2;

        if( a == b)
        {
            print ("ir vienadi");
        }
        else
        {
            print ("nav vienadi");
        }
        
    }

    void Func2()
    {
        int a = 1;

        if(a >= 0)
        {
            print("ir pozitivs");
        }
        else
        {
            print("negativs");
        }
    }

    void Func3()
    {
        int a = 1;
        int rem = a % 2;
        if( 0 == rem )
        {
            print("para");
        }
        else
        {
            print("nepara");
        }

    }

    void func4()
    {
        int a = 1;
        int b = 3;
        int c = 2;

        if(a > b)
        {
            if( a > c )
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


        if(a > b && a > c)
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
*/
