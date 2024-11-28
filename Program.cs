using System;

namespace Assignment3
{
    //Encap. city class 
    class City
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }




    // Inherit. Vehicle class that gets inherited by a tractor class
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("The vehicle started to move...");
        }
        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped moving.");
        }
    }

    class Tractor : Vehicle
    {
        public void Plow()
        {
            Console.WriteLine("The tractor is plowing forward.");
        }
    }

    // Poly.
    class Dog
    {
        public virtual void Bark()
        {
            Console.WriteLine("Woof, Awoof, Ruff!");
        }
    }

    class Wolf : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("AWOOOOOOO, WOOOOOO!");
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exhibit E:");
            Encapsulation();

            Console.WriteLine("\nExhibit I:");
            Inheritance();

            Console.WriteLine("\nExhibit P:");
            Polymorphism();
        } 

        static void Encapsulation()
        {
            City city = new City();
            city.SetName("Milwaukee");
            Console.WriteLine($"The city's name is... : {city.GetName()}");
        }

        static void Inheritance()
        {
            Tractor tractor = new Tractor();
            tractor.Start();
            tractor.Stop();
            tractor.Plow();
        }

        static void Polymorphism()
        {
            Dog Balto;

            Balto = new Dog();
            Balto.Bark();
            //Balto's bark will now be a howl.
            Balto = new Wolf();
            Balto.Bark();
        }
    }
}
