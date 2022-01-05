

using System;

namespace ConsoleApp6
{
    public class People
    {
        // fields
        private int _age;
        // automatic properties
        public string Name { get; set; } // prop - tab // properties
        // properties
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value >= 18 ? value : 0;
            }
        }

        // contructor with para
        public People(string name, int age) // ctor - tab
        {
            Name = name;
            Age = age;
        }
        // default constructor
        public People()
        {
            
        }
        
        public void Eat()
        {
            Console.WriteLine("I'am eating");
        }

        public int NumberOfLeg()
        {
            return 2;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        // destructor
        ~People()
        {
            
        }
    }
}