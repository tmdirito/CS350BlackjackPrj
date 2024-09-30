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
            button1 = new Button();
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
            instructionsOKButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1154, 1006);
            button1.Name = "button1";
            button1.Size = new Size(168, 83);
            button1.TabIndex = 0;
            button1.Text = "Shuffle";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // cardDisplayTextBox
            // 
            cardDisplayTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cardDisplayTextBox.Location = new Point(926, 1006);
            cardDisplayTextBox.Multiline = true;
            cardDisplayTextBox.Name = "cardDisplayTextBox";
            cardDisplayTextBox.ReadOnly = true;
            cardDisplayTextBox.Size = new Size(206, 65);
            cardDisplayTextBox.TabIndex = 2;
            // 
            // nextRoundButton
            // 
            nextRoundButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextRoundButton.BackColor = SystemColors.GradientActiveCaption;
            nextRoundButton.BackgroundImage = (Image)resources.GetObject("nextRoundButton.BackgroundImage");
            nextRoundButton.BackgroundImageLayout = ImageLayout.Zoom;
            nextRoundButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nextRoundButton.Location = new Point(1160, 1104);
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
            dealButton.Location = new Point(1157, 937);
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
            hitButton.Location = new Point(14, 985);
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
            standButton.Location = new Point(12, 1071);
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
            playerHandValueTextBox.Location = new Point(1124, 429);
            playerHandValueTextBox.Multiline = true;
            playerHandValueTextBox.Name = "playerHandValueTextBox";
            playerHandValueTextBox.ReadOnly = true;
            playerHandValueTextBox.Size = new Size(177, 120);
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
            playerHandTextBox.Font = new Font("Tw Cen MT", 13.875F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            playerHandTextBox.ForeColor = Color.Black;
            playerHandTextBox.Location = new Point(1114, 363);
            playerHandTextBox.Name = "playerHandTextBox";
            playerHandTextBox.PlaceholderText = "Your Hand";
            playerHandTextBox.ReadOnly = true;
            playerHandTextBox.Size = new Size(199, 48);
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
            chip_10.Location = new Point(277, 1035);
            chip_10.Name = "chip_10";
            chip_10.Size = new Size(133, 125);
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
            chip_25.Location = new Point(428, 1039);
            chip_25.Name = "chip_25";
            chip_25.Size = new Size(125, 126);
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
            chip_50.Location = new Point(571, 1038);
            chip_50.Name = "chip_50";
            chip_50.Size = new Size(139, 129);
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
            chip_100.Location = new Point(731, 1035);
            chip_100.Name = "chip_100";
            chip_100.Size = new Size(138, 132);
            chip_100.TabIndex = 17;
            chip_100.UseVisualStyleBackColor = false;
            chip_100.Click += chip_100_Click;
            // 
            // playerMoneyTextBox
            // 
            playerMoneyTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            playerMoneyTextBox.Location = new Point(14, 760);
            playerMoneyTextBox.Multiline = true;
            playerMoneyTextBox.Name = "playerMoneyTextBox";
            playerMoneyTextBox.ReadOnly = true;
            playerMoneyTextBox.Size = new Size(200, 78);
            playerMoneyTextBox.TabIndex = 18;
            // 
            // betTextBox
            // 
            betTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            betTextBox.Location = new Point(14, 871);
            betTextBox.Multiline = true;
            betTextBox.Name = "betTextBox";
            betTextBox.ReadOnly = true;
            betTextBox.Size = new Size(200, 66);
            betTextBox.TabIndex = 19;
            // 
            // instructionsTextBox
            // 
            instructionsTextBox.Location = new Point(813, 2);
            instructionsTextBox.Multiline = true;
            instructionsTextBox.Name = "instructionsTextBox";
            instructionsTextBox.ReadOnly = true;
            instructionsTextBox.Size = new Size(191, 59);
            instructionsTextBox.TabIndex = 20;
            instructionsTextBox.Text = resources.GetString("instructionsTextBox.Text");
            // 
            // instructionsOKButton
            // 
            instructionsOKButton.Location = new Point(1040, 12);
            instructionsOKButton.Name = "instructionsOKButton";
            instructionsOKButton.Size = new Size(276, 46);
            instructionsOKButton.TabIndex = 21;
            instructionsOKButton.Text = "I understand";
            instructionsOKButton.UseVisualStyleBackColor = true;
            instructionsOKButton.Click += instructionsOKButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1325, 1172);
            Controls.Add(instructionsTextBox);
            Controls.Add(instructionsOKButton);
            Controls.Add(betTextBox);
            Controls.Add(playerMoneyTextBox);
            Controls.Add(chip_100);
            Controls.Add(chip_50);
            Controls.Add(chip_25);
            Controls.Add(chip_10);
            Controls.Add(cardDisplayTextBox);
            Controls.Add(nextRoundButton);
            Controls.Add(button1);
            Controls.Add(dealButton);
            Controls.Add(playerHandTextBox);
            Controls.Add(dealerTitleTextBox);
            Controls.Add(dealerHandValueTextBox);
            Controls.Add(playerHandValueTextBox);
            Controls.Add(standButton);
            Controls.Add(hitButton);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
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
        private GroupBox groupBox1;
        private Button chip_10;
        private Button chip_25;
        private Button chip_50;
        private Button chip_100;
        private TextBox playerMoneyTextBox;
        private TextBox betTextBox;
        private TextBox instructionsTextBox;
        private Button instructionsOKButton;
    }
}