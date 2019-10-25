using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using pentago.Components;
using pentago.Engine;
using pentago.Values;

namespace pentago.Forms
{
    public partial class GameField : Form
    {
        public static int SectorCount;

        public Game Game { get; set; }
        public StartForm Start { get; }
        private bool IsBallNotSector { get; set; }

        public GameField()
        {
            InitializeComponent();

            Start = new StartForm(this);
            Start.ShowDialog();

            if (Start.IsFinish)
                return;

            MinimumSize = Constants.GetMinimumFieldSize(SectorCount);
            SetFields();
            SetupSectorsAndBalls();

            IsBallNotSector = true;
        }

        private void SetFields()
        {
            Text = OnscreenText.Pentago;
            label_Pentago.Text = OnscreenText.Pentago;
            label_your_move.Text = OnscreenText.YourMove;
            label_hint.Text = OnscreenText.ChooseBall;
            lblActivePlayer.Text = OnscreenText.PlayerName(Player.GetActivePlayer().Name);
            SetNames();
            ShowScoreForAllPlayers();
            ShowPlayers();
        }

        private void SetupSectorsAndBalls()
        {
            foreach (Point sectorPlace in Game.GetSectorMatrix())
            {
                Sector sector = new Sector(Game, sectorPlace);
                Controls.Add(sector);
                sector.MouseClick += OnSectorMouseClick;
                foreach (Point ballPoint in Sector.GetBallMatrix())
                {
                    BallPoint bp = new BallPoint(sector, ballPoint);
                    bp.MouseClick += OnBallPointClick;
                    sector.Controls.Add(bp);
                }
            }
        }

        public static void SetSectorCount(string sectorType)
        {
            switch (sectorType)
            {
                case OnscreenText.FieldSizeTwo:
                    SectorCount = 2;
                    break;
                case OnscreenText.FieldSizeThree:
                    SectorCount = 3;
                    break;
                case OnscreenText.FieldSizeFour:
                    SectorCount = 4;
                    break;
                case OnscreenText.FieldSizeFive:
                    SectorCount = 5;
                    break;
            }
        }

        private void OnBallPointClick(object sender, MouseEventArgs e)
        {
            BallPoint ball = (BallPoint)sender;
            if (ball.IsColored || !IsBallNotSector)
                OnSectorMouseClick(ball.Sector, e);
            else
            {
                ball.PointColor = Player.GetActivePlayer().Color;
                ball.DrawBallPoint();

                label_hint.Text = OnscreenText.TurnSector;
                IsBallNotSector = false;
            }
        }

        private void OnSectorMouseClick(object sender, MouseEventArgs e)
        {
            if (IsBallNotSector)
                return;

            Sector sector = (Sector)sender;

            if (e.Button == MouseButtons.Left)
                sector.TurnLeft();

            if (e.Button == MouseButtons.Right)
                sector.TurnRight();

            int currentMaxScore = ScoreLogic.GetUpdatedMaximumScore();
            Game.ChangeScoreForAllPlayers();
            ShowScoreForAllPlayers();

            if (currentMaxScore >= Constants.WIN_SCORE)
                SomeoneWins(currentMaxScore);

            if (Game.HasNoWhiteBalls())
                GameOver();

            sector.Game.SetNextPlayerIndex();
            lblActivePlayer.Text = OnscreenText.PlayerName(Player.GetActivePlayer().Name);
            label_hint.Text = OnscreenText.ChooseBall;

            IsBallNotSector = true;
        }

        private void SomeoneWins(int score)
        {
            string message = OnscreenText.SomeoneWon(score);
            List<Player> currentWinners = Player.GetWinners(score);
            foreach (Player winner in currentWinners)
                message += $"\n{winner.Name}";
            MessageBox.Show(message);
            Application.Exit();
        }

        private void GameOver()
        {
            MessageBox.Show(OnscreenText.EndOfGame);
            Application.Exit();
        }

        private void ShowScoreForAllPlayers()
        {
            switch (Game.PlayerCount)
            {
                case 8:
                    lblScore8.Text = Player.GetPlayerByIndex(8).Score;
                    goto case 7;
                case 7:
                    lblScore7.Text = Player.GetPlayerByIndex(7).Score;
                    goto case 6;
                case 6:
                    lblScore6.Text = Player.GetPlayerByIndex(6).Score;
                    goto case 5;
                case 5:
                    lblScore5.Text = Player.GetPlayerByIndex(5).Score;
                    goto case 4;
                case 4:
                    lblScore4.Text = Player.GetPlayerByIndex(4).Score;
                    goto case 3;
                case 3:
                    lblScore3.Text = Player.GetPlayerByIndex(3).Score;
                    goto default;
                default:
                    lblScore2.Text = Player.GetPlayerByIndex(2).Score;
                    lblScore1.Text = Player.GetPlayerByIndex(1).Score;
                    break;
            }
        }

        private void SetNames()
        {
            lblName1.Text = Start.Player1Name;
            lblName2.Text = Start.Player2Name;
            lblName3.Text = Start.Player3Name;
            lblName4.Text = Start.Player4Name;
            lblName5.Text = Start.Player5Name;
            lblName6.Text = Start.Player6Name;
            lblName7.Text = Start.Player7Name;
            lblName8.Text = Start.Player8Name;
        }

        private void ShowPlayers()
        {
            pnlPlayers3.Visible = false;
            pnlPlayers4.Visible = false;
            pnlPlayers5.Visible = false;
            pnlPlayers6.Visible = false;
            pnlPlayers7.Visible = false;
            pnlPlayers8.Visible = false;

            switch (Start.PlayerCount)
            {
                case 8:
                    pnlPlayers8.Visible = true;
                    goto case 7;
                case 7:
                    pnlPlayers7.Visible = true;
                    goto case 6;
                case 6:
                    pnlPlayers6.Visible = true;
                    goto case 5;
                case 5:
                    pnlPlayers5.Visible = true;
                    goto case 4;
                case 4:
                    pnlPlayers4.Visible = true;
                    goto case 3;
                case 3:
                    pnlPlayers3.Visible = true;
                    break;
            }
        }

    }
}
