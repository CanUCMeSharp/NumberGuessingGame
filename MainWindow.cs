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
        }
        private void UIChangeToNavMode()
        {
            UILeadNav.Visible = true;
            UISetNav.Visible = true;
            UIStartBut.Visible = true;
            UIGuessBox.Visible = false;
            UIGuessBut.Visible = false;
        }

        private void UIStartBut_Click(object sender, EventArgs e)
        {
            UIChangeToGameMode();
            string[] placeholder = { "Placeholder A2", "Placeholder B" };
            Globals.currentGame = new Game(placeholder);
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
            if (Globals.currentGame.guess(inputNumber))
#pragma warning restore CS8602 // Dereferenzierung eines möglichen Nullverweises.
            {
                UOText.Text = "Win! " + Globals.currentGame.PlayerNames[Globals.currentGame.CurrentPlayer] +
                    Globals.currentGame.WinnerScore.ToString();
            }
        }
    }
}