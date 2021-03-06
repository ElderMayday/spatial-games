﻿using System;
using System.Collections.Generic;

namespace Spatial_games
{
    public class ActionReselectorReplicator : ActionReselector
    {
        public ActionReselectorReplicator(double maxPrts, double minPrts, double coefficient) : base()
        {
            this.maxPrts = maxPrts;
            this.minPrts = minPrts;
            this.coefficient = coefficient;
        }

        public override Action Reselect(Player player, List<Player> neighbours)
        {
            Player selected = neighbours[Generator.Next(neighbours.Count)];
            double probability = (1.0 + (selected.Payoff - player.Payoff) / (coefficient * (maxPrts - minPrts))) / 2.0;
            double generated = (double) Generator.Next(101) / 100.0;

            if (generated < probability)
                return selected.ChosenAction;
            else
                return player.ChosenAction;
        }

        protected double maxPrts, minPrts, coefficient;
    }
}
