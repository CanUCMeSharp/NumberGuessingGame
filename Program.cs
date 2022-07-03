using System.Diagnostics;

namespace NumberGuessingGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
    public class Game
    {
        public string[] PlayerNames { get; internal set; }
        public int Winner { get; internal set; }
        public int WinnerScore { get; internal set; }
        public bool Finished { get; internal set; }
        //Aus irgendnem Grund hat hier ein Array ned funktioniert
        private List<Stopwatch> stopwatch;
        private int numberToGuess;
        Random random = new Random();
        public int CurrentPlayer { get; private set; }
        private int[] numberOfPlayerGuesses;
        public Game(string[] playerNames)
        {
            PlayerNames = playerNames;
            stopwatch = new List<Stopwatch>();
            for(int i = 0; i < PlayerNames.Length; i++)
            {
                stopwatch.Add(new Stopwatch());
            }
            numberOfPlayerGuesses = new int[PlayerNames.Length - 1];
        }
        
        public void startGame()
        {
            setNewNumber();
            CurrentPlayer = 0;
            stopwatch[CurrentPlayer].Start();
        }
        private void setNewNumber()
        {
            numberToGuess = random.Next(Globals.minValue, Globals.maxValue + 1);
        }
        public bool guess(int guessNumber)
        {
            stopwatch[CurrentPlayer].Stop();
            numberOfPlayerGuesses[CurrentPlayer]++;
            if (numberToGuess == guessNumber)
            {
                //Enter Success Sequence
                Winner = CurrentPlayer;
                WinnerScore = (int)stopwatch[Winner].ElapsedMilliseconds / numberOfPlayerGuesses[Winner]
                    * (Globals.maxValue - Globals.minValue);
                Finished = true;
                return true;
            }
            //Enter Failure Sequence
            setNextPlayer();
            stopwatch[CurrentPlayer].Start();
            return false;
        }
        private void setNextPlayer()
        {
            if(CurrentPlayer < PlayerNames.Length - 1)
            {
                CurrentPlayer++;
            }
            else
            {
                CurrentPlayer = 0;
            }
        }
    }
    public static class Globals
    {
        public static int minValue = 0, maxValue = 10;
        public static Game? currentGame;
    }
}