using System;
using System.Security.Cryptography.X509Certificates;

namespace lab2_z1
{
    public class Program
    {
        static public int Colors(int num)
        {

            switch (num)
            {
                case 1:
                    Console.WriteLine("Червоний");
                    break;
                case 2:
                    Console.WriteLine("оранжевий");
                    break;
                case 3:
                    Console.WriteLine("жовтий");
                    break;
                case 4:
                    Console.WriteLine("зелений");
                    break;
                case 5:
                    Console.WriteLine("голубий");
                    break;
                case 6:
                    Console.WriteLine("синій");
                    break;
                case 7:
                    Console.WriteLine("фіолетовий");
                    break;
                default:
                    Console.WriteLine("Колір не існує");
                    break;
            }
            return num;

        }

        static void Main(string[] args)
        {


            Console.WriteLine("Введiть число");
            string inser = Console.ReadLine();
            int num = int.Parse(inser);
            Colors(num);
            Console.ReadLine();
        }
    }
}


