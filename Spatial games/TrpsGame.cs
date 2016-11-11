using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    public class TrpsGame : GameSymmetric
    {
        public TrpsGame(double temptation, double reward, double punishment, double suckersPayoff) : base(reward, suckersPayoff, temptation, punishment)
        {
        }
    }
}
