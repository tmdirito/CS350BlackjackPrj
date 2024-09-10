using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace Project_experimentation
{
    public partial class Form1 : Form // All variables that need to be accessed by any methods (i.e "public" variables) should be placed under here
    {
        private Deck myDeck; // Initialize deck variable
        private List<Card> playerHand = new List<Card>();
        private List<Card> dealerHand = new List<Card>();

        private Dictionary<string, Image> cardImages = new Dictionary<string, Image>(); // Dictionary to load all image files upon launch

        private string cardImagesFolderPath = @"..\..\..\images"; // Path to image folder (three directories up)


        private void DisplayCardImage(PictureBox pictureBox, Card card) // method to display the card image 
        {
            string imageName = GetCardImageName(card); // gets the actual image name (i.e. h05.bmp)

            if (!cardImages.ContainsKey(imageName)) // assigns it to the empty dict
            {
                string imagePath = Path.Combine(cardImagesFolderPath, imageName); // sets path for specific image
                cardImages[imageName] = Image.FromFile(imagePath); // sets card in dictionary
            }

            pictureBox.Image = cardImages[imageName]; // displays correct card in picture box
        }

        private string GetCardImageName(Card card) // method to convert card to image file name 
        {
            char suitChar = card.Suit.ToString().ToLower()[0]; // take first letter of suit and turns is lowercase
            int rankValue = (int)card.Rank + 1; // Gets card value based on enum index
            string formattedRank = rankValue.ToString("D2"); // formats rank as double digit
            return $"{suitChar}{formattedRank}.bmp"; // returns image file name in correct syntax
        }

        public enum Suit // enum for suits
        {
            Hearts, // # 0
            Diamonds, // # 1
            Clubs, // # 2
            Spades // # 3
        }
        public enum Rank // enum for card ranks
        {
            Ace, // 0
            Two, // 1
            Three, // 2
            Four, //3 
            Five, // 4
            Six, // 5
            Seven, // 6
            Eight, // 7
            Nine, // 8
            Ten, // 9
            Jack, // 10
            Queen, // 11
            King // 12
        }

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
            dealerCard3TextBox.Text = "";
            playerCard1TextBox.Text = "";
            playerCard2TextBox.Text = "";
            playerCard3TextBox.Text = "";
            playerHandValueTextBox.Text = "";
            dealerHandValueTextBox.Text = "";
            playerHand.Clear();
            dealerHand.Clear();
            playerPictureBox1.Image = null; playerPictureBox2.Image = null; playerPictureBox3.Image = null;
        }
        public class Card // Card class to create card object that contains rank and suit.
        {
            public Suit Suit { get; }
            public Rank Rank { get; }

            public Card(Suit suit, Rank rank)
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
                // string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
                // string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (Rank rank in Enum.GetValues(typeof(Rank)))
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
                dealerCard1TextBox.Text = $"{dealtCard.Rank.ToString()} of {dealtCard.Suit.ToString()}";
                dealerHand.Add(dealtCard);
                dealtCard = myDeck.Deal();
                dealerCard2TextBox.Text = $"{dealtCard.Rank.ToString()} of {dealtCard.Suit.ToString()}";
                dealerHand.Add(dealtCard);


                dealtCard = myDeck.Deal();
                playerCard1TextBox.Text = $"{dealtCard.Rank.ToString()} of {dealtCard.Suit.ToString()}";
                playerHand.Add(dealtCard);
                dealtCard = myDeck.Deal();
                playerCard2TextBox.Text = $"{dealtCard.Rank.ToString()} of {dealtCard.Suit.ToString()}";
                playerHand.Add(dealtCard);

                dealerHandValueTextBox.Text = "Dealer hand value: " + (CalculateHandValue(dealerHand).ToString());
                playerHandValueTextBox.Text = "Player hand value: " + (CalculateHandValue(playerHand).ToString());

                DisplayCardImage(playerPictureBox1, playerHand[0]); // displays the card image
                DisplayCardImage(playerPictureBox2, playerHand[1]);
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
                playerCard3TextBox.Text = $"{dealtCard.Rank.ToString()} of {dealtCard.Suit.ToString()}"; // FIXME: Need to find a way for each new card dealt displays in a different text box. The playerHand data is accurate, but the displayed cards get overridden.
                playerHand.Add(dealtCard);
                DisplayCardImage(playerPictureBox3, playerHand[2]);

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
                if (card.Rank == Rank.Ace)
                {
                    numAces++;
                    value += 11;
                }
                else if (card.Rank == Rank.King || card.Rank == Rank.Queen || card.Rank == Rank.Jack)
                {
                    value += 10;
                }
                else
                {
                    value += (int)card.Rank + 1;
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
                Card dealtCard = myDeck.Deal();
                dealerCard3TextBox.Text = $"{dealtCard.Rank.ToString()} of {dealtCard.Suit.ToString()}"; // FIXME: Need to find a way for each new card dealt displays in a different text box. The playerHand data is accurate, but the displayed cards get overridden.
                dealerHand.Add(dealtCard);
                dealerHandValueTextBox.Text = "Dealer hand value: " + CalculateHandValue(dealerHand).ToString();
            }

            int playerHandValue = CalculateHandValue(playerHand);
            int dealerHandValue = CalculateHandValue(dealerHand);
            string resultMessage;

            if (dealerHandValue > 21)
            {
                resultMessage = "Player wins - Dealer busts!";
            }
            else if (playerHandValue > dealerHandValue)
            {
                resultMessage = "Player wins!";
            }
            else if (dealerHandValue > playerHandValue)
            {
                resultMessage = "Dealer wins!";
            }
            else
            {
                resultMessage = "Push - Tie game!";
            }

            cardDisplayTextBox.Text = resultMessage;
        }
    }
}