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
}
