namespace Spatial_games
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRounds = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelRounds = new System.Windows.Forms.Label();
            this.groupBoxNeighbourhood = new System.Windows.Forms.GroupBox();
            this.radioButtonVonNeumann = new System.Windows.Forms.RadioButton();
            this.radioButtonMoore = new System.Windows.Forms.RadioButton();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.radioButtonSnowdrift = new System.Windows.Forms.RadioButton();
            this.radioButtonPrisonersDilemma = new System.Windows.Forms.RadioButton();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonReplicator = new System.Windows.Forms.RadioButton();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.groupBoxInTime = new System.Windows.Forms.GroupBox();
            this.radioButtonTemporal = new System.Windows.Forms.RadioButton();
            this.radioButtonInstant = new System.Windows.Forms.RadioButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageLattice = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePlot = new System.Windows.Forms.TabPage();
            this.tabControlPlot = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelMeanDeviation = new System.Windows.Forms.Label();
            this.chartDist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.numericUpDownSimulations = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownIntervals = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).BeginInit();
            this.groupBoxNeighbourhood.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxInTime.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageLattice.SuspendLayout();
            this.tabPagePlot.SuspendLayout();
            this.tabControlPlot.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSimulations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervals)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(191, 51);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(980, 500);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Location = new System.Drawing.Point(6, 6);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(165, 48);
            this.buttonSimulate.TabIndex = 2;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(529, 38);
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownWidth.TabIndex = 3;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(529, 12);
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownHeight.TabIndex = 4;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDownRounds
            // 
            this.numericUpDownRounds.Location = new System.Drawing.Point(529, 64);
            this.numericUpDownRounds.Name = "numericUpDownRounds";
            this.numericUpDownRounds.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownRounds.TabIndex = 5;
            this.numericUpDownRounds.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(468, 14);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(471, 45);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "Width";
            // 
            // labelRounds
            // 
            this.labelRounds.Location = new System.Drawing.Point(461, 64);
            this.labelRounds.Name = "labelRounds";
            this.labelRounds.Size = new System.Drawing.Size(62, 31);
            this.labelRounds.TabIndex = 8;
            this.labelRounds.Text = "Number of rounds";
            // 
            // groupBoxNeighbourhood
            // 
            this.groupBoxNeighbourhood.Controls.Add(this.radioButtonVonNeumann);
            this.groupBoxNeighbourhood.Controls.Add(this.radioButtonMoore);
            this.groupBoxNeighbourhood.Location = new System.Drawing.Point(12, 12);
            this.groupBoxNeighbourhood.Name = "groupBoxNeighbourhood";
            this.groupBoxNeighbourhood.Size = new System.Drawing.Size(140, 75);
            this.groupBoxNeighbourhood.TabIndex = 9;
            this.groupBoxNeighbourhood.TabStop = false;
            this.groupBoxNeighbourhood.Text = "Neighbourhood";
            // 
            // radioButtonVonNeumann
            // 
            this.radioButtonVonNeumann.AutoSize = true;
            this.radioButtonVonNeumann.Location = new System.Drawing.Point(10, 42);
            this.radioButtonVonNeumann.Name = "radioButtonVonNeumann";
            this.radioButtonVonNeumann.Size = new System.Drawing.Size(93, 17);
            this.radioButtonVonNeumann.TabIndex = 1;
            this.radioButtonVonNeumann.Text = "Von Neumann";
            this.radioButtonVonNeumann.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoore
            // 
            this.radioButtonMoore.AutoSize = true;
            this.radioButtonMoore.Checked = true;
            this.radioButtonMoore.Location = new System.Drawing.Point(10, 19);
            this.radioButtonMoore.Name = "radioButtonMoore";
            this.radioButtonMoore.Size = new System.Drawing.Size(55, 17);
            this.radioButtonMoore.TabIndex = 0;
            this.radioButtonMoore.TabStop = true;
            this.radioButtonMoore.Text = "Moore";
            this.radioButtonMoore.UseVisualStyleBackColor = true;
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.Controls.Add(this.radioButtonSnowdrift);
            this.groupBoxGame.Controls.Add(this.radioButtonPrisonersDilemma);
            this.groupBoxGame.Location = new System.Drawing.Point(158, 12);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(140, 75);
            this.groupBoxGame.TabIndex = 10;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Text = "Game";
            // 
            // radioButtonSnowdrift
            // 
            this.radioButtonSnowdrift.AutoSize = true;
            this.radioButtonSnowdrift.Checked = true;
            this.radioButtonSnowdrift.Location = new System.Drawing.Point(10, 42);
            this.radioButtonSnowdrift.Name = "radioButtonSnowdrift";
            this.radioButtonSnowdrift.Size = new System.Drawing.Size(69, 17);
            this.radioButtonSnowdrift.TabIndex = 3;
            this.radioButtonSnowdrift.TabStop = true;
            this.radioButtonSnowdrift.Text = "Snowdrift";
            this.radioButtonSnowdrift.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrisonersDilemma
            // 
            this.radioButtonPrisonersDilemma.AutoSize = true;
            this.radioButtonPrisonersDilemma.Location = new System.Drawing.Point(10, 19);
            this.radioButtonPrisonersDilemma.Name = "radioButtonPrisonersDilemma";
            this.radioButtonPrisonersDilemma.Size = new System.Drawing.Size(111, 17);
            this.radioButtonPrisonersDilemma.TabIndex = 2;
            this.radioButtonPrisonersDilemma.Text = "Prisoners Dilemma";
            this.radioButtonPrisonersDilemma.UseVisualStyleBackColor = true;
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.radioButtonCustom);
            this.groupBoxUpdate.Controls.Add(this.radioButtonReplicator);
            this.groupBoxUpdate.Controls.Add(this.radioButtonMax);
            this.groupBoxUpdate.Location = new System.Drawing.Point(304, 12);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(140, 96);
            this.groupBoxUpdate.TabIndex = 11;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Update mechanism";
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.Location = new System.Drawing.Point(10, 66);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(60, 17);
            this.radioButtonCustom.TabIndex = 4;
            this.radioButtonCustom.Text = "Custom";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonReplicator
            // 
            this.radioButtonReplicator.AutoSize = true;
            this.radioButtonReplicator.Checked = true;
            this.radioButtonReplicator.Location = new System.Drawing.Point(10, 42);
            this.radioButtonReplicator.Name = "radioButtonReplicator";
            this.radioButtonReplicator.Size = new System.Drawing.Size(73, 17);
            this.radioButtonReplicator.TabIndex = 3;
            this.radioButtonReplicator.TabStop = true;
            this.radioButtonReplicator.Text = "Replicator";
            this.radioButtonReplicator.UseVisualStyleBackColor = true;
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Location = new System.Drawing.Point(10, 19);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(45, 17);
            this.radioButtonMax.TabIndex = 2;
            this.radioButtonMax.Text = "Max";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // groupBoxInTime
            // 
            this.groupBoxInTime.Controls.Add(this.radioButtonTemporal);
            this.groupBoxInTime.Controls.Add(this.radioButtonInstant);
            this.groupBoxInTime.Location = new System.Drawing.Point(6, 70);
            this.groupBoxInTime.Name = "groupBoxInTime";
            this.groupBoxInTime.Size = new System.Drawing.Size(165, 71);
            this.groupBoxInTime.TabIndex = 12;
            this.groupBoxInTime.TabStop = false;
            this.groupBoxInTime.Text = "Time";
            // 
            // radioButtonTemporal
            // 
            this.radioButtonTemporal.AutoSize = true;
            this.radioButtonTemporal.Location = new System.Drawing.Point(10, 42);
            this.radioButtonTemporal.Name = "radioButtonTemporal";
            this.radioButtonTemporal.Size = new System.Drawing.Size(69, 17);
            this.radioButtonTemporal.TabIndex = 3;
            this.radioButtonTemporal.Text = "Temporal";
            this.radioButtonTemporal.UseVisualStyleBackColor = true;
            // 
            // radioButtonInstant
            // 
            this.radioButtonInstant.AutoSize = true;
            this.radioButtonInstant.Checked = true;
            this.radioButtonInstant.Location = new System.Drawing.Point(10, 19);
            this.radioButtonInstant.Name = "radioButtonInstant";
            this.radioButtonInstant.Size = new System.Drawing.Size(57, 17);
            this.radioButtonInstant.TabIndex = 2;
            this.radioButtonInstant.TabStop = true;
            this.radioButtonInstant.Text = "Instant";
            this.radioButtonInstant.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageLattice);
            this.tabControl.Controls.Add(this.tabPagePlot);
            this.tabControl.Location = new System.Drawing.Point(12, 92);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1185, 600);
            this.tabControl.TabIndex = 13;
            // 
            // tabPageLattice
            // 
            this.tabPageLattice.Controls.Add(this.label2);
            this.tabPageLattice.Controls.Add(this.label1);
            this.tabPageLattice.Controls.Add(this.buttonSimulate);
            this.tabPageLattice.Controls.Add(this.picture);
            this.tabPageLattice.Controls.Add(this.groupBoxInTime);
            this.tabPageLattice.Location = new System.Drawing.Point(4, 22);
            this.tabPageLattice.Name = "tabPageLattice";
            this.tabPageLattice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLattice.Size = new System.Drawing.Size(1177, 574);
            this.tabPageLattice.TabIndex = 0;
            this.tabPageLattice.Text = "Lattice";
            this.tabPageLattice.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(345, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Yellow - Defect";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(197, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Red - Cooperate";
            // 
            // tabPagePlot
            // 
            this.tabPagePlot.Controls.Add(this.tabControlPlot);
            this.tabPagePlot.Controls.Add(this.buttonPlot);
            this.tabPagePlot.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlot.Name = "tabPagePlot";
            this.tabPagePlot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlot.Size = new System.Drawing.Size(1177, 574);
            this.tabPagePlot.TabIndex = 1;
            this.tabPagePlot.Text = "Plot";
            this.tabPagePlot.UseVisualStyleBackColor = true;
            // 
            // tabControlPlot
            // 
            this.tabControlPlot.Controls.Add(this.tabPage1);
            this.tabControlPlot.Controls.Add(this.tabPage2);
            this.tabControlPlot.Location = new System.Drawing.Point(190, 6);
            this.tabControlPlot.Name = "tabControlPlot";
            this.tabControlPlot.SelectedIndex = 0;
            this.tabControlPlot.Size = new System.Drawing.Size(974, 558);
            this.tabControlPlot.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(966, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FractionTime";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartTime
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTime.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTime.Legends.Add(legend3);
            this.chartTime.Location = new System.Drawing.Point(6, 6);
            this.chartTime.Name = "chartTime";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTime.Series.Add(series3);
            this.chartTime.Size = new System.Drawing.Size(955, 508);
            this.chartTime.TabIndex = 1;
            this.chartTime.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelMeanDeviation);
            this.tabPage2.Controls.Add(this.chartDist);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fraction Distribution";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelMeanDeviation
            // 
            this.labelMeanDeviation.AutoSize = true;
            this.labelMeanDeviation.Location = new System.Drawing.Point(44, 13);
            this.labelMeanDeviation.Name = "labelMeanDeviation";
            this.labelMeanDeviation.Size = new System.Drawing.Size(0, 13);
            this.labelMeanDeviation.TabIndex = 17;
            // 
            // chartDist
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDist.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDist.Legends.Add(legend4);
            this.chartDist.Location = new System.Drawing.Point(3, 38);
            this.chartDist.Name = "chartDist";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDist.Series.Add(series4);
            this.chartDist.Size = new System.Drawing.Size(955, 491);
            this.chartDist.TabIndex = 16;
            this.chartDist.Text = "chartDist";
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(6, 6);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(165, 48);
            this.buttonPlot.TabIndex = 0;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // numericUpDownSimulations
            // 
            this.numericUpDownSimulations.Location = new System.Drawing.Point(665, 14);
            this.numericUpDownSimulations.Name = "numericUpDownSimulations";
            this.numericUpDownSimulations.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownSimulations.TabIndex = 14;
            this.numericUpDownSimulations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(597, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Number of simulations";
            // 
            // numericUpDownIntervals
            // 
            this.numericUpDownIntervals.Location = new System.Drawing.Point(665, 54);
            this.numericUpDownIntervals.Name = "numericUpDownIntervals";
            this.numericUpDownIntervals.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownIntervals.TabIndex = 16;
            this.numericUpDownIntervals.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(597, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Number of distribution intervals";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 694);
            this.Controls.Add(this.numericUpDownIntervals);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownSimulations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBoxNeighbourhood);
            this.Controls.Add(this.groupBoxGame);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownRounds);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.labelRounds);
            this.Controls.Add(this.labelHeight);
            this.Name = "MainForm";
            this.Text = "Spatial game";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).EndInit();
            this.groupBoxNeighbourhood.ResumeLayout(false);
            this.groupBoxNeighbourhood.PerformLayout();
            this.groupBoxGame.ResumeLayout(false);
            this.groupBoxGame.PerformLayout();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.groupBoxInTime.ResumeLayout(false);
            this.groupBoxInTime.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageLattice.ResumeLayout(false);
            this.tabPageLattice.PerformLayout();
            this.tabPagePlot.ResumeLayout(false);
            this.tabControlPlot.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTime)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSimulations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownRounds;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelRounds;
        private System.Windows.Forms.GroupBox groupBoxNeighbourhood;
        private System.Windows.Forms.RadioButton radioButtonVonNeumann;
        private System.Windows.Forms.RadioButton radioButtonMoore;
        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.RadioButton radioButtonSnowdrift;
        private System.Windows.Forms.RadioButton radioButtonPrisonersDilemma;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.RadioButton radioButtonReplicator;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.GroupBox groupBoxInTime;
        private System.Windows.Forms.RadioButton radioButtonTemporal;
        private System.Windows.Forms.RadioButton radioButtonInstant;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageLattice;
        private System.Windows.Forms.TabPage tabPagePlot;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlPlot;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDownSimulations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDist;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMeanDeviation;
        private System.Windows.Forms.RadioButton radioButtonCustom;
    }
}

