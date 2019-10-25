using System.Collections.Generic;
using System.Linq;
using pentago.Values;

namespace pentago.Engine
{
    public class Player
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public BallColor Color { get; set; }

        public int CurrentLine { get; set; }
        public int MaxLine { get; set; }
        public string Score { get; set; }

        public Player(string name, BallColor color, int index)
        {
            Name = name;
            Color = color;
            Index = index;
        }

        public void SetZeroScore()
        {
            CurrentLine = 0;
            MaxLine = 0;
            Score = "";
        }

        public void SaveCurrentLineToMaxLine()
        {
            if (MaxLine < CurrentLine)
                MaxLine = CurrentLine;
        }

        public static List<Player> GetWinners(int score) =>
            Game.Instance.Players.FindAll(f => f.MaxLine == score);

        public static Player GetPlayerByIndex(int index) =>
            Game.Instance.Players.SingleOrDefault(f => f.Index == index);

        public static Player GetActivePlayer() =>
            GetPlayerByIndex(Game.ActivePlayerIndex);

        public static Player GetPlayerByColor(BallColor pointColor) =>
            Game.Instance.Players.Single(f => f.Color == pointColor);
    }
}
