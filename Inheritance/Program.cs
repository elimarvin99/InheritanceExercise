using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common               //Done


            // Create a class Bird                                                //Done
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile                                            //Done
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values                                       //Done
             */
            var birdie = new Bird() { Age = 1, CanFly = true, FeatherColor = "blue", HasTail = false, Legs = 2, Sex = "male", Speed = 10, Wingspan = 2 };
            Console.WriteLine($"My name is Birdie, I am {birdie.Age} years old. I can fly at a speed of {birdie.Speed} mph. My wingspan is {birdie.Wingspan} feet and i have beautiful {birdie.FeatherColor} feathers");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var snake = new Reptile();
            snake.ColdBlooded = true;
            snake.LaysEggs = true;
            snake.ScalesColor = "green";
            snake.Sex = "female";
            snake.Type = "Python";

            Console.WriteLine($"I am a nasty {snake.ScalesColor} {snake.Type}. I am a {snake.Sex} and therefore it's {snake.LaysEggs} that I lay eggs");

        }
    }
}
