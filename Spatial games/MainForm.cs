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
            Reselector reselector;

            if (radioButtonMax.Checked)
                reselector = Reselector.Max;
            else if (radioButtonReplicator.Checked)
                reselector = Reselector.Replicator;
            else
                reselector = Reselector.Custom;

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
            simulateMultiple();
            plotTime();
            calculateDistribution();
            plotDistribution();
        }

        protected void simulateMultiple()
        {
            experimentNumber = (int)numericUpDownSimulations.Value;
            roundNumber = (int)numericUpDownRounds.Value;
            int height = (int)numericUpDownHeight.Value;
            int width = (int)numericUpDownWidth.Value;
            GameSymmetric game = radioButtonPrisonersDilemma.Checked ? new TrpsGame(10, 7, 0, 0) : new TrpsGame(10, 7, 0, 3);
            NeighbourhoodType neighbourhoodType = radioButtonMoore.Checked ? NeighbourhoodType.Moore : NeighbourhoodType.VonNeumann;
            Reselector reselector;

            if (radioButtonMax.Checked)
                reselector = Reselector.Max;
            else if (radioButtonReplicator.Checked)
                reselector = Reselector.Replicator;
            else
                reselector = Reselector.Custom;

            fraction = new List<double>[roundNumber + 1];

            for (int round = 0; round < roundNumber + 1; round++)
                fraction[round] = new List<double>();

            for (int experiment = 0; experiment < experimentNumber; experiment++)
            {
                Lattice lattice = new Lattice(height, width, neighbourhoodType, game, reselector);

                fraction[0].Add(lattice.RatioActionOne);

                for (int round = 1; round < roundNumber + 1; round++)
                {
                    lattice.NextRound();
                    fraction[round].Add(lattice.RatioActionOne);
                }
            }
        }

        protected void plotTime()
        {
            chartTime.Series.Clear();

            chartTime.Series.Add("Cooperation");
            chartTime.Series["Cooperation"].ChartType = SeriesChartType.FastLine;
            chartTime.Series["Cooperation"].Color = Color.Red;
            chartTime.Series["Cooperation"].BorderWidth = 3;

            chartTime.ChartAreas[0].AxisX.Title = "Round";
            chartTime.ChartAreas[0].AxisY.Title = "Fraction";
            chartTime.ChartAreas[0].AxisY.Maximum = 1.0;
            chartTime.ChartAreas[0].AxisY.Minimum = 0.0;
            chartTime.ChartAreas[0].AxisX.Maximum = roundNumber;
            chartTime.ChartAreas[0].AxisX.Minimum = 0.0;

            if (roundNumber >= 20)
                chartTime.ChartAreas[0].AxisX.Interval = 10.0;

            for (int round = 0; round < roundNumber + 1; round++)
                chartTime.Series["Cooperation"].Points.AddXY(round, fraction[round].Sum() / (double)experimentNumber);
        }

        protected void calculateDistribution()
        {
            intervalNumber = (int)numericUpDownIntervals.Value;

            List<double> values = fraction[roundNumber];
            double mean = values.Sum() / (double)experimentNumber;
            double deviation = Math.Sqrt(values.Sum(x => Math.Pow(x - mean, 2.0)) / (double) experimentNumber);

            /*if (deviation > 0.001)
            {
                leftValue = mean - 3 * deviation;
                rightValue = mean + 3 * deviation;
            }
            else
            {
                leftValue = mean - 0.1;
                rightValue = mean + 0.1;
            }*/

            leftValue = -0.1; rightValue = 1.1;

            intervalWidth = (rightValue - leftValue) / (double)intervalNumber;

            probability = new double[intervalNumber];

            foreach (double value in values)
            {
                int index = (int)Math.Ceiling((value - leftValue) / intervalWidth);

                if ((index >= 0) && (index < intervalNumber))
                    probability[index]++;
            }

            for (int i = 0; i < intervalNumber; i++)
                probability[i] /= experimentNumber;

            labelMeanDeviation.Text = "Mean = " + mean.ToString() + "; Deviation = " + deviation.ToString();
        }

        protected void plotDistribution()
        {
            chartDist.Series.Clear();

            chartDist.Series.Add("Probability");
            chartDist.Series["Probability"].ChartType = SeriesChartType.Column;
            chartDist.Series["Probability"].Color = Color.Blue;
            chartDist.Series["Probability"].BorderWidth = 3;

            chartDist.ChartAreas[0].AxisX.Title = "Fraction";
            chartDist.ChartAreas[0].AxisY.Title = "Probability";
            chartDist.ChartAreas[0].AxisY.Minimum = 0.0;
            chartDist.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.00}";
            chartDist.ChartAreas[0].AxisX.Maximum = rightValue;
            chartDist.ChartAreas[0].AxisX.Minimum = leftValue;

            /*if (leftValue < 0.0)
                chartDist.ChartAreas[0].AxisX.Minimum = -0.1;

            if (rightValue > 1.0)
                chartDist.ChartAreas[0].AxisX.Maximum = 1.1;*/

            for (int i = 0; i < intervalNumber; i++)
                chartDist.Series["Probability"].Points.AddXY(leftValue + i * intervalWidth, probability[i]);
        }

        protected double leftValue, rightValue, intervalWidth;
        protected double[] probability;
        protected int intervalNumber;
        protected int roundNumber;
        protected List<double>[] fraction;
        protected int experimentNumber;
    }
}
