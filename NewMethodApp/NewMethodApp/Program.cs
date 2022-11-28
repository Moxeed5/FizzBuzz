namespace NewMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Exercise 1 is below

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

            //Exercise 1 is above

            //Exercise 2 below

            // calling the method I defined in the Methods Class

            int Addanswer = Methods.Add(2, 3); //assigning the result of Add to the int var answer
            Console.WriteLine(Addanswer);      //answer has the result of add, so I want to print that in the console when I run the program

            //calling the subtract method

            int Subtractanswer = Methods.Subtract(30, 15);
            Console.WriteLine(Subtractanswer);

            //calling divide method

            int Divideanswer = Methods.Div(10, 2);
            Console.WriteLine(Divideanswer);

            //calling multiply method

            int Multiplyanswer = Methods.Multiply(10, 2);
            Console.WriteLine(Multiplyanswer);

            //params - we're using the method from the methods class called addwithparams. This method when called, will add all of the numbers 
            //that are in our array

            Methods.AddWithParam(5, 5, 5, 5, 5);
        }
    }
}