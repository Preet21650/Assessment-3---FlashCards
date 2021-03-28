using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment_3___FlashCards
{
    class Deck
    {
        //Attributes
        private string FileName;// The Filename of the deck is loaded into the program
        private Card[] Cards; // array of cards in the deck
        private int TopOfDeck = 0; // top card in the deck
        private int length; // length of the deck

        //Constructor 
        public Deck(string FileName)
        {
            this.FileName = FileName;
            
            LoadCards();
        }

        // Methods

        /// <summary>
        /// A Method to load the file with the cards into the program 
        /// </summary>
        public void LoadCards()
        {
            StreamReader fileReader = new StreamReader(FileName);
            while ((fileReader.ReadLine()) != null)
            {
                length++;
            }


            fileReader = new StreamReader(FileName);
            string line = "";
             Cards = new Card[length];
            int count = 0;
            while ((line = fileReader.ReadLine()) != null)
            {
                string[] cells = line.Split(',');
                string  Word = cells[0];
                string Def = cells[1];
                Cards[count] = new Card(Word,Def);
                count++;

            }
        }

        /// <summary>
        /// A method to get the next card in the deck 
        /// </summary>
        public void NextCard()
        {
            TopOfDeck++;
            if (TopOfDeck >= Cards.Length)
            {
                TopOfDeck = 0;
            }
        }

        /// <summary>
        /// A method to get the previous card in the deck
        /// </summary>
        public void PreviousCard()
        {
            if(TopOfDeck <= 0)
            {
                TopOfDeck = Cards.Length;
            }
            TopOfDeck--;
        }

        /// <summary>
        /// A method the get a random card in the deck 
        /// </summary>
        public void RandomCard()
        {
            Random RandomCard = new Random();
            TopOfDeck = RandomCard.Next(0, Cards.Length - 1);

        }

        /// <summary>
        /// A method to shuffle up all the cards in the deck
        /// </summary>
        public void Shufflecards()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int n = rnd.Next(0, Cards.Length - 1);
                int r = rnd.Next(0, Cards.Length - 1);
                Card Temp = Cards[n];
                Cards[n] = Cards[r];
                Cards[r] = Temp;
            }
        }
        /// <summary>
        /// A method that resets the deck 
        /// </summary>
        public void Resetdeck()
        {
            TopOfDeck = 0;
        }

        //Accessors

        /// <summary>
        /// To get the card that is on top of the deck
        /// </summary>
        /// <returns>returns the card that is on top of the deck </returns>
        public Card GetCard()
        {
            return Cards[TopOfDeck];
        }

        /// <summary>
  
        /// <summary>
        /// To return the current card that is on top of the deck
        /// </summary>
        /// <returns> the card that is on top of the deck </returns>
        public int GetCardIndex()
        {
            return TopOfDeck;
        }

        /// <summary>
        /// to get the number of cards in the deck
        /// </summary>
        /// <returns> The number of cards in the deck</returns>
        public int GetDeckLength()
        {
            return length ;
        }
    }
}
