using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using pentago.Engine;
using pentago.Values;

namespace pentago.Components
{
    public class Sector : Control
    {
        public List<BallPoint> BallPoints = new List<BallPoint>();
        private BackgroundDirection BackgroundIndex;

        public Game Game { get; set; }
        public Point Place { get; }


        public Sector(Game game, Point point)
        {
            Place = point;
            Game = game;
            Size = new Size(Constants.SIDE, Constants.SIDE);
            PositionSector();
            BackgroundImageLayout = ImageLayout.Zoom;
            BackgroundIndex = BackgroundDirection.UP;
            SetImage(Constants.SectorBgImageName(BackgroundDirection.UP));

            Game.Sectors.Add(this);
        }

        public void PositionSector()
        {
            int LocX = Constants.START_TOP + (Place.X - 1) * Constants.SECTOR_GAP;
            int LocY = Constants.START_LEFT + (Place.Y - 1) * Constants.SECTOR_GAP;
            Location = new Point(LocY, LocX);
        }

        public static Point[,] GetBallMatrix()
        {
            Point[,] ball = new Point[Constants.SECTOR_WIDTH, Constants.SECTOR_WIDTH];
            for (int i = 1; i <= Constants.SECTOR_WIDTH; i++)
                for (int j = 1; j <= Constants.SECTOR_WIDTH; j++)
                    ball[i - 1, j - 1] = new Point(i, j);
            return ball;
        }


        public void TurnRight()
        {
            foreach (BallPoint ball in BallPoints)
            {
                ball.Point = new Point(Constants.SECTOR_WIDTH - ball.Point.Y + 1, ball.Point.X);
                ball.DrawBallPoint();
            }
            BackgroundIndex--;
            if (BackgroundIndex < 0)
                BackgroundIndex = BackgroundDirection.LEFT;
            DrawBackground();
        }

        public void TurnLeft()
        {
            foreach (BallPoint ball in BallPoints)
            {
                ball.Point = new Point(ball.Point.Y, Constants.SECTOR_WIDTH - ball.Point.X + 1);
                ball.DrawBallPoint();
            }
            BackgroundIndex++;
            if ((int)BackgroundIndex > 3)
                BackgroundIndex = BackgroundDirection.UP;
            DrawBackground();
        }

        private void DrawBackground()
        {
            string imgFileName = Constants.SectorBgImageName(BackgroundIndex);
            SetImage(imgFileName);
        }

        private void SetImage(string imgFileName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string s = Path.Combine(basePath, Constants.IMAGE_FOLDER_NAME, imgFileName);
            BackgroundImage = Image.FromFile(s);
        }
    }
}
