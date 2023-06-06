namespace CSharpIntermediate
{
    public class Calculator
    {
        public int Add(params int[] numbers) // params keyword for adding n amount of params
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
