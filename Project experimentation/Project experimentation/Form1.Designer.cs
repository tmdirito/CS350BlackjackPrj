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
            button3.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1154, 995);
            button3.Name = "button3";
            button3.Size = new Size(162, 76);
            button3.TabIndex = 3;
            button3.Text = "Reset";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1325, 1091);
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
    }
}