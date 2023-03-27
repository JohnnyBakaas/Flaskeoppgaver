namespace Flaskeoppgaver.Model
{
    internal class SortingOfBottles
    {
        public int WantedVolume;
        public Bottle BOne;
        public Bottle BTwo;

        public SortingOfBottles(int wantedVolum, Bottle bottleOne, Bottle bottleTwo)
        {
            WantedVolume = wantedVolum;
            BOne = bottleOne;
            BTwo = bottleTwo;
        }

        public void Bogosort()
        {
            Random rnd = new Random();

            int iterations = 0;

            bool checkIfOneIsCorect = true;

            while (checkIfOneIsCorect)
            {

                iterations++;
                int kake = rnd.Next(6);

                if (kake == 0)
                {
                    BOne.FillFromTap();
                }
                else if (kake == 1)
                {
                    BTwo.FillFromTap();
                }
                else if (kake == 2)
                {
                    BOne.TransfereContentTo(BTwo);
                }
                else if (kake == 3)
                {
                    BTwo.TransfereContentTo(BOne);
                }
                else if (kake == 4)
                {
                    BOne.EmptyBotle();
                }
                else
                {
                    BTwo.EmptyBotle();
                }

                if (BOne.GetVolume() == WantedVolume || BTwo.GetVolume() == WantedVolume)
                {
                    checkIfOneIsCorect = false;
                }
                if (iterations % 10000 == 0) { Console.WriteLine(iterations); }
            }
            Console.WriteLine("Long live THE BOGO");
            Console.WriteLine("Wanted: " + WantedVolume + ". BOGO One: " + BOne.GetVolume());
            Console.WriteLine("Wanted: " + WantedVolume + ". BOGO Two: " + BTwo.GetVolume());

            Console.WriteLine("BOGO gjorde det på " + iterations + " ganger");
        }
    }
}
