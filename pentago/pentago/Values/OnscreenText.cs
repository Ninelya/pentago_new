namespace pentago.Values
{
    public class OnscreenText
    {
        public const string EndOfGame = "Game over";
        public const string ChooseBall = "Choose a ball";
        public const string TurnSector = "Turn a sector";
        public const string NamesShouldBeDifferent = "Names should be different";

        public const string FieldSizeTwo = "4 (2 х 2)";
        public const string FieldSizeThree = "9 (3 х 3)";
        public const string FieldSizeFour = "16 (4 х 4)";
        public const string FieldSizeFive = "25 (5 х 5)";

        public const string DefaultPlayerCount = "2";

        public const string Pentago = "Pentago";
        public const string YourMove = "Your move";

        public const string SectorsNumberText = "Set number of sectors:";
        public const string PlayersNumberText = "Set number of players:";
        public const string WelcomeToPentago = "Welcome to Pentago :-)";
        public const string NewGame = "New game";

        public static string PlayerName(string name) => $"{name}!";
        public static string PlayerNumber(int number) => $"Player {number}";
        public static string SomeoneWon(int result) =>
            $"Following players won with a score of {result}:";
    }
}
