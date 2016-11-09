using System;
using System.Collections.Generic;


namespace Spatial_games
{
    abstract class SymmetricGame
    {
        public SymmetricGame(double Payoff11, double Payoff12, double Payoff21, double Payoff22)
        {
            payoff = new Dictionary<Tuple<Action, Action>, double>
            {
                {new Tuple<Action, Action>(Action.One, Action.One), Payoff11 },
                {new Tuple<Action, Action>(Action.One, Action.Two), Payoff12 },
                {new Tuple<Action, Action>(Action.Two, Action.One), Payoff21 },
                {new Tuple<Action, Action>(Action.Two, Action.Two), Payoff22 }
            };
        }

        public double GetPayoff(Action ActionFirst, Action ActionSecond)
        {
            return payoff[new Tuple<Action, Action>(ActionFirst, ActionSecond)];
        }

        public double GetPayoff(Tuple<Action, Action> ActionPair)
        {
            return payoff[ActionPair];
        }

        protected Dictionary<Tuple<Action, Action>, double> payoff;
    }
}
