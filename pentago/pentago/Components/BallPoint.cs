using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using pentago.Engine;
using pentago.Values;

namespace pentago.Components
{
    public class BallPoint : Control
    {
        public Game Game { get; set; }
        public Sector Sector { get; set; }
        public BallColor PointColor { get; set; }
        public Point Point { get; set; }

        public bool IsColored => PointColor != BallColor.WHITE;
        public Point OpenCoordinates => new Point(
                (Sector.Place.X - 1) * Constants.SECTOR_WIDTH + Point.X,
                (Sector.Place.Y - 1) * Constants.SECTOR_WIDTH + Point.Y);

        public BallPoint(Sector sector, Point point)
        {
            Sector = sector;
            Game = sector.Game;
            Point = point;
            PointColor = BallColor.WHITE;
            Size = new Size(Constants.RADIUS, Constants.RADIUS);
            BackColor = Constants.BACKGROUND_COLOR;
            BackgroundImageLayout = ImageLayout.Zoom;
            DrawBallPoint();

            Game.BallPoints.Add(this);
            Sector.BallPoints.Add(this);
        }

        public void DrawBallPoint()
        {
            int LocX = (Point.X - 1) * Constants.BALLS_GAP + Constants.EDGE;
            int LocY = (Point.Y - 1) * Constants.BALLS_GAP + Constants.EDGE;
            Location = new Point(LocY, LocX);

            string colorName = PointColor.ToString().ToLower();
            SetBackgroundImage(Constants.BallImageFileName(colorName));
        }

        void SetBackgroundImage(string imgFileName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string imageName = Path.Combine(basePath, Constants.IMAGE_FOLDER_NAME, imgFileName);
            BackgroundImage = Image.FromFile(imageName);
        }
    }
}
