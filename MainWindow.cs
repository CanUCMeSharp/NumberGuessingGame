namespace NumberGuessingGame
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void UIChangeToGameMode()
        {
            UILeadNav.Visible = false;
            UISetNav.Visible = false;
            UIStartBut.Visible = false;
            UIGuessBox.Visible = true;
            UIGuessBut.Visible = true;
            UOHighLowInidicator.Visible = true;
        }
        private void UIChangeToNavMode()
        {
            UILeadNav.Visible = true;
            UISetNav.Visible = true;
            UIStartBut.Visible = true;
            UIGuessBox.Visible = false;
            UIGuessBut.Visible = false;
            UOHighLowInidicator.Visible = false;
        }

        private void UIStartBut_Click(object sender, EventArgs e)
        {
            UIChangeToGameMode();
            //string[] placeholder = { "Placeholder A2", "Placeholder B" };
            UOHighLowInidicator.Text = "";
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
            Globals.currentGame = new Game(Globals.PlayerNames.ToArray());
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
            Globals.currentGame.startGame();
            changeUOText();
        }
        private void changeUOText()
        {
            //Warning will never occurr and can be ignored
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
            UOText.Text = Globals.currentGame.PlayerNames[Globals.currentGame.CurrentPlayer] + "´s turn";
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
        }

        private void UIGuessBut_Click(object sender, EventArgs e)
        {
            //Never, ever trust User Input XD
            string inputText = UIGuessBox.Text;
            UIGuessBox.Text = "";
            if(inputText == null || inputText == "")
            {
                return;
            }
            //Wertzuweisung, damit isch compiler nicht beschwert
            int inputNumber = 0;
            try
            {
                inputNumber = Convert.ToInt32(inputText);
            }
            catch
            {
                return;
            }
            //Warning will never occurr and can be ignored
#pragma warning disable CS8602 // Dereferenzierung eines möglichen Nullverweises.
            var guessResult = Globals.currentGame.guess(inputNumber);
            if (guessResult[0])
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
            {
                UOText.Text = "Win! " + Globals.currentGame.PlayerNames[Globals.currentGame.CurrentPlayer] +
                    ": " +Globals.currentGame.WinnerScore.ToString() + "pt";
                UIChangeToNavMode();
                GameSave.save();
                return;
            }
            UOText.Text = Globals.currentGame.PlayerNames[Globals.currentGame.CurrentPlayer] + "´s turn";
            if (guessResult[1])
            {
                UOHighLowInidicator.Text = "Number too high";
                return;
            }
            UOHighLowInidicator.Text = "Number too low";
        }

        private void UILeadNav_Click(object sender, EventArgs e)
        {

        }

        private void UISetNav_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}