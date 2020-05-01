namespace GenericsExercise
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int text = int.Parse(Console.ReadLine());
                box.Add(text);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(indexes);
            string result = box.ToString().TrimEnd();
            Console.WriteLine(result);
        }
    }
}
