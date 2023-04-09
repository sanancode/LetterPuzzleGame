namespace LetterPuzzleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to Letter Puzzle Game");

            config.createArray(); //oyunu yaradir
            util.showTable(); //evvelceden bos olan oyunu ilkin olaraq gosterir
            run(); //esas proses ve oyun basladi
        }

        public static void run()
        {
            int check = 0;
            do
            {
                check = 0;
                int first = util.getNumber("\nPlease select the first place: ");
                int second = util.getNumber("\nPlease select the first place: ");

                if (first <= config.configArray.Count && second <= config.configArray.Count)
                { //her hansi biri oyunun olcusunden boyukdurmu
                    if (config.configArray[first - 1].isStatus() == true && config.configArray[second - 1].isStatus() == true)
                    { //secilen reqemde her hansi biri evvelceden secilibmi

                        //secilenleri gostermek ucun
                        config.configArray[first - 1].setStatus(false);
                        config.configArray[second - 1].setStatus(false);
                        util.showTable();

                        //secilenlere uygun neticeni teyin etmek ucun
                        String firstLetter = config.configArray[first - 1].getPlace();
                        String secondLetter = config.configArray[second - 1].getPlace();
                        if (firstLetter.Equals(secondLetter))
                        {
                            config.configArray[first - 1].setStatus(false);
                            config.configArray[second - 1].setStatus(false);
                            Console.WriteLine("Bravo!!! You found the letters");
                        }
                        else
                        {
                            config.configArray[first - 1].setStatus(true);
                            config.configArray[second - 1].setStatus(true);
                            Console.WriteLine("Ups! You couldn't find(");
                        }

                        //oyun bitdi mi? (boyuk do while ucun)
                        for (int i = 0; i < config.configArray.Count; i++)
                        {
                            if (config.configArray[i].isStatus() == false)
                            {
                                check++;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nOne of the Letter you have chosen has been already found...Try other one");
                    }
                }
                else
                {
                    Console.WriteLine("\nYou can not select number over the size of game places...Try again");
                }
            } while (check != config.configArray.Count);

            Console.WriteLine("\n\tGame ended...");
        }
    }
}