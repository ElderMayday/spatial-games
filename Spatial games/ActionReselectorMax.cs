﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    public class ActionReselectorMax : ActionReselector
    {
        public override Action Reselect(Player player, List<Player> neighbours)
        {
            double maxPayoff = neighbours.Max(x => x.Payoff);
            Player bestNeighbour = neighbours.Find(x => x.Payoff == maxPayoff);
            return bestNeighbour.ChosenAction;
        }
    }
}
