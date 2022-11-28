using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMethodApp
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public static int Subtract(int num1, int num2)
        {
            int dif = num1 - num2;
            return dif;

        }

        public static int Div(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        public static int Multiply(int num1,int num2)
        {
            int result = num1 * num2;
            return result;

        }

        //params excerise below

        public static void AddWithParam(params int[] numbers) //we're making an array with [] and numbers is the parameter for our array
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum = sum + item;
            }
            Console.WriteLine(sum);
        }   

              public static void MadLib()
        {
            Console.WriteLine("Please type in an animal name: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a shape: ");
            string shape = Console.ReadLine();

            //string interpolation

            Console.WriteLine($"My {animal} is {color} \n" +
             $"and their favorite fruit is {fruit} \n" +
             $"because it is shaped like a {shape}");
        }
    }

}
