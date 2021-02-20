using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassiveLogicPhysicsSimulator
{
    public partial class Form1 : Form
    {
        private const double WaterSpecificHeat = 4.184;
        private const double GramsPerLiter = 1000;
        private bool running = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void RunProgram_Click(object sender, EventArgs e)
        {
            RunProgram.Enabled = false;
            StopButton.Enabled = true;
            running = true;

            //convert values
            double energyOut = decimal.ToDouble(EnergyOut.Value);
            double waterSpeed = decimal.ToDouble(WaterSpeed.Value);
            int pipeLength = decimal.ToInt32(PipeLength.Value);
            int tankCapacity = decimal.ToInt32(TankCapacity.Value);
            double startingTemp = decimal.ToDouble(StartingTemp.Value);

            //The amount of energy going into a liter of water each time it passes through the heating element
            double joulesPerLiter = energyOut * (waterSpeed / 60.0);
            int numLiters = pipeLength + tankCapacity;

            double[] waterTemps = new double[numLiters];

            for(int i=0; i<numLiters; i++)
            {
                waterTemps[i] = startingTemp;
            }

            while (running)
            {
                //TODO: Change Values in current liter

                //TODO: Average Values in Tank

                //TODO: output results for t=now
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            running = false;
        }
    }
}
