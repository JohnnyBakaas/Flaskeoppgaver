using Flaskeoppgaver.Model;

namespace Flaskeoppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Legg til Bogosort!");

            Bottle BottleOne = new(5);
            Bottle BottleTwo = new(3);
            SortingOfBottles SortingAlgo = new(2, BottleOne, BottleTwo);
            SortingAlgo.Bogosort();
        }
    }
}