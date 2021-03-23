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
        private int FileI;
        public Form1()
        {
            InitializeComponent();
            Decks = new Deck[100];

        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
        

                openFileDialog1.ShowDialog();
                MessageBox.Show(openFileDialog1.FileName);
                FileName = openFileDialog1.FileName;
                SFileName = openFileDialog1.SafeFileName;
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            Decks[DC] = new Deck(FileName);
            AddDeck();
            Index = DC;
            DC += 1;
        }

        private void FilePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileI = FilePicker.SelectedIndex;
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();
        }

        public void AddDeck()
        {
            FilePicker.Items.Add(SFileName);
        }

        private void flipbutton_Click(object sender, EventArgs e)
        {
            Decks[Index].GetCard().Flip();
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            Decks[Index].NextCard();
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();

        }

        private void prevbutton_Click(object sender, EventArgs e)
        {
            Decks[Index].PreviousCard();
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();
        }

        private void randombutton_Click(object sender, EventArgs e)
        {
            Decks[Index].RandomCard();
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();
        }

        private void shufflebutton_Click(object sender, EventArgs e)
        {
            Decks[Index].Shufflecards();
            richTextBox1.Text = Decks[Index].GetCard().GetCardText();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
