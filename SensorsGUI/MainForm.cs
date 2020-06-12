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
        bool pwm_sent = false;
        string led_state = "OFF";
        string fan_state = "OFF";
        string room_temperature;
        string pwm_value;
        string motor_state="OFF";
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
                        room_temperature = read[2];
                        fan_state = read[1];
                    }
                    else if (read[0] == "SMOKE")
                    {
                        smoke_value = read[2];
                        smoke_led_state = read[1];
                    }
                    else if(read[0] == "MOTOR")
                    {
                        pwm_value = read[2];
                        motor_state = read[1];
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
                if (int.Parse(room_temperature) >= 30)
                {
                    temperatureLabelValue.BackColor = Color.Yellow;
                }
                else if (int.Parse(room_temperature) >= 40)
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
                if (motor_state == "ON")
                {
                    panelMotorState.BackColor = Color.Green;
                }
                else if (motor_state == "OFF")
                {
                    panelMotorState.BackColor = Color.IndianRed;
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
            pwnValueG.Text = pwm_value;
            temperatureLabelValue.Text = room_temperature;
            labelSmokeSensorValue.Text = smoke_value;
            smokeLedState.Text = smoke_led_state;
            stateMotorLabel.Text = motor_state;
        }

        private void pwnValueG_Click(object sender, EventArgs e)
        {

        }
    }
  
}
