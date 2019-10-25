using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using pentago.Components;
using pentago.Forms;
using pentago.Values;

namespace pentago.Engine
{
    public class Game
    {
        public static Game Instance { get; private set; }
        public int FieldSize = GameField.SectorCount * Constants.SECTOR_WIDTH;
        public static int ActivePlayerIndex;

        public List<Sector> Sectors = new List<Sector>();
        public List<Player> Players = new List<Player>();
        public List<BallPoint> BallPoints = new List<BallPoint>();
        public int PlayerCount { get; set; }

        public Game(StartForm startForm)
        {
            PlayerCount = startForm.PlayerCount;
            ActivePlayerIndex = 1;
            CreatePlayers(startForm);
            Instance = this;
        }

        public static Point[,] GetSectorMatrix()
        {
            Point[,] sec = new Point[GameField.SectorCount, GameField.SectorCount];
            for (int x = 1; x <= GameField.SectorCount; x++)
                for (int y = 1; y <= GameField.SectorCount; y++)
                    sec[x - 1, y - 1] = new Point(x, y);
            return sec;
        }

        public void SetNextPlayerIndex()
        {
            ActivePlayerIndex++;
            if (ActivePlayerIndex > PlayerCount)
                ActivePlayerIndex = 1;
        }

        public void CreatePlayers(StartForm start)
        {
            switch (PlayerCount)
            {
                case 8:
                    Players.Add(new Player(start.Player8Name, start.Player8Color, 8));
                    goto case 7;
                case 7:
                    Players.Add(new Player(start.Player7Name, start.Player7Color, 7));
                    goto case 6;
                case 6:
                    Players.Add(new Player(start.Player6Name, start.Player6Color, 6));
                    goto case 5;
                case 5:
                    Players.Add(new Player(start.Player5Name, start.Player5Color, 5));
                    goto case 4;
                case 4:
                    Players.Add(new Player(start.Player4Name, start.Player4Color, 4));
                    goto case 3;
                case 3:
                    Players.Add(new Player(start.Player3Name, start.Player3Color, 3));
                    goto default;
                default:
                    Players.Add(new Player(start.Player2Name, start.Player2Color, 2));
                    Players.Add(new Player(start.Player1Name, start.Player1Color, 1));
                    break;
            }
        }

        public bool HasNoWhiteBalls() =>
            BallPoints.Count(f => f.PointColor == BallColor.WHITE) == 0;
        public BallPoint GetBallByOpenCoord(int x, int y) =>
            BallPoints.Single(f => f.OpenCoordinates == new Point(x, y));


        public void ChangeScoreForAllPlayers()
        {
            foreach (Player player in Instance.Players)
                player.Score = player.MaxLine.ToString();
        }
    }
}
