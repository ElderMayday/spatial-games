using System;
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
            int height = 50, width = 50;
            int numberOfRounds = 50;
            bool modelInTime = false;
            GameSymmetric game = new PrisonersDilemma(10, 7, 0, 0);
            NeighbourhoodType neighbourhoodType = NeighbourhoodType.Moore;
            ActionReselector actionReselector = new ActionReselectorMax();


            Lattice lattice = new Lattice(height, width, neighbourhoodType, game, actionReselector);

            

            using (Graphics g = picture.CreateGraphics())
            {
                if (modelInTime)
                    for (int n = 0; n < numberOfRounds; n++)
                    {
                        lattice.NextRound();

                        for (int i = 0; i < lattice.Height; i++)
                            for (int j = 0; j < lattice.Width; j++)
                                if (lattice.player[i, j].ChosenAction == Action.One)
                                    drawCell(i, j, Color.Red, g);
                                else
                                    drawCell(i, j, Color.Yellow, g);

                        Thread.Sleep(100);
                    }
                else
                {
                    lattice.PlayRounds(numberOfRounds);

                    for (int i = 0; i < lattice.Height; i++)
                        for (int j = 0; j < lattice.Width; j++)
                            if (lattice.player[i, j].ChosenAction == Action.One)
                                drawCell(i, j, Color.Red, g);
                            else
                                drawCell(i, j, Color.Yellow, g);
                }
            }

        }

        protected void drawCell(int row, int column, Color color, Graphics g)
        {
            int size = 10;
            g.FillRectangle(new SolidBrush(color), row * size, column * size, size, size);
            g.DrawRectangle(new Pen(Color.Black), row * size, column * size, size, size);
        }
    }
}
