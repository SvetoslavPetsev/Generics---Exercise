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
            string personName = $"{personAdress[0]} {personAdress[1]}";
            string adress = personAdress[2];
            string town = personAdress[3];

            var personAdressTree = new Threeuple<string, string, string>(personName, adress, town);

            string[] personBeer = Console
                .ReadLine()
                .Split();
            string person = personBeer[0];
            int numBeer = int.Parse(personBeer[1]);

            string isDrunk = !personBeer[2].Equals("drunk") ? "False" : "True";
            var personBeerThree = new Threeuple<string, int, string>(person, numBeer, isDrunk);

            string[] intDouble = Console
                .ReadLine()
                .Split();
            string name = intDouble[0];
            double balance = double.Parse(intDouble[1]);
            string bank = intDouble[2];
            var intDoubleThree = new Threeuple<string, double, string>(name, balance, bank);

            Console.WriteLine(personAdressTree.GetInfo());
            Console.WriteLine(personBeerThree.GetInfo());
            Console.WriteLine(intDoubleThree.GetInfo());
        }
    }
}
