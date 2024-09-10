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
            button1 = new Button();
            cardDisplayTextBox = new TextBox();
            button3 = new Button();
            groupBox1 = new GroupBox();
            dealerPictureBox3 = new PictureBox();
            dealerPictureBox2 = new PictureBox();
            dealerPictureBox1 = new PictureBox();
            dealerCard3TextBox = new TextBox();
            dealerCard2TextBox = new TextBox();
            dealerCard1TextBox = new TextBox();
            dealButton = new Button();
            groupBox2 = new GroupBox();
            playerPictureBox3 = new PictureBox();
            playerPictureBox2 = new PictureBox();
            playerPictureBox1 = new PictureBox();
            playerCard3TextBox = new TextBox();
            playerCard2TextBox = new TextBox();
            playerCard1TextBox = new TextBox();
            hitButton = new Button();
            standButton = new Button();
            playerHandValueTextBox = new TextBox();
            dealerHandValueTextBox = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dealerPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerPictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1860, 694);
            button1.Name = "button1";
            button1.Size = new Size(191, 122);
            button1.TabIndex = 0;
            button1.Text = "Shuffle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cardDisplayTextBox
            // 
            cardDisplayTextBox.Location = new Point(1860, 345);
            cardDisplayTextBox.Multiline = true;
            cardDisplayTextBox.Name = "cardDisplayTextBox";
            cardDisplayTextBox.ReadOnly = true;
            cardDisplayTextBox.Size = new Size(191, 167);
            cardDisplayTextBox.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1860, 860);
            button3.Name = "button3";
            button3.Size = new Size(191, 123);
            button3.TabIndex = 3;
            button3.Text = "Reset deck";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dealerPictureBox3);
            groupBox1.Controls.Add(dealerPictureBox2);
            groupBox1.Controls.Add(dealerPictureBox1);
            groupBox1.Controls.Add(dealerCard3TextBox);
            groupBox1.Controls.Add(dealerCard2TextBox);
            groupBox1.Controls.Add(dealerCard1TextBox);
            groupBox1.Location = new Point(67, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1418, 447);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dealer's Hand";
            // 
            // dealerPictureBox3
            // 
            dealerPictureBox3.Location = new Point(937, 38);
            dealerPictureBox3.Name = "dealerPictureBox3";
            dealerPictureBox3.Size = new Size(193, 246);
            dealerPictureBox3.TabIndex = 17;
            dealerPictureBox3.TabStop = false;
            // 
            // dealerPictureBox2
            // 
            dealerPictureBox2.Location = new Point(564, 27);
            dealerPictureBox2.Name = "dealerPictureBox2";
            dealerPictureBox2.Size = new Size(179, 246);
            dealerPictureBox2.TabIndex = 16;
            dealerPictureBox2.TabStop = false;
            // 
            // dealerPictureBox1
            // 
            dealerPictureBox1.Location = new Point(95, 46);
            dealerPictureBox1.Name = "dealerPictureBox1";
            dealerPictureBox1.Size = new Size(194, 246);
            dealerPictureBox1.TabIndex = 15;
            dealerPictureBox1.TabStop = false;
            // 
            // dealerCard3TextBox
            // 
            dealerCard3TextBox.Location = new Point(953, 298);
            dealerCard3TextBox.Multiline = true;
            dealerCard3TextBox.Name = "dealerCard3TextBox";
            dealerCard3TextBox.ReadOnly = true;
            dealerCard3TextBox.Size = new Size(159, 104);
            dealerCard3TextBox.TabIndex = 7;
            // 
            // dealerCard2TextBox
            // 
            dealerCard2TextBox.Location = new Point(547, 298);
            dealerCard2TextBox.Multiline = true;
            dealerCard2TextBox.Name = "dealerCard2TextBox";
            dealerCard2TextBox.ReadOnly = true;
            dealerCard2TextBox.Size = new Size(153, 104);
            dealerCard2TextBox.TabIndex = 6;
            // 
            // dealerCard1TextBox
            // 
            dealerCard1TextBox.Location = new Point(86, 298);
            dealerCard1TextBox.Multiline = true;
            dealerCard1TextBox.Name = "dealerCard1TextBox";
            dealerCard1TextBox.ReadOnly = true;
            dealerCard1TextBox.Size = new Size(159, 104);
            dealerCard1TextBox.TabIndex = 5;
            // 
            // dealButton
            // 
            dealButton.BackColor = SystemColors.GradientActiveCaption;
            dealButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dealButton.Location = new Point(1860, 551);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(191, 109);
            dealButton.TabIndex = 5;
            dealButton.Text = "Deal";
            dealButton.UseVisualStyleBackColor = false;
            dealButton.Click += dealButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(playerPictureBox3);
            groupBox2.Controls.Add(playerPictureBox2);
            groupBox2.Controls.Add(playerPictureBox1);
            groupBox2.Controls.Add(playerCard3TextBox);
            groupBox2.Controls.Add(playerCard2TextBox);
            groupBox2.Controls.Add(playerCard1TextBox);
            groupBox2.Location = new Point(17, 515);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1386, 530);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Your Hand";
            // 
            // playerPictureBox3
            // 
            playerPictureBox3.Location = new Point(709, 68);
            playerPictureBox3.Name = "playerPictureBox3";
            playerPictureBox3.Size = new Size(194, 293);
            playerPictureBox3.TabIndex = 14;
            playerPictureBox3.TabStop = false;
            // 
            // playerPictureBox2
            // 
            playerPictureBox2.Location = new Point(319, 59);
            playerPictureBox2.Name = "playerPictureBox2";
            playerPictureBox2.Size = new Size(204, 302);
            playerPictureBox2.TabIndex = 13;
            playerPictureBox2.TabStop = false;
            // 
            // playerPictureBox1
            // 
            playerPictureBox1.Location = new Point(19, 38);
            playerPictureBox1.Name = "playerPictureBox1";
            playerPictureBox1.Size = new Size(181, 356);
            playerPictureBox1.TabIndex = 12;
            playerPictureBox1.TabStop = false;
            // 
            // playerCard3TextBox
            // 
            playerCard3TextBox.Location = new Point(722, 429);
            playerCard3TextBox.Multiline = true;
            playerCard3TextBox.Name = "playerCard3TextBox";
            playerCard3TextBox.ReadOnly = true;
            playerCard3TextBox.Size = new Size(159, 71);
            playerCard3TextBox.TabIndex = 7;
            // 
            // playerCard2TextBox
            // 
            playerCard2TextBox.Location = new Point(357, 429);
            playerCard2TextBox.Multiline = true;
            playerCard2TextBox.Name = "playerCard2TextBox";
            playerCard2TextBox.ReadOnly = true;
            playerCard2TextBox.Size = new Size(162, 72);
            playerCard2TextBox.TabIndex = 6;
            // 
            // playerCard1TextBox
            // 
            playerCard1TextBox.Location = new Point(34, 429);
            playerCard1TextBox.Multiline = true;
            playerCard1TextBox.Name = "playerCard1TextBox";
            playerCard1TextBox.ReadOnly = true;
            playerCard1TextBox.Size = new Size(150, 72);
            playerCard1TextBox.TabIndex = 5;
            // 
            // hitButton
            // 
            hitButton.BackColor = SystemColors.GradientActiveCaption;
            hitButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hitButton.Location = new Point(1437, 696);
            hitButton.Name = "hitButton";
            hitButton.Size = new Size(150, 46);
            hitButton.TabIndex = 8;
            hitButton.Text = "Hit";
            hitButton.UseVisualStyleBackColor = false;
            hitButton.Click += hitButton_Click;
            // 
            // standButton
            // 
            standButton.BackColor = SystemColors.GradientActiveCaption;
            standButton.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            standButton.Location = new Point(1437, 807);
            standButton.Name = "standButton";
            standButton.Size = new Size(150, 46);
            standButton.TabIndex = 9;
            standButton.Text = "Stand";
            standButton.UseVisualStyleBackColor = false;
            standButton.Click += standButton_Click;
            // 
            // playerHandValueTextBox
            // 
            playerHandValueTextBox.Location = new Point(1426, 896);
            playerHandValueTextBox.Multiline = true;
            playerHandValueTextBox.Name = "playerHandValueTextBox";
            playerHandValueTextBox.ReadOnly = true;
            playerHandValueTextBox.Size = new Size(177, 120);
            playerHandValueTextBox.TabIndex = 10;
            // 
            // dealerHandValueTextBox
            // 
            dealerHandValueTextBox.Location = new Point(1530, 97);
            dealerHandValueTextBox.Multiline = true;
            dealerHandValueTextBox.Name = "dealerHandValueTextBox";
            dealerHandValueTextBox.ReadOnly = true;
            dealerHandValueTextBox.Size = new Size(177, 120);
            dealerHandValueTextBox.TabIndex = 11;
            dealerHandValueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2110, 1091);
            Controls.Add(dealerHandValueTextBox);
            Controls.Add(playerHandValueTextBox);
            Controls.Add(standButton);
            Controls.Add(hitButton);
            Controls.Add(groupBox2);
            Controls.Add(dealButton);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(cardDisplayTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dealerPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerPictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox cardDisplayTextBox;
        private Button button3;
        private GroupBox groupBox1;
        private TextBox dealerCard2TextBox;
        private TextBox dealerCard1TextBox;
        private Button dealButton;
        private GroupBox groupBox2;
        private TextBox playerCard2TextBox;
        private TextBox playerCard1TextBox;
        private Button hitButton;
        private Button standButton;
        private TextBox playerCard3TextBox;
        private TextBox playerHandValueTextBox;
        private TextBox dealerHandValueTextBox;
        private TextBox dealerCard3TextBox;
        private PictureBox playerPictureBox1;
        private PictureBox playerPictureBox3;
        private PictureBox playerPictureBox2;
        private PictureBox dealerPictureBox3;
        private PictureBox dealerPictureBox2;
        private PictureBox dealerPictureBox1;
    }
}