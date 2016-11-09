using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    class Player
    {
        public Player()
        {
            this.ChosenAction = Generator.Next(2) == 0 ? Action.One : Action.Two;
            this.Payoff = 0;
        }

        public Action ChosenAction { get; set; }
        public double Payoff { get; set; }
    }
}
