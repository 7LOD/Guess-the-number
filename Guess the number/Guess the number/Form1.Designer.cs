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
            textBoxNumber = new TextBox();
            btnSend = new Button();
            labelStreak = new Label();
            labelTextLive = new Label();
            labelBigOrSmall = new Label();
            btnTryAgain = new Button();
            btnChangeDifficulty = new Button();
            btnBackToMenu = new Button();
            label = new Label();
            labelIsNumber = new Label();
            labelTxtIncorrectNum = new Label();
            labelTxtScore = new Label();
            labelTxtGetScore = new Label();
            labelTxtDifficult = new Label();
            btnBTM = new Button();
            labelTxtWelcome = new Label();
            labelTxtNameGame = new Label();
            labelTxtTips = new Label();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(214, 147);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(75, 23);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Visible = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnRecords
            // 
            btnRecords.Location = new Point(214, 171);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(75, 23);
            btnRecords.TabIndex = 1;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Visible = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(214, 196);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnEasy
            // 
            btnEasy.Location = new Point(214, 147);
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
            btnMedium.Location = new Point(214, 171);
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
            btnHard.Location = new Point(214, 196);
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
            ChooseDifficulty.Location = new Point(201, 122);
            ChooseDifficulty.Name = "ChooseDifficulty";
            ChooseDifficulty.Size = new Size(97, 15);
            ChooseDifficulty.TabIndex = 6;
            ChooseDifficulty.Text = "Choose difficulty";
            ChooseDifficulty.Visible = false;
            // 
            // labelLive
            // 
            labelLive.AutoSize = true;
            labelLive.Location = new Point(52, 0);
            labelLive.Name = "labelLive";
            labelLive.Size = new Size(13, 15);
            labelLive.TabIndex = 7;
            labelLive.Text = "7";
            labelLive.Visible = false;
            // 
            // textBoxNumber
            // 
            textBoxNumber.AutoCompleteMode = AutoCompleteMode.Append;
            textBoxNumber.Location = new Point(214, 290);
            textBoxNumber.Multiline = true;
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(53, 20);
            textBoxNumber.TabIndex = 9;
            textBoxNumber.Tag = "";
            textBoxNumber.Visible = false;
            textBoxNumber.KeyDown += textBoxNumber_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(214, 316);
            btnSend.Name = "btnSend";
            btnSend.RightToLeft = RightToLeft.No;
            btnSend.Size = new Size(53, 23);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.TextAlign = ContentAlignment.MiddleLeft;
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Visible = false;
            btnSend.Click += btnSend_Click;
            // 
            // labelStreak
            // 
            labelStreak.AutoSize = true;
            labelStreak.Location = new Point(201, 9);
            labelStreak.Name = "labelStreak";
            labelStreak.Size = new Size(97, 15);
            labelStreak.TabIndex = 11;
            labelStreak.Text = "You're streak is: 0";
            labelStreak.Visible = false;
            // 
            // labelTextLive
            // 
            labelTextLive.AutoSize = true;
            labelTextLive.Location = new Point(0, 0);
            labelTextLive.Name = "labelTextLive";
            labelTextLive.Size = new Size(55, 15);
            labelTextLive.TabIndex = 12;
            labelTextLive.Text = "Your live:";
            labelTextLive.Visible = false;
            // 
            // labelBigOrSmall
            // 
            labelBigOrSmall.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelBigOrSmall.AutoSize = true;
            labelBigOrSmall.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBigOrSmall.Location = new Point(10, 91);
            labelBigOrSmall.Margin = new Padding(0);
            labelBigOrSmall.Name = "labelBigOrSmall";
            labelBigOrSmall.RightToLeft = RightToLeft.No;
            labelBigOrSmall.Size = new Size(0, 128);
            labelBigOrSmall.TabIndex = 13;
            labelBigOrSmall.TextAlign = ContentAlignment.MiddleCenter;
            labelBigOrSmall.Visible = false;
            // 
            // btnTryAgain
            // 
            btnTryAgain.Location = new Point(214, 147);
            btnTryAgain.Name = "btnTryAgain";
            btnTryAgain.Size = new Size(75, 23);
            btnTryAgain.TabIndex = 14;
            btnTryAgain.Text = "Try again";
            btnTryAgain.UseVisualStyleBackColor = true;
            btnTryAgain.Visible = false;
            btnTryAgain.Click += btnTryAgain_Click;
            // 
            // btnChangeDifficulty
            // 
            btnChangeDifficulty.Location = new Point(198, 171);
            btnChangeDifficulty.Name = "btnChangeDifficulty";
            btnChangeDifficulty.Size = new Size(107, 23);
            btnChangeDifficulty.TabIndex = 15;
            btnChangeDifficulty.Text = "Change difficulty";
            btnChangeDifficulty.UseVisualStyleBackColor = true;
            btnChangeDifficulty.Visible = false;
            btnChangeDifficulty.Click += btnChangeDifficulty_Click;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Location = new Point(208, 196);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(88, 23);
            btnBackToMenu.TabIndex = 16;
            btnBackToMenu.Text = "Back to menu";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Visible = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.Location = new Point(0, 9);
            label.Name = "label";
            label.Size = new Size(0, 128);
            label.TabIndex = 17;
            label.Visible = false;
            // 
            // labelIsNumber
            // 
            labelIsNumber.AutoSize = true;
            labelIsNumber.Location = new Point(232, 357);
            labelIsNumber.Name = "labelIsNumber";
            labelIsNumber.Size = new Size(13, 15);
            labelIsNumber.TabIndex = 19;
            labelIsNumber.Text = "5";
            labelIsNumber.Visible = false;
            // 
            // labelTxtIncorrectNum
            // 
            labelTxtIncorrectNum.AutoSize = true;
            labelTxtIncorrectNum.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTxtIncorrectNum.Location = new Point(40, 53);
            labelTxtIncorrectNum.Name = "labelTxtIncorrectNum";
            labelTxtIncorrectNum.Size = new Size(0, 40);
            labelTxtIncorrectNum.TabIndex = 20;
            labelTxtIncorrectNum.Visible = false;
            // 
            // labelTxtScore
            // 
            labelTxtScore.AutoSize = true;
            labelTxtScore.Location = new Point(0, 15);
            labelTxtScore.Name = "labelTxtScore";
            labelTxtScore.Size = new Size(48, 15);
            labelTxtScore.TabIndex = 21;
            labelTxtScore.Text = "Score: 0";
            labelTxtScore.Visible = false;
            // 
            // labelTxtGetScore
            // 
            labelTxtGetScore.AutoSize = true;
            labelTxtGetScore.Location = new Point(169, 324);
            labelTxtGetScore.Name = "labelTxtGetScore";
            labelTxtGetScore.Size = new Size(62, 15);
            labelTxtGetScore.TabIndex = 22;
            labelTxtGetScore.Text = "Get score: ";
            labelTxtGetScore.Visible = false;
            // 
            // labelTxtDifficult
            // 
            labelTxtDifficult.AutoSize = true;
            labelTxtDifficult.Dock = DockStyle.Right;
            labelTxtDifficult.Location = new Point(365, 0);
            labelTxtDifficult.Name = "labelTxtDifficult";
            labelTxtDifficult.Size = new Size(89, 15);
            labelTxtDifficult.TabIndex = 23;
            labelTxtDifficult.Text = "labelTxtDifficult";
            labelTxtDifficult.Visible = false;
            // 
            // btnBTM
            // 
            btnBTM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBTM.Location = new Point(365, 357);
            btnBTM.Name = "btnBTM";
            btnBTM.Size = new Size(88, 23);
            btnBTM.TabIndex = 24;
            btnBTM.Text = "Back to menu";
            btnBTM.UseVisualStyleBackColor = true;
            btnBTM.Visible = false;
            btnBTM.Click += btnBTM_Click;
            // 
            // labelTxtWelcome
            // 
            labelTxtWelcome.AutoSize = true;
            labelTxtWelcome.Font = new Font("Segoe UI", 45.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTxtWelcome.Location = new Point(-12, 36);
            labelTxtWelcome.Name = "labelTxtWelcome";
            labelTxtWelcome.Size = new Size(475, 82);
            labelTxtWelcome.TabIndex = 25;
            labelTxtWelcome.Text = "Welcome in the ";
            labelTxtWelcome.Visible = false;
            // 
            // labelTxtNameGame
            // 
            labelTxtNameGame.AutoSize = true;
            labelTxtNameGame.Font = new Font("Segoe UI", 36F, FontStyle.Underline, GraphicsUnit.Point, 204);
            labelTxtNameGame.Location = new Point(10, 122);
            labelTxtNameGame.Name = "labelTxtNameGame";
            labelTxtNameGame.Size = new Size(421, 65);
            labelTxtNameGame.TabIndex = 26;
            labelTxtNameGame.Text = "Guess the Number";
            labelTxtNameGame.Visible = false;
            // 
            // labelTxtTips
            // 
            labelTxtTips.AutoSize = true;
            labelTxtTips.Location = new Point(0, 361);
            labelTxtTips.Name = "labelTxtTips";
            labelTxtTips.Size = new Size(196, 15);
            labelTxtTips.TabIndex = 27;
            labelTxtTips.Text = "Tips(hidden number in range 1-100)";
            labelTxtTips.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 381);
            Controls.Add(labelTxtTips);
            Controls.Add(labelTxtNameGame);
            Controls.Add(labelTxtWelcome);
            Controls.Add(btnBTM);
            Controls.Add(labelTxtDifficult);
            Controls.Add(labelTxtGetScore);
            Controls.Add(labelTxtScore);
            Controls.Add(labelTxtIncorrectNum);
            Controls.Add(labelIsNumber);
            Controls.Add(label);
            Controls.Add(btnBackToMenu);
            Controls.Add(btnChangeDifficulty);
            Controls.Add(btnTryAgain);
            Controls.Add(labelBigOrSmall);
            Controls.Add(labelTextLive);
            Controls.Add(labelStreak);
            Controls.Add(btnSend);
            Controls.Add(textBoxNumber);
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
            Load += Form1_Load;
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
        private TextBox textBoxNumber;
        private Button btnSend;
        private Label labelStreak;
        private Label labelTextLive;
        private Label labelBigOrSmall;
        private Button btnTryAgain;
        private Button btnChangeDifficulty;
        private Button btnBackToMenu;
        private Label label;
        private Label labelIsNumber;
        private Label labelTxtIncorrectNum;
        private Label labelTxtScore;
        private Label labelTxtGetScore;
        private Label labelTxtDifficult;
        private Button btnBTM;
        private Label labelTxtWelcome;
        private Label labelTxtNameGame;
        private Label labelTxtTips;
    }
}
