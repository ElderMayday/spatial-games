using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    class PrisonersDilemma : SymmetricGame
    {
        public PrisonersDilemma(double Temptation, double Reward, double Punishment, double SuckersPayoff) : base(Reward, SuckersPayoff, Temptation, Punishment)
        {
        }
    }
}
