namespace Project_experimentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cardDisplayTextBox = new TextBox();
            nextRoundButton = new Button();
            dealButton = new Button();
            hitButton = new Button();
            standButton = new Button();
            playerHandValueTextBox = new TextBox();
            dealerHandValueTextBox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dealerTitleTextBox = new TextBox();
            playerHandTextBox = new TextBox();
            chip_10 = new Button();
            chip_25 = new Button();
            chip_50 = new Button();
            chip_100 = new Button();
            playerMoneyTextBox = new TextBox();
            betTextBox = new TextBox();
            instructionsTextBox = new TextBox();
            groupBox2 = new GroupBox();
            player1GroupBox = new GroupBox();
            player1LockedTextBox = new TextBox();
            player1HandGroupBox = new GroupBox();
            player1FlowLayoutPanel = new FlowLayoutPanel();
            dealerHandGroupBox = new GroupBox();
            dealerFlowLayoutPanel = new FlowLayoutPanel();
            controlsGroupBox = new GroupBox();
            player2HandGroupBox = new GroupBox();
            player2FlowLayoutPanel = new FlowLayoutPanel();
            player2GroupBox = new GroupBox();
            player2LockedTextBox = new TextBox();
            standButton2 = new Button();
            hitButton2 = new Button();
            player2BetTextBox = new TextBox();
            player2MoneyTextBox = new TextBox();
            player2HandValueTextBox = new TextBox();
            textBox1 = new TextBox();
            player1BetOverride = new Button();
            player2BetOverride = new Button();
            singlePlayerButton = new Button();
            twoPlayerButton = new Button();
            helpGroupBox = new GroupBox();
            helpTextBox = new TextBox();
            helpButton = new Button();
            groupBox2.SuspendLayout();
            player1GroupBox.SuspendLayout();
            player1HandGroupBox.SuspendLayout();
            dealerHandGroupBox.SuspendLayout();
            controlsGroupBox.SuspendLayout();
            player2HandGroupBox.SuspendLayout();
            player2GroupBox.SuspendLayout();
            helpGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // cardDisplayTextBox
            // 
            cardDisplayTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cardDisplayTextBox.Location = new Point(25, 206);
            cardDisplayTextBox.Multiline = true;
            cardDisplayTextBox.Name = "cardDisplayTextBox";
            cardDisplayTextBox.ReadOnly = true;
            cardDisplayTextBox.Size = new Size(235, 184);
            cardDisplayTextBox.TabIndex = 2;
            // 
            // nextRoundButton
            // 
            nextRoundButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextRoundButton.BackColor = SystemColors.GradientActiveCaption;
            nextRoundButton.BackgroundImage = (Image)resources.GetObject("nextRoundButton.BackgroundImage");
            nextRoundButton.BackgroundImageLayout = ImageLayout.Zoom;
            nextRoundButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nextRoundButton.Location = new Point(61, 129);
            nextRoundButton.Name = "nextRoundButton";
            nextRoundButton.Size = new Size(162, 56);
            nextRoundButton.TabIndex = 3;
            nextRoundButton.UseVisualStyleBackColor = false;
            nextRoundButton.Click += nextRoundButton_Click;
            // 
            // dealButton
            // 
            dealButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dealButton.BackColor = SystemColors.GradientActiveCaption;
            dealButton.BackgroundImage = (Image)resources.GetObject("dealButton.BackgroundImage");
            dealButton.BackgroundImageLayout = ImageLayout.Zoom;
            dealButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dealButton.Location = new Point(61, 58);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(159, 57);
            dealButton.TabIndex = 5;
            dealButton.UseVisualStyleBackColor = false;
            dealButton.Click += dealButton_Click;
            // 
            // hitButton
            // 
            hitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hitButton.BackColor = SystemColors.GradientActiveCaption;
            hitButton.BackgroundImage = (Image)resources.GetObject("hitButton.BackgroundImage");
            hitButton.BackgroundImageLayout = ImageLayout.Zoom;
            hitButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hitButton.Location = new Point(227, 82);
            hitButton.Name = "hitButton";
            hitButton.Size = new Size(172, 63);
            hitButton.TabIndex = 8;
            hitButton.UseVisualStyleBackColor = false;
            hitButton.Click += hitButton_Click;
            // 
            // standButton
            // 
            standButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            standButton.BackColor = SystemColors.GradientActiveCaption;
            standButton.BackgroundImage = (Image)resources.GetObject("standButton.BackgroundImage");
            standButton.BackgroundImageLayout = ImageLayout.Zoom;
            standButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            standButton.Location = new Point(225, 161);
            standButton.Name = "standButton";
            standButton.Size = new Size(174, 57);
            standButton.TabIndex = 9;
            standButton.UseVisualStyleBackColor = false;
            standButton.Click += standButton_Click;
            // 
            // playerHandValueTextBox
            // 
            playerHandValueTextBox.Anchor = AnchorStyles.Right;
            playerHandValueTextBox.BackColor = Color.Maroon;
            playerHandValueTextBox.Location = new Point(6, 82);
            playerHandValueTextBox.Multiline = true;
            playerHandValueTextBox.Name = "playerHandValueTextBox";
            playerHandValueTextBox.ReadOnly = true;
            playerHandValueTextBox.Size = new Size(170, 63);
            playerHandValueTextBox.TabIndex = 10;
            // 
            // dealerHandValueTextBox
            // 
            dealerHandValueTextBox.BackColor = Color.Maroon;
            dealerHandValueTextBox.ForeColor = SystemColors.WindowText;
            dealerHandValueTextBox.Location = new Point(46, 82);
            dealerHandValueTextBox.Multiline = true;
            dealerHandValueTextBox.Name = "dealerHandValueTextBox";
            dealerHandValueTextBox.ReadOnly = true;
            dealerHandValueTextBox.Size = new Size(177, 120);
            dealerHandValueTextBox.TabIndex = 11;
            dealerHandValueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // dealerTitleTextBox
            // 
            dealerTitleTextBox.BackColor = Color.Maroon;
            dealerTitleTextBox.Font = new Font("Tw Cen MT", 13.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            dealerTitleTextBox.Location = new Point(12, 28);
            dealerTitleTextBox.Name = "dealerTitleTextBox";
            dealerTitleTextBox.PlaceholderText = "Dealer's Hand";
            dealerTitleTextBox.ReadOnly = true;
            dealerTitleTextBox.Size = new Size(268, 48);
            dealerTitleTextBox.TabIndex = 12;
            // 
            // playerHandTextBox
            // 
            playerHandTextBox.Anchor = AnchorStyles.Right;
            playerHandTextBox.BackColor = Color.DarkRed;
            playerHandTextBox.Font = new Font("Tw Cen MT", 10.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            playerHandTextBox.ForeColor = Color.Black;
            playerHandTextBox.Location = new Point(12, 38);
            playerHandTextBox.Name = "playerHandTextBox";
            playerHandTextBox.PlaceholderText = "Your Hand";
            playerHandTextBox.ReadOnly = true;
            playerHandTextBox.Size = new Size(143, 39);
            playerHandTextBox.TabIndex = 13;
            // 
            // chip_10
            // 
            chip_10.Anchor = AnchorStyles.Bottom;
            chip_10.BackColor = Color.DarkGray;
            chip_10.BackgroundImage = (Image)resources.GetObject("chip_10.BackgroundImage");
            chip_10.BackgroundImageLayout = ImageLayout.Stretch;
            chip_10.FlatAppearance.BorderColor = Color.DarkGray;
            chip_10.FlatStyle = FlatStyle.Flat;
            chip_10.Location = new Point(45, 38);
            chip_10.Name = "chip_10";
            chip_10.Size = new Size(138, 138);
            chip_10.TabIndex = 14;
            chip_10.UseVisualStyleBackColor = false;
            chip_10.Click += chip_10_Click;
            // 
            // chip_25
            // 
            chip_25.Anchor = AnchorStyles.Bottom;
            chip_25.BackColor = Color.DarkGray;
            chip_25.BackgroundImage = (Image)resources.GetObject("chip_25.BackgroundImage");
            chip_25.BackgroundImageLayout = ImageLayout.Stretch;
            chip_25.FlatAppearance.BorderColor = Color.DarkGray;
            chip_25.FlatStyle = FlatStyle.Flat;
            chip_25.Location = new Point(206, 38);
            chip_25.Name = "chip_25";
            chip_25.Size = new Size(138, 138);
            chip_25.TabIndex = 15;
            chip_25.UseVisualStyleBackColor = false;
            chip_25.Click += chip_25_Click;
            // 
            // chip_50
            // 
            chip_50.Anchor = AnchorStyles.Bottom;
            chip_50.BackColor = Color.DarkGray;
            chip_50.BackgroundImage = (Image)resources.GetObject("chip_50.BackgroundImage");
            chip_50.BackgroundImageLayout = ImageLayout.Stretch;
            chip_50.FlatAppearance.BorderColor = Color.DarkGray;
            chip_50.FlatStyle = FlatStyle.Flat;
            chip_50.Location = new Point(378, 38);
            chip_50.Name = "chip_50";
            chip_50.Size = new Size(138, 138);
            chip_50.TabIndex = 16;
            chip_50.UseVisualStyleBackColor = false;
            chip_50.Click += chip_50_Click;
            // 
            // chip_100
            // 
            chip_100.Anchor = AnchorStyles.Bottom;
            chip_100.BackColor = Color.DarkGray;
            chip_100.BackgroundImage = (Image)resources.GetObject("chip_100.BackgroundImage");
            chip_100.BackgroundImageLayout = ImageLayout.Stretch;
            chip_100.FlatAppearance.BorderColor = Color.DarkGray;
            chip_100.FlatAppearance.BorderSize = 0;
            chip_100.FlatStyle = FlatStyle.Flat;
            chip_100.Location = new Point(540, 34);
            chip_100.Name = "chip_100";
            chip_100.Size = new Size(138, 138);
            chip_100.TabIndex = 17;
            chip_100.UseVisualStyleBackColor = false;
            chip_100.Click += chip_100_Click;
            // 
            // playerMoneyTextBox
            // 
            playerMoneyTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            playerMoneyTextBox.Location = new Point(0, 161);
            playerMoneyTextBox.Multiline = true;
            playerMoneyTextBox.Name = "playerMoneyTextBox";
            playerMoneyTextBox.ReadOnly = true;
            playerMoneyTextBox.Size = new Size(200, 117);
            playerMoneyTextBox.TabIndex = 18;
            // 
            // betTextBox
            // 
            betTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            betTextBox.Location = new Point(210, 235);
            betTextBox.Multiline = true;
            betTextBox.Name = "betTextBox";
            betTextBox.ReadOnly = true;
            betTextBox.Size = new Size(200, 47);
            betTextBox.TabIndex = 19;
            // 
            // instructionsTextBox
            // 
            instructionsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            instructionsTextBox.Location = new Point(9, 6);
            instructionsTextBox.Multiline = true;
            instructionsTextBox.Name = "instructionsTextBox";
            instructionsTextBox.ReadOnly = true;
            instructionsTextBox.Size = new Size(1653, 1400);
            instructionsTextBox.TabIndex = 20;
            instructionsTextBox.Text = resources.GetString("instructionsTextBox.Text");
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(chip_10);
            groupBox2.Controls.Add(chip_25);
            groupBox2.Controls.Add(chip_50);
            groupBox2.Controls.Add(chip_100);
            groupBox2.ForeColor = Color.Transparent;
            groupBox2.Location = new Point(470, 1206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(727, 200);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // player1GroupBox
            // 
            player1GroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            player1GroupBox.Controls.Add(player1LockedTextBox);
            player1GroupBox.Controls.Add(playerHandTextBox);
            player1GroupBox.Controls.Add(playerHandValueTextBox);
            player1GroupBox.Controls.Add(playerMoneyTextBox);
            player1GroupBox.Controls.Add(betTextBox);
            player1GroupBox.Controls.Add(hitButton);
            player1GroupBox.Controls.Add(standButton);
            player1GroupBox.Location = new Point(12, 1108);
            player1GroupBox.Name = "player1GroupBox";
            player1GroupBox.Size = new Size(416, 291);
            player1GroupBox.TabIndex = 23;
            player1GroupBox.TabStop = false;
            player1GroupBox.Text = "Player 1 Controls";
            // 
            // player1LockedTextBox
            // 
            player1LockedTextBox.BackColor = Color.DarkRed;
            player1LockedTextBox.Location = new Point(12, 38);
            player1LockedTextBox.Multiline = true;
            player1LockedTextBox.Name = "player1LockedTextBox";
            player1LockedTextBox.Size = new Size(363, 229);
            player1LockedTextBox.TabIndex = 30;
            player1LockedTextBox.Text = "LOCKED\r\n";
            player1LockedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // player1HandGroupBox
            // 
            player1HandGroupBox.Anchor = AnchorStyles.Left;
            player1HandGroupBox.BackColor = Color.Transparent;
            player1HandGroupBox.Controls.Add(player1FlowLayoutPanel);
            player1HandGroupBox.Location = new Point(32, 665);
            player1HandGroupBox.Name = "player1HandGroupBox";
            player1HandGroupBox.Size = new Size(629, 341);
            player1HandGroupBox.TabIndex = 24;
            player1HandGroupBox.TabStop = false;
            player1HandGroupBox.Text = "Player 1 Hand";
            // 
            // player1FlowLayoutPanel
            // 
            player1FlowLayoutPanel.AutoSize = true;
            player1FlowLayoutPanel.BackColor = Color.Transparent;
            player1FlowLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            player1FlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            player1FlowLayoutPanel.Location = new Point(0, 64);
            player1FlowLayoutPanel.Name = "player1FlowLayoutPanel";
            player1FlowLayoutPanel.Size = new Size(629, 231);
            player1FlowLayoutPanel.TabIndex = 18;
            player1FlowLayoutPanel.WrapContents = false;
            // 
            // dealerHandGroupBox
            // 
            dealerHandGroupBox.Anchor = AnchorStyles.Top;
            dealerHandGroupBox.BackColor = Color.Transparent;
            dealerHandGroupBox.Controls.Add(dealerFlowLayoutPanel);
            dealerHandGroupBox.Location = new Point(476, 113);
            dealerHandGroupBox.Name = "dealerHandGroupBox";
            dealerHandGroupBox.Size = new Size(731, 280);
            dealerHandGroupBox.TabIndex = 25;
            dealerHandGroupBox.TabStop = false;
            dealerHandGroupBox.Text = "Dealer Hand";
            // 
            // dealerFlowLayoutPanel
            // 
            dealerFlowLayoutPanel.AutoSize = true;
            dealerFlowLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            dealerFlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            dealerFlowLayoutPanel.Location = new Point(0, 55);
            dealerFlowLayoutPanel.Name = "dealerFlowLayoutPanel";
            dealerFlowLayoutPanel.Size = new Size(731, 171);
            dealerFlowLayoutPanel.TabIndex = 26;
            dealerFlowLayoutPanel.WrapContents = false;
            // 
            // controlsGroupBox
            // 
            controlsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            controlsGroupBox.Controls.Add(cardDisplayTextBox);
            controlsGroupBox.Controls.Add(dealButton);
            controlsGroupBox.Controls.Add(nextRoundButton);
            controlsGroupBox.Location = new Point(1396, 17);
            controlsGroupBox.Name = "controlsGroupBox";
            controlsGroupBox.Size = new Size(266, 408);
            controlsGroupBox.TabIndex = 26;
            controlsGroupBox.TabStop = false;
            controlsGroupBox.Text = "Master Controls";
            // 
            // player2HandGroupBox
            // 
            player2HandGroupBox.Anchor = AnchorStyles.Right;
            player2HandGroupBox.BackColor = Color.Transparent;
            player2HandGroupBox.Controls.Add(player2FlowLayoutPanel);
            player2HandGroupBox.Location = new Point(1013, 665);
            player2HandGroupBox.Name = "player2HandGroupBox";
            player2HandGroupBox.Size = new Size(629, 341);
            player2HandGroupBox.TabIndex = 27;
            player2HandGroupBox.TabStop = false;
            player2HandGroupBox.Text = "Player 2 Hand";
            // 
            // player2FlowLayoutPanel
            // 
            player2FlowLayoutPanel.AutoSize = true;
            player2FlowLayoutPanel.BackColor = Color.Transparent;
            player2FlowLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            player2FlowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            player2FlowLayoutPanel.Location = new Point(0, 64);
            player2FlowLayoutPanel.Name = "player2FlowLayoutPanel";
            player2FlowLayoutPanel.Size = new Size(629, 231);
            player2FlowLayoutPanel.TabIndex = 18;
            player2FlowLayoutPanel.WrapContents = false;
            // 
            // player2GroupBox
            // 
            player2GroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            player2GroupBox.Controls.Add(player2LockedTextBox);
            player2GroupBox.Controls.Add(standButton2);
            player2GroupBox.Controls.Add(hitButton2);
            player2GroupBox.Controls.Add(player2BetTextBox);
            player2GroupBox.Controls.Add(player2MoneyTextBox);
            player2GroupBox.Controls.Add(player2HandValueTextBox);
            player2GroupBox.Controls.Add(textBox1);
            player2GroupBox.Location = new Point(1235, 1082);
            player2GroupBox.Name = "player2GroupBox";
            player2GroupBox.Size = new Size(427, 324);
            player2GroupBox.TabIndex = 28;
            player2GroupBox.TabStop = false;
            player2GroupBox.Text = "Player 2 Controls";
            // 
            // player2LockedTextBox
            // 
            player2LockedTextBox.BackColor = Color.DarkRed;
            player2LockedTextBox.Location = new Point(44, 50);
            player2LockedTextBox.Multiline = true;
            player2LockedTextBox.Name = "player2LockedTextBox";
            player2LockedTextBox.Size = new Size(363, 229);
            player2LockedTextBox.TabIndex = 29;
            player2LockedTextBox.Text = "LOCKED\r\n";
            player2LockedTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // standButton2
            // 
            standButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            standButton2.BackColor = SystemColors.GradientActiveCaption;
            standButton2.BackgroundImage = (Image)resources.GetObject("standButton2.BackgroundImage");
            standButton2.BackgroundImageLayout = ImageLayout.Zoom;
            standButton2.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            standButton2.Location = new Point(247, 158);
            standButton2.Name = "standButton2";
            standButton2.Size = new Size(174, 57);
            standButton2.TabIndex = 22;
            standButton2.UseVisualStyleBackColor = false;
            standButton2.Click += standButton2_Click;
            // 
            // hitButton2
            // 
            hitButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hitButton2.BackColor = SystemColors.GradientActiveCaption;
            hitButton2.BackgroundImage = (Image)resources.GetObject("hitButton2.BackgroundImage");
            hitButton2.BackgroundImageLayout = ImageLayout.Zoom;
            hitButton2.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hitButton2.Location = new Point(249, 64);
            hitButton2.Name = "hitButton2";
            hitButton2.Size = new Size(172, 63);
            hitButton2.TabIndex = 21;
            hitButton2.UseVisualStyleBackColor = false;
            hitButton2.Click += hitButton2_Click;
            // 
            // player2BetTextBox
            // 
            player2BetTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            player2BetTextBox.Location = new Point(227, 253);
            player2BetTextBox.Multiline = true;
            player2BetTextBox.Name = "player2BetTextBox";
            player2BetTextBox.ReadOnly = true;
            player2BetTextBox.Size = new Size(200, 47);
            player2BetTextBox.TabIndex = 20;
            // 
            // player2MoneyTextBox
            // 
            player2MoneyTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            player2MoneyTextBox.Location = new Point(21, 183);
            player2MoneyTextBox.Multiline = true;
            player2MoneyTextBox.Name = "player2MoneyTextBox";
            player2MoneyTextBox.ReadOnly = true;
            player2MoneyTextBox.Size = new Size(200, 117);
            player2MoneyTextBox.TabIndex = 19;
            // 
            // player2HandValueTextBox
            // 
            player2HandValueTextBox.Anchor = AnchorStyles.Right;
            player2HandValueTextBox.BackColor = Color.Maroon;
            player2HandValueTextBox.Location = new Point(6, 83);
            player2HandValueTextBox.Multiline = true;
            player2HandValueTextBox.Name = "player2HandValueTextBox";
            player2HandValueTextBox.ReadOnly = true;
            player2HandValueTextBox.Size = new Size(170, 63);
            player2HandValueTextBox.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.BackColor = Color.DarkRed;
            textBox1.Font = new Font("Tw Cen MT", 10.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(6, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Your Hand";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(143, 39);
            textBox1.TabIndex = 14;
            // 
            // player1BetOverride
            // 
            player1BetOverride.Anchor = AnchorStyles.Bottom;
            player1BetOverride.Location = new Point(544, 1152);
            player1BetOverride.Name = "player1BetOverride";
            player1BetOverride.Size = new Size(150, 46);
            player1BetOverride.TabIndex = 29;
            player1BetOverride.Text = "Player 1 bet";
            player1BetOverride.UseVisualStyleBackColor = true;
            player1BetOverride.Click += player1BetOverride_Click;
            // 
            // player2BetOverride
            // 
            player2BetOverride.Anchor = AnchorStyles.Bottom;
            player2BetOverride.Location = new Point(978, 1152);
            player2BetOverride.Name = "player2BetOverride";
            player2BetOverride.Size = new Size(150, 46);
            player2BetOverride.TabIndex = 30;
            player2BetOverride.Text = "Player 2 bet";
            player2BetOverride.UseVisualStyleBackColor = true;
            player2BetOverride.Click += player2BetOverride_Click;
            // 
            // singlePlayerButton
            // 
            singlePlayerButton.Location = new Point(66, 561);
            singlePlayerButton.Name = "singlePlayerButton";
            singlePlayerButton.Size = new Size(256, 46);
            singlePlayerButton.TabIndex = 31;
            singlePlayerButton.Text = "Single Player";
            singlePlayerButton.UseVisualStyleBackColor = true;
            singlePlayerButton.Click += singlePlayerButton_Click;
            // 
            // twoPlayerButton
            // 
            twoPlayerButton.Location = new Point(547, 561);
            twoPlayerButton.Name = "twoPlayerButton";
            twoPlayerButton.Size = new Size(256, 46);
            twoPlayerButton.TabIndex = 32;
            twoPlayerButton.Text = "Two Player";
            twoPlayerButton.UseVisualStyleBackColor = true;
            twoPlayerButton.Click += twoPlayerButton_Click;
            // 
            // helpGroupBox
            // 
            helpGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            helpGroupBox.BackColor = Color.White;
            helpGroupBox.Controls.Add(helpTextBox);
            helpGroupBox.Controls.Add(helpButton);
            helpGroupBox.Location = new Point(1203, 1165);
            helpGroupBox.Name = "helpGroupBox";
            helpGroupBox.Size = new Size(470, 180);
            helpGroupBox.TabIndex = 33;
            helpGroupBox.TabStop = false;
            // 
            // helpTextBox
            // 
            helpTextBox.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            helpTextBox.Location = new Point(124, 0);
            helpTextBox.Multiline = true;
            helpTextBox.Name = "helpTextBox";
            helpTextBox.Size = new Size(342, 180);
            helpTextBox.TabIndex = 1;
            helpTextBox.Text = "\r\n\r\nStuck? Click on the light bulb for a hint!";
            helpTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // helpButton
            // 
            helpButton.BackColor = Color.Black;
            helpButton.BackgroundImage = (Image)resources.GetObject("helpButton.BackgroundImage");
            helpButton.BackgroundImageLayout = ImageLayout.Stretch;
            helpButton.Location = new Point(0, 38);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(126, 110);
            helpButton.TabIndex = 0;
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1674, 1411);
            Controls.Add(helpGroupBox);
            Controls.Add(singlePlayerButton);
            Controls.Add(twoPlayerButton);
            Controls.Add(instructionsTextBox);
            Controls.Add(player2BetOverride);
            Controls.Add(player1BetOverride);
            Controls.Add(player2GroupBox);
            Controls.Add(player2HandGroupBox);
            Controls.Add(controlsGroupBox);
            Controls.Add(dealerHandGroupBox);
            Controls.Add(player1HandGroupBox);
            Controls.Add(player1GroupBox);
            Controls.Add(groupBox2);
            Controls.Add(dealerTitleTextBox);
            Controls.Add(dealerHandValueTextBox);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            player1GroupBox.ResumeLayout(false);
            player1GroupBox.PerformLayout();
            player1HandGroupBox.ResumeLayout(false);
            player1HandGroupBox.PerformLayout();
            dealerHandGroupBox.ResumeLayout(false);
            dealerHandGroupBox.PerformLayout();
            controlsGroupBox.ResumeLayout(false);
            controlsGroupBox.PerformLayout();
            player2HandGroupBox.ResumeLayout(false);
            player2HandGroupBox.PerformLayout();
            player2GroupBox.ResumeLayout(false);
            player2GroupBox.PerformLayout();
            helpGroupBox.ResumeLayout(false);
            helpGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox cardDisplayTextBox;
        private Button nextRoundButton;
        private TextBox dealerCard2TextBox;
        private TextBox dealerCard1TextBox;
        private Button dealButton;
        private TextBox playerCard2TextBox;
        private TextBox playerCard1TextBox;
        private Button hitButton;
        private Button standButton;
        private TextBox playerCard3TextBox;
        private TextBox playerHandValueTextBox;
        private TextBox dealerHandValueTextBox;
        private TextBox dealerCard3TextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox dealerTitleTextBox;
        private TextBox playerHandTextBox;
        private GroupBox helpGroupBox;
        private Button chip_10;
        private Button chip_25;
        private Button chip_50;
        private Button chip_100;
        private TextBox playerMoneyTextBox;
        private TextBox betTextBox;
        private TextBox instructionsTextBox;
        private GroupBox groupBox2;
        private GroupBox player1GroupBox;
        private GroupBox player1HandGroupBox;
        private FlowLayoutPanel player1FlowLayoutPanel;
        private GroupBox dealerHandGroupBox;
        private FlowLayoutPanel dealerFlowLayoutPanel;
        private GroupBox controlsGroupBox;
        private GroupBox player2HandGroupBox;
        private FlowLayoutPanel player2FlowLayoutPanel;
        private GroupBox player2GroupBox;
        private Button standButton2;
        private Button hitButton2;
        private TextBox player2BetTextBox;
        private TextBox player2MoneyTextBox;
        private TextBox player2HandValueTextBox;
        private TextBox textBox1;
        private TextBox player1LockedTextBox;
        private TextBox player2LockedTextBox;
        private Button player1BetOverride;
        private Button player2BetOverride;
        private Button singlePlayerButton;
        private Button twoPlayerButton;
        private Button helpButton;
        private TextBox helpTextBox;
    }
}