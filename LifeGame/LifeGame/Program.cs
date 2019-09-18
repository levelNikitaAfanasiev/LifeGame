using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LifeGame
{
    
    class Program
    {
        static void Main(string[] args)
        {
           
         
            Point point = new Point();
            point.Print();
            Console.WriteLine("Press any button to start a program");
            Console.ReadLine();
            while (true)
            {
                point.Start();         
            }
           
        }
       
    }
}
