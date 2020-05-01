namespace GenericsExercise
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                double number = double.Parse(Console.ReadLine());
                box.Add(number);
            }

            double numberToCompare = double.Parse(Console.ReadLine());
            box.Compare(numberToCompare);
            
            int result = box.GreaterCounter;
            Console.WriteLine(result);
        }
    }
}
