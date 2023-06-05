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
    }
}
