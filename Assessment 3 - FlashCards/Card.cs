using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_3___FlashCards
{
    class Card
    {
        //Attributes
        private string Word; // The Word of the flashcards
        private string Def; //  The Definition of the flascards
        private bool Flipped; // To see if the flashcard is flipped or not 

        //constructor of card class that consists of the word and definition of the flashcard
        public Card(String Word, string Def)
        {
            this.Word = Word;
            this.Def = Def;
            Flipped = false;
        }

        //Methods

        /// <summary>
        /// A method to see what it is supposed to be return when the card is flipped or unflipped
        /// </summary>
        /// <returns>returns Word if not flipped and definition if flipped</returns>
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

        /// <summary>
        /// A method to flip the cards 
        /// </summary>
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
        //Accessors 

        /// <summary>
        /// To see if the card is flipeed 
        /// </summary>
        /// <returns>if Flipped is true or false</returns>
        public bool isFlipped()
        {
            return Flipped;
        }
        /// <summary>
        /// To Get the word of the card so it can be used in another class
        /// </summary>
        /// <returns> return the word on the card</returns>
        public string GetWord()
        {
            return Word;
        }
    }

}
