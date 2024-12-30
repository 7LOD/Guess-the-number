namespace Guess_the_number
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
            btnStartGame = new Button();
            btnRecords = new Button();
            btnExit = new Button();
            btnEasy = new Button();
            btnMedium = new Button();
            btnHard = new Button();
            ChooseDifficulty = new Label();
            labelLive = new Label();
            labelHiddenNumber = new Label();
            textBoxNumber = new TextBox();
            btnSend = new Button();
            labelResult = new Label();
            labelTextLive = new Label();
            labelBigOrSmall = new Label();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(212, 123);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(75, 23);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(212, 152);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(75, 23);
            btnRecords.TabIndex = 1;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(212, 181);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEasy
            // 
            btnEasy.Location = new Point(212, 123);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(75, 23);
            btnEasy.TabIndex = 3;
            btnEasy.Text = "Easy";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Visible = false;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnMedium
            // 
            btnMedium.Location = new Point(212, 152);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(75, 23);
            btnMedium.TabIndex = 4;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Visible = false;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnHard
            // 
            btnHard.Location = new Point(212, 181);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(75, 23);
            btnHard.TabIndex = 5;
            btnHard.Text = "Hard";
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Visible = false;
            btnHard.Click += btnHard_Click;
            // 
            // ChooseDifficulty
            // 
            ChooseDifficulty.AutoSize = true;
            ChooseDifficulty.Location = new Point(201, 96);
            ChooseDifficulty.Name = "ChooseDifficulty";
            ChooseDifficulty.Size = new Size(97, 15);
            ChooseDifficulty.TabIndex = 6;
            ChooseDifficulty.Text = "Choose difficulty";
            ChooseDifficulty.Visible = false;
            ChooseDifficulty.Click += label1_Click;
            // 
            // labelLive
            // 
            labelLive.AutoSize = true;
            labelLive.Location = new Point(52, 9);
            labelLive.Name = "labelLive";
            labelLive.Size = new Size(13, 15);
            labelLive.TabIndex = 7;
            labelLive.Text = "7";
            labelLive.Visible = false;
            labelLive.Click += labelLive_Click;
            // 
            // labelHiddenNumber
            // 
            labelHiddenNumber.AutoSize = true;
            labelHiddenNumber.Location = new Point(238, 9);
            labelHiddenNumber.Name = "labelHiddenNumber";
            labelHiddenNumber.Size = new Size(22, 15);
            labelHiddenNumber.TabIndex = 8;
            labelHiddenNumber.Text = "???";
            labelHiddenNumber.Visible = false;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(12, 331);
            textBoxNumber.Multiline = true;
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(109, 20);
            textBoxNumber.TabIndex = 9;
            textBoxNumber.Visible = false;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(127, 328);
            btnSend.Name = "btnSend";
            btnSend.RightToLeft = RightToLeft.No;
            btnSend.Size = new Size(41, 23);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.TextAlign = ContentAlignment.MiddleLeft;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Visible = false;
            btnSend.Click += btnSend_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(266, 9);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 11;
            labelResult.Visible = false;
            // 
            // labelTextLive
            // 
            labelTextLive.AutoSize = true;
            labelTextLive.Location = new Point(0, 9);
            labelTextLive.Name = "labelTextLive";
            labelTextLive.Size = new Size(55, 15);
            labelTextLive.TabIndex = 12;
            labelTextLive.Text = "Your live:";
            labelTextLive.Visible = false;
            labelTextLive.Click += labelTextLive_Click;
            // 
            // labelBigOrSmall
            // 
            labelBigOrSmall.AutoSize = true;
            labelBigOrSmall.Location = new Point(17, 293);
            labelBigOrSmall.Name = "labelBigOrSmall";
            labelBigOrSmall.Size = new Size(0, 15);
            labelBigOrSmall.TabIndex = 13;
            labelBigOrSmall.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 363);
            Controls.Add(labelBigOrSmall);
            Controls.Add(labelTextLive);
            Controls.Add(labelResult);
            Controls.Add(btnSend);
            Controls.Add(textBoxNumber);
            Controls.Add(labelHiddenNumber);
            Controls.Add(labelLive);
            Controls.Add(ChooseDifficulty);
            Controls.Add(btnHard);
            Controls.Add(btnMedium);
            Controls.Add(btnEasy);
            Controls.Add(btnExit);
            Controls.Add(btnRecords);
            Controls.Add(btnStartGame);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartGame;
        private Button btnRecords;
        private Button btnExit;
        private Button btnEasy;
        private Button btnMedium;
        private Button btnHard;
        private Label ChooseDifficulty;
        private Label labelLive;
        private Label labelHiddenNumber;
        private TextBox textBoxNumber;
        private Button btnSend;
        private Label labelResult;
        private Label labelTextLive;
        private Label labelBigOrSmall;
    }
}
