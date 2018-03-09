using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Random random = new Random();
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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();

            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::FlappyBird.Properties.Resources.flappyModel;
            this.flappyBird.Location = new System.Drawing.Point(47, 295);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(80, 80);
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 454);
            this.Controls.Add(this.flappyBird);
            this.MaximumSize = new System.Drawing.Size(700, 1000);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);

        }

        private void InitializePipe()
        {
            this.pipe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            this.SuspendLayout();
            this.pipe.BackColor = System.Drawing.Color.Green;

            int pipeHeight = random.Next(this.Height/4, this.Height/2);

            int pipeXCoordinate = random.Next(200, this.Width);
            int pipeYCoordinate = this.Height - pipeHeight;
            this.pipe.Location = new System.Drawing.Point(pipeXCoordinate, pipeYCoordinate);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(54, pipeHeight);
            this.pipe.TabIndex = 1;
            this.pipe.TabStop = false;
            this.Controls.Add(this.pipe);
            pipesArray.Add(pipe);
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox flappyBird;
        private List<PictureBox> pipesArray = new List<PictureBox>();
        private PictureBox pipe;
    }
}

