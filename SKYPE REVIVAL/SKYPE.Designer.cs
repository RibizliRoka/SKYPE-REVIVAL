﻿namespace SKYPE_REVIVAL
{
    partial class SKYPE
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
            this.SuspendLayout();
            // 
            // SKYPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1129, 756);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SKYPE";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SKYPE_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SKYPE_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

    }
}