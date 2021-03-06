using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_3___FlashCards
{
    public partial class Form1 : Form
    {
        //Attributes
        private string SFileName;//Short Name for the chosen flie
        private string FileName;// Name of the chosen file 
        private int DC = 0; // number of decks (Deck Count)
        private int Index = 0; //  Index of the deck
        Deck[] Decks;// Array of decks 
        private int FileI;// Index of the chosen file (File Index)
        private int CardI;// Index of the Card in the deck (Card Index)

        // Constructor
        public Form1()
        {
            InitializeComponent();
            Decks = new Deck[100];
        }

        /// <summary>
        ///  To browse the file for the flashcard decks 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browsebutton_Click(object sender, EventArgs e)
        {
            loadbutton.Enabled = true;
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
            FileName = openFileDialog1.FileName;
            SFileName = openFileDialog1.SafeFileName;
            loadbutton.Visible = true;
        }
        /// <summary>
        /// To load the chosen file into the program / load the deck 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadbutton_Click(object sender, EventArgs e)
        {
            Decks[DC] = new Deck(FileName);
            AddDeck();
            Index = DC;
            DC += 1;
            progressBar1.Visible = true;
            ProgessBarLabel.Visible = true;
            CardI = Decks[Index].GetCardIndex();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Decks[Index].GetDeckLength();
            UpdateProgress();
            loadbutton.Visible = false;
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileI = FilePicker.SelectedIndex;

            CardI = Decks[Index].GetCardIndex();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Decks[Index].GetDeckLength();
            UpdateProgress();
        }


        /// <summary>
        /// To add the Deck to the FilePicker
        /// </summary>
        public void AddDeck()
        {
            FilePicker.Items.Add(SFileName);
        }

        /// <summary>
        /// To flip the card to see the info on the other side of the card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flipbutton_Click(object sender, EventArgs e)
        {
            if (DC == 0)
            {
                MessageBox.Show("Please load in the file first!");
            }
            else
            {
                Decks[Index].GetCard().Flip();
                richTextBox1.Text = Decks[Index].GetCard().GetCardText();

            }
            
        }

        /// <summary>
        /// To go on the he next card in the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextbutton_Click(object sender, EventArgs e)
        {
            if (DC == 0)
            {
                MessageBox.Show("Please load in the file first!");
            }
            else
            {
                Decks[Index].NextCard();
                richTextBox1.Text = Decks[Index].GetCard().GetCardText();
                CardI = Decks[Index].GetCardIndex();
                UpdateProgress();

            }
        }
        /// <summary>
        /// To go back to the last card in the deck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevbutton_Click(object sender, EventArgs e)
        {
            if (DC == 0)
            {
                MessageBox.Show("Please load in the file first!");
            }
            else
            {
                Decks[Index].PreviousCard();
                richTextBox1.Text = Decks[Index].GetCard().GetCardText();
                CardI = Decks[Index].GetCardIndex();
                UpdateProgress();
            }

           
        }

        /// <summary>
        /// To choose a random card in the deck 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void randombutton_Click(object sender, EventArgs e)
        {
            if (DC == 0)
            {
                MessageBox.Show("Please load in the file first!");
            }
            else
            {
                Decks[Index].RandomCard();
                richTextBox1.Text = Decks[Index].GetCard().GetCardText();
                CardI = Decks[Index].GetCardIndex();
                UpdateProgress();
            }
        }

        /// <summary>
        /// To shuffle the cards in the deck 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shufflebutton_Click(object sender, EventArgs e)
        {
            if (DC == 0)
            {
                MessageBox.Show("Please load in the file first!");
            }
            else
            {
                Decks[Index].Shufflecards();
                richTextBox1.Text = Decks[Index].GetCard().GetCardText();
                CardI = 0;
                UpdateProgress();
            }
        }

        /// <summary>
        /// To change the font style and size in the card text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontButton_Click(object sender, EventArgs e)
        {
            if (DC == 0)
            {
                MessageBox.Show("Please load in the file first!");
            }
            else if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestButton_Click(object sender, EventArgs e)
        {
            if (DC == 0)
            {
                MessageBox.Show("Please load in the file first!");
            }
            else
            {
                Decks[Index].Resetdeck();
                TestModeButtons();
                if (Decks[Index].GetCard().isFlipped() == false)
                {
                    Decks[Index].GetCard().Flip();
                    richTextBox1.Text = Decks[Index].GetCard().GetCardText();
                }
                CardI = 0;
                UpdateProgress();
            }
        }
        /// <summary>
        /// To enter the answer (Word) of the definition 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterButton_Click(object sender, EventArgs e)
        {
            Decks[Index].GetCard().Flip();
            if (AnswerTextBox.Text == Decks[Index].GetCard().GetCardText())
            {
                Decks[Index].NextCard();
                Decks[Index].GetCard().Flip();
                richTextBox1.Text = Decks[Index].GetCard().GetCardText();
                AnswerTextBox.Text = "";
                CardI = Decks[Index].GetCardIndex();
                UpdateProgress();
            }
            else
            {
                MessageBox.Show("Wrong Answer");
            }
        }

        /// <summary>
        /// All the buttons for the test mode ( put into a function so it can be reusable)
        /// </summary>
        private void TestModeButtons()
        {
            AnswerLabel.Visible = true;
            AnswerTextBox.Visible = true;
            EnterButton.Visible = true;
            flipbutton.Visible = false;
            nextbutton.Visible = false;
            prevbutton.Visible = false;
            randombutton.Visible = false;
            shufflebutton.Visible = false;
            TestButton.Visible = false;
            BackButton.Visible = true;
        }

        /// <summary>
        /// To go back from the test mode to the normal mode 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            
            NormalModeButtons();
            if (Decks[Index].GetCard().isFlipped() == true)
            {
                Decks[Index].GetCard().Flip();
            }
            Decks[Index].Resetdeck();
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();
            CardI = 0;
            UpdateProgress();

        }
        /// <summary>
        ///  All the buttons for the Normal mode ( put into a function so it can be reusable)
        /// </summary>
        private void NormalModeButtons()
        {
            AnswerLabel.Visible = false;
            AnswerTextBox.Visible = false;
            EnterButton.Visible = false;
            flipbutton.Visible = true;
            nextbutton.Visible = true;
            prevbutton.Visible = true;
            randombutton.Visible = true;
            shufflebutton.Visible = true;
            TestButton.Visible = true;
        }
        /// <summary>
        /// To update the progress bar when the next or previous button is clicked 
        /// </summary>
        public void UpdateProgress()
        {
            ProgessBarLabel.Text = "Card " + (CardI + 1).ToString() + "/" + Decks[Index].GetDeckLength().ToString();
            progressBar1.Value = CardI + 1;
        }


    }
}
