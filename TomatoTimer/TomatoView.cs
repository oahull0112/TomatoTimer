using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomatoTimer
{
    public partial class TomatoView : Form
    {
        private TimeSpan remainingTime = new TimeSpan(0, 25, 1);
        private TimeSpan noTime = new TimeSpan(0, 0, 0);
        private Timer timer = new Timer();
        private bool isTimeRunning = true;
        private bool isTimeLeft = true;

        public TomatoView()
        {
            InitializeComponent();
            label1.Text = "Time remaining: ";

            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (1);              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
            timer.Start();                              // Start the timer

            label2.Text = String.Empty;

            this.Controls.Add(label2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remainingTime = new TimeSpan(0, 25, 1);
            if (!isTimeRunning)
            {
                isTimeRunning = true;
            }
        }


        void timer_Tick(object sender, EventArgs e)
        {
            isTimeLeft = Convert.ToBoolean((remainingTime.CompareTo(noTime)));
            //  label2.Text = DateTime.Now.ToString();
            if (isTimeRunning & isTimeLeft)
            {
                button2.Text = "Pause";
                remainingTime -= TimeSpan.FromSeconds(1); // then show the countdown timer
                label2.Text = remainingTime.ToString("mm\\:ss");
            }
            else if (!isTimeLeft)
            {
                MessageBox.Show("Time's up!");
                isTimeRunning = false;
            }
            else
            {
                
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In progress!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isTimeRunning)
            {
                isTimeRunning = false;
                button2.Text = "Resume";
            }
            else
            {
                isTimeRunning = true;
                button2.Text = "Pause";
            }
        }

        private void shortBreakButton_Click(object sender, EventArgs e)
        {
            remainingTime = new TimeSpan(0, 5, 1);
            if (!isTimeRunning)
            {
                isTimeRunning = true;
            }
        }

        private void longBreakButton_Click(object sender, EventArgs e)
        {
            remainingTime = new TimeSpan(0, 15, 1);
            if (!isTimeRunning)
            {
                isTimeRunning = true;
            }
        }
    }
}
