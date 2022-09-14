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

namespace receiver_of_clicks
{
    partial class ReceiverForm
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
            this.rtbLogging = new System.Windows.Forms.RichTextBox();
            this.lblClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbLogging
            // 
            this.rtbLogging.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLogging.DetectUrls = false;
            this.rtbLogging.Location = new System.Drawing.Point(12, 243);
            this.rtbLogging.Name = "rtbLogging";
            this.rtbLogging.ReadOnly = true;
            this.rtbLogging.Size = new System.Drawing.Size(776, 195);
            this.rtbLogging.TabIndex = 0;
            this.rtbLogging.Text = "";
            this.rtbLogging.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogClickEvent);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(244, 103);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(237, 15);
            this.lblClick.TabIndex = 1;
            this.lblClick.Text = "Click anywhere on this form, if you want to.";
            this.lblClick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogClickEvent);
            // 
            // ReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.rtbLogging);
            this.Name = "ReceiverForm";
            this.Text = "To click or not to click, that is the question.";
            this.Shown += new System.EventHandler(this.ReceiverForm_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogClickEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblClick;
        internal RichTextBox rtbLogging;
    }
}