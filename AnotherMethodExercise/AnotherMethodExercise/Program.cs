namespace AnotherMethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
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