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


        // General variables for program and initialization of components


        private Deck myDeck; // Initialize deck variable
        private List<Card> playerHand = new List<Card>();
        private List<Card> dealerHand = new List<Card>();
        private List<Card> player2Hand = new List<Card>();
        private Dictionary<string, Image> cardImages = new Dictionary<string, Image>(); // Dictionary to load all image files upon launch
        private string cardImagesFolderPath = @"..\..\..\images"; // Path to image folder (three directories up)
        private bool canDeal = false;
        private bool twoPlayer = true;
        private bool player1Locked = false;
        private bool player2Locked = false;
        private bool player1BetTurn = true;
        private bool player1Busted = false;
        private int playerBet = 0;
        private int playerMoney = 1000;
        private int player2Bet = 0;
        private int player2Money = 1000;
        private PictureBox dealerFirstCardPictureBox = null;


        // Basic reference and data methods

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
            player1LockedTextBox.Visible = false;
            player2LockedTextBox.Visible = false;
            singlePlayerButton.BringToFront();
            twoPlayerButton.BringToFront();

            if (twoPlayer)
            {
                player2MoneyTextBox.Text = $"Remaining Money: {player2Money}";
                player2LockedTextBox.Visible = false;
                player1Locked = false;
                player2Locked = true;
                player2GroupBox.Visible = true;
                hitButton2.Enabled = false;
                standButton2.Enabled = false;
                player1BetOverride.Visible = true;
                player2BetOverride.Visible = true;
            }
            else if (!twoPlayer)
            {
                player2GroupBox.Visible = false;
                player2HandGroupBox.Visible = false;
                player1BetTurn = true;
                player1BetOverride.Visible = false;
                player2BetOverride.Visible = false;
            }



        }
        private void singlePlayer() // single player method that gets called when single player button is selected
        {
            player2GroupBox.Visible = false;
            player2HandGroupBox.Visible = false;
            player1BetTurn = true;
            player1BetOverride.Visible = false;
            player2BetOverride.Visible = false;
        }
        private void doublePlayer() // two player method that gets called when two player button is selected
        {
            player2MoneyTextBox.Text = $"Remaining Money: {player2Money}";
            player2LockedTextBox.Visible = false;
            player1Locked = false;
            player2Locked = true;
            player2GroupBox.Visible = true;
            hitButton2.Enabled = false;
            standButton2.Enabled = false;
            player1BetOverride.Visible = true;
            player2BetOverride.Visible = true;
        }


        // Deck and Card classes


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

            public int Count()
            {
                return cards.Count;
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


        // Chip bet buttons
        /*
         * All chip logic has changed to account for two player, runs normally if twoPlayer is set to false, and if twoPlayer is true,
         * runs for both players depending on what button is selected, and only allows for dealing once the second player has placed their bet.
         * Player 1 bet and player 2 bet buttons allow for user to take control over who is placing bet.
         */


        private void chip_10_Click(object sender, EventArgs e)
        {
            if (!twoPlayer)
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
            else if (twoPlayer)
            {
                if (player1BetTurn)
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
                        // canDeal = true;
                        playerMoney -= 10;
                        playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
                    }
                }
                else if (!player1BetTurn)
                {
                    if (player2Money < 10)
                    {
                        chip_10.Enabled = false;
                        cardDisplayTextBox.Text = "You cannot bet more than your bankroll.";
                    }
                    else
                    {
                        player2Bet += 10;
                        player2BetTextBox.Text = $"Bet Amount: {player2Bet}";
                        canDeal = true; // only enables dealing once both players have placed their bets
                        player2Money -= 10;
                        player2MoneyTextBox.Text = $"Remaining Money: {player2Money}";
                    }
                }
            }

        }
        private void chip_25_Click(object sender, EventArgs e)
        {
            if (!twoPlayer)
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
            else if (twoPlayer)
            {
                if (player1BetTurn)
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
                        // canDeal = true;
                        playerMoney -= 25;
                        playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
                    }
                }
                else if (!player1BetTurn)
                {
                    if (player2Money < 25)
                    {
                        chip_25.Enabled = false;
                        cardDisplayTextBox.Text = "You cannot bet more than your bankroll.";
                    }
                    else
                    {
                        player2Bet += 25;
                        player2BetTextBox.Text = $"Bet Amount: {player2Bet}";
                        canDeal = true;
                        player2Money -= 25;
                        player2MoneyTextBox.Text = $"Remaining Money: {player2Money}";
                    }
                }
            }

        }
        private void chip_50_Click(object sender, EventArgs e)
        {
            if (!twoPlayer)
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
            else if (twoPlayer)
            {
                if (player1BetTurn)
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
                        // canDeal = true;
                        playerMoney -= 50;
                        playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
                    }
                }
                else if (!player1BetTurn)
                {
                    if (player2Money < 50)
                    {
                        chip_50.Enabled = false;
                        cardDisplayTextBox.Text = "You cannot bet more than your bankroll.";
                    }
                    else
                    {
                        player2Bet += 50;
                        player2BetTextBox.Text = $"Bet Amount: {player2Bet}";
                        canDeal = true;
                        player2Money -= 50;
                        player2MoneyTextBox.Text = $"Remaining Money: {player2Money}";
                    }
                }
            }
        }
        private void chip_100_Click(object sender, EventArgs e)
        {
            if (!twoPlayer)
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
            else if (twoPlayer)
            {
                if (player1BetTurn)
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
                        // canDeal = true;
                        playerMoney -= 100;
                        playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";

                    }
                }
                else if (!player1BetTurn)
                {
                    if (player2Money < 100)
                    {
                        chip_100.Enabled = false;
                        cardDisplayTextBox.Text = "You cannot bet more than your bankroll.";
                    }
                    else
                    {
                        player2Bet += 100;
                        player2BetTextBox.Text = $"Bet Amount: {player2Bet}";
                        canDeal = true;
                        player2Money -= 100;
                        player2MoneyTextBox.Text = $"Remaining Money: {player2Money}";

                    }
                }
            }

        }


        // Buttons


        private void dealButton_Click(object sender, EventArgs e) // Method and functionality for clicking the deal button. This deals 2 cards to both the player and the dealer.
        {
            if (!canDeal) { return; }
            try
            {
                Card dealtCard = myDeck.Deal();
                dealerHand.Add(dealtCard);
                // Below is all logic for displaying dealer card, however could not call method since this is unique to the dealer's first card (back of card)
                PictureBox newPictureBox = new PictureBox();
                newPictureBox.Anchor = AnchorStyles.Top;
                newPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                newPictureBox.Size = new Size(150, 225);
                /* 
                int x = 600 + (dealerHand.Count - 1) * 110;
                int y = 150;
                newPictureBox.Location = new Point(x, y);
                */
                string imageName = "b2fv.bmp"; //back of card image name

                if (!cardImages.ContainsKey(imageName)) // assigns it to the empty dict
                {
                    string imagePath = Path.Combine(cardImagesFolderPath, imageName); // sets path for specific image
                    cardImages[imageName] = Image.FromFile(imagePath); // sets card in dictionary
                }

                Image resizedImage = new Bitmap(cardImages[imageName], new Size(150, 225));
                newPictureBox.Image = resizedImage;
                //this.Controls.Add(newPictureBox);
                dealerFlowLayoutPanel.Controls.Add(newPictureBox);
                dealerFirstCardPictureBox = newPictureBox; // asigns name to picture box so image can be replaced with actual card

                newPictureBox.BringToFront();
                dealtCard = myDeck.Deal();
                dealerHand.Add(dealtCard);
                createPictureBoxDealer(dealtCard);




                dealtCard = myDeck.Deal();
                playerHand.Add(dealtCard);
                createPictureBoxPlayer(dealtCard, 1);
                dealtCard = myDeck.Deal();
                playerHand.Add(dealtCard);
                createPictureBoxPlayer(dealtCard, 1);

                if (twoPlayer)
                {
                    dealtCard = myDeck.Deal();
                    player2Hand.Add(dealtCard);
                    createPictureBoxPlayer(dealtCard, 2);
                    dealtCard = myDeck.Deal();
                    player2Hand.Add(dealtCard);
                    createPictureBoxPlayer(dealtCard, 2);
                    player2HandValueTextBox.Text = "Player hand value: " + (CalculateHandValue(player2Hand).ToString());
                    player2LockedTextBox.Visible = true;


                }


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

        /*
         * Hit button now runs normally if twoPlayer is set to false, and if twoPlayer is set to true, it 
         * accounts for player 1 busting and the turn transferring over to player 2.
         */
        private void hitButton_Click(object sender, EventArgs e) // Hit button functionality
        {

            try
            {
                Card dealtCard = myDeck.Deal();

                playerHand.Add(dealtCard);

                createPictureBoxPlayer(dealtCard, 1);



                int playerHandValue = CalculateHandValue(playerHand);
                playerHandValueTextBox.Text = "Player Hand Value: " + playerHandValue.ToString();

                if (!twoPlayer) 
                {
                    if (playerHandValue > 21)
                    {
                        cardDisplayTextBox.Text = "Player busts! Dealer wins.";
                        hitButton.Enabled = false; // Disable hit and stand buttons after busting
                        standButton.Enabled = false;

                    }
                }
                else if (twoPlayer)
                {
                    if (playerHandValue > 21)
                    {
                        cardDisplayTextBox.Text = "Player busts! Dealer wins.";
                        hitButton.Enabled = false; // Disable hit and stand buttons after busting
                        standButton.Enabled = false;
                        player1LockedTextBox.Visible = true;
                        player1Locked = true;
                        player2LockedTextBox.Visible = false;
                        player2Locked = false;
                        player1Busted = true;
                        hitButton2.Enabled = true;
                        standButton2.Enabled = true;



                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                cardDisplayTextBox.Text = ex.Message;
            }
        }

        /*
         * Hit button for second player. Only is activated once player 1 either busts or stands.
         * Similar hit logic, however if they bust, it displays a winner depending on if both players have busted or not.
         */
        private void hitButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Card dealtCard = myDeck.Deal();

                player2Hand.Add(dealtCard);

                createPictureBoxPlayer(dealtCard, 2);



                int player2HandValue = CalculateHandValue(player2Hand);
                player2HandValueTextBox.Text = "Player Hand Value: " + player2HandValue.ToString();

                if (player2HandValue > 21)
                {

                    hitButton2.Enabled = false; // Disable hit and stand buttons after busting
                    standButton2.Enabled = false;
                    player2LockedTextBox.Visible = true;
                    if (!player1Busted)
                    {

                        dealerHandValueTextBox.Visible = true;

                        if (dealerFirstCardPictureBox != null)
                        {
                            DisplayCardImage(dealerFirstCardPictureBox, dealerHand[0]); // replaces face down card with actual first card in dealer's hand
                        }

                        while (CalculateHandValue(dealerHand) < 17)
                        {
                            dealtCard = myDeck.Deal();


                            dealerHand.Add(dealtCard);
                            createPictureBoxDealer(dealtCard);
                            dealerHandValueTextBox.Text = "Dealer hand value: " + CalculateHandValue(dealerHand).ToString();
                        }

                        int playerHandValue = CalculateHandValue(playerHand);
                        int dealerHandValue = CalculateHandValue(dealerHand);
                        string resultMessage;

                        if (dealerHandValue > 21)
                        {
                            resultMessage = "Player 2 busted and player 1 wins - Dealer busts!";
                            playerMoney += (playerBet * 2);

                        }
                        else if (playerHandValue > dealerHandValue)
                        {
                            resultMessage = "Player 2 busted and player 1 wins!";
                            playerMoney += (playerBet * 2);

                        }
                        else if (dealerHandValue > playerHandValue)
                        {
                            resultMessage = "Dealer wins!";
                        }
                        else
                        {
                            resultMessage = "Push - Tie game! (player 2 busted)";
                            playerMoney = playerBet + playerMoney;

                        }

                        cardDisplayTextBox.Text = resultMessage;
                        playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
                    }
                    else if (player1Busted)
                    {
                        cardDisplayTextBox.Text = "Players busts! Dealer wins.";
                    }

                }
            }
            catch (InvalidOperationException ex)
            {
                cardDisplayTextBox.Text = ex.Message;
            }
        }

        /*
         * Stand button for player 1, runs normally if it is single player. If it is two player,
         * it transfers the turn to player 2.
         */
        private void standButton_Click(object sender, EventArgs e) // Stand button functionality
        {
            hitButton.Enabled = false;
            standButton.Enabled = false;
            if (!twoPlayer)
            {
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
            else if (twoPlayer)
            {
                player1Locked = true;
                player1LockedTextBox.Visible = true;
                player2Locked = false;
                player2LockedTextBox.Visible = false;
                hitButton2.Enabled = true;
                standButton2.Enabled = true;

            }
        }

        /*
         * Stand button for player 2, transfers turn to dealer and calculates winner based on every possible outcome.
         */
        private void standButton2_Click(object sender, EventArgs e)
        {
            hitButton2.Enabled = false;
            standButton2.Enabled = false;
            player2Locked = true;
            player2LockedTextBox.Visible = true;
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

            int player2HandValue = CalculateHandValue(player2Hand);
            int player1HandValue = CalculateHandValue(playerHand);
            int dealerHandValue = CalculateHandValue(dealerHand);
            string resultMessage;

            if (dealerHandValue > 21)
            {
                resultMessage = "Both players win - Dealer busts!";
                playerMoney += (playerBet * 2);
                player2Money += (player2Bet * 2);

            }
            else if (player1Busted && dealerHandValue > player2HandValue)
            {
                resultMessage = "Dealer wins!";

            }
            else if (player1Busted && player2HandValue > dealerHandValue)
            {
                resultMessage = "Player 2 wins!";
                player2Money += (player2Bet * 2);
            }

            // player 1 win conditions: 

            else if (player1HandValue > dealerHandValue && dealerHandValue > player2HandValue)
            {
                resultMessage = "Player 1 wins!";
                playerMoney += (playerBet * 2);
            }

            // player 2 win condition

            else if (player2HandValue > dealerHandValue && dealerHandValue > player1HandValue)
            {
                resultMessage = "Player 2 wins!";
                player2Money += (player2Bet * 2);
            }

            // dealer win conditions
            else if (dealerHandValue > player1HandValue && dealerHandValue > player2HandValue)
            {
                resultMessage = "Dealer wins!";
            }
            else if (dealerHandValue == player1HandValue && dealerHandValue > player2HandValue)
            {
                resultMessage = "Dealer wins!";
            }
            else if (dealerHandValue == player2HandValue && dealerHandValue > player1HandValue)
            {
                resultMessage = "Dealer wins!";
            }

            // both players win conditions

            else if (player1HandValue > dealerHandValue && player2HandValue > dealerHandValue)
            {
                resultMessage = "Both players win!";
                playerMoney += (playerBet * 2);
                player2Money += (player2Bet * 2);
            }
            else if (player1HandValue > dealerHandValue && player2HandValue == dealerHandValue)
            {
                resultMessage = "Both players win!";
                playerMoney += (playerBet * 2);
                player2Money += (player2Bet * 2);
            }
            else if (player2HandValue > dealerHandValue && player1HandValue == dealerHandValue)
            {
                resultMessage = "Both players win!";
                playerMoney += (playerBet * 2);
                player2Money += (player2Bet * 2);
            }

            // ties

            else if (dealerHandValue == player1HandValue && player1HandValue == player2HandValue)
            {
                resultMessage = "Push - Tie game!";
                playerMoney = playerBet + playerMoney;
                player2Money = player2Bet + player2Money;
            }
            else
            {
                resultMessage = "Push - Tie game!";
                playerMoney = playerBet + playerMoney;

            }

            cardDisplayTextBox.Text = resultMessage;
            playerMoneyTextBox.Text = $"Remaining Money: {playerMoney}";
            player2MoneyTextBox.Text = $"Remaining Money: {player2Money}";

        }
        private void nextRoundButton_Click(object sender, EventArgs e) // Next round button
        {


            if (myDeck.Count() < 15) // only creates and shuffles new deck if deck card count falls below 15 to keep odds as realistic as possible
            {
                myDeck = new Deck();
                myDeck.Shuffle();
            }
            cardDisplayTextBox.Text = $"Next round! Card count in deck: {myDeck.Count()}";
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

            for (int i = player1FlowLayoutPanel.Controls.Count - 1; i >= 0; i--)
            {
                if (player1FlowLayoutPanel.Controls[i] is PictureBox pictureBox)
                {
                    player1FlowLayoutPanel.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                }
            }
            for (int i = player2FlowLayoutPanel.Controls.Count - 1; i >= 0; i--)
            {
                if (player2FlowLayoutPanel.Controls[i] is PictureBox pictureBox)
                {
                    player2FlowLayoutPanel.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                }
            }
            for (int i = dealerFlowLayoutPanel.Controls.Count - 1; i >= 0; i--)
            {
                if (dealerFlowLayoutPanel.Controls[i] is PictureBox pictureBox)
                {
                    dealerFlowLayoutPanel.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                }
            }
            canDeal = false;
            if (twoPlayer)
            {
                player2LockedTextBox.Visible = false;
                player1LockedTextBox.Visible = false;
                player2Hand.Clear();
                player2MoneyTextBox.Text = $"Remaining Money: {player2Money}";
                player2Bet = 0;
                player2BetTextBox.Text = $"Bet amount: {player2Bet}";
                player1BetTurn = true;
            }
        }

        private void player1BetOverride_Click(object sender, EventArgs e)
        {
            player1BetTurn = true;
        } // button to switch who is placing their bets, sets player 1 as the better

        private void player2BetOverride_Click(object sender, EventArgs e)
        {
            player1BetTurn = false;
        } // button to switch who is placing their bets, sets player 2 as the better

        private void singlePlayerButton_Click(object sender, EventArgs e) // single player button
        {
            twoPlayer = false;
            singlePlayer();
            instructionsTextBox.Visible = false;
            singlePlayerButton.Visible = false;
            twoPlayerButton.Visible = false;

        }

        private void twoPlayerButton_Click(object sender, EventArgs e) // two player button
        {
            twoPlayer = true;
            doublePlayer();
            instructionsTextBox.Visible = false;
            singlePlayerButton.Visible = false;
            twoPlayerButton.Visible = false;
        }


        // Functionalities


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
        private void createPictureBoxDealer(Card dealtCard) // Method that creates a dynamic pictureBox at the dealer's hand location and displays the newly dealt card within that
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.Anchor = AnchorStyles.Top;
            newPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            newPictureBox.Size = new Size(150, 225);
            
            dealerFlowLayoutPanel.Controls.Add(newPictureBox);
            DisplayCardImage(newPictureBox, dealtCard);

            

            newPictureBox.BringToFront();
        }
        private void createPictureBoxPlayer(Card dealtCard, int player) // Similar method to createPictureBoxDealer but for the player's hand location
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.Anchor = AnchorStyles.Bottom;
            newPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            newPictureBox.Size = new Size(150, 225);
            
            if (player == 1)
            {
                player1FlowLayoutPanel.Controls.Add(newPictureBox);
                DisplayCardImage(newPictureBox, dealtCard);
            }
            else if (player == 2)
            {
                player2FlowLayoutPanel.Controls.Add(newPictureBox);
                DisplayCardImage(newPictureBox, dealtCard);
            }
            

            newPictureBox.BringToFront();
        }
        private int CalculateHandValue(List<Card> hand) // Calculates the value of a player or dealers hand and accounts for aces.
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


        // Currently unused methods


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
        private void Form1_Load(object sender, EventArgs e) // Ignore?
        {

        }
        private void button1_Click(object sender, EventArgs e) // Shuffle button function, name needs to be changed
        {
            myDeck.Shuffle();
            cardDisplayTextBox.Text = "Deck shuffled!";
        }


    }
}
