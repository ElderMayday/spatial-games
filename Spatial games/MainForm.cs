using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

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
                        Thread.Sleep(500);

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

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            chartTime.Series.Clear();

            int numberOfExperiments = (int)numericUpDownSimulations.Value;

            int numberOfRounds = (int)numericUpDownRounds.Value;
            int height = (int)numericUpDownHeight.Value;
            int width = (int)numericUpDownWidth.Value;
            GameSymmetric game = radioButtonPrisonersDilemma.Checked ? new TrpsGame(10, 7, 0, 0) : new TrpsGame(10, 7, 0, 3);
            NeighbourhoodType neighbourhoodType = radioButtonMoore.Checked ? NeighbourhoodType.Moore : NeighbourhoodType.VonNeumann;
            Reselector reselector = radioButtonMax.Checked ? Reselector.Max : Reselector.Replicator;

            List<double>[] fraction = new List<double>[numberOfRounds + 1];

            for (int round = 0; round < numberOfRounds + 1; round++)
                fraction[round] = new List<double>();

            for (int experiment = 0; experiment < numberOfExperiments; experiment++)
            {
                Lattice lattice = new Lattice(height, width, neighbourhoodType, game, reselector);
                
                fraction[0].Add(lattice.RatioActionOne);

                for (int round = 1; round < numberOfRounds + 1; round++)
                {
                    lattice.NextRound();
                    fraction[round].Add(lattice.RatioActionOne);
                }
            }

            chartTime.Series.Add("Cooperation");
            chartTime.Series["Cooperation"].ChartType = SeriesChartType.FastLine;
            chartTime.Series["Cooperation"].Color = Color.Red;
            chartTime.Series["Cooperation"].BorderWidth = 3;
            chartTime.ChartAreas[0].AxisY.Maximum = 1.0;
            chartTime.ChartAreas[0].AxisY.Minimum = 0.0;
            chartTime.ChartAreas[0].AxisX.Maximum = numberOfRounds;
            chartTime.ChartAreas[0].AxisX.Minimum = 0.0;

            for (int round = 0; round < numberOfRounds + 1; round++)
                chartTime.Series["Cooperation"].Points.AddXY(round, fraction[round].Sum() / (double)numberOfExperiments);
        }
    }
}
