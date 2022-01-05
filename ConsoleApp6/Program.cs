using System;

namespace ConsoleApp6
{
    public class Program
    {
        static void Main(string[] args)
        {
            // object
            People Tuan = new People("Hoang Anh Tuan", 20);
            Console.WriteLine($"My Name is {Tuan.Name} and {Tuan.Age}");
            // method return void 
            Tuan.Eat();
            // method return int
            int numberOfLeg = Tuan.NumberOfLeg();
            Console.WriteLine($"Number of Leg {numberOfLeg}");
            // method with input and return type
            int value = Tuan.Add(2, 4);
            Console.WriteLine($"Sum {value}");
            
            // object
            People Tri = new People();
            Tri.Name = "Tri";
            Tri.Age = 20;
            Console.WriteLine($"My Name is {Tri.Name} and {Tri.Age}");

            int age = 3;

            // Cha cha = new Cha();
            // cha.Age;
        }
    }
}
