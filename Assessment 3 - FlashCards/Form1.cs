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
        private string FileName, SFileName;
        private int DC = 0;
        private Deck[] Decks;
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
            Decks[DC] = new Deck(SFileName);
            AddDeck();
            DC += 1;
        }

        private void FilePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileI = FilePicker.SelectedIndex;
            richTextBox1.Text = Decks[FileI].GetCard(0).GetWord();

        }

        public void AddDeck()
        {
            FilePicker.Items.Add(SFileName);
        }



    }
}
