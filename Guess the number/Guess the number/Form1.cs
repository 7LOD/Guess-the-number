using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using Newtonsoft.Json;
using Guess_the_number;
using System;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        private List<Control> —ontrolIsToCenter;
        SaveData saveData = new SaveData();
        Game game = new Game();
        SaveDataAfterExit saveInGame = new SaveDataAfterExit();
        DifficultyData difficultyData;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.Shown += MainForm_Shown;
        }
        private void InitializeCentering()
        {
            —ontrolIsToCenter = new List<Control>
            {
                btnStartGame, btnRecords, btnExit,
                btnEasy, btnMedium, btnHard ,ChooseDifficulty,
                textBoxNumber, btnSend, labelStreak, labelBigOrSmall,
                btnTryAgain, btnChangeDifficulty, btnBackToMenu,
                label, labelIsNumber, labelTxtIncorrectNum,
                labelTxtGetScore,labelTxtWelcome,labelTxtNameGame,
                btnMediumRecord, btnContinue, btnContinueMedium,
            };
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (—ontrolIsToCenter != null)
            {
                AllCenter();
                ChangeLocation();
            }
        }

        private void AllCenter()
        {
            foreach (var control in —ontrolIsToCenter)
            {
                control.Left = (this.ClientSize.Width - control.Width) / 2;
            }
        }
        private void ChangeLocation()
        {
            btnContinueHard.Left = (this.ClientSize.Width - btnContinueMedium.Width + 260) / 2;
            btnContinueEasy.Left = (this.ClientSize.Width - btnContinueMedium.Width - 260) / 2;
            panelSaveEasy.Left = (this.ClientSize.Width - panelSaveMedium.Width - 240) / 2;
            panelSaveHard.Left = (this.ClientSize.Width - panelSaveMedium.Width + 280) / 2;
        }
        private void ShowContinue(bool vision = true)
        {
            SetVisibility(new Dictionary<Control, bool>
            {
                { btnContinue, !vision },
                { btnExit, !vision },
                { btnRecords, !vision },
                { btnStartGame, !vision },
                { labelTxtTips, !vision },

                { btnContinueEasy, vision },
                { btnContinueMedium, vision },
                { btnContinueHard, vision },
                { btnBTM, vision },
            });
            ShowSaves(Game.MultipleScore.Easy.ToString(), panelSaveEasy, labelScoreEasy, labelStreakEasy, labelLiveEasy);
            ShowSaves(Game.MultipleScore.Medium.ToString(), panelSaveMedium, labelScoreMedium, labelStreakMedium, labelLiveMedium);
            ShowSaves(Game.MultipleScore.Hard.ToString(), panelSaveHard, labelScoreHard, labelStreakHard, labelLiveHard);
            ChangeLocation();
        }
        private void ShowSaves(string difficulty, Panel panel, Label labelScore, Label labelStreak, Label labelLive) 
        {
            if (difficultyData.TimeSave.ContainsKey(difficulty))
            {
                labelScore.Text = "Score = " + difficultyData.TimeSave[difficulty].Score.ToString();
                labelStreak.Text = "Streak = " + difficultyData.TimeSave[difficulty].Streak.ToString();
                labelLive.Text = "Live = " + difficultyData.TimeSave[difficulty].Live.ToString();
            }
            else
            {
                labelScore.Text = "Score = " + 0;
                labelStreak.Text = "Streak = " + 0;
                labelLive.Text = "Live = " + 0;
            }
            panel.Visible = true;
        }
        private void Record(bool record = true)
        {

            SetVisibility(new Dictionary<Control, bool>
            {

                { btnExit, !record },
                { btnRecords, !record },
                { btnStartGame, !record },
                { labelTxtTips, !record },
                { labelStreak, !record },
                { btnContinue, !record },

                { btnHardRecord, record },
                { btnMediumRecord, record },
                { btnEasyRecord, record },
                { btnBTM, record },
                { labelMaximumScore, record },
                { labelMaximumStreak, record },
                { labelWin, record },
                { labelLoss, record },
                { labelWinRate, record },
                { labelAttempts, record },
                { labelRecordDifficult, record },
            });
        }

        private void StartMenu(bool startMenu = true)
        {
            SetVisibility(new Dictionary<Control, bool>
            {
                { label, !startMenu },
                { labelIsNumber, !startMenu },
                { btnBackToMenu, !startMenu },
                { btnChangeDifficulty, !startMenu },
                { btnTryAgain, !startMenu },
                { labelTxtGetScore, !startMenu },
                { ChooseDifficulty, !startMenu },
                { btnEasy, !startMenu },
                { btnMedium, !startMenu },
                { btnHard, !startMenu },
                { btnBTM, !startMenu },
                { labelTextLive, !startMenu },
                { labelLive, !startMenu },
                { textBoxNumber, !startMenu },
                { btnSend, !startMenu },
                { labelBigOrSmall, !startMenu },
                { labelTxtIncorrectNum, !startMenu },
                { labelTxtScore, !startMenu },
                { labelTxtDifficult, !startMenu },
                { btnHardRecord, !startMenu },
                { btnMediumRecord, !startMenu },
                { btnEasyRecord, !startMenu },
                { labelStreak, !startMenu },
                { labelMaximumScore, !startMenu },
                { labelMaximumStreak, !startMenu },
                { labelWin, !startMenu },
                { labelLoss, !startMenu },
                { labelWinRate, !startMenu },
                { labelAttempts, !startMenu },
                { labelRecordDifficult, !startMenu },
                { btnContinueEasy, !startMenu },
                { btnContinueMedium, !startMenu },
                { btnContinueHard, !startMenu },
                { panelSaveEasy, !startMenu },
                { panelSaveMedium, !startMenu },
                { panelSaveHard, !startMenu },

                { btnExit, startMenu },
                { btnRecords, startMenu },
                { btnStartGame, startMenu },
            });
            if (difficultyData.TimeSave.Count > 0)
                btnContinue.Visible = true;
            ClearField(labelBigOrSmall);

        }

        private void Difficulty(bool chooseDifficulty = true)
        {
            SetVisibility(new Dictionary<Control, bool>
        {
            { btnExit, !chooseDifficulty },
            { btnRecords, !chooseDifficulty },
            { btnStartGame, !chooseDifficulty },
            { label, !chooseDifficulty },
            { btnBackToMenu, !chooseDifficulty },
            { btnChangeDifficulty, !chooseDifficulty },
            { btnTryAgain, !chooseDifficulty },
            { labelIsNumber, !chooseDifficulty },
            { labelTxtGetScore,!chooseDifficulty },
            { labelTxtTips, !chooseDifficulty },
            { btnContinue, !chooseDifficulty },


            { ChooseDifficulty, chooseDifficulty },
            { btnEasy, chooseDifficulty },
            { btnMedium, chooseDifficulty },
            { btnHard, chooseDifficulty },
            { btnBTM, chooseDifficulty },
        });

        }

        public void UIGamePlay(bool control = true, bool continueGame = false)
        {
            SetVisibility(new Dictionary<Control, bool>
            {
                { ChooseDifficulty, !control },
                { btnEasy, !control },
                { btnMedium, !control },
                { btnHard, !control },
                { label, !control },
                { btnBackToMenu, !control },
                { btnChangeDifficulty, !control },
                { btnTryAgain, !control },
                { labelIsNumber, !control },
                { labelTxtGetScore, !control },
                { btnContinue, !control },
                { btnContinueEasy, !control },
                { btnContinueMedium, !control },
                { btnContinueHard, !control },
                { panelSaveEasy, !control },
                { panelSaveMedium, !control },
                { panelSaveHard, !control },

                { labelTextLive, control },
                { labelLive, control },
                { textBoxNumber, control },
                { btnSend, control },
                { labelBigOrSmall, control },
                { labelTxtIncorrectNum, control },
                { labelTxtScore, control },
                { labelTxtDifficult, control },
                { btnBTM, control },
                { labelStreak, control },
            });
            GamePlay(continueGame);
        }
        public void GamePlay(bool continueGame = false)
        {
            {
                labelLive.Text = Convert.ToString(game.Live);
                if (continueGame)
                {
                    game.HiddenNumber = saveInGame.HideNumber;
                }
                else
                {
                    game.Live = game._Live;
                    game.HiddenNumber = (uint)Game.random.Next(1, 100);
                    labelLive.Text = game.Live.ToString();
                }
                UITextInGamePlayLabel();
                if (continueGame || saveInGame.Live == 0)
                    SaveAfterMove();
            }
        }
        public void UITextInGamePlayLabel()
        {
            labelStreak.Text = $"You're streak is: {Convert.ToString(saveInGame.Streak)}";
            labelTxtScore.Text = $"Score: {saveInGame.Score}";
            labelBigOrSmall.Text = saveInGame.Tips;
            CenterLabel(labelBigOrSmall);
        }

        private void AfterGame(bool result = true)
        {
            ClearField(textBoxNumber);
            CenterLabel(label);
            ClearField(labelBigOrSmall);
            SetVisibility(new Dictionary<Control, bool>
            {
                { labelTextLive, !result },
                { labelLive, !result },
                { textBoxNumber, !result },
                { btnSend, !result },
                { labelBigOrSmall, !result },
                { labelTxtIncorrectNum, !result },
                { labelTxtScore, !result },
                { labelTxtDifficult, !result },
                { btnBTM, !result },
                { btnContinue, !result },

                { label, result },
                { btnBackToMenu, result },
                { btnChangeDifficulty, result },
                { btnTryAgain, result },
                { labelIsNumber, result },
                { labelTxtGetScore, result },
            });
            labelIsNumber.Text = $"Hidden number is: {Convert.ToString(game.HiddenNumber)}";
            CenterLabel(labelIsNumber);
            game.HiddenNumber = (uint)Game.random.Next(1, 100);
        }

        private void CenterLabel(Control control)
        {
            control.Left = (this.ClientSize.Width - control.Width) / 2;
        }

        private void CheckWin(uint enteredNumber = 0)
        {
            if (!string.IsNullOrWhiteSpace(textBoxNumber.Text) && uint.TryParse(textBoxNumber.Text, out enteredNumber) && enteredNumber <= 100)
            {
                if (enteredNumber == game.HiddenNumber)
                {
                    label.Text = "You Win";
                    game.Streak += 1;
                    labelStreak.Visible = false;

                    game.Score += (Game.baseScore * (uint)game.Live) * (uint)Game.Multiple;
                    labelTxtGetScore.Text = $"Get Score: {(Game.baseScore * (uint)game.Live) * (uint)Game.Multiple}";
                    saveInGame.Tips = "";
                    UITextInGamePlayLabel();
                    CenterLabel(labelTxtGetScore);
                    GamePlay(continueGame: true);
                    ChangeDateArterRound(Win: true);
                    UITextInGamePlayLabel();


                }
                else if (enteredNumber < game.HiddenNumber)
                {
                    saveInGame.Tips = labelBigOrSmall.Text = $"{enteredNumber} < ???";
                    ClearField(labelTxtIncorrectNum);
                    CenterLabel(labelBigOrSmall);
                    saveInGame.Live = game.Live -= 1;
                    SaveAfterMove();
                    labelLive.Text = Convert.ToString(game.Live);
                    Checkloss();
                }
                else
                {
                    saveInGame.Tips = labelBigOrSmall.Text = $"{enteredNumber} > ???";
                    ClearField(labelTxtIncorrectNum);
                    CenterLabel(labelBigOrSmall);
                    saveInGame.Live = game.Live -= 1;
                    labelLive.Text = Convert.ToString(game.Live);
                    SaveAfterMove();
                    Checkloss();
                }
            }
            else
            {
                labelTxtIncorrectNum.Text = "Please write a simple number";
                CenterLabel(labelTxtIncorrectNum);
                ClearField(textBoxNumber);
            }

        }

        private void Checkloss()
        {

            if (game.Live == 0)
            {
                game.Streak = 0;
                saveInGame.Tips = "";
                labelStreak.Text = $"You're streak is: {Convert.ToString(game.Streak)}";
                label.Text = ("You lose!");
                ClearField(labelTxtGetScore);


                ChangeDateArterRound(Win: false);
            }
            SaveRightInTheGame();
            ClearField(textBoxNumber);
        }

        private void StartGame(Game.MultipleScore difficulty, byte lives)
        {
            Game.Multiple = difficulty;
            game._Live = lives;
            labelTxtDifficult.Text = $"Difficult is: {Game.Multiple}";
            UIGamePlay();
        }
        private void ContinueGame(Game.MultipleScore difficulty, byte lives, byte standartLive)
        {
            saveInGame = new SaveDataAfterExit();
            Game.Multiple = difficulty;
            game.Live = lives;
            game._Live = standartLive;
            saveInGame.Difficulty = difficulty.ToString();
            SaveAfterStart();
            labelTxtDifficult.Text = $"Difficult is: {Game.Multiple}";
            UIGamePlay(continueGame: true);
        }

        private void SetVisibility(Dictionary<Control, bool> visibilitySetting)
        {
            foreach (var item in visibilitySetting)
            {
                item.Key.Visible = item.Value;
            }
            AllCenter();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            saveInGame.PlayerWantContinue = false;
            Difficulty();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Game.Multiple = Game.MultipleScore.Easy;
            if (Game.Multiple.ToString() != Game.MultipleScore.Easy.ToString())
                ChangeDifficult();

            saveInGame = new SaveDataAfterExit() { PlayerWantContinue = saveInGame.PlayerWantContinue };
            saveInGame.Difficulty = Game.Multiple.ToString();
            if (!difficultyData.TimeSave.ContainsKey(Game.Multiple.ToString()))
            {
                FirstSave();
                SaveRightInTheGame();
            }
            if (!saveInGame.PlayerWantContinue)
            {
                LostSave();
                SaveAfterStart();
                saveData.SaveFile(difficultyData);
            }
            else
            {
                SaveAfterStart();
                labelBigOrSmall.Text = saveInGame.Tips;
                labelBigOrSmall.Visible = true;

            }
            StartGame(Game.MultipleScore.Easy, 7);
            SaveAfterMove();


        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Game.Multiple = Game.MultipleScore.Medium;
            if (Game.Multiple.ToString() != Game.MultipleScore.Medium.ToString())
                ChangeDifficult();
            saveInGame = new SaveDataAfterExit() { PlayerWantContinue = saveInGame.PlayerWantContinue };
            saveInGame.Difficulty = Game.Multiple.ToString();

            if (!difficultyData.TimeSave.ContainsKey(Game.Multiple.ToString()))
            {
                FirstSave();
                SaveRightInTheGame();
            }
            if (!saveInGame.PlayerWantContinue)
            {
                LostSave();
                SaveAfterStart();
                saveData.SaveFile(difficultyData);
            }
            else
            {
                SaveAfterStart();
                labelBigOrSmall.Text = saveInGame.Tips;
                labelBigOrSmall.Visible = true;
            }
            StartGame(Game.MultipleScore.Medium, 6);
            SaveAfterMove();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Game.Multiple = Game.MultipleScore.Hard;
            if (Game.Multiple.ToString() != Game.MultipleScore.Hard.ToString())
                ChangeDifficult();

            saveInGame = new SaveDataAfterExit() { PlayerWantContinue = saveInGame.PlayerWantContinue };
            saveInGame.Difficulty = Game.Multiple.ToString();

            if (!difficultyData.TimeSave.ContainsKey(Game.Multiple.ToString()))
            {
                FirstSave();
                SaveRightInTheGame();
            }
            if (!saveInGame.PlayerWantContinue)
            {
                LostSave();
                SaveAfterStart();
                saveData.SaveFile(difficultyData);
            }
            else
            {
                SaveAfterStart();
                labelBigOrSmall.Text = saveInGame.Tips;
                labelBigOrSmall.Visible = true;
            }
            StartGame(Game.MultipleScore.Hard, 5);
            SaveAfterMove();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            CheckWin();
        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            UIGamePlay();
            SaveAfterMove();
        }

        private void btnChangeDifficulty_Click(object sender, EventArgs e)
        {
            saveInGame.PlayerWantContinue = true;
            Difficulty();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            GamePlay();
            SaveAfterMove();
            StartMenu();
        }

        private void textBoxNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckWin();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                StartMenu();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCentering();
            AllCenter();
        }

        private void btnBTM_Click(object sender, EventArgs e)
        {
            StartMenu();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LaunchGame();
        }

        private async void LaunchGame()
        {
            labelTxtWelcome.Visible = true;
            await Task.Delay(1000);
            labelTxtNameGame.Visible = true;
            await Task.Delay(1000);
            labelTxtTips.Visible = true;
            await Task.Delay(3000);
            labelTxtWelcome.Visible = false;
            labelTxtNameGame.Visible = false;
            btnStartGame.Visible = true;
            btnRecords.Visible = true;
            btnExit.Visible = true;
            difficultyData = saveData.LoadFile();
            if (File.Exists(SaveData.Path))
            {
                TipsLog("If you change difficulty in game you're score is reset!");
            }
            else TipsLog("Your saved file is invalid and has been deleted.");
            if (difficultyData.TimeSave.Count > 0)
                btnContinue.Visible = true;

        }

        public void FirstSave()
        {

            if (!difficultyData.TimeSave.ContainsKey(Game.Multiple.ToString()))
            {
                saveInGame.Difficulty = Game.Multiple.ToString();

                difficultyData.TimeSave.Add(Game.Multiple.ToString(), saveInGame);

                saveData.SaveFile(difficultyData);
            }
            if (!difficultyData.Difficulty.ContainsKey(Game.Multiple.ToString()))
            {
                saveData.Difficulty = Game.Multiple.ToString();

                difficultyData.Difficulty.Add(Game.Multiple.ToString(), saveData);

                saveData.SaveFile(difficultyData);
                saveData = new SaveData();
            }
        }

        public void ClearField(Control control)
        {
            control.Text = "";
        }

        public void ChangeDifficult()
        {
            saveData = new SaveData();
            game.Score = 0;
            game.Streak = 0;
            labelTxtScore.Text = $"Score: {game.Score}";
            labelStreak.Text = $"You're streak is: {Convert.ToString(game.Streak)}";
            ClearField(labelBigOrSmall);
        }

        public void SaveDataFile()
        {
            int count = 0;
            saveData = new SaveData();
            saveData.Streak = game.Streak;
            saveData.Score = game.Score;
            saveData.Difficulty = Game.Multiple.ToString();
            if (difficultyData.Difficulty.ContainsKey(saveData.Difficulty))
            {
                if (difficultyData.Difficulty[saveData.Difficulty].Streak < saveData.Streak)
                {
                    count++;
                    difficultyData.Difficulty[saveData.Difficulty].Streak = saveData.Streak;
                }
                if (difficultyData.Difficulty[saveData.Difficulty].Score < saveData.Score)
                {
                    count++;
                    difficultyData.Difficulty[saveData.Difficulty].Score = saveData.Score;
                }
                if (count > 0)
                {
                    saveData.SaveFile(difficultyData);
                }

            }
            game.Score = 0;
            game.Streak = 0;
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            Record();
        }

        private void btnEasyRecord_Click(object sender, EventArgs e)
        {
            if (sender == btnEasyRecord)
            {
                saveData.Difficulty = "Easy";
            }
            else if (sender == btnMediumRecord)
            {
                saveData.Difficulty = "Medium";
            }
            else
            {
                saveData.Difficulty = "Hard";
            }
            ShowRecord();
        }
        public void ChangeDateArterRound(bool Win)
        {
            saveData.Difficulty = Game.Multiple.ToString();
            difficultyData.Difficulty[saveData.Difficulty].Attempt++;
            if (Win)
            {
                difficultyData.Difficulty[saveData.Difficulty].Win++;
                AfterGame();
                SaveDataFile();
            }
            else
            {
                difficultyData.Difficulty[saveData.Difficulty].Loss++;
                AfterGame();
                LostSave();
            }
            difficultyData.Difficulty[saveData.Difficulty].WinRate = (float)difficultyData.Difficulty[saveData.Difficulty].Win / difficultyData.Difficulty[saveData.Difficulty].Attempt * 100;
            saveData.SaveFile(difficultyData);
        }
        public void ShowRecord()
        {
            if (!difficultyData.Difficulty.ContainsKey(saveData.Difficulty))
            {
                labelRecordDifficult.Text = "Difficult " + saveData.Difficulty.ToString() + ":";
                labelMaximumScore.Text = "Maximum score: 0";
                labelMaximumStreak.Text = "Maximum streak: 0";
                labelWinRate.Text = "Win: 0";
                labelWin.Text = "Loss: 0";
                labelLoss.Text = "Win rate: 0%";
                labelAttempts.Text = "Attempts  all  the time: 0";
            }
            else
            {
                labelRecordDifficult.Text = "Difficult " + saveData.Difficulty.ToString() + ":";
                labelMaximumScore.Text = "Maximum score: " + difficultyData.Difficulty[saveData.Difficulty].Score.ToString();
                labelMaximumStreak.Text = "Maximum streak: " + difficultyData.Difficulty[saveData.Difficulty].Streak.ToString();
                labelWin.Text = "Win: " + difficultyData.Difficulty[saveData.Difficulty].Win.ToString();
                labelLoss.Text = "Loss: " + difficultyData.Difficulty[saveData.Difficulty].Loss.ToString();
                labelWinRate.Text = "Win rate: " + difficultyData.Difficulty[saveData.Difficulty].WinRate.ToString("F2") + "%";
                labelAttempts.Text = "Attempts  all  the time: " + difficultyData.Difficulty[saveData.Difficulty].Attempt.ToString();
            }
        }
        private void SaveAfterStart()
        {
            saveInGame.Live = difficultyData.TimeSave[saveInGame.Difficulty].Live;
            saveInGame.HideNumber = difficultyData.TimeSave[saveInGame.Difficulty].HideNumber;
            saveInGame.Score = difficultyData.TimeSave[saveInGame.Difficulty].Score;
            saveInGame.Streak = difficultyData.TimeSave[saveInGame.Difficulty].Streak;
            saveInGame.Tips = difficultyData.TimeSave[saveInGame.Difficulty].Tips;

            saveInGame.Difficulty = Game.Multiple.ToString();
        }
        public void SaveAfterMove()
        {
            saveInGame.Live = game.Live;
            saveInGame.HideNumber = game.HiddenNumber;
            saveInGame.Score += game.Score;
            saveInGame.Streak += game.Streak;
            SaveRightInTheGame();

        }
        private void SaveRightInTheGame()
        {
            difficultyData.TimeSave[saveInGame.Difficulty].Streak = saveInGame.Streak;
            difficultyData.TimeSave[saveInGame.Difficulty].Score = saveInGame.Score;
            difficultyData.TimeSave[saveInGame.Difficulty].Live = saveInGame.Live;
            difficultyData.TimeSave[saveInGame.Difficulty].HideNumber = saveInGame.HideNumber;
            difficultyData.TimeSave[saveInGame.Difficulty].Tips = saveInGame.Tips;
            saveData.SaveFile(difficultyData);
        }
        private void LostSave()
        {
            difficultyData.TimeSave[Game.Multiple.ToString()].Streak = 0;
            difficultyData.TimeSave[Game.Multiple.ToString()].Live = 0;
            difficultyData.TimeSave[Game.Multiple.ToString()].Score = 0;
            difficultyData.TimeSave[Game.Multiple.ToString()].HideNumber = 0;
            difficultyData.TimeSave[saveInGame.Difficulty].Tips = saveInGame.Tips;
        }


        private void btnContinue_Click(object sender, EventArgs e)
        {
            saveInGame.PlayerWantContinue = true;
            ShowContinue();
        }
        public void TipsLog(string exception)
        {
            labelTxtTips.Text = exception;
        }

        private void btnContinueEasy_Click(object sender, EventArgs e)
        {
            ContinueGameByDifficulty(Game.MultipleScore.Easy, defaultLife: 7);
        }

        private void btnContinueMedium_Click(object sender, EventArgs e)
        {
            ContinueGameByDifficulty(Game.MultipleScore.Medium, defaultLife: 6);
        }

        private void btnContinueHard_Click(object sender, EventArgs e)
        {

            ContinueGameByDifficulty(Game.MultipleScore.Hard, defaultLife: 5);
        }
        private void ContinueGameByDifficulty(Game.MultipleScore difficulty, byte defaultLife)
        {
            try
            {
                if (difficultyData.TimeSave[difficulty.ToString()].Live > 0)
                {
                    ContinueGame(difficulty, difficultyData.TimeSave[difficulty.ToString()].Live, defaultLife);
                }
            }
            catch (Exception)
            {

            }

        }
        public void SaveAfterExit()
        {
            saveInGame.HideNumber = (uint)Game.random.Next(1, 100);
            SaveRightInTheGame();
        }
    }
}
class Game
{
    public static MultipleScore Multiple { get; set; }
    public byte Live { get; set; }
    public byte _Live { get; set; }
    public uint Score { get; set; }
    public byte Streak { get; set; }
    public uint HiddenNumber { get; set; }
    public static uint baseScore { get; } = 10;
    public static Random random = new Random();
    public enum MultipleScore
    {
        Easy = 1,
        Medium = 5,
        Hard = 20
    }
}
class SaveData
{
    public const string Path = "SaveData.json";
    private string difficulty = "Easy";
    public string Difficulty
    {
        get { return difficulty; }
        set { difficulty = value; }
    }
    private uint score = 0; //
    public uint Score
    {
        get { return score; }
        set
        {
            if (value > score)
                score = value;
        }
    }   // ÔÂÂÏÂÌÌ˚Â ‰Îˇ ÒÓı‡ÌÂÌËÂ ÂÍÓ‰Ó‚
    private uint streak = 0;   //
    public uint Streak
    {
        get { return streak; }
        set
        {
            if (value > streak)
                streak = value;
        }
    } //
    private uint attempt = 0;
    private uint win = 0;
    public uint Win
    {
        get { return win; }
        set { win = value; }
    }
    private uint loss = 0;
    public uint Loss
    {
        get { return loss; }
        set { loss = value; }
    }

