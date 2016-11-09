using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    abstract class Lattice
    {
        public Lattice(int height, int width)
        {
            this.Height = height;
            this.Width = width;

            player = new Player[height, width];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    this.player[i, j] = new Player();
        }

        public Player[,] player { get; protected set; }
        public int Height { get; protected set; }
        public int Width { get; protected set; }

        protected abstract List<Player> getNeighboursOfPlayer(int row, int column);
    }
}
