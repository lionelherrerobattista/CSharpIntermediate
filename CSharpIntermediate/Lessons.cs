using Amazon;

namespace CSharpIntermediate
{
    internal partial class Program
    {
        public class Lessons
        {
            public static void LessonOne()
            {
                var customer = new Customer();
            }

            public static void LessonTwo() 
            {
                var car = new Car("XYZ1234");
            }
        }
    }
}
