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
            try
            {
                SaveAfterExit();
            }
            catch (Exception)
            {

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
            btnEasyRecord = new Button();
            btnMediumRecord = new Button();
            btnHardRecord = new Button();
            labelMaximumScore = new Label();
            labelMaximumStreak = new Label();
            labelAttempts = new Label();
            labelWin = new Label();
            labelLoss = new Label();
            labelWinRate = new Label();
            labelRecordDifficult = new Label();
            btnContinue = new Button();
            btnContinueEasy = new Button();
            btnContinueMedium = new Button();
            btnContinueHard = new Button();
            panelSaveEasy = new Panel();
            labelLiveEasy = new Label();
            labelStreakEasy = new Label();
            labelScoreEasy = new Label();
            panelSaveMedium = new Panel();
            labelLiveMedium = new Label();
            labelStreakMedium = new Label();
            labelScoreMedium = new Label();
            panelSaveHard = new Panel();
            labelLiveHard = new Label();
            labelStreakHard = new Label();
            labelScoreHard = new Label();
            panelSaveEasy.SuspendLayout();
            panelSaveMedium.SuspendLayout();
            panelSaveHard.SuspendLayout();
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
            btnRecords.Click += btnRecords_Click;
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
            labelBigOrSmall.Location = new Point(9, 91);
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
            btnChangeDifficulty.Location = new Point(197, 172);
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
            labelTxtDifficult.Location = new Point(364, 0);
            labelTxtDifficult.Name = "labelTxtDifficult";
            labelTxtDifficult.Size = new Size(89, 15);
            labelTxtDifficult.TabIndex = 23;
            labelTxtDifficult.Text = "labelTxtDifficult";
            labelTxtDifficult.Visible = false;
            // 
            // btnBTM
            // 
            btnBTM.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBTM.Location = new Point(364, 357);
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
            labelTxtWelcome.Location = new Point(-6, 39);
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
            labelTxtNameGame.Location = new Point(12, 118);
            labelTxtNameGame.Name = "labelTxtNameGame";
            labelTxtNameGame.Size = new Size(421, 65);
            labelTxtNameGame.TabIndex = 26;
            labelTxtNameGame.Text = "Guess the Number";
            labelTxtNameGame.Visible = false;
            // 
            // labelTxtTips
            // 
            labelTxtTips.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelTxtTips.AutoSize = true;
            labelTxtTips.Location = new Point(0, 361);
            labelTxtTips.Name = "labelTxtTips";
            labelTxtTips.Size = new Size(196, 15);
            labelTxtTips.TabIndex = 27;
            labelTxtTips.Text = "Tips(hidden number in range 1-100)";
            labelTxtTips.Visible = false;
            // 
            // btnEasyRecord
            // 
            btnEasyRecord.Location = new Point(0, 15);
            btnEasyRecord.Name = "btnEasyRecord";
            btnEasyRecord.Size = new Size(75, 23);
            btnEasyRecord.TabIndex = 28;
            btnEasyRecord.Text = "Easy";
            btnEasyRecord.UseVisualStyleBackColor = true;
            btnEasyRecord.Visible = false;
            btnEasyRecord.Click += btnEasyRecord_Click;
            // 
            // btnMediumRecord
            // 
            btnMediumRecord.Location = new Point(192, 15);
            btnMediumRecord.Name = "btnMediumRecord";
            btnMediumRecord.Size = new Size(75, 23);
            btnMediumRecord.TabIndex = 29;
            btnMediumRecord.Text = "Medium";
            btnMediumRecord.UseVisualStyleBackColor = true;
            btnMediumRecord.Visible = false;
            btnMediumRecord.Click += btnEasyRecord_Click;
            // 
            // btnHardRecord
            // 
            btnHardRecord.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHardRecord.Location = new Point(378, 15);
            btnHardRecord.Name = "btnHardRecord";
            btnHardRecord.Size = new Size(75, 23);
            btnHardRecord.TabIndex = 30;
            btnHardRecord.Text = "Hard";
            btnHardRecord.UseVisualStyleBackColor = true;
            btnHardRecord.Visible = false;
            btnHardRecord.Click += btnEasyRecord_Click;
            // 
            // labelMaximumScore
            // 
            labelMaximumScore.AutoSize = true;
            labelMaximumScore.Location = new Point(0, 91);
            labelMaximumScore.Name = "labelMaximumScore";
            labelMaximumScore.Size = new Size(99, 15);
            labelMaximumScore.TabIndex = 31;
            labelMaximumScore.Text = "Maximum score: ";
            labelMaximumScore.Visible = false;
            // 
            // labelMaximumStreak
            // 
            labelMaximumStreak.AutoSize = true;
            labelMaximumStreak.Location = new Point(0, 106);
            labelMaximumStreak.Name = "labelMaximumStreak";
            labelMaximumStreak.Size = new Size(102, 15);
            labelMaximumStreak.TabIndex = 32;
            labelMaximumStreak.Text = "Maximum streak: ";
            labelMaximumStreak.Visible = false;
            // 
            // labelAttempts
            // 
            labelAttempts.AutoSize = true;
            labelAttempts.Location = new Point(0, 166);
            labelAttempts.Name = "labelAttempts";
            labelAttempts.Size = new Size(130, 15);
            labelAttempts.TabIndex = 33;
            labelAttempts.Text = "Attempts  all  the time: ";
            labelAttempts.Visible = false;
            // 
            // labelWin
            // 
            labelWin.AutoSize = true;
            labelWin.Location = new Point(0, 121);
            labelWin.Name = "labelWin";
            labelWin.Size = new Size(31, 15);
            labelWin.TabIndex = 34;
            labelWin.Text = "Win:";
            labelWin.Visible = false;
            // 
            // labelLoss
            // 
            labelLoss.AutoSize = true;
            labelLoss.Location = new Point(0, 136);
            labelLoss.Name = "labelLoss";
            labelLoss.Size = new Size(30, 15);
            labelLoss.TabIndex = 35;
            labelLoss.Text = "Loss";
            labelLoss.Visible = false;
            // 
            // labelWinRate
            // 
            labelWinRate.AutoSize = true;
            labelWinRate.Location = new Point(0, 151);
            labelWinRate.Name = "labelWinRate";
            labelWinRate.Size = new Size(54, 15);
            labelWinRate.TabIndex = 36;
            labelWinRate.Text = "Win rate:";
            labelWinRate.Visible = false;
            // 
            // labelRecordDifficult
            // 
            labelRecordDifficult.AutoSize = true;
            labelRecordDifficult.Location = new Point(0, 73);
            labelRecordDifficult.Name = "labelRecordDifficult";
            labelRecordDifficult.Size = new Size(49, 15);
            labelRecordDifficult.TabIndex = 37;
            labelRecordDifficult.Text = "Difficult";
            labelRecordDifficult.Visible = false;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(214, 122);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(75, 23);
            btnContinue.TabIndex = 38;
            btnContinue.Text = "Continue";
            btnContinue.TextAlign = ContentAlignment.MiddleRight;
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Visible = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnContinueEasy
            // 
            btnContinueEasy.Location = new Point(68, 53);
            btnContinueEasy.Name = "btnContinueEasy";
            btnContinueEasy.Size = new Size(75, 23);
            btnContinueEasy.TabIndex = 39;
            btnContinueEasy.Text = "Easy";
            btnContinueEasy.UseVisualStyleBackColor = true;
            btnContinueEasy.Visible = false;
            btnContinueEasy.Click += btnContinueEasy_Click;
            // 
            // btnContinueMedium
            // 
            btnContinueMedium.Location = new Point(198, 53);
            btnContinueMedium.Name = "btnContinueMedium";
            btnContinueMedium.Size = new Size(75, 23);
            btnContinueMedium.TabIndex = 40;
            btnContinueMedium.Text = "Medium";
            btnContinueMedium.UseVisualStyleBackColor = true;
            btnContinueMedium.Visible = false;
            btnContinueMedium.Click += btnContinueMedium_Click;
            // 
            // btnContinueHard
            // 
            btnContinueHard.Location = new Point(328, 53);
            btnContinueHard.Name = "btnContinueHard";
            btnContinueHard.Size = new Size(75, 23);
            btnContinueHard.TabIndex = 41;
            btnContinueHard.Text = "Hard";
            btnContinueHard.UseVisualStyleBackColor = true;
            btnContinueHard.Visible = false;
            btnContinueHard.Click += btnContinueHard_Click;
            // 
            // panelSaveEasy
            // 
            panelSaveEasy.Controls.Add(labelLiveEasy);
            panelSaveEasy.Controls.Add(labelStreakEasy);
            panelSaveEasy.Controls.Add(labelScoreEasy);
            panelSaveEasy.Location = new Point(68, 93);
            panelSaveEasy.Name = "panelSaveEasy";
            panelSaveEasy.Size = new Size(75, 54);
            panelSaveEasy.TabIndex = 42;
            panelSaveEasy.Visible = false;
            // 
            // labelLiveEasy
            // 
            labelLiveEasy.AutoSize = true;
            labelLiveEasy.Location = new Point(0, 27);
            labelLiveEasy.Name = "labelLiveEasy";
            labelLiveEasy.Size = new Size(76, 15);
            labelLiveEasy.TabIndex = 2;
            labelLiveEasy.Text = "labelLiveEasy";
            // 
            // labelStreakEasy
            // 
            labelStreakEasy.AutoSize = true;
            labelStreakEasy.Location = new Point(0, 15);
            labelStreakEasy.Name = "labelStreakEasy";
            labelStreakEasy.Size = new Size(87, 15);
            labelStreakEasy.TabIndex = 1;
            labelStreakEasy.Text = "labelStreakEasy";
            // 
            // labelScoreEasy
            // 
            labelScoreEasy.AutoSize = true;
            labelScoreEasy.Location = new Point(0, 0);
            labelScoreEasy.Name = "labelScoreEasy";
            labelScoreEasy.Size = new Size(84, 15);
            labelScoreEasy.TabIndex = 0;
            labelScoreEasy.Text = "labelScoreEasy";
            // 
            // panelSaveMedium
            // 
            panelSaveMedium.Controls.Add(labelLiveMedium);
            panelSaveMedium.Controls.Add(labelStreakMedium);
            panelSaveMedium.Controls.Add(labelScoreMedium);
            panelSaveMedium.Location = new Point(198, 91);
            panelSaveMedium.Name = "panelSaveMedium";
            panelSaveMedium.Size = new Size(75, 54);
            panelSaveMedium.TabIndex = 43;
            panelSaveMedium.Visible = false;
            // 
            // labelLiveMedium
            // 
            labelLiveMedium.AutoSize = true;
            labelLiveMedium.Location = new Point(0, 27);
            labelLiveMedium.Name = "labelLiveMedium";
            labelLiveMedium.Size = new Size(98, 15);
            labelLiveMedium.TabIndex = 2;
            labelLiveMedium.Text = "labelLiveMedium";
            // 
            // labelStreakMedium
            // 
            labelStreakMedium.AutoSize = true;
            labelStreakMedium.Location = new Point(0, 15);
            labelStreakMedium.Name = "labelStreakMedium";
            labelStreakMedium.Size = new Size(109, 15);
            labelStreakMedium.TabIndex = 1;
            labelStreakMedium.Text = "labelStreakMedium";
            // 
            // labelScoreMedium
            // 
            labelScoreMedium.AutoSize = true;
            labelScoreMedium.Location = new Point(0, 0);
            labelScoreMedium.Name = "labelScoreMedium";
            labelScoreMedium.Size = new Size(106, 15);
            labelScoreMedium.TabIndex = 0;
            labelScoreMedium.Text = "labelScoreMedium";
            // 
            // panelSaveHard
            // 
            panelSaveHard.Controls.Add(labelLiveHard);
            panelSaveHard.Controls.Add(labelStreakHard);
            panelSaveHard.Controls.Add(labelScoreHard);
            panelSaveHard.Location = new Point(328, 93);
            panelSaveHard.Name = "panelSaveHard";
            panelSaveHard.Size = new Size(75, 54);
            panelSaveHard.TabIndex = 44;
            panelSaveHard.Visible = false;
            // 
            // labelLiveHard
            // 
            labelLiveHard.AutoSize = true;
            labelLiveHard.Location = new Point(0, 27);
            labelLiveHard.Name = "labelLiveHard";
            labelLiveHard.Size = new Size(79, 15);
            labelLiveHard.TabIndex = 2;
            labelLiveHard.Text = "labelLiveHard";
            // 
            // labelStreakHard
            // 
            labelStreakHard.AutoSize = true;
            labelStreakHard.Location = new Point(0, 15);
            labelStreakHard.Name = "labelStreakHard";
            labelStreakHard.Size = new Size(90, 15);
            labelStreakHard.TabIndex = 1;
            labelStreakHard.Text = "labelStreakHard";
            // 
            // labelScoreHard
            // 
            labelScoreHard.AutoSize = true;
            labelScoreHard.Location = new Point(0, 0);
            labelScoreHard.Name = "labelScoreHard";
            labelScoreHard.Size = new Size(87, 15);
            labelScoreHard.TabIndex = 0;
            labelScoreHard.Text = "labelScoreHard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 381);
            Controls.Add(panelSaveHard);
            Controls.Add(panelSaveMedium);
            Controls.Add(panelSaveEasy);
            Controls.Add(btnContinueHard);
            Controls.Add(btnContinueMedium);
            Controls.Add(btnContinueEasy);
            Controls.Add(btnContinue);
            Controls.Add(labelRecordDifficult);
            Controls.Add(labelWinRate);
            Controls.Add(labelLoss);
            Controls.Add(labelWin);
            Controls.Add(labelAttempts);
            Controls.Add(labelMaximumStreak);
            Controls.Add(labelMaximumScore);
            Controls.Add(btnHardRecord);
            Controls.Add(btnMediumRecord);
            Controls.Add(btnEasyRecord);
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
            panelSaveEasy.ResumeLayout(false);
            panelSaveEasy.PerformLayout();
            panelSaveMedium.ResumeLayout(false);
            panelSaveMedium.PerformLayout();
            panelSaveHard.ResumeLayout(false);
            panelSaveHard.PerformLayout();
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
        private Button btnEasyRecord;
        private Button btnMediumRecord;
        private Button btnHardRecord;
        private Label labelMaximumScore;
        private Label labelMaximumStreak;
        private Label labelAttempts;
        private Label labelWin;
        private Label labelLoss;
        private Label labelWinRate;
        private Label labelRecordDifficult;
        private Button btnContinue;
        private Button btnContinueEasy;
        private Button btnContinueMedium;
        private Button btnContinueHard;
        private Panel panelSaveEasy;
        private Label labelScoreEasy;
        private Label labelLiveEasy;
        private Label labelStreakEasy;
        private Panel panelSaveMedium;
        private Label labelLiveMedium;
        private Label labelStreakMedium;
        private Label labelScoreMedium;
        private Panel panelSaveHard;
        private Label labelLiveHard;
        private Label labelStreakHard;
        private Label labelScoreHard;
    }
}
