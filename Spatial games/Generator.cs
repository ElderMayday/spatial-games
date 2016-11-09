using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    static class Generator
    {
        static private Random random = new Random();

        static public int Next(int number)
        {
            return random.Next(number);
        }
    }
}
