using System;

namespace CSharpIntermediate
{
    public class Lessons
    {
        public static void LessonOne()
        {
            //var person = new Person();
            //person.Name = "John";
            var person = Person.Parse("John");
            person.Introduce("Test");
        }

        public static void LessonTwo()
        {
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }

        public static void LessonThree()
        {
            // UsePoints();
            // UseParams();
            UseOut();
        }

        public static void UseOut()
        {
            try
            {
                var num = int.Parse("abc");

            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        public static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        public static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                // use of overloads
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
