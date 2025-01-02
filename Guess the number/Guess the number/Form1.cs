using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        private List<Control> controlIsToCenter;
        Game game = new Game();
        
        public Form1()
        {
            InitializeComponent();
            this.Shown += MainForm_Shown;
        }

        private void InitializeCentering()
        {
            controlIsToCenter = new List<Control>
            {
                btnStartGame, btnRecords, btnExit,
                btnEasy, btnMedium, btnHard ,ChooseDifficulty,
                textBoxNumber, btnSend, labelStreak, labelBigOrSmall,
                btnTryAgain, btnChangeDifficulty, btnBackToMenu,
                label, labelIsNumber, labelTxtIncorrectNum,
                labelTxtGetScore,labelTxtWelcome,labelTxtNameGame,
                labelTxtTips
            };
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (controlIsToCenter != null)
                AllCenter();
        }
        private void AllCenter()
        {
            foreach (var control in controlIsToCenter)
            {
                control.Left = (this.ClientSize.Width - control.Width) / 2;
            }
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

                { btnExit, startMenu },
                { btnRecords, startMenu },
                { btnStartGame, startMenu },
            });
            
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

            { ChooseDifficulty, chooseDifficulty },
            { btnEasy, chooseDifficulty },
            { btnMedium, chooseDifficulty },
            { btnHard, chooseDifficulty },
            { btnBTM, chooseDifficulty },
        });
            
        }
        public void GamePlay(bool control = true)
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

                { labelTextLive, control },
                { labelLive, control },
                { textBoxNumber, control },
                { btnSend, control },
                { labelBigOrSmall, control },
                { labelTxtIncorrectNum, control },
                { labelTxtScore, control },
                { labelTxtDifficult, control },
                { btnBTM, control },
            });            
            game.Live = game._Live;
            labelLive.Text = Convert.ToString(game.Live);
            game.HiddenNumber = (uint)game.random.Next(1, 100);
        }
        private void AfterGame(bool result = true)
        {
            
            label.Left = (this.ClientSize.Width - label.Width) / 2;
            labelBigOrSmall.Text = "";
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

                { label, result },
                { btnBackToMenu, result },
                { btnChangeDifficulty, result },
                { btnTryAgain, result },
                { labelIsNumber, result },
                { labelTxtGetScore, result },
            });
            
            labelIsNumber.Text = $"Hidden number is: {Convert.ToString(game.HiddenNumber)}";
            CenterLabel(labelIsNumber);
            game.HiddenNumber = (uint)game.random.Next(1, 100);
        }     
        private void CenterLabel(Label label)
        {
            label.Left = (this.ClientSize.Width - label.Width) / 2;
        }
        private void CheckWin(uint enteredNumber = 0) 
        {
            if (!string.IsNullOrWhiteSpace(textBoxNumber.Text) && uint.TryParse(textBoxNumber.Text, out enteredNumber) && enteredNumber <= 100)
            {
                if (enteredNumber == game.HiddenNumber)
                {
                    label.Text = "You Win";
                    game.Streak += 1;
                    labelStreak.Text = $"You're streak is: {Convert.ToString(game.Streak)}";
                    labelStreak.Visible = false;
                    game.Score += (Options.baseScore * (uint)game.Live) * (uint)game.Multiple;
                    labelTxtScore.Text = $"Score: {game.Score}";
                    labelTxtGetScore.Text = $"Get Score: {(Options.baseScore * (uint)game.Live) * (uint)game.Multiple}";
                    CenterLabel(labelTxtGetScore);
                    AfterGame();

                }
                else if (enteredNumber < game.HiddenNumber)
                {
                    labelBigOrSmall.Text = $"{enteredNumber} < ???";
                    labelTxtIncorrectNum.Text = "";
                    CenterLabel(labelBigOrSmall);
                    game.Live -= 1;
                    labelLive.Text = Convert.ToString(game.Live);
                    Checkloss();
                }
                else
                {
                    labelBigOrSmall.Text = $"{enteredNumber} > ???";
                    labelTxtIncorrectNum.Text = "";
                    CenterLabel(labelBigOrSmall);
                    game.Live -= 1;
                    labelLive.Text = Convert.ToString(game.Live);
                    Checkloss();
                }
            }
            else
            {
                labelTxtIncorrectNum.Text = "Please write a simple number";
                CenterLabel(labelTxtIncorrectNum);
                textBoxNumber.Text = "";
            }
        }
        private void Checkloss()
        {
            
            if (game.Live == 0)
            {
                game.Streak = 0;
                labelStreak.Text = $"You're streak is: {Convert.ToString(game.Streak)}";
                label.Text = ("You lose!");
                labelTxtGetScore.Text = "";
                AfterGame();
            }
            textBoxNumber.Text = "";
        }
        private void StartGame(Game.MultipleScore difficulty, byte lives)
        {
            game.Multiple = difficulty;
            game._Live = lives;
            labelTxtDifficult.Text = $"Difficult is: {game.Multiple}";            
            GamePlay();
        }
        private void SetVisibility(Dictionary<Control, bool>  visibilitySetting)
        {
            foreach(var item in visibilitySetting)
            {
                item.Key.Visible = item.Value;
            }
            AllCenter();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            Difficulty();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void btnEasy_Click(object sender, EventArgs e)
        {
            StartGame(Game.MultipleScore.Easy, 7);
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            StartGame(Game.MultipleScore.Medium, 6);
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            StartGame(Game.MultipleScore.Hard, 5);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            CheckWin();
        }
        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            GamePlay();
        }

        private void btnChangeDifficulty_Click(object sender, EventArgs e)
        {
            Difficulty();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
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
            labelTxtTips.Visible = false;
            btnStartGame.Visible = true;
            btnRecords.Visible = true;
            btnExit.Visible = true; 
        }
    }
}
    class Options
    {
        public MultipleScore Multiple { get; set; }
        public byte Live {  get; set; }
        public byte _Live {  get; set; }
        public uint Score {  get; set; }
        public byte Streak { get; set; }
        public uint HiddenNumber { get; set; }
        public const uint baseScore = 10;
        public Random random = new Random();
        public enum MultipleScore
        {
            Easy = 1,
            Medium = 5,
            Hard = 20
        }
        

    }
    class Game : Options
    {

    }
    
