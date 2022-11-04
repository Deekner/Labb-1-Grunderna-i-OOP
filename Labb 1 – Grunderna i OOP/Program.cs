using System;

namespace Labb_1___Grunderna_i_OOP
{

    class Program
    {
        static void Main(string[] args)
        {

            //Namn: Dennis Ekner Klass: SUT22

            Circle sum5 = new Circle(5);
            sum5.GetArea();
            Console.WriteLine("Circle with radius 5: {0}", sum5.GetArea());

            Circle sum6 = new Circle(6);
            sum6.GetArea();
            Console.WriteLine("Circle with radius 6: {0}", sum6.GetArea());


        }
    }
}
