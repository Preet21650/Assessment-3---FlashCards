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
        private string SFileName;
        private string FileName;
        private int DC = 0;
        private int Index = 0;
        Deck[] Decks;
        private int FileI,CardI,DL;
        public Form1()
        {
            InitializeComponent();
            Decks = new Deck[100];
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            loadbutton.Enabled = true;
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
            FileName = openFileDialog1.FileName;
            SFileName = openFileDialog1.SafeFileName;
            loadbutton.Visible = true;
        }
        private void FilePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileI = FilePicker.SelectedIndex;
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();
            CardI = Decks[Index].GetCardIndex();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = Decks[Index].GetDeckLength();
            UpdateProgress();
        }

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

        }


        public void AddDeck()
        {
            FilePicker.Items.Add(SFileName);
        }

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
            }
        }
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
            }
        }

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
            }
        }
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            NormalModeButtons();
            Decks[Index].Resetdeck();
            if (Decks[Index].GetCard().isFlipped() == true)
            {
                Decks[Index].GetCard().Flip();
                richTextBox1.Text = Decks[Index].GetCard().GetCardText();
            }

        }

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
        public void UpdateProgress()
        {
            ProgessBarLabel.Text = "Card " + (CardI + 1).ToString() + "/" + Decks[Index].GetDeckLength().ToString();
            progressBar1.Value = CardI + 1;
        }


    }
}
