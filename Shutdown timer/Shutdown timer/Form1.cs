using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shutdown_timer
{
    public partial class Form1 : Form
    {
        /* - fix resizing after removing controls
         * 
         * 
         * 
         * 
         * 
         * 
         */

        private int s;
        private int m;
        private int h;

        public Form1()
        {
            InitializeComponent();

           

            hours.Maximum = Int32.MaxValue;

            hours.Controls[0].Visible = false;
            minutes.Controls[0].Visible = false;
            seconds.Controls[0].Visible = false;


            //cause am idiot: https://stackoverflow.com/questions/5226688/numericupdown-mousewheel-event-increases-decimal-more-than-one-increment
            hours.Increment = 1m / SystemInformation.MouseWheelScrollLines;
            minutes.Increment = 1m / SystemInformation.MouseWheelScrollLines;
            seconds.Increment = 1m / SystemInformation.MouseWheelScrollLines;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            s = (int)seconds.Value;
            m = (int)minutes.Value;
            h = (int)hours.Value;

            timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
             if(s > 0)
             {
                s--;
             }
             else
             {
                if(m > 0)
                {
                    m--;

                    s = 59;
                }
                else
                {
                    if(h > 0)
                    {
                        h--;

                        m = 59;
                        s = 59;
                    }
                }
             }

            hours.Value = h;
            minutes.Value = m;
            seconds.Value = s;

            if(h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                System.Diagnostics.Process.Start("shutdown", "/s /t 0");
            }
        }

        private void hours_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void minutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void seconds_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
