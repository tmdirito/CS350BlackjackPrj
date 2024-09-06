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
            dealerCard3TextBox = new TextBox();
            dealerCard2TextBox = new TextBox();
            dealerCard1TextBox = new TextBox();
            dealButton = new Button();
            groupBox2 = new GroupBox();
            playerCard4TextBox = new TextBox();
            playerCard3TextBox = new TextBox();
            playerCard2TextBox = new TextBox();
            playerCard1TextBox = new TextBox();
            hitButton = new Button();
            standButton = new Button();
            playerHandValueTextBox = new TextBox();
            dealerHandValueTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Tw Cen MT Condensed Extra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1068, 401);
            button1.Name = "button1";
            button1.Size = new Size(191, 122);
            button1.TabIndex = 0;
            button1.Text = "Shuffle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cardDisplayTextBox
            // 
            cardDisplayTextBox.Location = new Point(1068, 97);
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
            button3.Location = new Point(1068, 530);
            button3.Name = "button3";
            button3.Size = new Size(191, 123);
            button3.TabIndex = 3;
            button3.Text = "Reset deck";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dealerCard3TextBox);
            groupBox1.Controls.Add(dealerCard2TextBox);
            groupBox1.Controls.Add(dealerCard1TextBox);
            groupBox1.Location = new Point(67, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 308);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dealer's Hand";
            // 
            // dealerCard3TextBox
            // 
            dealerCard3TextBox.Location = new Point(21, 187);
            dealerCard3TextBox.Multiline = true;
            dealerCard3TextBox.Name = "dealerCard3TextBox";
            dealerCard3TextBox.ReadOnly = true;
            dealerCard3TextBox.Size = new Size(159, 104);
            dealerCard3TextBox.TabIndex = 7;
            // 
            // dealerCard2TextBox
            // 
            dealerCard2TextBox.Location = new Point(200, 51);
            dealerCard2TextBox.Multiline = true;
            dealerCard2TextBox.Name = "dealerCard2TextBox";
            dealerCard2TextBox.ReadOnly = true;
            dealerCard2TextBox.Size = new Size(153, 104);
            dealerCard2TextBox.TabIndex = 6;
            // 
            // dealerCard1TextBox
            // 
            dealerCard1TextBox.Location = new Point(21, 51);
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
            dealButton.Location = new Point(1068, 286);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(191, 109);
            dealButton.TabIndex = 5;
            dealButton.Text = "Deal";
            dealButton.UseVisualStyleBackColor = false;
            dealButton.Click += dealButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(playerCard4TextBox);
            groupBox2.Controls.Add(playerCard3TextBox);
            groupBox2.Controls.Add(playerCard2TextBox);
            groupBox2.Controls.Add(playerCard1TextBox);
            groupBox2.Location = new Point(33, 416);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(403, 237);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Your Hand";
            // 
            // playerCard4TextBox
            // 
            playerCard4TextBox.Location = new Point(200, 135);
            playerCard4TextBox.Multiline = true;
            playerCard4TextBox.Name = "playerCard4TextBox";
            playerCard4TextBox.ReadOnly = true;
            playerCard4TextBox.Size = new Size(173, 71);
            playerCard4TextBox.TabIndex = 8;
            // 
            // playerCard3TextBox
            // 
            playerCard3TextBox.Location = new Point(21, 135);
            playerCard3TextBox.Multiline = true;
            playerCard3TextBox.Name = "playerCard3TextBox";
            playerCard3TextBox.ReadOnly = true;
            playerCard3TextBox.Size = new Size(159, 71);
            playerCard3TextBox.TabIndex = 7;
            // 
            // playerCard2TextBox
            // 
            playerCard2TextBox.Location = new Point(200, 39);
            playerCard2TextBox.Multiline = true;
            playerCard2TextBox.Name = "playerCard2TextBox";
            playerCard2TextBox.ReadOnly = true;
            playerCard2TextBox.Size = new Size(162, 72);
            playerCard2TextBox.TabIndex = 6;
            // 
            // playerCard1TextBox
            // 
            playerCard1TextBox.Location = new Point(21, 39);
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
            hitButton.Location = new Point(490, 425);
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
            standButton.Location = new Point(490, 477);
            standButton.Name = "standButton";
            standButton.Size = new Size(150, 46);
            standButton.TabIndex = 9;
            standButton.Text = "Stand";
            standButton.UseVisualStyleBackColor = false;
            standButton.Click += standButton_Click;
            // 
            // playerHandValueTextBox
            // 
            playerHandValueTextBox.Location = new Point(478, 542);
            playerHandValueTextBox.Multiline = true;
            playerHandValueTextBox.Name = "playerHandValueTextBox";
            playerHandValueTextBox.ReadOnly = true;
            playerHandValueTextBox.Size = new Size(177, 120);
            playerHandValueTextBox.TabIndex = 10;
            // 
            // dealerHandValueTextBox
            // 
            dealerHandValueTextBox.Location = new Point(516, 111);
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
            ClientSize = new Size(1271, 674);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private TextBox playerCard4TextBox;
        private TextBox playerCard3TextBox;
        private TextBox playerHandValueTextBox;
        private TextBox dealerHandValueTextBox;
        private TextBox dealerCard3TextBox;
    }
}