using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Project_experimentation
{
    public partial class Form1 : Form
    {
        private Deck myDeck;
        //private TextBox cardDisplayTextBox;
        public Form1()
        {
            InitializeComponent();
            myDeck = new Deck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myDeck.Shuffle();
            cardDisplayTextBox.Text = "Deck shuffled!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Card dealtCard = myDeck.Deal();
                cardDisplayTextBox.Text = $"{dealtCard.Rank} of {dealtCard.Suit}";
            }
            catch (InvalidOperationException ex)
            {
                cardDisplayTextBox.Text = ex.Message;
            }
        }
        public class Card
        {
            public string Suit { get; }
            public string Rank { get; }

            public Card(string suit, string rank)
            {
                Suit = suit;
                Rank = rank;
            }
        }

        public class Deck
        {
            private List<Card> cards;
            private Random random;
            public Deck()
            {
                random = new Random();
                cards = new List<Card>();
                string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
                string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

                foreach (string suit in suits)
                {
                    foreach (string rank in ranks)
                    {
                        cards.Add(new Card(suit, rank));
                    }
                }
            }

            public void Shuffle()
            {
                int n = cards.Count();
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    Card value = cards[k];
                    cards[k] = cards[n];
                    cards[n] = value;
                }
            }

            public Card Deal()
            {
                if (cards.Count == 0)
                {
                    throw new InvalidOperationException("Cannot deal from an empty deck.");
                }
                Card topCard = cards[0];
                cards.RemoveAt(0);
                return topCard;
            }
        }






    }
}