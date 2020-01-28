using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuffle_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnShuffle_Click(object sender, EventArgs e)
        {
            const int CARDSPERLINE = 13;
            int j;
            int cardIndex;
            int deckSize;
            int passes;
            string buff;
            string temp;
            clsCardDeck myDeck = new clsCardDeck();
            passes = myDeck.ShuffleDeck();
            lblPassCounter.Text = "It took" + passes.ToString() + "passes to shuffle the deck";
            deckSize = myDeck.DeckSize;
            for (cardIndex = 1; cardIndex < deckSize + 1;)
            {
                buff = "";
                for (j = 0; j < CARDSPERLINE; j++)

                {
                    temp = myDeck.getOneCard(cardIndex);
                    if (temp.Length == 0)
                    {
                        MessageBox.Show("Error reading deck.", "Processing Error");
                        return;
                    }
                    buff += temp + "";
                    cardIndex++;
                }
                stDeck.Items.Add(buff);
            }
            stDeck.Items.Add("");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            stDeck.Items.Clear();
        }
    }
}
