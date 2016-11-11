using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    abstract public class ActionReselector
    {
        public ActionReselector()
        {
        }

        public abstract Action Reselect(Player player, List<Player> neighbours);
    }
}
