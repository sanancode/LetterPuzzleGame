using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LetterPuzzleGame
{
    internal class Game
    {
        //oyunun herf ve herflerin tapilib tapilmamasini kontrol etmek ucun

        private string place;
        private bool status;
        //status true-dursa bosdur

        public Game(string place, bool status)
        {
            this.place = place;
            this.status = status;
        }

        public string getPlace()
        {
            return this.place;
        }

        public void setPlace(string place)
        {
            this.place = place;
        }

        public bool isStatus()
        {
            return status;
        }

        public void setStatus(bool status)
        {
            this.status = status;
        }
    }
}
