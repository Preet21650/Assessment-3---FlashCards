using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3___FlashCards
{
    class Deck
    {
        private string FileName;
        private Card[] Cards;

        public Deck(string FileName)
        {
            Cards = new Card[1000];
        }

        public void ShuffleCards()
        {

        }
    }
}
