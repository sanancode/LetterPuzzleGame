using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterPuzzleGame
{
    internal class config
    {
        public static List<Game> configArray = new List<Game>(); //oyundaki her bir xanani tutmaq ucun

        public static void createArray()
        { //oyundaki her bir xanada herfleri ve herflerin statusunu yaradir
            configArray.Add(new Game("B", true));
            configArray.Add(new Game("E", true));
            configArray.Add(new Game("F", true));
            configArray.Add(new Game("A", true));
            configArray.Add(new Game("C", true));
            configArray.Add(new Game("B", true));
            configArray.Add(new Game("C", true));
            configArray.Add(new Game("A", true));
            configArray.Add(new Game("D", true));
            configArray.Add(new Game("E", true));
            configArray.Add(new Game("D", true));
            configArray.Add(new Game("F", true));
        }
    }
}
