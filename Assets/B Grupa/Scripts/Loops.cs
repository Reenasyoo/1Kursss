using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B_Grupa
{
    public class Loops : MonoBehaviour
    {
        // 0, 1, 2, 3, 4
        // 1, 2, 5, 7, 10
        public int[] intArray = {1, 2, 5, 7, 10 };
        int[] numbers1 = {190, 291, 145, 209, 280, 300};
        int[] numbers2 = {-9, -2, -7, -8, -4};
        
        private  void Start()
        {
            // WhileLoop();
            // print("-------");
            // DoWhileLoop();
            // ForLoop();
            // DoubleForLoop();
            // ArrayWork();
            Exercise(numbers1); // 300
            Exercise(numbers2); // -2
            Exercise(intArray); // 10
        }

        private void ArrayWork()
        {
            // intArray[0] = 6;
            // print(intArray[0]);


            for (int i = 0; i < intArray.Length; i++)
            {
                print(intArray[i]);
            }
        }

        private void WhileLoop()
        {
            int x = 0;
            
            while ( x < 10 )
            {
                print($"x : {x}");
                x++;
            }
        }

        private void DoWhileLoop()
        {
            int x = 0;
            do
            {
                print($"y : {x}");
                x++;
            } while ( x <= 5);
        }

        private void ForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                print($"i : {i}");
            }
            // int x;
            // for (x = 0; x < 5; x++)
            // {
            //     
            // }
        }

        private void DoubleForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    print($"I : {i} / J : {j}");
                }
            }
        }

        private void Uzd2()
        {
            int x = 1;
            int sum = 0;

            while (x <= 10)
            {
                sum = sum + x;
            }
            print(sum);

            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            print(sum);
            
        }

        private void Exercise(int[] numbers)
        {
            int biggestNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (biggestNumber < numbers[i])
                {
                    biggestNumber = numbers[i];
                }
            }
            
            print(biggestNumber);
        }
    }
}