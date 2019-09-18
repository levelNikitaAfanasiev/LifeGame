using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LifeGame
{
    class Point
    {
        private static int ilength = 20, jlenght = 50;
        Life[,] life = new Life[ilength, jlenght];
        public Point()
        {
           
            GenerateField();
        }
        private void GenerateField()
        {
            Random generator = new Random();
            int number;
            for (int i = 0; i < ilength; i++)
            {
                for (int j = 0; j < jlenght; j++)
                {
                    life[i, j] = new Life();
                    number = generator.Next(6);
                    life[i, j].IsAlive = ((number == 0) ? true : false);
                }
            }
        }
        public void Print()
        {
            Console.Clear();
            for (int i = 0; i < ilength; i++)
            {
                for (int j = 0; j < jlenght; j++)
                {
                    if (life[i, j].IsAlive == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(life[i, j].s);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(life[i, j].s);
                    }
                }
                Console.WriteLine();
            }
        }
        private void Check()
        {
            int LifePoints;
            for (int i = 0; i < ilength; i++)
            {
                for (int j = 0; j < jlenght; j++)
                {
                    LifePoints = 0;
                    Checker(i,j,ref LifePoints);
                    if (life[i, j].IsAlive)
                    {
                        if (LifePoints < 2 || LifePoints > 3)
                            life[i, j].IsAlive = false;


                    }
                    else
                    {
                         if (LifePoints == 3)
                            life[i, j].IsAlive = true;
                    }

                }
            }
          
        }
        private void Checker(int i, int j, ref int LifePoints)
        {
            for (int k = i - 1; k < i + 2; k++)
            {
                for (int z = j - 1; z < j + 2; z++)
                {
                    if (!((k < 0 || z < 0) || (k >= ilength || z >= jlenght)))
                    {
                        if (life[k, z].IsAlive == true) LifePoints++;
                    }
                }
            }
        }
        public void Start()
        {
            Check();
            Print();
            Thread.Sleep(500);
        }
       
    }
}
