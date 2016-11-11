﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Spatial_games
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            int height = (int)numericUpDownHeight.Value;
            int width = (int)numericUpDownWidth.Value;
            int numberOfRounds = (int)numericUpDownRounds.Value;
            bool modelInTime = radioButtonTemporal.Checked;
            GameSymmetric game = radioButtonPrisonersDilemma.Checked ? new TrpsGame(10, 7, 0, 0) : new TrpsGame(10, 7, 0, 3);
            NeighbourhoodType neighbourhoodType = radioButtonMoore.Checked ? NeighbourhoodType.Moore : NeighbourhoodType.VonNeumann;

            Reselector reselector = radioButtonMax.Checked ? Reselector.Max : Reselector.Replicator;

            Lattice lattice = new Lattice(height, width, neighbourhoodType, game, reselector);

            using (Graphics graphics = picture.CreateGraphics())
            {
                this.clear(graphics);

                if (modelInTime)
                {
                    drawLattice(lattice, graphics);

                    for (int n = 0; n < numberOfRounds; n++)
                    {
                        Thread.Sleep(100);

                        lattice.NextRound();

                        drawLattice(lattice, graphics);
                    }
                }
                else
                {
                    lattice.PlayRounds(numberOfRounds);

                    drawLattice(lattice, graphics);
                }
            }

        }

        protected void drawLattice(Lattice lattice, Graphics graphics)
        {
            for (int i = 0; i < lattice.Height; i++)
                for (int j = 0; j < lattice.Width; j++)
                    if (lattice.player[i, j].ChosenAction == Action.One)
                        drawCell(i, j, Color.Red, graphics);
                    else
                        drawCell(i, j, Color.Yellow, graphics);
        }

        protected void clear(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, picture.Width, picture.Height);
        }

        protected void drawCell(int row, int column, Color color, Graphics graphics)
        {
            int size = 10;
            graphics.FillRectangle(new SolidBrush(color), row * size, column * size, size, size);
            graphics.DrawRectangle(new Pen(Color.Black), row * size, column * size, size, size);
        }
    }
}
