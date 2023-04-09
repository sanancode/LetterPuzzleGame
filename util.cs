using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterPuzzleGame
{
    internal class util
    {
        public static void showTable()
        {
            //her bir secimden sonra herfleri ve oyunun taxtasii gosterir

            int row = 0;

            Console.WriteLine("");

            for (int i = 0; i < 3; i++)
            { //setir sayi
                Console.Write((i + 1) + ".  ");

                for (int j = 0; j < 4; j++)
                {  //sutun sayi
                    if (config.configArray[row].isStatus() == true)
                    { //eger xana tapilmayibsa
                        Console.Write("| |");
                        Console.Write("  ");
                        row++;
                    }
                    else
                    { //eger xana tapilibsa
                        Console.Write("|" + config.configArray[row].getPlace() + "|");
                        Console.Write("  ");
                        row++;
                    }
                }
                Console.WriteLine("");
            }
        }

        public static int getNumber(String title)
        {
            //istifadeciden reqem almaq ucun
            Console.WriteLine(title);
            return int.Parse(Console.ReadLine());
        }
    }
}
