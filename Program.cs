using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

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
            numberOfPlayerGuesses = new int[PlayerNames.Length];
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
        public bool[] guess(int guessNumber)
        {
            //[0] = correct or not
            //[1] = too high
            bool[] result = new bool[2];
            stopwatch[CurrentPlayer].Stop();
            numberOfPlayerGuesses[CurrentPlayer]++;
            if (numberToGuess == guessNumber)
            {
                //Enter Success Sequence
                Winner = CurrentPlayer;
                WinnerScore = (int)stopwatch[Winner].ElapsedMilliseconds / numberOfPlayerGuesses[Winner]
                    * (Globals.maxValue - Globals.minValue);
                Finished = true;
                result[0] = true;
                result[1] = true;
                return result;
            }
            //Enter Failure Sequence
            setNextPlayer();
            stopwatch[CurrentPlayer].Start();
            result[0] = false;
            if(numberToGuess < guessNumber)
            {
                result[1] = true;
            }
            else
            {
                result[1] = false;
            }
            return result;
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
    public static class GameSave
    {
        private const string GameSaveLocation = "GameData.txt";
        public static void save()
        {
            var OldData = read();
            if(OldData == null)
            {
                OldData = new List<Game>();
            }
            if(Globals.currentGame == null)
            {
                return;
            }
            OldData.Add(Globals.currentGame);
            File.WriteAllText(GameSaveLocation, JsonConvert.SerializeObject(OldData));
        }
        public static List<Game>? read()
        {
            if (File.Exists(GameSaveLocation))
            {
                return JsonConvert.DeserializeObject<List<Game>>(File.ReadAllText(GameSaveLocation));
            }
            return null;
        }
    }
}