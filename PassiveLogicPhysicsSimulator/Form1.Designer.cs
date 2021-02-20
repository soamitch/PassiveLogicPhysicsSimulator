namespace PassiveLogicPhysicsSimulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.EnergyLabel.Size = new System.Drawing.Size(490, 25);
            this.EnergyLabel.TabIndex = 2;
            this.EnergyLabel.Text = "Energy Output of Solar Panel (Joules per Second)";
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
            this.label3.Size = new System.Drawing.Size(328, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Capacity of Storage Tank (Liters)";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 370);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
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
            this.EnergyOut.Name = "EnergyOut";
            this.EnergyOut.Size = new System.Drawing.Size(120, 31);
            this.EnergyOut.TabIndex = 12;
            // 
            // WaterSpeed
            // 
            this.WaterSpeed.DecimalPlaces = 2;
            this.WaterSpeed.Location = new System.Drawing.Point(18, 135);
            this.WaterSpeed.Name = "WaterSpeed";
            this.WaterSpeed.Size = new System.Drawing.Size(120, 31);
            this.WaterSpeed.TabIndex = 13;
            // 
            // PipeLength
            // 
            this.PipeLength.Location = new System.Drawing.Point(18, 228);
            this.PipeLength.Name = "PipeLength";
            this.PipeLength.Size = new System.Drawing.Size(120, 31);
            this.PipeLength.TabIndex = 14;
            // 
            // TankCapacity
            // 
            this.TankCapacity.Location = new System.Drawing.Point(18, 321);
            this.TankCapacity.Name = "TankCapacity";
            this.TankCapacity.Size = new System.Drawing.Size(120, 31);
            this.TankCapacity.TabIndex = 15;
            // 
            // StartingTemp
            // 
            this.StartingTemp.DecimalPlaces = 2;
            this.StartingTemp.Location = new System.Drawing.Point(525, 49);
            this.StartingTemp.Name = "StartingTemp";
            this.StartingTemp.Size = new System.Drawing.Size(120, 31);
            this.StartingTemp.TabIndex = 17;
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
            this.StopButton.Location = new System.Drawing.Point(240, 532);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(231, 56);
            this.StopButton.TabIndex = 18;
            this.StopButton.Text = "Stop Simulation";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 771);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

