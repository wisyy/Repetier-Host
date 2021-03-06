﻿namespace RepetierHost.view
{
    partial class FormTempMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTempMonitor));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.comboMonitor = new System.Windows.Forms.ComboBox();
            this.checkAutoscaleX = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonStartMonitor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStopMonitor = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.plotter = new RepetierHost.GraphLib.PlotterDisplayEx();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.comboMonitor);
            this.panelButtons.Controls.Add(this.checkAutoscaleX);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Controls.Add(this.buttonStartMonitor);
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.buttonStopMonitor);
            this.panelButtons.Controls.Add(this.buttonClear);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 627);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1161, 63);
            this.panelButtons.TabIndex = 8;
            // 
            // comboMonitor
            // 
            this.comboMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonitor.FormattingEnabled = true;
            this.comboMonitor.Items.AddRange(new object[] {
            "Extruder 0",
            "Extruder 1",
            "Extruder 2",
            "Extruder 3",
            "Heated bed"});
            this.comboMonitor.Location = new System.Drawing.Point(83, 18);
            this.comboMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboMonitor.Name = "comboMonitor";
            this.comboMonitor.Size = new System.Drawing.Size(220, 24);
            this.comboMonitor.TabIndex = 6;
            // 
            // checkAutoscaleX
            // 
            this.checkAutoscaleX.AutoSize = true;
            this.checkAutoscaleX.Location = new System.Drawing.Point(648, 21);
            this.checkAutoscaleX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkAutoscaleX.Name = "checkAutoscaleX";
            this.checkAutoscaleX.Size = new System.Drawing.Size(105, 21);
            this.checkAutoscaleX.TabIndex = 7;
            this.checkAutoscaleX.Text = "Autoscale X";
            this.checkAutoscaleX.UseVisualStyleBackColor = true;
            this.checkAutoscaleX.CheckedChanged += new System.EventHandler(this.checkAutoscaleX_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(1045, 18);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 28);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonStartMonitor
            // 
            this.buttonStartMonitor.Location = new System.Drawing.Point(317, 18);
            this.buttonStartMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStartMonitor.Name = "buttonStartMonitor";
            this.buttonStartMonitor.Size = new System.Drawing.Size(104, 28);
            this.buttonStartMonitor.TabIndex = 2;
            this.buttonStartMonitor.Text = "Start monitor";
            this.buttonStartMonitor.UseVisualStyleBackColor = true;
            this.buttonStartMonitor.Click += new System.EventHandler(this.buttonStartMonitor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monitor:";
            // 
            // buttonStopMonitor
            // 
            this.buttonStopMonitor.Location = new System.Drawing.Point(427, 17);
            this.buttonStopMonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStopMonitor.Name = "buttonStopMonitor";
            this.buttonStopMonitor.Size = new System.Drawing.Size(104, 28);
            this.buttonStopMonitor.TabIndex = 3;
            this.buttonStopMonitor.Text = "Stop monitor";
            this.buttonStopMonitor.UseVisualStyleBackColor = true;
            this.buttonStopMonitor.Click += new System.EventHandler(this.buttonStopMonitor_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(536, 16);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 28);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // plotter
            // 
            this.plotter.BackColor = System.Drawing.Color.Black;
            this.plotter.BackgroundColorBot = System.Drawing.Color.DimGray;
            this.plotter.BackgroundColorTop = System.Drawing.Color.Black;
            this.plotter.DashedGridColor = System.Drawing.Color.DarkGray;
            this.plotter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotter.DoubleBuffering = true;
            this.plotter.ForeColor = System.Drawing.Color.White;
            this.plotter.Location = new System.Drawing.Point(0, 0);
            this.plotter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.plotter.Name = "plotter";
            this.plotter.PlaySpeed = 0.5F;
            this.plotter.Size = new System.Drawing.Size(1161, 627);
            this.plotter.SolidGridColor = System.Drawing.Color.DarkGray;
            this.plotter.TabIndex = 0;
            // 
            // FormTempMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1161, 690);
            this.ControlBox = false;
            this.Controls.Add(this.plotter);
            this.Controls.Add(this.panelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTempMonitor";
            this.Text = "Temperature monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTempMonitor_FormClosing);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RepetierHost.GraphLib.PlotterDisplayEx plotter;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonStartMonitor;
        private System.Windows.Forms.Button buttonStopMonitor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMonitor;
        private System.Windows.Forms.CheckBox checkAutoscaleX;
        private System.Windows.Forms.Panel panelButtons;
    }
}