namespace GenericsExercise
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personAdress = Console
                .ReadLine()
                .Split();
            string personName = personAdress[0] + " " + personAdress[1];
            string adress = personAdress[2];
            Tuple<string, string> personAdressTuple = new Tuple<string, string>(personName, adress);

            string[] personBeer = Console
                .ReadLine()
                .Split();
            string person = personBeer[0];
            int numBeer = int.Parse(personBeer[1]);
            Tuple<string, int> personBeerTuple = new Tuple<string, int>(person, numBeer);

            string[] intDouble = Console
                .ReadLine()
                .Split();
            int numInt = int.Parse(intDouble[0]);
            double numDouble = double.Parse(intDouble[1]);
            Tuple<int, double> intDoubleTuple = new Tuple<int, double>(numInt, numDouble);

            Console.WriteLine(personAdressTuple.GetInfo());
            Console.WriteLine(personBeerTuple.GetInfo());
            Console.WriteLine(intDoubleTuple.GetInfo());
        }
    }
}
