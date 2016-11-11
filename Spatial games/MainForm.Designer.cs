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
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRounds = new System.Windows.Forms.NumericUpDown();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelRounds = new System.Windows.Forms.Label();
            this.groupBoxNeighbourhood = new System.Windows.Forms.GroupBox();
            this.radioButtonMoore = new System.Windows.Forms.RadioButton();
            this.radioButtonVonNeumann = new System.Windows.Forms.RadioButton();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.radioButtonSnowdrift = new System.Windows.Forms.RadioButton();
            this.radioButtonPrisonersDilemma = new System.Windows.Forms.RadioButton();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.radioButtonReplicator = new System.Windows.Forms.RadioButton();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.groupBoxInTime = new System.Windows.Forms.GroupBox();
            this.radioButtonTemporal = new System.Windows.Forms.RadioButton();
            this.radioButtonInstant = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRounds)).BeginInit();
            this.groupBoxNeighbourhood.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxInTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(158, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1000, 500);
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Location = new System.Drawing.Point(12, 12);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(121, 48);
            this.buttonSimulate.TabIndex = 2;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(77, 102);
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
            this.numericUpDownHeight.Location = new System.Drawing.Point(77, 76);
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
            this.numericUpDownRounds.Location = new System.Drawing.Point(77, 128);
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
            this.labelHeight.Location = new System.Drawing.Point(16, 78);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(19, 109);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "Width";
            // 
            // labelRounds
            // 
            this.labelRounds.Location = new System.Drawing.Point(9, 128);
            this.labelRounds.Name = "labelRounds";
            this.labelRounds.Size = new System.Drawing.Size(62, 31);
            this.labelRounds.TabIndex = 8;
            this.labelRounds.Text = "Number of rounds";
            // 
            // groupBoxNeighbourhood
            // 
            this.groupBoxNeighbourhood.Controls.Add(this.radioButtonVonNeumann);
            this.groupBoxNeighbourhood.Controls.Add(this.radioButtonMoore);
            this.groupBoxNeighbourhood.Location = new System.Drawing.Point(12, 162);
            this.groupBoxNeighbourhood.Name = "groupBoxNeighbourhood";
            this.groupBoxNeighbourhood.Size = new System.Drawing.Size(140, 70);
            this.groupBoxNeighbourhood.TabIndex = 9;
            this.groupBoxNeighbourhood.TabStop = false;
            this.groupBoxNeighbourhood.Text = "Neighbourhood";
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
            // groupBoxGame
            // 
            this.groupBoxGame.Controls.Add(this.radioButtonSnowdrift);
            this.groupBoxGame.Controls.Add(this.radioButtonPrisonersDilemma);
            this.groupBoxGame.Location = new System.Drawing.Point(12, 238);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(140, 75);
            this.groupBoxGame.TabIndex = 10;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Text = "Game";
            // 
            // radioButtonSnowdrift
            // 
            this.radioButtonSnowdrift.AutoSize = true;
            this.radioButtonSnowdrift.Location = new System.Drawing.Point(10, 42);
            this.radioButtonSnowdrift.Name = "radioButtonSnowdrift";
            this.radioButtonSnowdrift.Size = new System.Drawing.Size(69, 17);
            this.radioButtonSnowdrift.TabIndex = 3;
            this.radioButtonSnowdrift.Text = "Snowdrift";
            this.radioButtonSnowdrift.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrisonersDilemma
            // 
            this.radioButtonPrisonersDilemma.AutoSize = true;
            this.radioButtonPrisonersDilemma.Checked = true;
            this.radioButtonPrisonersDilemma.Location = new System.Drawing.Point(10, 19);
            this.radioButtonPrisonersDilemma.Name = "radioButtonPrisonersDilemma";
            this.radioButtonPrisonersDilemma.Size = new System.Drawing.Size(111, 17);
            this.radioButtonPrisonersDilemma.TabIndex = 2;
            this.radioButtonPrisonersDilemma.TabStop = true;
            this.radioButtonPrisonersDilemma.Text = "Prisoners Dilemma";
            this.radioButtonPrisonersDilemma.UseVisualStyleBackColor = true;
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.radioButtonReplicator);
            this.groupBoxUpdate.Controls.Add(this.radioButtonMax);
            this.groupBoxUpdate.Location = new System.Drawing.Point(12, 319);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(140, 71);
            this.groupBoxUpdate.TabIndex = 11;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Update mechanism";
            // 
            // radioButtonReplicator
            // 
            this.radioButtonReplicator.AutoSize = true;
            this.radioButtonReplicator.Location = new System.Drawing.Point(10, 42);
            this.radioButtonReplicator.Name = "radioButtonReplicator";
            this.radioButtonReplicator.Size = new System.Drawing.Size(73, 17);
            this.radioButtonReplicator.TabIndex = 3;
            this.radioButtonReplicator.Text = "Replicator";
            this.radioButtonReplicator.UseVisualStyleBackColor = true;
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Checked = true;
            this.radioButtonMax.Location = new System.Drawing.Point(10, 19);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(45, 17);
            this.radioButtonMax.TabIndex = 2;
            this.radioButtonMax.TabStop = true;
            this.radioButtonMax.Text = "Max";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // groupBoxInTime
            // 
            this.groupBoxInTime.Controls.Add(this.radioButtonTemporal);
            this.groupBoxInTime.Controls.Add(this.radioButtonInstant);
            this.groupBoxInTime.Location = new System.Drawing.Point(12, 396);
            this.groupBoxInTime.Name = "groupBoxInTime";
            this.groupBoxInTime.Size = new System.Drawing.Size(140, 71);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 591);
            this.Controls.Add(this.groupBoxInTime);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupBoxGame);
            this.Controls.Add(this.groupBoxNeighbourhood);
            this.Controls.Add(this.labelRounds);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.buttonSimulate);
            this.Controls.Add(this.numericUpDownRounds);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
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
    }
}

