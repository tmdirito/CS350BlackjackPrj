using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using static Project_experimentation.Form1;
using System.Drawing.Drawing2D;

namespace Project_experimentation
{
    public partial class Form1 : Form // All variables that need to be accessed by any methods (i.e "public" variables) should be placed under here
    {
        private Deck myDeck; // Initialize deck variable
        private List<Card> playerHand = new List<Card>();
        private List<Card> dealerHand = new List<Card>();

        private Dictionary<string, Image> cardImages = new Dictionary<string, Image>(); // Dictionary to load all image files upon launch

        private string cardImagesFolderPath = @"..\..\..\images"; // Path to image folder (three directories up)

        private bool canDeal = false;

        private int playerBet = 0;
        private int playerMoney = 1000;


        private PictureBox dealerFirstCardPictureBox = null;




        private void DisplayCardImage(PictureBox pictureBox, Card card) // method to display the card image 
        {
            string imageName = GetCardImageName(card); // gets the actual image name (i.e. h05.bmp)

            if (!cardImages.ContainsKey(imageName)) // assigns it to the empty dict
            {
                string imagePath = Path.Combine(cardImagesFolderPath, imageName); // sets path for specific image
                cardImages[imageName] = Image.FromFile(imagePath); // sets card in dictionary
            }

            Image resizedImage = new Bitmap(cardImages[imageName], new Size(150, 225));
            pictureBox.Image = resizedImage;

        }

        private string GetCardImageName(Card card) // method to convert card to image file name 
        {
            char suitChar = card.Suit.ToString().ToLower()[0]; // take first letter of suit and turns it lowercase
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
            myDeck.Shuffle(); // shuffles the deck automatically now instead of player selecting it
            hitButton.Enabled = false; // disables hit and stand button on reset
            standButton.Enabled = false;
            dealerHandValueTextBox.Visible = false;
            playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
        }
        //Chip bets

        private void chip_10_Click(object sender, EventArgs e)
        {
            if (playerMoney < 10)
            {
                chip_10.Enabled = false;
                cardDisplayTextBox.Text = "You cannot bet more than your bankroll.";
            }
            else
            {
                playerBet += 10;
                betTextBox.Text = $"Bet Amount: {playerBet}";
                canDeal = true;
                playerMoney -= 10;
                playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
            }

        }
        private void chip_25_Click(object sender, EventArgs e)
        {

            if (playerMoney < 25)
            {
                chip_25.Enabled = false;
                cardDisplayTextBox.Text = "You cannot bet more than your bankroll.";
            }
            else
            {
                playerBet += 25;
                betTextBox.Text = $"Bet Amount: {playerBet}";
                canDeal = true;
                playerMoney -= 25;
                playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
            }

        }
        private void chip_50_Click(object sender, EventArgs e)
        {
            if (playerMoney < 50)
            {
                chip_50.Enabled = false;
                cardDisplayTextBox.Text = "You cannot bet more than your bankroll.";
            }
            else
            {
                playerBet += 50;
                betTextBox.Text = $"Bet Amount: {playerBet}";
                canDeal = true;
                playerMoney -= 50;
                playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
            }
        }
        private void chip_100_Click(object sender, EventArgs e)
        {
            if (playerMoney < 100)
            {
                chip_100.Enabled = false;
                cardDisplayTextBox.Text = "You cannot bet more than your bankroll.";
            }
            else
            {
                playerBet += 100;
                betTextBox.Text = $"Bet Amount: {playerBet}";
                canDeal = true;
                playerMoney -= 100;
                playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";

            }

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
            myDeck.Shuffle();
            cardDisplayTextBox.Text = "Deck reset and shuffled!";
            playerHandValueTextBox.Text = "";
            dealerHandValueTextBox.Text = "";
            playerHand.Clear();
            dealerHand.Clear();
            dealerHandValueTextBox.Visible = false;
            hitButton.Enabled = false;
            standButton.Enabled = false;
            playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
            playerBet = 0;
            betTextBox.Text = $"Bet Amount: {playerBet}";
            chip_10.Enabled = true;
            chip_25.Enabled = true;
            chip_50.Enabled = true;
            chip_100.Enabled = true;
            for (int i = this.Controls.Count - 1; i >= 0; i--) // New functionality added to remove all dynamic picture boxes created within the program
            {
                if (this.Controls[i] is PictureBox pictureBox)
                {
                    this.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                }

            }
            canDeal = false;
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

        public class CircularButton : Button
        {
            protected override void OnPaint(PaintEventArgs pevent)
            {
                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(gp);
                base.OnPaint(pevent);
            }
        }

        private void dealButton_Click(object sender, EventArgs e) // Method and functionality for clicking the deal button. This deals 2 cards to both the player and the dealer. Needs improvements such as a face down dealer's card but we will get to that.
        {
            if (!canDeal) { return; }
            try
            {
                Card dealtCard = myDeck.Deal();
                dealerHand.Add(dealtCard);
                // Below is all logic for displaying dealer card, however could not call method since this is unique to the dealer's first card (back of card)
                PictureBox newPictureBox = new PictureBox();
                newPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                newPictureBox.Size = new Size(150, 225);

                int x = 475 + (dealerHand.Count - 1) * 110;
                int y = 100;
                newPictureBox.Location = new Point(x, y);

                string imageName = "b2fv.bmp"; //back of card image name

                if (!cardImages.ContainsKey(imageName)) // assigns it to the empty dict
                {
                    string imagePath = Path.Combine(cardImagesFolderPath, imageName); // sets path for specific image
                    cardImages[imageName] = Image.FromFile(imagePath); // sets card in dictionary
                }

                Image resizedImage = new Bitmap(cardImages[imageName], new Size(150, 225));
                newPictureBox.Image = resizedImage;
                this.Controls.Add(newPictureBox);
                dealerFirstCardPictureBox = newPictureBox; // asigns name to picture box so image can be replaced with actual card

                newPictureBox.BringToFront();
                dealtCard = myDeck.Deal();
                dealerHand.Add(dealtCard);
                createPictureBoxDealer(dealtCard);




                dealtCard = myDeck.Deal();
                playerHand.Add(dealtCard);
                createPictureBoxPlayer(dealtCard);
                dealtCard = myDeck.Deal();
                playerHand.Add(dealtCard);
                createPictureBoxPlayer(dealtCard);

                dealerHandValueTextBox.Text = "Dealer hand value: " + (CalculateHandValue(dealerHand).ToString());
                playerHandValueTextBox.Text = "Player hand value: " + (CalculateHandValue(playerHand).ToString());

                canDeal = false;
                chip_10.Enabled = false;
                chip_25.Enabled = false;
                chip_50.Enabled = false;
                chip_100.Enabled = false;
                hitButton.Enabled = true; // enable hit and stand buttons after dealing
                standButton.Enabled = true;

            }
            catch (InvalidOperationException ex)
            {
                cardDisplayTextBox.Text = ex.Message;
            }
        }
        private void createPictureBoxDealer(Card dealtCard) // Method that creates a dynamic pictureBox at the dealer's hand location and displays the newly dealt card within that
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            newPictureBox.Size = new Size(150, 225);

            int x = 475 + (dealerHand.Count - 1) * 110;
            int y = 100;
            newPictureBox.Location = new Point(x, y);

            DisplayCardImage(newPictureBox, dealtCard);

            this.Controls.Add(newPictureBox);

            newPictureBox.BringToFront();
        }
        private void createPictureBoxPlayer(Card dealtCard) // Similar method to createPictureBoxDealer but for the player's hand location
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            newPictureBox.Size = new Size(150, 225);

