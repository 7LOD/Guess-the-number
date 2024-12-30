namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnExit.Visible = false;
            btnRecords.Visible = false;
            btnStartGame.Visible = false;
            ChooseDifficulty.Visible = true;
            btnEasy.Visible = true;
            btnMedium.Visible = true;
            btnHard.Visible = true;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            btnEasy.Visible = false;
            btnMedium.Visible = false;
            btnHard.Visible = false;
            ChooseDifficulty.Visible = false;

            labelTextLive.Visible = true;
            labelLive.Visible = true;
            labelHiddenNumber.Visible = true;
            textBoxNumber.Visible = true;
            btnSend.Visible = true;
            labelBigOrSmall.Visible = true;
            labelResult.Visible = true;

            game.Difficulty = "Easy";
            game.Live = 7;
            game.HiddenNumber = (uint)game.random.Next(1, 100);

            labelLive.Text = Convert.ToString(game.Live);



        }

        private void btnMedium_Click(object sender, EventArgs e)
        {

        }

        private void btnHard_Click(object sender, EventArgs e)
        {

        }

        private void labelLive_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            uint enteredNumber = 0;
            if (!string.IsNullOrWhiteSpace(textBoxNumber.Text) && uint.TryParse(textBoxNumber.Text, out enteredNumber))
            {
                if (enteredNumber == game.HiddenNumber)
                {
                    labelBigOrSmall.Text = "";
                    labelResult.Text = "You are win!!!";
                }
                else if (enteredNumber > game.HiddenNumber)
                {
                    labelBigOrSmall.Text = "Hidden number is less";
                    game.Live -= 1;
                    labelLive.Text = Convert.ToString(game.Live);
                }
                else
                {
                    labelBigOrSmall.Text = "Hidden number is more";
                    game.Live -= 1;
                    labelLive.Text = Convert.ToString(game.Live);
                }
            }
            else
                labelBigOrSmall.Text = "Please write a simple number";
            if(game.Live == 0)
            {
                labelResult.Text = "You are loss";
            }

        }

        private void labelTextLive_Click(object sender, EventArgs e)
        {

        }
    }
    class Options
    {
        public string Difficulty {  get; set; }
        public byte Live {  get; set; }
        public uint Score { get; set; }
        public byte Streak { get; set; }
        public uint HiddenNumber { get; set; }
        public Random random = new Random();

    }
    class Game : Options
    {
        
    }
}
