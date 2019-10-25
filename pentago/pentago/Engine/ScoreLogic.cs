using pentago.Components;
using pentago.Values;

namespace pentago.Engine
{
    public class ScoreLogic
    {
        private static Game CurrentGame => Game.Instance;

        public static int GetUpdatedMaximumScore()
        {
            SetZeroScoreForAllPlayers();
            CheckForHorizontalLines();
            CheckForVerticalLines();
            CheckForMainDiagonalLines();
            CheckForSecondaryDiagonalLines();
            return GetMaxLine();
        }

        private static void SetZeroScoreForAllPlayers()
        {
            foreach (Player player in CurrentGame.Players)
                player.SetZeroScore();
        }

        private static int GetMaxLine()
        {
            int maxLine = 0;
            foreach (Player player in CurrentGame.Players)
                if (player.MaxLine > maxLine)
                    maxLine = player.MaxLine;

            return maxLine;
        }

        private static void CheckForHorizontalLines()
        {
            for (int x = 1; x <= CurrentGame.FieldSize; x++)
            {
                CheckFirstBallInRaw(x, 1);
                for (int y = 1; y < CurrentGame.FieldSize; y++)
                {
                    CheckTwoBalls(x, y, x, y + 1);
                }
            }
        }

        private static void CheckForVerticalLines()
        {
            for (int y = 1; y <= CurrentGame.FieldSize; y++)
            {
                CheckFirstBallInRaw(1, y);
                for (int x = 1; x < CurrentGame.FieldSize; x++)
                {
                    CheckTwoBalls(x, y, x + 1, y);
                }
            }
        }

        private static void CheckForMainDiagonalLines()
        {
            for (int lineNumber = 2; lineNumber <= 2 * CurrentGame.FieldSize - 2; lineNumber++)
            {
                int x = lineNumber <= CurrentGame.FieldSize
                    ? CurrentGame.FieldSize
                    : 2 * CurrentGame.FieldSize - lineNumber;
                int y = lineNumber <= CurrentGame.FieldSize
                    ? lineNumber
                    : CurrentGame.FieldSize;

                CheckFirstBallInRaw(x, y);
                while (--x > 1 && --y > 1)
                {
                    CheckTwoBalls(x, y, x - 1, y - 1);
                }
            }
        }

        private static void CheckForSecondaryDiagonalLines()
        {
            for (int lineNumber = 2; lineNumber <= 2 * CurrentGame.FieldSize - 2; lineNumber++)
            {
                int x = lineNumber <= CurrentGame.FieldSize
                    ? 1
                    : lineNumber - CurrentGame.FieldSize + 1;
                int y = lineNumber <= CurrentGame.FieldSize
                    ? lineNumber
                    : CurrentGame.FieldSize;

                CheckFirstBallInRaw(x, y);
                while (++x < CurrentGame.FieldSize && --y > 1)
                {
                    CheckTwoBalls(x, y, x + 1, y - 1);
                }
            }
        }

        private static void CheckFirstBallInRaw(int firstX, int firstY)
        {
            BallPoint currentBall = CurrentGame.GetBallByOpenCoord(firstX, firstY);
            CheckLine(BallColor.WHITE, currentBall.PointColor);
        }

        private static void CheckTwoBalls(int prevX, int prevY, int currX, int currY)
        {
            BallPoint currentBall = CurrentGame.GetBallByOpenCoord(currX, currY);
            BallPoint previousBall = CurrentGame.GetBallByOpenCoord(prevX, prevY);
            CheckLine(previousBall.PointColor, currentBall.PointColor);
        }

        private static void CheckLine(BallColor previousBallColor, BallColor currentBallColor)
        {
            if (currentBallColor != BallColor.WHITE)
            {
                Player currentPlayer = Player.GetPlayerByColor(currentBallColor);
                if (currentBallColor == previousBallColor)
                {
                    currentPlayer.CurrentLine++;
                    currentPlayer.SaveCurrentLineToMaxLine();
                }
                else //currentBallColor != previousBallColor
                {
                    currentPlayer.CurrentLine = 1;
                    currentPlayer.SaveCurrentLineToMaxLine();
                }
            }
            if (previousBallColor != BallColor.WHITE 
                && previousBallColor != currentBallColor)
            {
                Player previousPlayer = Player.GetPlayerByColor(previousBallColor);
                previousPlayer.CurrentLine = 0;
            }
        }

    }
}
