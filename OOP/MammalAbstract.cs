using System;

namespace OOP
{
    public abstract class MammalAbstract
    {
        public void TestNormalMethod()
        {
            Console.WriteLine("This is normal method");
        }
        // abstract method
        public abstract int NumberOfLeg();
    }
}