using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace OOP_D4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[10] { new Cow(), new Bat(), new Pinguin(), new Duck(), new Cow(), new Bat(), new Pinguin(), new Duck(), new Pinguin(), new Bat() };

            foreach (Animal animal in animals)
            {
                if (animal is IFlyable)
                {
                    (animal as IFlyable).Fly();

                }
            }

            int[] myArray = new int[3];

            try
            {
                myArray[10] = 7;
            }
            catch (Exception)
            {
                Console.WriteLine("Index out of range");
            }

            try
            {
                myArray[10] = 7;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                string txt = File.ReadAllText("Hej.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            finally
            {
                Console.WriteLine("Finally this happens");
            }

            MathLib.Math math = new MathLib.Math();

            math.Addition();
            math.Subraction();
            math.Division();

            Console.ReadLine();
        }
    }
}
