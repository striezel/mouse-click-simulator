/*
    This file is part of the mouse click simulator.
    Copyright (C) 2022  Dirk Stolle

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Windows.Forms;

namespace mouse_click_simulator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbWindows = new System.Windows.Forms.GroupBox();
            this.lbWindows = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbClicks = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbCoordinates = new System.Windows.Forms.GroupBox();
            this.lblCoordinateY = new System.Windows.Forms.Label();
            this.lblCoordinateX = new System.Windows.Forms.Label();
            this.numericUpDownCoordY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCoordX = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbClickTiming = new System.Windows.Forms.GroupBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.gbMouseButtons = new System.Windows.Forms.GroupBox();
            this.cbMiddleMouseButton = new System.Windows.Forms.CheckBox();
            this.cbRightMouseButton = new System.Windows.Forms.CheckBox();
            this.cbLeftMouseButton = new System.Windows.Forms.CheckBox();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.gbWindows.SuspendLayout();
            this.gbClicks.SuspendLayout();
            this.gbCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordX)).BeginInit();
            this.gbClickTiming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.gbMouseButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWindows
            // 
            this.gbWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWindows.Controls.Add(this.lbWindows);
            this.gbWindows.Controls.Add(this.btnRefresh);
            this.gbWindows.Location = new System.Drawing.Point(12, 12);
            this.gbWindows.Name = "gbWindows";
            this.gbWindows.Size = new System.Drawing.Size(379, 426);
            this.gbWindows.TabIndex = 0;
            this.gbWindows.TabStop = false;
            this.gbWindows.Text = "Available target windows:";
            // 
            // lbWindows
            // 
            this.lbWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWindows.Enabled = false;
            this.lbWindows.FormattingEnabled = true;
            this.lbWindows.ItemHeight = 15;
            this.lbWindows.Items.AddRange(new object[] {
            "Click the button above to get a list of available windows."});
            this.lbWindows.Location = new System.Drawing.Point(6, 51);
            this.lbWindows.Name = "lbWindows";
            this.lbWindows.Size = new System.Drawing.Size(367, 364);
            this.lbWindows.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(203, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh window list";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // gbClicks
            // 
            this.gbClicks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClicks.Controls.Add(this.btnStop);
            this.gbClicks.Controls.Add(this.gbCoordinates);
            this.gbClicks.Controls.Add(this.btnStart);
            this.gbClicks.Controls.Add(this.gbClickTiming);
            this.gbClicks.Controls.Add(this.gbMouseButtons);
            this.gbClicks.Location = new System.Drawing.Point(409, 12);
            this.gbClicks.Name = "gbClicks";
            this.gbClicks.Size = new System.Drawing.Size(379, 426);
            this.gbClicks.TabIndex = 1;
            this.gbClicks.TabStop = false;
            this.gbClicks.Text = "Click properties:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(175, 292);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // gbCoordinates
            // 
            this.gbCoordinates.Controls.Add(this.lblCoordinateY);
            this.gbCoordinates.Controls.Add(this.lblCoordinateX);
            this.gbCoordinates.Controls.Add(this.numericUpDownCoordY);
            this.gbCoordinates.Controls.Add(this.numericUpDownCoordX);
            this.gbCoordinates.Location = new System.Drawing.Point(6, 197);
            this.gbCoordinates.Name = "gbCoordinates";
            this.gbCoordinates.Size = new System.Drawing.Size(367, 89);
            this.gbCoordinates.TabIndex = 3;
            this.gbCoordinates.TabStop = false;
            this.gbCoordinates.Text = "Coordinates";
            // 
            // lblCoordinateY
            // 
            this.lblCoordinateY.AutoSize = true;
            this.lblCoordinateY.Location = new System.Drawing.Point(6, 53);
            this.lblCoordinateY.Name = "lblCoordinateY";
            this.lblCoordinateY.Size = new System.Drawing.Size(17, 15);
            this.lblCoordinateY.TabIndex = 3;
            this.lblCoordinateY.Text = "Y:";
            // 
            // lblCoordinateX
            // 
            this.lblCoordinateX.AutoSize = true;
            this.lblCoordinateX.Location = new System.Drawing.Point(6, 24);
            this.lblCoordinateX.Name = "lblCoordinateX";
            this.lblCoordinateX.Size = new System.Drawing.Size(17, 15);
            this.lblCoordinateX.TabIndex = 2;
            this.lblCoordinateX.Text = "X:";
            // 
            // numericUpDownCoordY
            // 
            this.numericUpDownCoordY.Location = new System.Drawing.Point(88, 51);
            this.numericUpDownCoordY.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.numericUpDownCoordY.Name = "numericUpDownCoordY";
            this.numericUpDownCoordY.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCoordY.TabIndex = 1;
            // 
            // numericUpDownCoordX
            // 
            this.numericUpDownCoordX.Location = new System.Drawing.Point(88, 22);
            this.numericUpDownCoordX.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDownCoordX.Name = "numericUpDownCoordX";
            this.numericUpDownCoordX.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCoordX.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(94, 292);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // gbClickTiming
            // 
            this.gbClickTiming.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClickTiming.Controls.Add(this.lblInterval);
            this.gbClickTiming.Controls.Add(this.numericUpDownInterval);
            this.gbClickTiming.Location = new System.Drawing.Point(6, 131);
            this.gbClickTiming.Name = "gbClickTiming";
            this.gbClickTiming.Size = new System.Drawing.Size(367, 60);
            this.gbClickTiming.TabIndex = 1;
            this.gbClickTiming.TabStop = false;
            this.gbClickTiming.Text = "Interval";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(6, 24);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(76, 15);
            this.lblInterval.TabIndex = 1;
            this.lblInterval.Text = "Milliseconds:";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(88, 22);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownInterval.TabIndex = 0;
            this.numericUpDownInterval.ThousandsSeparator = true;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // gbMouseButtons
            // 
            this.gbMouseButtons.Controls.Add(this.cbMiddleMouseButton);
            this.gbMouseButtons.Controls.Add(this.cbRightMouseButton);
            this.gbMouseButtons.Controls.Add(this.cbLeftMouseButton);
            this.gbMouseButtons.Location = new System.Drawing.Point(6, 22);
            this.gbMouseButtons.Name = "gbMouseButtons";
            this.gbMouseButtons.Size = new System.Drawing.Size(348, 103);
            this.gbMouseButtons.TabIndex = 0;
            this.gbMouseButtons.TabStop = false;
            this.gbMouseButtons.Text = "Mouse buttons";
            // 
            // cbMiddleMouseButton
            // 
            this.cbMiddleMouseButton.AutoSize = true;
            this.cbMiddleMouseButton.Location = new System.Drawing.Point(6, 47);
            this.cbMiddleMouseButton.Name = "cbMiddleMouseButton";
            this.cbMiddleMouseButton.Size = new System.Drawing.Size(141, 19);
            this.cbMiddleMouseButton.TabIndex = 2;
            this.cbMiddleMouseButton.Text = "middle mouse button";
            this.cbMiddleMouseButton.UseVisualStyleBackColor = true;
            // 
            // cbRightMouseButton
            // 
            this.cbRightMouseButton.AutoSize = true;
            this.cbRightMouseButton.Location = new System.Drawing.Point(6, 72);
            this.cbRightMouseButton.Name = "cbRightMouseButton";
            this.cbRightMouseButton.Size = new System.Drawing.Size(129, 19);
            this.cbRightMouseButton.TabIndex = 1;
            this.cbRightMouseButton.Text = "right mouse button";
            this.cbRightMouseButton.UseVisualStyleBackColor = true;
            // 
            // cbLeftMouseButton
            // 
            this.cbLeftMouseButton.AutoSize = true;
            this.cbLeftMouseButton.Checked = true;
            this.cbLeftMouseButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLeftMouseButton.Location = new System.Drawing.Point(6, 22);
            this.cbLeftMouseButton.Name = "cbLeftMouseButton";
            this.cbLeftMouseButton.Size = new System.Drawing.Size(121, 19);
            this.cbLeftMouseButton.TabIndex = 0;
            this.cbLeftMouseButton.Text = "left mouse button";
            this.cbLeftMouseButton.UseVisualStyleBackColor = true;
            // 
            // timerClick
            // 
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbClicks);
            this.Controls.Add(this.gbWindows);
            this.Name = "MainForm";
            this.Text = "Mouse click simulator";
            this.gbWindows.ResumeLayout(false);
            this.gbClicks.ResumeLayout(false);
            this.gbCoordinates.ResumeLayout(false);
            this.gbCoordinates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCoordX)).EndInit();
            this.gbClickTiming.ResumeLayout(false);
            this.gbClickTiming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.gbMouseButtons.ResumeLayout(false);
            this.gbMouseButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbWindows;
        private ListBox lbWindows;
        private Button btnRefresh;
        private GroupBox gbClicks;
        private GroupBox gbMouseButtons;
        private CheckBox cbRightMouseButton;
        private CheckBox cbLeftMouseButton;
        private GroupBox gbClickTiming;
        private NumericUpDown numericUpDownInterval;
        private Label lblInterval;
        private Button btnStart;
        private CheckBox cbMiddleMouseButton;
        private GroupBox gbCoordinates;
        private NumericUpDown numericUpDownCoordY;
        private NumericUpDown numericUpDownCoordX;
        private Label lblCoordinateY;
        private Label lblCoordinateX;
        private Button btnStop;
        private Timer timerClick;
    }
}