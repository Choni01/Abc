using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Abc
{
    public partial class Form2 : Form
    {
        public Form2(string time0, string errors)
        {
            InitializeComponent();
            time = time0;
            err = errors;
        }
        public static bool reset = false;
        string time;
        string err;
        int i;


        private async void Form2_Shown(object sender, EventArgs e)
        {
            int accuracy = (int)Math.Round((double)2600 / (26 + int.Parse(err)));
            int red = 25500;
            int green = 0;
            for (i = 0; i < accuracy; i++)
            {
                red -= 255;
                green += 255;
                var rand = new Random();
                label1.Text = "Accuracy: " + i + "." + rand.Next(100).ToString() + "%";
                label1.ForeColor = Color.FromArgb(0, (red / 100), (green / 100), 0);
                await Task.Delay(10);
            }
            label1.Text = "Accuracy: " + i + ".00%";
            label2.Visible = true;

            red = 0;
            green = 25500;
            int timemilli = Int32.Parse(time.Substring(9, 7));
            int timemilliinterval = timemilli / 53;
            int timesec = Int32.Parse(time.Substring(6, 2));
            int timemin = Int32.Parse(time.Substring(3, 2));
            int timehr = Int32.Parse(time.Substring(0, 2));
            for (i = 0; i < 53; i++)
            {
                label2.Text = "Time: 00:00:00." + timemilliinterval;
                timemilliinterval += timemilli / 53;
                await Task.Delay(10);
            }
            if ((timesec & timemin & timehr) == 0)
            {
                label2.ForeColor = Color.FromArgb(0, 0, 255, 0);
            }
            if (timesec > 0)
            {
                for (i = 0; i <= timesec; i++)
                {
                    label2.Text = "Time: 00:00:" + i + "." + timemilli;
                    if ((timemin & timehr) == 0)
                    {
                        red += 255 / 60;
                        green -= 255 / 60;
                        label2.ForeColor = Color.FromArgb(0, (red / 100), (green / 100), 0);
                    }
                    await Task.Delay(10);
                }
            }
            if (timemin > 0)
            {
                for (i = 0; i <= timemin; i++)
                {
                    label2.Text = "Time: 00:" + i + ":" + timesec + "." + timemilli;
                    if (timehr == 0)
                    {
                        red += 255;
                        green -= 255;
                        label2.ForeColor = Color.FromArgb(0, (red / 100), (green / 100), 0);
                    }
                    await Task.Delay(10);
                }
            }
            if (timehr > 0)
            {
                for (i = 0; i <= timehr; i++)
                {
                    label2.Text = "Time: " + i + ":" + timemin + ":" + timesec + "." + timemilli;
                    label2.ForeColor = Color.FromArgb(0, 255, 0, 0);
                    await Task.Delay(10);
                }
            }
            label3.Visible = true;
            label4.Text = "...";
            int timesec_overall = ((int)Math.Round(Convert.ToDouble((timemilli / 10000000) + "." + (timemilli % 10000000)), 0) + timesec + (timemin * 60) + (timehr * 3600));
            double score = accuracy;
            for (i = 0; i < timesec_overall; i++)
            {
                score = score - (double)(score * 0.01);
            }
            score = Math.Round(score, 10);
            await Task.Delay(1000);
            label4.Text = score.ToString() + "%";
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reset = true;
            Close();
        }
    }
}
