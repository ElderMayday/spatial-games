using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spatial_games
{
    public class Lattice
    {
        public Lattice(int height, int width, NeighbourhoodType neighbourhoodType, GameSymmetric game, Reselector reselector)
        {
            this.Height = height;
            this.Width = width;

            switch (neighbourhoodType)
            {
                case NeighbourhoodType.Moore: this.NeighbourDeterminer = new NeighbourDeterminerMoore(this); break;
                case NeighbourhoodType.VonNeumann: this.NeighbourDeterminer = new NeighbourDeterminerVonNeumann(this); break;
            }

            this.Game = game;

            switch (reselector)
            {
                case Reselector.Max: ActionReselector = new ActionReselectorMax(); break;
                case Reselector.Replicator: ActionReselector = new ActionReselectorReplicator(Game.maxPayoff, Game.minPayoff); break;
            }

            player = new Player[height, width];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    this.player[i, j] = new Player();
        }

        public void PlayRounds(int number)
        {
            for (int i = 0; i < number; i++)
                this.NextRound();
        }

        public void NextRound()
        {
            foreach (var playerCurrent in player)
                playerCurrent.Payoff = 0;

            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                {
                    var neighbours = NeighbourDeterminer.Determine(i, j);

                    foreach (var neighbour in neighbours)
                        this.player[i, j].Payoff += this.Game.GetPayoff(this.player[i, j].ChosenAction, neighbour.ChosenAction);
                }

            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                {
                    var neighbours = NeighbourDeterminer.Determine(i, j);
                    this.player[i, j].ChosenAction = this.ActionReselector.Reselect(this.player[i, j], neighbours);
                }
        }

        public Player[,] player { get; protected set; }
        public int Height { get; protected set; }
        public int Width { get; protected set; }
        public NeighbourDeterminer NeighbourDeterminer { get; protected set; }
        public GameSymmetric Game { get; protected set; }
        public ActionReselector ActionReselector { get; protected set; }
    }
}
