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

        /// <summary>
        /// Toggle Elements for starting and stopping the simulation
        /// </summary>
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

        /// <summary>
        /// Starting a fresh simulation based on user input.
        /// </summary>
        private void RunProgram_Click(object sender, EventArgs e)
        {
            ToggleSim();
            OutputText.Clear();

            //convert values
            double energyOutWatts = decimal.ToDouble(EnergyOut.Value) * 1000;
            double waterSpeedMinutes = decimal.ToDouble(WaterSpeed.Value);
            double waterSpeedSeconds = waterSpeedMinutes / 60.0;
            //Capacities are in liters
            int pipeCapacity = decimal.ToInt32(PipeLength.Value) * 30;
            //1000 liters in a cubic meter
            int tankCapacity = decimal.ToInt32(TankCapacity.Value) * 1000;
            double startingTemp = decimal.ToDouble(StartingTemp.Value);

            //The amount of energy going into a liter of water each time it passes through the heating element
            double joulesPerLiter = energyOutWatts * waterSpeedSeconds;
            int numLiters = pipeCapacity + tankCapacity;

            //each double in this array represents a liter of water
            double[] waterTemps = new double[numLiters];

            //initialize water temperatures to starting temperature
            for(int i=0; i<numLiters; i++)
            {
                waterTemps[i] = startingTemp;
            }

            //Start new thread to allow stop button to work.
            new Thread(() =>
            {
                int minutes = 1;
                int curr = 0;
                int tankStart = pipeCapacity / 2;
                int tankEnd = tankStart + tankCapacity;
                while (running)
                {
                    //Change in temp = (energy in)/(mass * thermal constant)
                    //(modulo allows array to wrap around).
                    waterTemps[curr % waterTemps.Length] += joulesPerLiter / (GramsPerLiter * WaterSpecificHeat);

                    //curr can be thought of to represent how many liters have moved through the heating element
                    //Thus if curr % water speed in minutes = 0, a minute has passed
                    if (curr % waterSpeedMinutes == 0) {
                        double TankTemp = 0;
                        //Average Values in Tank
                        for (int j = tankStart; j < tankEnd; j++)
                        {
                            TankTemp += waterTemps[j % waterTemps.Length];
                        }
                        TankTemp /= tankCapacity;

                        //output results for t=now
                        Invoke(new Action(() => OutputText.AppendText("t = " + minutes + " minutes; Tank Temperature = " +
                            TankTemp + "°C" + Environment.NewLine)));
                        minutes++;
                    }

                    tankStart++;
                    tankEnd++;
                    curr++;
                }
            }).Start();
        }

        /// <summary>
        /// Force stop the simulation from user input
        /// </summary>
        private void StopButton_Click(object sender, EventArgs e)
        {
            ToggleSim();
        }
    }
}
