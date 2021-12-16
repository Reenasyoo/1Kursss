using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B_Grupa
{
    public class Factory : MonoBehaviour
    {
        [SerializeField]
        public List<Car> cars = new List<Car>();

        void Start()
        {
            //Car temp = new Car("New car");
            //temp.PrintName();
            //temp.Drive();
            
            //Car temp2 = new Car("New caasdaar");
            //temp2.PrintName();

            Bembis zurka = new Bembis("zurciks");
            cars.Add(zurka);
            zurka.PrintName();
            zurka.Drift();
            zurka.GetGas();

            Audi cigars = new Audi("cigarcik");
            cars.Add(cigars);
            cigars.PrintName();
            cigars.Drag();
            cigars.Drive();

            Cilveks human = new Cilveks();
            human.PrintSmth("hello");

            Skolotajs gala = new Skolotajs();
            gala.SetAge(30);
            gala.PrintSmth("You should listen");

            Pastnieks cuvaks = new Pastnieks();
            cuvaks.SetAge(40);
            cuvaks.PrintSmth("Special Delivery");
            cuvaks.PrintSmth("Hey mister postmaan, heeeee");


        }
    }
}


public class Cilveks
{
    public int humanAge = 0;
    
    public void PrintSmth(string smth)
    {
        MonoBehaviour.print(smth);
    }

    public void SetAge(int age)
    {
        humanAge = age;
    }
}

public class Skolotajs : Cilveks
{
    
}

public class Pastnieks : Cilveks
{
    
}