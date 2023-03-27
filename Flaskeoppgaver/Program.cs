using Flaskeoppgaver.Model;

namespace Flaskeoppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bottle BottleOne = new(5);
            Bottle BottleTwo = new(3);
            SortingOfBottles SortingAlgo = new(4, BottleOne, BottleTwo);
            SortingAlgo.Bogosort();
        }
    }
}