    private float winRate = 0;
    public float WinRate
    {
        get { return winRate; }
        set { winRate = value; }
    }
    public uint Attempt
    {
        get { return attempt; }
        set { attempt = value; }
    }
    public void SaveFile(DifficultyData datas)
    {
        string json = JsonConvert.SerializeObject(datas,Formatting.Indented);
        File.WriteAllText(Path, json);
    }
    public DifficultyData LoadFile()
    {
        if (File.Exists(Path))
        {
            string json = File.ReadAllText(Path);
            try
            {
                return JsonConvert.DeserializeObject<DifficultyData>(json) ?? new DifficultyData();
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Œ¯Ë·Í‡ Á‡„ÛÁÍË Ù‡ÈÎ‡: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete(Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error load file: {ex.Message}");
                File.Delete(Path);
            }
        }
        else
        {
            File.Create(Path).Dispose();
        }
        return new DifficultyData();
    }
}
class DifficultyData
{
    public Dictionary<string, SaveData> Difficulty { get; set; } = new();
    public Dictionary<string, SaveDataAfterExit> TimeSave { get; set; } = new();
}
class SaveDataAfterExit
{
    private string? difficult;
    public string Difficulty
    {
        get { return difficult; }
        set { difficult = value; }
    }
    private uint score = 0;
    public uint  Score
    {
        get { return score; }
        set { score = value; }
    }
    private uint streak = 0;
    public  uint Streak
    {
        get { return streak; }
        set { streak = value; }
    }
    private byte live = 0;
    public byte Live
    {
        get { return live; }
        set { live = value; }
    }
    private uint hideNumber;

    public uint HideNumber
    {
        get { return hideNumber; }
        set { hideNumber = value; }
    }
    private bool playerWantContinue;
    [JsonIgnoreAttribute]
    public bool PlayerWantContinue
    {
        get { return playerWantContinue; }
        set { playerWantContinue = value; }
    }
    private string tips;

    public string Tips
    {
        get { return tips; }
        set { tips = value; }
    }
}  