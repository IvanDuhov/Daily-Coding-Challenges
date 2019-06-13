using System;

namespace DCC
{
    class DCC
    {
        /*
        This problem was asked by Facebook.

        In chess, the Elo rating system is used to calculate player strengths based on game results.

        A simplified description of the Elo system is as follows. Every player begins at the same score.
        For each subsequent game, the loser transfers some points to the winner, where the amount of points
        transferred depends on how unlikely the win is. For example, a 1200-ranked player should gain much more
        points for beating a 2000-ranked player than for beating a 1300-ranked player.

        Implement this system.
        */

        public enum Outcome
        {
            win = 1,
            loss = 0
        }

        public static void Main()
        {
            int first, second;

            first = 1200; second = 2000;
            ChangeElo(ref first, ref second, Outcome.win);
            // first = 1327, second = 1873
            // ELO shift = 127

            first = 1200; second = 1300;
            ChangeElo(ref first, ref second, Outcome.win);
            // first = 1264, second = 1236
            // ELO shift = 64
        }

        public static double ExpectationToWin(int firstPlayerScore, int secondPlayerScore)
        {
            return 1 / (1 + Math.Pow(10, (secondPlayerScore - firstPlayerScore) / 200));
        }

        public static void ChangeElo(ref int firstPlayerPoints, ref int secondPlayerPoints, Outcome outcomeForFirst)
        {
            int eloK = 32;
            int delta = (int)(eloK * ((int)outcomeForFirst - ExpectationToWin(firstPlayerPoints, secondPlayerPoints))*4);
            Console.WriteLine(delta);

            firstPlayerPoints += delta;
            secondPlayerPoints -= delta;
        }
    }
}
