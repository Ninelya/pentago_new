using System.Drawing;

namespace pentago.Values
{
    public class Constants
    {
        public static readonly Color BACKGROUND_COLOR = Color.FromArgb(247, 235, 200);
        public static readonly int RADIUS = 35;
        public static readonly int BALLS_GAP = 63;
        public static readonly int EDGE = 14;

        public static readonly int MENU_WIDTH = 300;

        public static readonly int START_TOP = 20;
        public static readonly int START_LEFT = START_TOP + MENU_WIDTH;
        public static readonly int SECTOR_GAP = 199;
        public static readonly int SIDE = 189;
        public static readonly int SECTOR_WIDTH = 3;

        public static readonly int WIN_SCORE = 5;
        public static readonly int FIELD_STEP = SECTOR_GAP;
        public static readonly int FIELD_LEFT = 2 * START_TOP + MENU_WIDTH;
        public static readonly int FIELD_TOP = 3 * START_TOP;

        public static readonly string IMAGE_FOLDER_NAME = "Images";

        public static string SectorBgImageName(BackgroundDirection direction) => 
            $"sector_{direction.ToString().ToLower()}.gif";

        public static string BallImageFileName(string colorName) => $"ball_{colorName}.gif";

        internal static Size GetMinimumFieldSize(int sectorCount) => new Size(
                sectorCount * SECTOR_GAP + FIELD_LEFT,
                sectorCount * SECTOR_GAP + FIELD_TOP);
    }
}
