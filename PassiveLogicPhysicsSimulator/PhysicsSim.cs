using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassiveLogicPhysicsSimulator
{
    public partial class PhysicsSim : Form
    {
        private const double WaterSpecificHeat = 4.184;
        private const int GramsPerLiter = 1000;
        private bool running = false;

        public PhysicsSim()
        {
            InitializeComponent();
        }

        private void ToggleSim()
        {
            RunProgram.Enabled = !RunProgram.Enabled;
            StopButton.Enabled = !StopButton.Enabled;
            EnergyOut.Enabled = !EnergyOut.Enabled;
            WaterSpeed.Enabled = !WaterSpeed.Enabled;
            PipeLength.Enabled = !PipeLength.Enabled;
            TankCapacity.Enabled = !TankCapacity.Enabled;
            StartingTemp.Enabled = !StartingTemp.Enabled;
            running = !running;
        }

        private void RunProgram_Click(object sender, EventArgs e)
        {
            ToggleSim();
            OutputText.Clear();

            //convert values
            double energyOutWatts = decimal.ToDouble(EnergyOut.Value) * 1000;
            double waterSpeed = decimal.ToDouble(WaterSpeed.Value);
            //Capacities are in liters
            int pipeCapacity = decimal.ToInt32(PipeLength.Value) * 30;
            //1000 liters in a cubic meter
            int tankCapacity = decimal.ToInt32(TankCapacity.Value) * 1000;
            double startingTemp = decimal.ToDouble(StartingTemp.Value);

            //The amount of energy going into a liter of water each time it passes through the heating element
            double joulesPerLiter = energyOutWatts * (waterSpeed / 60.0);
            int numLiters = pipeCapacity + tankCapacity;

            double[] waterTemps = new double[numLiters];

            for(int i=0; i<numLiters; i++)
            {
                waterTemps[i] = startingTemp;
            }

            new Thread(() =>
            {
                int minutes = 0;
                int curr = 0;
                int tankStart = pipeCapacity / 2;
                int tankEnd = tankStart + tankCapacity;
                while (running)
                {
                    //Change in temp = (energy in)/(mass * thermal constant)
                    waterTemps[curr % waterTemps.Length] += joulesPerLiter / (GramsPerLiter * WaterSpecificHeat);

                    if (curr % waterSpeed == 0) {
                        minutes++;
                        double TankTemp = 0;
                        //TODO: Average Values in Tank
                        for (int j = tankStart; j < tankEnd; j++)
                        {
                            TankTemp += waterTemps[j % waterTemps.Length];
                        }
                        TankTemp /= tankCapacity;

                        //TODO: output results for t=now
                        Invoke(new Action(() => OutputText.AppendText("t = " + minutes + " minutes; Tank Temperature = " +
                            TankTemp + "°C" + Environment.NewLine)));
                    }

                    //modulo allows array to wrap around
                    tankStart++;
                    tankEnd++;
                    curr++;
                }
            }).Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ToggleSim();
        }
    }
}
