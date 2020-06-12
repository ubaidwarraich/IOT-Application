namespace SensorsGUI
{
    partial class SensorsGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorsGUI));
            this.ldrLabel = new System.Windows.Forms.Label();
            this.ldrValueLabel = new System.Windows.Forms.Label();
            this.part1groupBox = new System.Windows.Forms.GroupBox();
            this.ledStateLabel = new System.Windows.Forms.Label();
            this.panelLedState = new System.Windows.Forms.Panel();
            this.ledValueLabel = new System.Windows.Forms.Label();
            this.part2GroupBox = new System.Windows.Forms.GroupBox();
            this.fanStateLabel = new System.Windows.Forms.Label();
            this.fanStatePanel = new System.Windows.Forms.Panel();
            this.fanStateValue = new System.Windows.Forms.Label();
            this.temperatureLabelValue = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.part3groupbox = new System.Windows.Forms.GroupBox();
            this.smokeLedStateLAbel = new System.Windows.Forms.Label();
            this.panelSmokeState = new System.Windows.Forms.Panel();
            this.smokeLedState = new System.Windows.Forms.Label();
            this.labelSmokeSensorValue = new System.Windows.Forms.Label();
            this.smokeValueLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.timerToUpdateValues = new System.Windows.Forms.Timer(this.components);
            this.part1groupBox.SuspendLayout();
            this.panelLedState.SuspendLayout();
            this.part2GroupBox.SuspendLayout();
            this.fanStatePanel.SuspendLayout();
            this.part3groupbox.SuspendLayout();
            this.panelSmokeState.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ldrLabel
            // 
            this.ldrLabel.AutoSize = true;
            this.ldrLabel.Location = new System.Drawing.Point(69, 50);
            this.ldrLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ldrLabel.Name = "ldrLabel";
            this.ldrLabel.Size = new System.Drawing.Size(163, 29);
            this.ldrLabel.TabIndex = 0;
            this.ldrLabel.Text = "LDR Reading:";
            // 
            // ldrValueLabel
            // 
            this.ldrValueLabel.AutoSize = true;
            this.ldrValueLabel.Location = new System.Drawing.Point(225, 50);
            this.ldrValueLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ldrValueLabel.Name = "ldrValueLabel";
            this.ldrValueLabel.Size = new System.Drawing.Size(70, 29);
            this.ldrValueLabel.TabIndex = 1;
            this.ldrValueLabel.Text = "value";
            // 
            // part1groupBox
            // 
            this.part1groupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.part1groupBox.Controls.Add(this.ledStateLabel);
            this.part1groupBox.Controls.Add(this.panelLedState);
            this.part1groupBox.Controls.Add(this.ldrValueLabel);
            this.part1groupBox.Controls.Add(this.ldrLabel);
            this.part1groupBox.Location = new System.Drawing.Point(27, 12);
            this.part1groupBox.Name = "part1groupBox";
            this.part1groupBox.Size = new System.Drawing.Size(376, 230);
            this.part1groupBox.TabIndex = 2;
            this.part1groupBox.TabStop = false;
            this.part1groupBox.Text = "LDR and LED";
            // 
            // ledStateLabel
            // 
            this.ledStateLabel.AutoSize = true;
            this.ledStateLabel.Location = new System.Drawing.Point(130, 93);
            this.ledStateLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ledStateLabel.Name = "ledStateLabel";
            this.ledStateLabel.Size = new System.Drawing.Size(120, 29);
            this.ledStateLabel.TabIndex = 3;
            this.ledStateLabel.Text = "LED State";
            // 
            // panelLedState
            // 
            this.panelLedState.Controls.Add(this.ledValueLabel);
            this.panelLedState.Location = new System.Drawing.Point(114, 125);
            this.panelLedState.Name = "panelLedState";
            this.panelLedState.Size = new System.Drawing.Size(142, 65);
            this.panelLedState.TabIndex = 2;
            // 
            // ledValueLabel
            // 
            this.ledValueLabel.AutoSize = true;
            this.ledValueLabel.Location = new System.Drawing.Point(45, 18);
            this.ledValueLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ledValueLabel.Name = "ledValueLabel";
            this.ledValueLabel.Size = new System.Drawing.Size(50, 29);
            this.ledValueLabel.TabIndex = 4;
            this.ledValueLabel.Text = "ON";
            // 
            // part2GroupBox
            // 
            this.part2GroupBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.part2GroupBox.Controls.Add(this.fanStateLabel);
            this.part2GroupBox.Controls.Add(this.fanStatePanel);
            this.part2GroupBox.Controls.Add(this.temperatureLabelValue);
            this.part2GroupBox.Controls.Add(this.temperatureLabel);
            this.part2GroupBox.Location = new System.Drawing.Point(423, 12);
            this.part2GroupBox.Name = "part2GroupBox";
            this.part2GroupBox.Size = new System.Drawing.Size(376, 230);
            this.part2GroupBox.TabIndex = 3;
            this.part2GroupBox.TabStop = false;
            this.part2GroupBox.Text = "Temprature Moniter";
            // 
            // fanStateLabel
            // 
            this.fanStateLabel.AutoSize = true;
            this.fanStateLabel.Location = new System.Drawing.Point(138, 93);
            this.fanStateLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.fanStateLabel.Name = "fanStateLabel";
            this.fanStateLabel.Size = new System.Drawing.Size(115, 29);
            this.fanStateLabel.TabIndex = 5;
            this.fanStateLabel.Text = "Fan State";
            // 
            // fanStatePanel
            // 
            this.fanStatePanel.Controls.Add(this.fanStateValue);
            this.fanStatePanel.Location = new System.Drawing.Point(122, 125);
            this.fanStatePanel.Name = "fanStatePanel";
            this.fanStatePanel.Size = new System.Drawing.Size(142, 65);
            this.fanStatePanel.TabIndex = 4;
            // 
            // fanStateValue
            // 
            this.fanStateValue.AutoSize = true;
            this.fanStateValue.Location = new System.Drawing.Point(43, 17);
            this.fanStateValue.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.fanStateValue.Name = "fanStateValue";
            this.fanStateValue.Size = new System.Drawing.Size(50, 29);
            this.fanStateValue.TabIndex = 4;
            this.fanStateValue.Text = "ON";
            // 
            // temperatureLabelValue
            // 
            this.temperatureLabelValue.AutoSize = true;
            this.temperatureLabelValue.Location = new System.Drawing.Point(231, 50);
            this.temperatureLabelValue.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.temperatureLabelValue.Name = "temperatureLabelValue";
            this.temperatureLabelValue.Size = new System.Drawing.Size(70, 29);
            this.temperatureLabelValue.TabIndex = 1;
            this.temperatureLabelValue.Text = "value";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(67, 50);
            this.temperatureLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(159, 29);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "Temperature:";
            // 
            // part3groupbox
            // 
            this.part3groupbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.part3groupbox.Controls.Add(this.smokeLedStateLAbel);
            this.part3groupbox.Controls.Add(this.panelSmokeState);
            this.part3groupbox.Controls.Add(this.labelSmokeSensorValue);
            this.part3groupbox.Controls.Add(this.smokeValueLabel);
            this.part3groupbox.Location = new System.Drawing.Point(27, 281);
            this.part3groupbox.Name = "part3groupbox";
            this.part3groupbox.Size = new System.Drawing.Size(376, 249);
            this.part3groupbox.TabIndex = 4;
            this.part3groupbox.TabStop = false;
            this.part3groupbox.Text = "Smoke Detection";
            // 
            // smokeLedStateLAbel
            // 
            this.smokeLedStateLAbel.AutoSize = true;
            this.smokeLedStateLAbel.Location = new System.Drawing.Point(130, 126);
            this.smokeLedStateLAbel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.smokeLedStateLAbel.Name = "smokeLedStateLAbel";
            this.smokeLedStateLAbel.Size = new System.Drawing.Size(120, 29);
            this.smokeLedStateLAbel.TabIndex = 5;
            this.smokeLedStateLAbel.Text = "LED State";
            // 
            // panelSmokeState
            // 
            this.panelSmokeState.Controls.Add(this.smokeLedState);
            this.panelSmokeState.Location = new System.Drawing.Point(114, 158);
            this.panelSmokeState.Name = "panelSmokeState";
            this.panelSmokeState.Size = new System.Drawing.Size(142, 65);
            this.panelSmokeState.TabIndex = 4;
            // 
            // smokeLedState
            // 
            this.smokeLedState.AutoSize = true;
            this.smokeLedState.Location = new System.Drawing.Point(45, 18);
            this.smokeLedState.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.smokeLedState.Name = "smokeLedState";
            this.smokeLedState.Size = new System.Drawing.Size(50, 29);
            this.smokeLedState.TabIndex = 4;
            this.smokeLedState.Text = "ON";
            // 
            // labelSmokeSensorValue
            // 
            this.labelSmokeSensorValue.AutoSize = true;
            this.labelSmokeSensorValue.Location = new System.Drawing.Point(244, 74);
            this.labelSmokeSensorValue.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelSmokeSensorValue.Name = "labelSmokeSensorValue";
            this.labelSmokeSensorValue.Size = new System.Drawing.Size(70, 29);
            this.labelSmokeSensorValue.TabIndex = 1;
            this.labelSmokeSensorValue.Text = "value";
            // 
            // smokeValueLabel
            // 
            this.smokeValueLabel.AutoSize = true;
            this.smokeValueLabel.Location = new System.Drawing.Point(57, 74);
            this.smokeValueLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.smokeValueLabel.Name = "smokeValueLabel";
            this.smokeValueLabel.Size = new System.Drawing.Size(193, 29);
            this.smokeValueLabel.TabIndex = 0;
            this.smokeValueLabel.Text = "Sensor Reading:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(423, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 249);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LDR and LED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "LDR Reading:";
            // 
            // port
            // 
            this.port.PortName = "COM3";
            // 
            // timerToUpdateValues
            // 
            this.timerToUpdateValues.Interval = 900;
            this.timerToUpdateValues.Tick += new System.EventHandler(this.ldrTimer_Tick);
            // 
            // SensorsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(811, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.part3groupbox);
            this.Controls.Add(this.part2GroupBox);
            this.Controls.Add(this.part1groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "SensorsGUI";
            this.Text = "IOT Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SensorsGUI_FormClosing);
            this.Load += new System.EventHandler(this.SensorsGUI_Load);
            this.part1groupBox.ResumeLayout(false);
            this.part1groupBox.PerformLayout();
            this.panelLedState.ResumeLayout(false);
            this.panelLedState.PerformLayout();
            this.part2GroupBox.ResumeLayout(false);
            this.part2GroupBox.PerformLayout();
            this.fanStatePanel.ResumeLayout(false);
            this.fanStatePanel.PerformLayout();
            this.part3groupbox.ResumeLayout(false);
            this.part3groupbox.PerformLayout();
            this.panelSmokeState.ResumeLayout(false);
            this.panelSmokeState.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ldrLabel;
        private System.Windows.Forms.Label ldrValueLabel;
        private System.Windows.Forms.GroupBox part1groupBox;
        private System.Windows.Forms.Label ledStateLabel;
        private System.Windows.Forms.Panel panelLedState;
        private System.Windows.Forms.Label ledValueLabel;
        private System.Windows.Forms.GroupBox part2GroupBox;
        private System.Windows.Forms.Label temperatureLabelValue;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.GroupBox part3groupbox;
        private System.Windows.Forms.Label labelSmokeSensorValue;
        private System.Windows.Forms.Label smokeValueLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Timer timerToUpdateValues;
        private System.Windows.Forms.Label fanStateLabel;
        private System.Windows.Forms.Panel fanStatePanel;
        private System.Windows.Forms.Label fanStateValue;
        private System.Windows.Forms.Label smokeLedStateLAbel;
        private System.Windows.Forms.Panel panelSmokeState;
        private System.Windows.Forms.Label smokeLedState;
    }
}

