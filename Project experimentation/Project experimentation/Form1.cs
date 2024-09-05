using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Project_experimentation
{
    public partial class Form1 : Form // All variables that need to be accessed by any methods (i.e "public" variables) should be placed under here
    {
        private Deck myDeck; // Initialize deck variable
        private List<Card> playerHand = new List<Card>();
        private List<Card> dealerHand = new List<Card>();

        public Form1() // This is the start of the program, so all code that needs to happen upon launch should go here
        {
            InitializeComponent();
            myDeck = new Deck(); // Creates and fills the deck
        }

        private void Form1_Load(object sender, EventArgs e) // Ignore?
        {

        }

        private void button1_Click(object sender, EventArgs e) // Shuffle button function, name needs to be changed
        {
            myDeck.Shuffle();
            cardDisplayTextBox.Text = "Deck shuffled!";
        }

        private void button2_Click(object sender, EventArgs e) // Deal button (has since been deleted, it was the old deal button when I was testing it out)
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
        private void button3_Click(object sender, EventArgs e) // Reset deck button, initializes and fills a new deck with all 52 cards, name needs to be changed
        {
            myDeck = new Deck();
            cardDisplayTextBox.Text = "Deck reset!";
            dealerCard1TextBox.Text = "";
            dealerCard2TextBox.Text = "";
            playerCard1TextBox.Text = "";
            playerCard2TextBox.Text = "";
            playerCard3TextBox.Text = "";
            playerHandValueTextBox.Text = "";
            dealerHandValueTextBox.Text = "";
            playerHand.Clear();
            dealerHand.Clear();
        }
        public class Card // Card class to create card object that contains rank and suit.
        {
            public string Suit { get; }
            public string Rank { get; }

            public Card(string suit, string rank)
            {
                Suit = suit;
                Rank = rank;
            }
        }

        public class Deck // Deck class, creates and fills the deck, and contains functions such as shuffle and deal.
        {
            private List<Card> cards;
            private Random random;
            public Deck() // Constructor to intialize deck
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

            public void Shuffle() // Shuffle method using Fisher-Yates shuffle algorithm
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

            public Card Deal() // Removes and returns top card from deck (first element in list)
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

        private void dealButton_Click(object sender, EventArgs e) // Method and functionality for clicking the deal button. This deals 2 cards to both the player and the dealer. Needs improvements such as a face down dealer's card but we will get to that.
        {
            try
            {
                Card dealtCard = myDeck.Deal();
                dealerCard1TextBox.Text = $"{dealtCard.Rank} of {dealtCard.Suit}";
                dealerHand.Add(dealtCard);
                dealtCard = myDeck.Deal();
                dealerCard2TextBox.Text = $"{dealtCard.Rank} of {dealtCard.Suit}";
                dealerHand.Add(dealtCard);


                dealtCard = myDeck.Deal();
                playerCard1TextBox.Text = $"{dealtCard.Rank} of {dealtCard.Suit}";
                playerHand.Add(dealtCard);
                dealtCard = myDeck.Deal();
                playerCard2TextBox.Text = $"{dealtCard.Rank} of {dealtCard.Suit}";
                playerHand.Add(dealtCard);

                dealerHandValueTextBox.Text = "Dealer hand value: " + (CalculateHandValue(dealerHand).ToString());
                playerHandValueTextBox.Text = "Player hand value: " + (CalculateHandValue(playerHand).ToString());
            }
            catch (InvalidOperationException ex)
            {
                cardDisplayTextBox.Text = ex.Message;
            }
        }

        private void hitButton_Click(object sender, EventArgs e) // Hit button functionality
        {

            try
            {
                Card dealtCard = myDeck.Deal();
                playerCard3TextBox.Text = $"{dealtCard.Rank} of {dealtCard.Suit}"; // FIXME: Need to find a way for each new card dealt displays in a different text box. The playerHand data is accurate, but the displayed cards get overridden.
                playerHand.Add(dealtCard);

                int playerHandValue = CalculateHandValue(playerHand);
                playerHandValueTextBox.Text = "Player Hand Value: " + playerHandValue.ToString();

                if (playerHandValue > 21)
                {
                    cardDisplayTextBox.Text = "Player busts! Dealer wins.";
                }
            }
            catch (InvalidOperationException ex)
            {
                cardDisplayTextBox.Text = ex.Message;
            }
        }

        private int CalculateHandValue(List<Card> hand) // Calculates the value of a player or dealers handanda accounts for aces.
        {
            int value = 0;
            int numAces = 0;

            foreach (Card card in hand)
            {
                if (card.Rank == "Ace")
                {
                    numAces++;
                    value += 11;
                }
                else if (card.Rank == "King" || card.Rank == "Queen" || card.Rank == "Jack")
                {
                    value += 10;
                }
                else
                {
                    value += int.Parse(card.Rank);
                }
            }

            while (value > 21 && numAces > 0)
            {
                value -= 10;
                numAces--;
            }
            return value;
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            while (CalculateHandValue(dealerHand) < 17)
            {

            }
        }
    }
}