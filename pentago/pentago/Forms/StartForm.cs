using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pentago.Engine;
using pentago.Values;

namespace pentago.Forms
{
    public partial class StartForm : Form
    {
        public Game Game { get; set; }
        public GameField Field { get; }
        public int PlayerCount { get; set; }
        public bool IsFinish { get; set; }

        public string Player1Name { get; set; }
        public string Player2Name { get; set; }
        public string Player3Name { get; set; }
        public string Player4Name { get; set; }
        public string Player5Name { get; set; }
        public string Player6Name { get; set; }
        public string Player7Name { get; set; }
        public string Player8Name { get; set; }

        public BallColor Player1Color { get; set; }
        public BallColor Player2Color { get; set; }
        public BallColor Player3Color { get; set; }
        public BallColor Player4Color { get; set; }
        public BallColor Player5Color { get; set; }
        public BallColor Player6Color { get; set; }
        public BallColor Player7Color { get; set; }
        public BallColor Player8Color { get; set; }

        private List<string> _names;
        
        public StartForm(GameField field)
        {
            InitializeComponent();
            SetTextFields();
            Field = field;
            IsFinish = true;
        }

        private void SetTextFields()
        {
            Text = OnscreenText.WelcomeToPentago;
            label_players_number.Text = OnscreenText.PlayersNumberText;
            label_sectors_number.Text = OnscreenText.SectorsNumberText;
            cbPlayerCount.Text = OnscreenText.DefaultPlayerCount;
            cbSectorCount.Text = OnscreenText.FieldSizeTwo;
            tbName1.Text = OnscreenText.PlayerNumber(1);
            tbName2.Text = OnscreenText.PlayerNumber(2);
            button_new_game.Text = OnscreenText.NewGame;
            tbName1.Select();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!ValidateNames())
                MessageBox.Show(OnscreenText.NamesShouldBeDifferent);
            else
            {
                PlayerCount = Convert.ToInt16(cbPlayerCount.Text);
                GameField.SetSectorCount(cbSectorCount.Text);
                SetFields();

                Game = new Game(this);
                Field.Game = Game;

                IsFinish = false;
                Close();
            }
        }

        private bool ValidateNames()
        {
            ReadNames();
            for (int i = 0; i < _names.Count - 1; i++)
                for (int j = i + 1; j < _names.Count; j++)
                    if (_names[i] == _names[j])
                        return false;
            return true;
        }

        private void ReadNames()
        {
            _names = new List<string>
            {
                tbName1.Text,
                tbName2.Text
            };
            if(tbName3.Enabled)
                _names.Add(tbName3.Text);
            if (tbName4.Enabled)
                _names.Add(tbName4.Text);
            if (tbName5.Enabled)
                _names.Add(tbName5.Text);
            if (tbName6.Enabled)
                _names.Add(tbName6.Text);
            if (tbName7.Enabled)
                _names.Add(tbName7.Text);
            if (tbName8.Enabled)
                _names.Add(tbName8.Text);
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsFinish)
                Application.Exit();
        }

        private void cbPlayerCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbName3.Enabled = false;
            tbName4.Enabled = false;
            tbName5.Enabled = false;
            tbName6.Enabled = false;
            tbName7.Enabled = false;
            tbName8.Enabled = false;

            switch (Convert.ToInt32(cbPlayerCount.Text))
            {
                case 8:
                    tbName8.Enabled = true;
                    tbName8.Text = OnscreenText.PlayerNumber(8);
                    goto case 7;
                case 7:
                    tbName7.Enabled = true;
                    tbName7.Text = OnscreenText.PlayerNumber(7);
                    goto case 6;
                case 6:
                    tbName6.Enabled = true;
                    tbName6.Text = OnscreenText.PlayerNumber(6);
                    goto case 5;
                case 5:
                    tbName5.Enabled = true;
                    tbName5.Text = OnscreenText.PlayerNumber(5);
                    goto case 4;
                case 4:
                    tbName4.Enabled = true;
                    tbName4.Text = OnscreenText.PlayerNumber(4);
                    goto case 3;
                case 3:
                    tbName3.Enabled = true;
                    tbName3.Text = OnscreenText.PlayerNumber(3);
                    break;
            }
        }

        private void SetFields()
        {
            Player1Name = tbName1.Text;
            Player2Name = tbName2.Text;
            Player3Name = tbName3.Text;
            Player4Name = tbName4.Text;
            Player5Name = tbName5.Text;
            Player6Name = tbName6.Text;
            Player7Name = tbName7.Text;
            Player8Name = tbName8.Text;

            Player1Color = BallColor.RED;
            Player2Color = BallColor.GREEN;
            Player3Color = BallColor.BLUE;
            Player4Color = BallColor.CYAN;
            Player5Color = BallColor.MAGENTA;
            Player6Color = BallColor.YELLOW;
            Player7Color = BallColor.BLACK;
            Player8Color = BallColor.BROWN;
        }

    }
}
