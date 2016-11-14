using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    public class ActionReselectorCustom : ActionReselector
    {
        public ActionReselectorCustom() : base()
        {
        }

        public override Action Reselect(Player player, List<Player> neighbours)
        {
            List<Player> selected = neighbours.Where(x => x.Payoff > player.Payoff).ToList();

            if (selected.Count == 0)
                return player.ChosenAction;
            else
                return neighbours[Generator.Next(neighbours.Count)].ChosenAction;
        }
    }
}
