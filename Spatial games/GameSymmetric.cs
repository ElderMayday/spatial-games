using System;
using System.Collections.Generic;


namespace Spatial_games
{
    abstract public class GameSymmetric
    {
        public GameSymmetric(double payoff11, double payoff12, double payoff21, double payoff22)
        {
            payoff = new Dictionary<Tuple<Action, Action>, double>
            {
                {new Tuple<Action, Action>(Action.One, Action.One), payoff11 },
                {new Tuple<Action, Action>(Action.One, Action.Two), payoff12 },
                {new Tuple<Action, Action>(Action.Two, Action.One), payoff21 },
                {new Tuple<Action, Action>(Action.Two, Action.Two), payoff22 }
            };
        }

        public double GetPayoff(Action actionFirst, Action actionSecond)
        {
            return payoff[new Tuple<Action, Action>(actionFirst, actionSecond)];
        }

        public double GetPayoff(Tuple<Action, Action> actionPair)
        {
            return payoff[actionPair];
        }

        protected Dictionary<Tuple<Action, Action>, double> payoff;
    }
}
