using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    public class PrisonersDilemma : GameSymmetric
    {
        public PrisonersDilemma(double temptation, double reward, double punishment, double suckersPayoff) : base(reward, suckersPayoff, temptation, punishment)
        {
            if (temptation <= reward)
                throw new Exception("Wrong game parameters");

            if (reward <= punishment)
                throw new Exception("Wrong game parameters");

            if (punishment < suckersPayoff)
                throw new Exception("Wrong game parameters");

            if (temptation + suckersPayoff >= 2 * reward)
                throw new Exception("Wrong game parameters");
        }
    }
}
