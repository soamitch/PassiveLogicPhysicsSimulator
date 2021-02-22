namespace PassiveLogicPhysicsSimulator
{
    partial class PhysicsSim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhysicsSim));
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RunProgram = new System.Windows.Forms.Button();
            this.EnergyOut = new System.Windows.Forms.NumericUpDown();
            this.WaterSpeed = new System.Windows.Forms.NumericUpDown();
            this.PipeLength = new System.Windows.Forms.NumericUpDown();
            this.TankCapacity = new System.Windows.Forms.NumericUpDown();
            this.StartingTemp = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TankCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.AutoSize = true;
            this.EnergyLabel.Location = new System.Drawing.Point(12, 9);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(404, 25);
            this.EnergyLabel.TabIndex = 2;
            this.EnergyLabel.Text = "Energy Input from Solar Panel (Kilowatts)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed of Water (Liters per Minute)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Length of Piping (Meters)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Capacity of Storage Tank (Meters^3)";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(12, 370);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(459, 143);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // RunProgram
            // 
            this.RunProgram.Location = new System.Drawing.Point(12, 532);
            this.RunProgram.Name = "RunProgram";
            this.RunProgram.Size = new System.Drawing.Size(222, 56);
            this.RunProgram.TabIndex = 11;
            this.RunProgram.Text = "Start Simulation";
            this.RunProgram.UseVisualStyleBackColor = true;
            this.RunProgram.Click += new System.EventHandler(this.RunProgram_Click);
            // 
            // EnergyOut
            // 
            this.EnergyOut.DecimalPlaces = 2;
            this.EnergyOut.Location = new System.Drawing.Point(18, 49);
            this.EnergyOut.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.EnergyOut.Name = "EnergyOut";
            this.EnergyOut.Size = new System.Drawing.Size(120, 31);
            this.EnergyOut.TabIndex = 1;
            this.EnergyOut.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // WaterSpeed
            // 
            this.WaterSpeed.DecimalPlaces = 2;
            this.WaterSpeed.Location = new System.Drawing.Point(18, 135);
            this.WaterSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WaterSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.WaterSpeed.Name = "WaterSpeed";
            this.WaterSpeed.Size = new System.Drawing.Size(120, 31);
            this.WaterSpeed.TabIndex = 13;
            this.WaterSpeed.Value = new decimal(new int[] {
            6000,
            0,
            0,
            131072});
            // 
            // PipeLength
            // 
            this.PipeLength.Location = new System.Drawing.Point(18, 228);
            this.PipeLength.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.PipeLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PipeLength.Name = "PipeLength";
            this.PipeLength.Size = new System.Drawing.Size(120, 31);
            this.PipeLength.TabIndex = 14;
            this.PipeLength.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // TankCapacity
            // 
            this.TankCapacity.Location = new System.Drawing.Point(18, 321);
            this.TankCapacity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.TankCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TankCapacity.Name = "TankCapacity";
            this.TankCapacity.Size = new System.Drawing.Size(120, 31);
            this.TankCapacity.TabIndex = 15;
            this.TankCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartingTemp
            // 
            this.StartingTemp.DecimalPlaces = 2;
            this.StartingTemp.Location = new System.Drawing.Point(525, 49);
            this.StartingTemp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.StartingTemp.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.StartingTemp.Name = "StartingTemp";
            this.StartingTemp.Size = new System.Drawing.Size(120, 31);
            this.StartingTemp.TabIndex = 17;
            this.StartingTemp.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Starting Water Temp (Celsius)";
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(240, 532);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(231, 56);
            this.StopButton.TabIndex = 18;
            this.StopButton.Text = "Stop Simulation";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // OutputText
            // 
            this.OutputText.AcceptsReturn = true;
            this.OutputText.AcceptsTab = true;
            this.OutputText.Location = new System.Drawing.Point(525, 124);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(827, 464);
            this.OutputText.TabIndex = 19;
            // 
            // PhysicsSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 655);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartingTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TankCapacity);
            this.Controls.Add(this.PipeLength);
            this.Controls.Add(this.WaterSpeed);
            this.Controls.Add(this.EnergyOut);
            this.Controls.Add(this.RunProgram);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnergyLabel);
            this.Name = "PhysicsSim";
            this.Text = "Solar Panel Heat Transfer Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.EnergyOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TankCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartingTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnergyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RunProgram;
        private System.Windows.Forms.NumericUpDown EnergyOut;
        private System.Windows.Forms.NumericUpDown WaterSpeed;
        private System.Windows.Forms.NumericUpDown PipeLength;
        private System.Windows.Forms.NumericUpDown TankCapacity;
        private System.Windows.Forms.NumericUpDown StartingTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox OutputText;
    }
}

