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
            components = new System.ComponentModel.Container();
            gbWindows = new GroupBox();
            lbWindows = new ListBox();
            btnRefresh = new Button();
            gbClicks = new GroupBox();
            gbSyncAsync = new GroupBox();
            rbAsync = new RadioButton();
            rbSynchronous = new RadioButton();
            btnStop = new Button();
            gbCoordinates = new GroupBox();
            lblCoordinateY = new Label();
            lblCoordinateX = new Label();
            numericUpDownCoordY = new NumericUpDown();
            numericUpDownCoordX = new NumericUpDown();
            btnStart = new Button();
            gbClickTiming = new GroupBox();
            lblInterval = new Label();
            numericUpDownInterval = new NumericUpDown();
            gbMouseButtons = new GroupBox();
            cbMiddleMouseButton = new CheckBox();
            cbRightMouseButton = new CheckBox();
            cbLeftMouseButton = new CheckBox();
            timerClick = new Timer(components);
            menuStripMain = new MenuStrip();
            tsmiProgram = new ToolStripMenuItem();
            tsmiClose = new ToolStripMenuItem();
            tsmiSettings = new ToolStripMenuItem();
            tsmiLoadPresetAtStartup = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tsmiSaveCurrentSettingsAsPreset = new ToolStripMenuItem();
            tsmiLoadPresetNow = new ToolStripMenuItem();
            tsmiInformation = new ToolStripMenuItem();
            tsmiVersion = new ToolStripMenuItem();
            gbWindows.SuspendLayout();
            gbClicks.SuspendLayout();
            gbSyncAsync.SuspendLayout();
            gbCoordinates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCoordY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCoordX).BeginInit();
            gbClickTiming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterval).BeginInit();
            gbMouseButtons.SuspendLayout();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // gbWindows
            // 
            gbWindows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbWindows.Controls.Add(lbWindows);
            gbWindows.Controls.Add(btnRefresh);
            gbWindows.Location = new System.Drawing.Point(12, 36);
            gbWindows.Name = "gbWindows";
            gbWindows.Size = new System.Drawing.Size(379, 463);
            gbWindows.TabIndex = 0;
            gbWindows.TabStop = false;
            gbWindows.Text = "Available target windows:";
            // 
            // lbWindows
            // 
            lbWindows.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbWindows.Enabled = false;
            lbWindows.FormattingEnabled = true;
            lbWindows.ItemHeight = 15;
            lbWindows.Items.AddRange(new object[] { "Click the button above to get a list of available windows." });
            lbWindows.Location = new System.Drawing.Point(6, 51);
            lbWindows.Name = "lbWindows";
            lbWindows.Size = new System.Drawing.Size(367, 394);
            lbWindows.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.arrow_circle_double;
            btnRefresh.Location = new System.Drawing.Point(6, 22);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(203, 23);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh window list";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += Refresh_Click;
            // 
            // gbClicks
            // 
            gbClicks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gbClicks.Controls.Add(gbSyncAsync);
            gbClicks.Controls.Add(btnStop);
            gbClicks.Controls.Add(gbCoordinates);
            gbClicks.Controls.Add(btnStart);
            gbClicks.Controls.Add(gbClickTiming);
            gbClicks.Controls.Add(gbMouseButtons);
            gbClicks.Location = new System.Drawing.Point(409, 36);
            gbClicks.Name = "gbClicks";
            gbClicks.Size = new System.Drawing.Size(379, 463);
            gbClicks.TabIndex = 1;
            gbClicks.TabStop = false;
            gbClicks.Text = "Click properties:";
            // 
            // gbSyncAsync
            // 
            gbSyncAsync.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbSyncAsync.Controls.Add(rbAsync);
            gbSyncAsync.Controls.Add(rbSynchronous);
            gbSyncAsync.Location = new System.Drawing.Point(6, 322);
            gbSyncAsync.Name = "gbSyncAsync";
            gbSyncAsync.Size = new System.Drawing.Size(367, 60);
            gbSyncAsync.TabIndex = 5;
            gbSyncAsync.TabStop = false;
            gbSyncAsync.Text = "Message dispatch";
            // 
            // rbAsync
            // 
            rbAsync.AutoSize = true;
            rbAsync.Location = new System.Drawing.Point(179, 26);
            rbAsync.Name = "rbAsync";
            rbAsync.Size = new System.Drawing.Size(99, 19);
            rbAsync.TabIndex = 1;
            rbAsync.Text = "asynchronous";
            rbAsync.UseVisualStyleBackColor = true;
            // 
            // rbSynchronous
            // 
            rbSynchronous.AutoSize = true;
            rbSynchronous.Checked = true;
            rbSynchronous.Location = new System.Drawing.Point(47, 26);
            rbSynchronous.Name = "rbSynchronous";
            rbSynchronous.Size = new System.Drawing.Size(93, 19);
            rbSynchronous.TabIndex = 0;
            rbSynchronous.TabStop = true;
            rbSynchronous.Text = "synchronous";
            rbSynchronous.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Image = Properties.Resources.control_stop_square;
            btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStop.Location = new System.Drawing.Point(175, 388);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(75, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += Stop_Click;
            // 
            // gbCoordinates
            // 
            gbCoordinates.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbCoordinates.Controls.Add(lblCoordinateY);
            gbCoordinates.Controls.Add(lblCoordinateX);
            gbCoordinates.Controls.Add(numericUpDownCoordY);
            gbCoordinates.Controls.Add(numericUpDownCoordX);
            gbCoordinates.Location = new System.Drawing.Point(6, 227);
            gbCoordinates.Name = "gbCoordinates";
            gbCoordinates.Size = new System.Drawing.Size(367, 89);
            gbCoordinates.TabIndex = 3;
            gbCoordinates.TabStop = false;
            gbCoordinates.Text = "Coordinates";
            // 
            // lblCoordinateY
            // 
            lblCoordinateY.AutoSize = true;
            lblCoordinateY.Location = new System.Drawing.Point(6, 53);
            lblCoordinateY.Name = "lblCoordinateY";
            lblCoordinateY.Size = new System.Drawing.Size(17, 15);
            lblCoordinateY.TabIndex = 3;
            lblCoordinateY.Text = "Y:";
            // 
            // lblCoordinateX
            // 
            lblCoordinateX.AutoSize = true;
            lblCoordinateX.Location = new System.Drawing.Point(6, 24);
            lblCoordinateX.Name = "lblCoordinateX";
            lblCoordinateX.Size = new System.Drawing.Size(17, 15);
            lblCoordinateX.TabIndex = 2;
            lblCoordinateX.Text = "X:";
            // 
            // numericUpDownCoordY
            // 
            numericUpDownCoordY.Location = new System.Drawing.Point(88, 51);
            numericUpDownCoordY.Maximum = new decimal(new int[] { 1080, 0, 0, 0 });
            numericUpDownCoordY.Name = "numericUpDownCoordY";
            numericUpDownCoordY.Size = new System.Drawing.Size(120, 23);
            numericUpDownCoordY.TabIndex = 1;
            // 
            // numericUpDownCoordX
            // 
            numericUpDownCoordX.Location = new System.Drawing.Point(88, 22);
            numericUpDownCoordX.Maximum = new decimal(new int[] { 1920, 0, 0, 0 });
            numericUpDownCoordX.Name = "numericUpDownCoordX";
            numericUpDownCoordX.Size = new System.Drawing.Size(120, 23);
            numericUpDownCoordX.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Image = Properties.Resources.control;
            btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStart.Location = new System.Drawing.Point(94, 388);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += Start_Click;
            // 
            // gbClickTiming
            // 
            gbClickTiming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbClickTiming.Controls.Add(lblInterval);
            gbClickTiming.Controls.Add(numericUpDownInterval);
            gbClickTiming.Location = new System.Drawing.Point(6, 161);
            gbClickTiming.Name = "gbClickTiming";
            gbClickTiming.Size = new System.Drawing.Size(367, 60);
            gbClickTiming.TabIndex = 1;
            gbClickTiming.TabStop = false;
            gbClickTiming.Text = "Interval";
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Location = new System.Drawing.Point(6, 24);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new System.Drawing.Size(76, 15);
            lblInterval.TabIndex = 1;
            lblInterval.Text = "Milliseconds:";
            // 
            // numericUpDownInterval
            // 
            numericUpDownInterval.Location = new System.Drawing.Point(88, 22);
            numericUpDownInterval.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            numericUpDownInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownInterval.Name = "numericUpDownInterval";
            numericUpDownInterval.Size = new System.Drawing.Size(120, 23);
            numericUpDownInterval.TabIndex = 0;
            numericUpDownInterval.ThousandsSeparator = true;
            numericUpDownInterval.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // gbMouseButtons
            // 
            gbMouseButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbMouseButtons.Controls.Add(cbMiddleMouseButton);
            gbMouseButtons.Controls.Add(cbRightMouseButton);
            gbMouseButtons.Controls.Add(cbLeftMouseButton);
            gbMouseButtons.Location = new System.Drawing.Point(6, 22);
            gbMouseButtons.Name = "gbMouseButtons";
            gbMouseButtons.Size = new System.Drawing.Size(367, 133);
            gbMouseButtons.TabIndex = 0;
            gbMouseButtons.TabStop = false;
            gbMouseButtons.Text = "Mouse buttons";
            // 
            // cbMiddleMouseButton
            // 
            cbMiddleMouseButton.Image = Properties.Resources.mouse_select_wheel;
            cbMiddleMouseButton.Location = new System.Drawing.Point(6, 57);
            cbMiddleMouseButton.Name = "cbMiddleMouseButton";
            cbMiddleMouseButton.Size = new System.Drawing.Size(157, 29);
            cbMiddleMouseButton.TabIndex = 2;
            cbMiddleMouseButton.Text = "middle mouse button";
            cbMiddleMouseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbMiddleMouseButton.UseVisualStyleBackColor = true;
            // 
            // cbRightMouseButton
            // 
            cbRightMouseButton.Image = Properties.Resources.mouse_select_right;
            cbRightMouseButton.Location = new System.Drawing.Point(6, 92);
            cbRightMouseButton.Name = "cbRightMouseButton";
            cbRightMouseButton.Size = new System.Drawing.Size(157, 29);
            cbRightMouseButton.TabIndex = 1;
            cbRightMouseButton.Text = "right mouse button";
            cbRightMouseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbRightMouseButton.UseVisualStyleBackColor = true;
            // 
            // cbLeftMouseButton
            // 
            cbLeftMouseButton.Checked = true;
            cbLeftMouseButton.CheckState = CheckState.Checked;
            cbLeftMouseButton.Image = Properties.Resources.mouse_select_left;
            cbLeftMouseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            cbLeftMouseButton.Location = new System.Drawing.Point(6, 22);
            cbLeftMouseButton.Name = "cbLeftMouseButton";
            cbLeftMouseButton.Size = new System.Drawing.Size(137, 29);
            cbLeftMouseButton.TabIndex = 0;
            cbLeftMouseButton.Text = "left mouse button";
            cbLeftMouseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            cbLeftMouseButton.UseVisualStyleBackColor = true;
            // 
            // timerClick
            // 
            timerClick.Tick += TimerClick_Tick;
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { tsmiProgram, tsmiSettings, tsmiInformation });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new System.Drawing.Size(800, 24);
            menuStripMain.TabIndex = 2;
            menuStripMain.Text = "menuStrip1";
            // 
            // tsmiProgram
            // 
            tsmiProgram.DropDownItems.AddRange(new ToolStripItem[] { tsmiClose });
            tsmiProgram.Name = "tsmiProgram";
            tsmiProgram.Size = new System.Drawing.Size(65, 20);
            tsmiProgram.Text = "&Program";
            // 
            // tsmiClose
            // 
            tsmiClose.Image = Properties.Resources.control_power;
            tsmiClose.Name = "tsmiClose";
            tsmiClose.Size = new System.Drawing.Size(103, 22);
            tsmiClose.Text = "&Close";
            tsmiClose.Click += Close_Click;
            // 
            // tsmiSettings
            // 
            tsmiSettings.DropDownItems.AddRange(new ToolStripItem[] { tsmiLoadPresetAtStartup, toolStripSeparator1, tsmiSaveCurrentSettingsAsPreset, tsmiLoadPresetNow });
            tsmiSettings.Name = "tsmiSettings";
            tsmiSettings.Size = new System.Drawing.Size(61, 20);
            tsmiSettings.Text = "Settings";
            // 
            // tsmiLoadPresetAtStartup
            // 
            tsmiLoadPresetAtStartup.Name = "tsmiLoadPresetAtStartup";
            tsmiLoadPresetAtStartup.Size = new System.Drawing.Size(232, 22);
            tsmiLoadPresetAtStartup.Text = "Load preset at startup";
            tsmiLoadPresetAtStartup.Click += LoadPresetAtStartup_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiSaveCurrentSettingsAsPreset
            // 
            tsmiSaveCurrentSettingsAsPreset.Image = Properties.Resources.disk;
            tsmiSaveCurrentSettingsAsPreset.Name = "tsmiSaveCurrentSettingsAsPreset";
            tsmiSaveCurrentSettingsAsPreset.Size = new System.Drawing.Size(232, 22);
            tsmiSaveCurrentSettingsAsPreset.Text = "Save current settings as preset";
            tsmiSaveCurrentSettingsAsPreset.Click += SaveCurrentSettingsAsPreset_Click;
            // 
            // tsmiLoadPresetNow
            // 
            tsmiLoadPresetNow.Image = Properties.Resources.folder_horizontal_open;
            tsmiLoadPresetNow.Name = "tsmiLoadPresetNow";
            tsmiLoadPresetNow.Size = new System.Drawing.Size(232, 22);
            tsmiLoadPresetNow.Text = "Load preset now";
            // 
            // tsmiInformation
            // 
            tsmiInformation.DropDownItems.AddRange(new ToolStripItem[] { tsmiVersion });
            tsmiInformation.Name = "tsmiInformation";
            tsmiInformation.Size = new System.Drawing.Size(82, 20);
            tsmiInformation.Text = "&Information";
            // 
            // tsmiVersion
            // 
            tsmiVersion.Image = Properties.Resources.information;
            tsmiVersion.Name = "tsmiVersion";
            tsmiVersion.Size = new System.Drawing.Size(112, 22);
            tsmiVersion.Text = "&Version";
            tsmiVersion.Click += Version_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 511);
            Controls.Add(gbClicks);
            Controls.Add(gbWindows);
            Controls.Add(menuStripMain);
            Icon = Properties.Resources.mouse_icon;
            MainMenuStrip = menuStripMain;
            MinimumSize = new System.Drawing.Size(500, 425);
            Name = "MainForm";
            Text = "Mouse Click Simulator";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            gbWindows.ResumeLayout(false);
            gbClicks.ResumeLayout(false);
            gbSyncAsync.ResumeLayout(false);
            gbSyncAsync.PerformLayout();
            gbCoordinates.ResumeLayout(false);
            gbCoordinates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCoordY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCoordX).EndInit();
            gbClickTiming.ResumeLayout(false);
            gbClickTiming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterval).EndInit();
            gbMouseButtons.ResumeLayout(false);
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private GroupBox gbSyncAsync;
        private RadioButton rbAsync;
        private RadioButton rbSynchronous;
        private MenuStrip menuStripMain;
        private ToolStripMenuItem tsmiProgram;
        private ToolStripMenuItem tsmiClose;
        private ToolStripMenuItem tsmiInformation;
        private ToolStripMenuItem tsmiVersion;
        private ToolStripMenuItem tsmiSettings;
        private ToolStripMenuItem tsmiLoadPresetAtStartup;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tsmiSaveCurrentSettingsAsPreset;
        private ToolStripMenuItem tsmiLoadPresetNow;
    }
}