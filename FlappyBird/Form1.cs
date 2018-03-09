using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Numerics;
using System.Threading.Tasks;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        private int gravity = -5;
        private int sleepTimeMiliSecs = 10;
        private int jumpDistance = 70;

        public Form1()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                DoStuff();
            });
            Application.Idle += UpdateBirdPosition;
            Application.Idle += UpdatePipePosition;
            MouseClick += HandleMouseClick;
        }

        void UpdateBirdPosition(object sender, EventArgs e)
        {
            //Adjust bird's position
            flappyBird.Location = new Point(flappyBird.Location.X, flappyBird.Location.Y - gravity);
            if(flappyBird.Location.Y <= 0)
            {
                flappyBird.Location = new Point(flappyBird.Location.X, 0);
            }
            if(flappyBird.Location.Y >= Form1.ActiveForm.Height - flappyBird.Height)
            {
                flappyBird.Location = new Point(flappyBird.Location.X, Form1.ActiveForm.Height - flappyBird.Height);
            }
            
            Thread.Sleep(sleepTimeMiliSecs);
        }

        void UpdatePipePosition(object sender, EventArgs e)
        {
            //Adjust pipe's position
            for (int i = 0; i < pipesArray.Count; i++)
            {
                var pipe = pipesArray[i];
                pipe.Location = new Point(pipe.Location.X - 5, pipe.Location.Y);
            }
            Thread.Sleep(100);
        }

        void DoStuff()
        {
            InitializePipe();
            Thread.Sleep(2000);
        }
        

        void HandleMouseClick(object sender, EventArgs e)
        {
            flappyBird.Location = new Point(flappyBird.Location.X, flappyBird.Location.Y - jumpDistance);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
