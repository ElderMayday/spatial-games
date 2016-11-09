using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    abstract class NeighbourDeterminer
    {
        public NeighbourDeterminer(Lattice lattice)
        {
            this.Lattice = lattice;
        }

        abstract public List<Player> Determine(int row, int column);

        public Lattice Lattice { get; protected set; }
    }
}
