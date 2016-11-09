using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    class NeighbourDeterminerMoore : NeighbourDeterminer
    {
        public NeighbourDeterminerMoore(Lattice lattice) : base(lattice)
        {
        }

        public override List<Player> Determine(int row, int column)
        {
            List<Player> result = new List<Player>();

            int rowUp, rowDown, columnLeft, columnRight;

            rowUp = row > 0 ? row - 1 : this.Lattice.Height - 1;
            rowDown = row < this.Lattice.Height - 1 ? row + 1 : 0;
            columnLeft = column > 0 ? column - 1 : this.Lattice.Width - 1;
            columnRight = column < this.Lattice.Width - 1 ? column + 1 : 0;

            result.Add(this.Lattice.player[rowUp, columnLeft]);
            result.Add(this.Lattice.player[rowUp, column]);
            result.Add(this.Lattice.player[rowUp, columnRight]);
            result.Add(this.Lattice.player[row, columnLeft]);
            result.Add(this.Lattice.player[row, columnRight]);
            result.Add(this.Lattice.player[rowDown, columnLeft]);
            result.Add(this.Lattice.player[rowDown, column]);
            result.Add(this.Lattice.player[rowDown, columnRight]);

            return result;
        }
    }
}
