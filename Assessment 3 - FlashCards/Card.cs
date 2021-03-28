using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3___FlashCards
{
    class Card
    {
        private string Word;
        private string Def;
        private bool Flipped;

        public Card(String Word, string Def)
        {
            this.Word = Word;
            this.Def = Def;
            Flipped = false;
        }

        public string FlipCard()
        {
            if (Flipped == false)
            {
                return Word;
            }
            else 
            {
                return Def;
            }
        }

        public void Flip()
        {
            if (Flipped == true)
            {
                Flipped = false;
            }
            else
            {
                Flipped = true;
            }
        }
        public string GetCardText()
        {
            if (Flipped == false)
            {
                return Word;
            }
            else
            {
                return Def;
            }
            
        }
        public bool isFlipped()
        {
            return Flipped;
        }
        public string GetWord()
        {
            return Word;
        }
    }

}
