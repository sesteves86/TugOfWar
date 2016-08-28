using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugOfWar
{
    public class AI
    {
        public static int Level1AI(int PointsB)
        {
            Random r = new Random();
            int spentB = r.Next(PointsB);
            return spentB;
        }

        public static int Level2AI(int PointsB)
        {
            Random r = new Random();

            int spentB = r.Next(10);
            return spentB;
        }

        public static int Level3AI(int PointsB)
        {
            Random r = new Random();
            Random r2 = new Random();

            int spentB = (int)(r.NextDouble() * r2.NextDouble() * 11 + 1);

            return spentB;
        }
    }
}
