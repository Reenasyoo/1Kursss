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

    public void DownHealth()
    {
        health--;

        if( health <= 0 )
        {
            health = 0;
        }

        RefreshText();

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
        bat.health -= Random.Range(0, attackStrenght);
        GetDamage();
        RefreshText();
        RefreshBatText();
    }

    public void GetDamage()
    {
        health -= Random.Range(0, bat.attackStrenght);
    }


    void Test()
    {
        int a = 0;
        int b = 1;
        int c = 2;

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
}
