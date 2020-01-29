using System;

namespace classes.Models
{
    class Cat
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName 
        { 
            get
            {
                return FirstName + " " + LastName;
            } 
        }
        public int Lives { get; private set; }
        private bool Happy { get; set;}
        private int Pets { get; set;}
        private int Tolerance { get; set; }

        public void Pet()
        {
            Pets++;
            Happy = Pets < Tolerance;
            if (Happy)
            {
                Console.WriteLine("meow");
            }
            else
            {
                Console.WriteLine("Hiss");
            }
        }
        public void Catnip()
        {
            Pets = 0;
        }
        public void Feed()
        {
            Happy = true;
            Console.WriteLine("mmhmmm im happy");
        }
        public void Feed(string food)
        {
            if (food == "catfood")
            {
                Console.WriteLine("mmmm");
                return;
            }
            Console.WriteLine("Barf");
        }
        public Cat(string firstName, string lastName, int tolerance)
        {
            FirstName = firstName;
            LastName = lastName;
            Tolerance = tolerance;
            Lives = 9;
            Happy = true;
        }
    }
}