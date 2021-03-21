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
        private string FileName;
        private Card[] Cards;
        private int TopOfDeck;

        public Deck(string FileName)
        {
            Cards = new Card[1000];
            TopOfDeck = 0;
        }

        public void LoadCards()
        {
            int length = 0;
            StreamReader fileReader = new StreamReader(FileName);
            while ((fileReader.ReadLine()) != null)
            {
                length++;
            }


            fileReader = new StreamReader(FileName);
            string line = fileReader.ReadLine();
            Card[] cards = new Card[length - 1];
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
        public void NextCard()
        {
            TopOfDeck++;
            if (TopOfDeck >= Cards.Length)
            {
                TopOfDeck = 0;
            }
        }

        public void PreviousCard()
        {
            if(TopOfDeck <= 0)
            {
                TopOfDeck = Cards.Length;
            }
            TopOfDeck--;
        }

        public void RandomCard()
        {
            Random RandomCard = new Random();
            TopOfDeck = RandomCard.Next(0, Cards.Length - 1);

        }

        public void Shufflecards()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int z = rnd.Next(0, Cards.Length - 1);
                int r = rnd.Next(0, Cards.Length - 1);
                Card Temp = Cards[z];
                Cards[z] = Cards[r];
                Cards[r] = Temp;

            }

        }
        public Card GetCard( int i)
        {
            return Cards[TopOfDeck];

        }
    }
}
