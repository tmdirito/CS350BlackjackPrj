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
            button3 = new Button();
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1154, 906);
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
            cardDisplayTextBox.Location = new Point(933, 944);
            cardDisplayTextBox.Multiline = true;
            cardDisplayTextBox.Name = "cardDisplayTextBox";
            cardDisplayTextBox.ReadOnly = true;
            cardDisplayTextBox.Size = new Size(206, 65);
            cardDisplayTextBox.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1154, 1014);
            button3.Name = "button3";
            button3.Size = new Size(162, 56);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dealButton
            // 
            dealButton.BackColor = SystemColors.GradientActiveCaption;
            dealButton.BackgroundImage = (Image)resources.GetObject("dealButton.BackgroundImage");
            dealButton.BackgroundImageLayout = ImageLayout.Zoom;
            dealButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dealButton.Location = new Point(1154, 843);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(159, 57);
            dealButton.TabIndex = 5;
            dealButton.UseVisualStyleBackColor = false;
            dealButton.Click += dealButton_Click;
            // 
            // hitButton
            // 
            hitButton.BackColor = SystemColors.GradientActiveCaption;
            hitButton.BackgroundImage = (Image)resources.GetObject("hitButton.BackgroundImage");
            hitButton.BackgroundImageLayout = ImageLayout.Zoom;
            hitButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hitButton.Location = new Point(12, 898);
            hitButton.Name = "hitButton";
            hitButton.Size = new Size(172, 63);
            hitButton.TabIndex = 8;
            hitButton.UseVisualStyleBackColor = false;
            hitButton.Click += hitButton_Click;
            // 
            // standButton
            // 
            standButton.BackColor = SystemColors.GradientActiveCaption;
            standButton.BackgroundImage = (Image)resources.GetObject("standButton.BackgroundImage");
            standButton.BackgroundImageLayout = ImageLayout.Zoom;
            standButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            standButton.Location = new Point(12, 978);
            standButton.Name = "standButton";
            standButton.Size = new Size(174, 57);
            standButton.TabIndex = 9;
            standButton.UseVisualStyleBackColor = false;
            standButton.Click += standButton_Click;
            // 
            // playerHandValueTextBox
            // 
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
            chip_10.BackgroundImage = (Image)resources.GetObject("chip_10.BackgroundImage");
            chip_10.BackgroundImageLayout = ImageLayout.Stretch;
            chip_10.Location = new Point(210, 906);
            chip_10.Name = "chip_10";
            chip_10.Size = new Size(145, 156);
            chip_10.TabIndex = 14;
            chip_10.UseVisualStyleBackColor = true;
            chip_10.Click += chip_10_Click;
            // 
            // chip_25
            // 
            chip_25.BackgroundImage = (Image)resources.GetObject("chip_25.BackgroundImage");
            chip_25.BackgroundImageLayout = ImageLayout.Stretch;
            chip_25.Location = new Point(361, 906);
            chip_25.Name = "chip_25";
            chip_25.Size = new Size(154, 157);
            chip_25.TabIndex = 15;
            chip_25.UseVisualStyleBackColor = true;
            chip_25.Click += chip_25_Click;
            // 
            // chip_50
            // 
            chip_50.BackgroundImage = (Image)resources.GetObject("chip_50.BackgroundImage");
            chip_50.BackgroundImageLayout = ImageLayout.Stretch;
            chip_50.Location = new Point(521, 906);
            chip_50.Name = "chip_50";
            chip_50.Size = new Size(166, 157);
            chip_50.TabIndex = 16;
            chip_50.UseVisualStyleBackColor = true;
            chip_50.Click += chip_50_Click;
            // 
            // chip_100
            // 
            chip_100.BackgroundImage = (Image)resources.GetObject("chip_100.BackgroundImage");
            chip_100.BackgroundImageLayout = ImageLayout.Stretch;
            chip_100.Location = new Point(693, 906);
            chip_100.Name = "chip_100";
            chip_100.Size = new Size(155, 156);
            chip_100.TabIndex = 17;
            chip_100.UseVisualStyleBackColor = true;
            chip_100.Click += chip_100_Click;
            // 
            // playerMoneyTextBox
            // 
            playerMoneyTextBox.Location = new Point(12, 704);
            playerMoneyTextBox.Multiline = true;
            playerMoneyTextBox.Name = "playerMoneyTextBox";
            playerMoneyTextBox.ReadOnly = true;
            playerMoneyTextBox.Size = new Size(200, 78);
            playerMoneyTextBox.TabIndex = 18;
            // 
            // betTextBox
            // 
            betTextBox.Location = new Point(12, 805);
            betTextBox.Multiline = true;
            betTextBox.Name = "betTextBox";
            betTextBox.ReadOnly = true;
            betTextBox.Size = new Size(200, 66);
            betTextBox.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1325, 1091);
            Controls.Add(betTextBox);
            Controls.Add(playerMoneyTextBox);
            Controls.Add(chip_100);
            Controls.Add(chip_50);
            Controls.Add(chip_25);
            Controls.Add(chip_10);
            Controls.Add(cardDisplayTextBox);
            Controls.Add(button3);
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
        private Button button3;
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
    }
}