            int x = 475 + (playerHand.Count - 1) * 110;
            int y = 600;
            newPictureBox.Location = new Point(x, y);

            DisplayCardImage(newPictureBox, dealtCard);

            this.Controls.Add(newPictureBox);

            newPictureBox.BringToFront();
        }
        private void hitButton_Click(object sender, EventArgs e) // Hit button functionality
        {

            try
            {
                Card dealtCard = myDeck.Deal();

                playerHand.Add(dealtCard);

                createPictureBoxPlayer(dealtCard);



                int playerHandValue = CalculateHandValue(playerHand);
                playerHandValueTextBox.Text = "Player Hand Value: " + playerHandValue.ToString();

                if (playerHandValue > 21)
                {
                    cardDisplayTextBox.Text = "Player busts! Dealer wins.";
                    hitButton.Enabled = false; // Diable hit and stand buttons after busting
                    standButton.Enabled = false;
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
            hitButton.Enabled = false;
            standButton.Enabled = false;
            dealerHandValueTextBox.Visible = true;

            if (dealerFirstCardPictureBox != null)
            {
                DisplayCardImage(dealerFirstCardPictureBox, dealerHand[0]); // replaces face down card with actual first card in dealer's hand
            }

            while (CalculateHandValue(dealerHand) < 17)
            {
                Card dealtCard = myDeck.Deal();


                dealerHand.Add(dealtCard);
                createPictureBoxDealer(dealtCard);
                dealerHandValueTextBox.Text = "Dealer hand value: " + CalculateHandValue(dealerHand).ToString();
            }

            int playerHandValue = CalculateHandValue(playerHand);
            int dealerHandValue = CalculateHandValue(dealerHand);
            string resultMessage;

            if (dealerHandValue > 21)
            {
                resultMessage = "Player wins - Dealer busts!";
                playerMoney += (playerBet * 2);

            }
            else if (playerHandValue > dealerHandValue)
            {
                resultMessage = "Player wins!";
                playerMoney += (playerBet * 2);

            }
            else if (dealerHandValue > playerHandValue)
            {
                resultMessage = "Dealer wins!";
            }
            else
            {
                resultMessage = "Push - Tie game!";
                playerMoney = playerBet + playerMoney;

            }

            cardDisplayTextBox.Text = resultMessage;
            playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
        }

        private void instructionsOKButton_Click(object sender, EventArgs e)
        {
            instructionsTextBox.Visible = false;
            instructionsOKButton.Visible = false;
        }
    }
}
