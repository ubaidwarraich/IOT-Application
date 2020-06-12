using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorsGUI
{
    public partial class SensorsGUI : Form
    {
        string smoke_led_state = "OFF";
        string smoke_value;
        string ldr_value;
        public SensorsGUI()
        {
            InitializeComponent();
        }
       
        private void SensorsGUI_Load(object sender, EventArgs e)
        {
            try
            {
                port.Open();
                timerToUpdateValues.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        string led_state = "OFF";
        string fan_state = "OFF";
        string tem_val;
        private string getValues()
        {
            string result = "";
            try
            {
                string reading = port.ReadLine();
                string[] readings = reading.Split(' ');
                foreach (string line in readings)
                {
                    string[] read = line.Split(':');
                    if (read[0] == "LED")
                    {
                        led_state = read[1];
                        ldr_value = read[2];
                    }
                    else if (read[0] == "FAN")
                    {
                        tem_val = read[2];
                        fan_state = read[1];
                    }
                    else if (read[0] == "SMOKE")
                    {
                        smoke_value = read[2];
                        smoke_led_state = read[1];
                    }
                }
            }
            catch
            {
                Thread.Sleep(100);
            }
            return result;
        }

        private void SensorsGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.Close();
        }

        private async void ldrTimer_Tick(object sender, EventArgs e)
        {
            Task<string> t = new Task<string>(getValues);
            t.Start();
            string result= await t;
            updateAllSensorsValues();
            updateAllStatesResults();
        }

        private void updateAllStatesResults()
        {
            try
            {
                if (int.Parse(tem_val) >= 30)
                {
                    temperatureLabelValue.BackColor = Color.Yellow;
                }
                else if (int.Parse(tem_val) >= 40)
                {
                    temperatureLabelValue.BackColor = Color.Orange;
                }
                if (fan_state == "ON")
                {
                    fanStatePanel.BackColor = Color.Green;
                }
                else if (fan_state == "OFF")
                {
                    fanStatePanel.BackColor = Color.IndianRed;
                }
                if (smoke_led_state == "ON")
                {
                    panelSmokeState.BackColor = Color.Green;
                }
                else if (smoke_led_state == "OFF")
                {
                    panelSmokeState.BackColor = Color.IndianRed;
                }
                if (led_state == "ON")
                {
                    panelLedState.BackColor = Color.Green;
                }
                else if (led_state == "OFF")
                {
                    panelLedState.BackColor = Color.IndianRed;
                }
            }
            catch
            {
                Thread.Sleep(100);
            }
        }

        private void updateAllSensorsValues()
        {
            ldrValueLabel.Text = ldr_value;
            ledValueLabel.Text = led_state;
            fanStateValue.Text = fan_state;
            temperatureLabelValue.Text = tem_val;
            labelSmokeSensorValue.Text = smoke_value;
            smokeLedState.Text = smoke_led_state;
        }
    }
  
}
