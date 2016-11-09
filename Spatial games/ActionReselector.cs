using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    abstract class ActionReselector
    {
        public ActionReselector()
        {
        }

        public abstract Action Reselect(List<Player> neighbours);
    }
}
