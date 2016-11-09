using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    class LatticeMoore : Lattice
    {
        public LatticeMoore(int height, int width) : base(height, width)
        {
        }

        protected override List<Player> getNeighboursOfPlayer(int row, int column)
        {
            List<Player> result = new List<Player>();

            int rowUp, rowDown, columnLeft, columnRight;

            rowUp = row > 0 ? row - 1 : this.Height - 1;
            rowDown = row < this.Height - 1 ? row + 1 : 0;
            columnLeft = column > 0 ? column - 1 : this.Width - 1;
            columnRight = column < this.Width - 1 ? column + 1 : 0;

            result.Add(this.player[rowUp, columnLeft]);
            result.Add(this.player[rowUp, column]);
            result.Add(this.player[rowUp, columnRight]);
            result.Add(this.player[row, columnLeft]);
            result.Add(this.player[row, columnRight]);
            result.Add(this.player[rowDown, columnLeft]);
            result.Add(this.player[rowDown, column]);
            result.Add(this.player[rowDown, columnRight]);

            return result;
        }
    }
}
