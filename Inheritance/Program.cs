using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            var myBird = new Bird()
            {
                Name = "Sparrow",
                Lifespan = 3,
                Legs = 2,
                Diet = "omnivorous",
                CanFly = true,
                WingColor = "brown",
                WillMigrate = true,
                BeakLength = 1.5
            };
            
            Console.WriteLine($"The {myBird.Name} is a {(myBird.CanFly == true ? "flying" : "flightless")} bird that " +
                $"{(myBird.WillMigrate == true ? "migrates" : "does not migrate")} and has a lifespan of {myBird.Lifespan} " +
                $"years.\nAll birds have {myBird.Legs} legs, so the {myBird.Name} isn't any different.\nThe {myBird.Name} " +
                $"commonly has a {myBird.WingColor} wing color, and is known to be {myBird.Diet}.\nIts beak length can " +
                $"grow to {myBird.BeakLength} cm.");

            Console.WriteLine("\n");

            var myReptile = new Reptile()
            {
                Name = "Viper",
                Lifespan = 20,
                Legs = 0,
                Diet = "carnivorous",
                Length = 10,
                IsConstrictor = false,
                IsVenomous = true,
                IsColdblooded = true
            };

            Console.WriteLine($"The {myReptile.Name} is a reptile, which is a {(myReptile.IsColdblooded == true ? "cold-blooded" : "warm-blooded")} animal." +
                $"\nIt has {myReptile.Legs} legs, has a lifespan of up to {myReptile.Lifespan} years, and is known to be {myReptile.Diet}." +
                $"\nThe {myReptile.Name} can grow to a length of {myReptile.Length} feet, is " +
                $"{(myReptile.IsConstrictor == true ? "a constrictor" : "not a constrictor")}, and is " +
                $"{(myReptile.IsVenomous == true ? "venomous" : "not venomous")}.");
        }
    }
}
