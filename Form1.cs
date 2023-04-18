using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Abc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int err0 = 0;
        int ltr = 1;
        //private static int err = 0;
        public int err
        {
            get { return err0; }
            set
            {

                err0 = value;
                OnVarChange();
            }
        }

        private void OnVarChange()
        {
            labelErrors.Text = "Errors: " + err;
        }

        System.Timers.Timer timer = new System.Timers.Timer(1);
        Stopwatch stopwatch = new Stopwatch();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Elapsed += timer_Elapsed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void timer_Elapsed(Object source, ElapsedEventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                if (stopwatch.Elapsed.ToString().Substring(0, 2) == "99")
                {
                    stopwatch.Stop();
                }
                labelTimer.Text = stopwatch.Elapsed.ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
 || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
 || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)))
            {
                switch (ltr)
                {
                    case 1:
                        stopwatch.Start();
                        timer.Start();
                        if (e.KeyCode == Keys.A)
                        {
                            ltr = 2;
                            label1.BackColor = Color.Lime;
                        }
                        else
                        {
                            label1.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 2:
                        if (e.KeyCode == Keys.B)
                        {
                            ltr = 3;
                            label2.BackColor = Color.Lime;
                        }
                        else
                        {
                            label2.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 3:
                        if (e.KeyCode == Keys.C)
                        {
                            ltr = 4;
                            label3.BackColor = Color.Lime;
                        }
                        else
                        {
                            label3.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 4:
                        if (e.KeyCode == Keys.D)
                        {
                            ltr = 5;
                            label4.BackColor = Color.Lime;
                        }
                        else
                        {
                            label4.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 5:
                        if (e.KeyCode == Keys.E)
                        {
                            ltr = 6;
                            label5.BackColor = Color.Lime;
                        }
                        else
                        {
                            label5.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 6:
                        if (e.KeyCode == Keys.F)
                        {
                            ltr = 7;
                            label6.BackColor = Color.Lime;
                        }
                        else
                        {
                            label6.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 7:
                        if (e.KeyCode == Keys.G)
                        {
                            ltr = 8;
                            label7.BackColor = Color.Lime;
                        }
                        else
                        {
                            label7.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 8:
                        if (e.KeyCode == Keys.H)
                        {
                            ltr = 9;
                            label8.BackColor = Color.Lime;
                        }
                        else
                        {
                            label8.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 9:
                        if (e.KeyCode == Keys.I)
                        {
                            ltr = 10;
                            label9.BackColor = Color.Lime;
                        }
                        else
                        {
                            label9.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 10:
                        if (e.KeyCode == Keys.J)
                        {
                            ltr = 11;
                            label10.BackColor = Color.Lime;
                        }
                        else
                        {
                            label10.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 11:
                        if (e.KeyCode == Keys.K)
                        {
                            ltr = 12;
                            label11.BackColor = Color.Lime;
                        }
                        else
                        {
                            label11.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 12:
                        if (e.KeyCode == Keys.L)
                        {
                            ltr = 13;
                            label12.BackColor = Color.Lime;
                        }
                        else
                        {
                            label12.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 13:
                        if (e.KeyCode == Keys.M)
                        {
                            ltr = 14;
                            label13.BackColor = Color.Lime;
                        }
                        else
                        {
                            label13.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 14:
                        if (e.KeyCode == Keys.N)
                        {
                            ltr = 15;
                            label14.BackColor = Color.Lime;
                        }
                        else
                        {
                            label14.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 15:
                        if (e.KeyCode == Keys.O)
                        {
                            ltr = 16;
                            label15.BackColor = Color.Lime;
                        }
                        else
                        {
                            label15.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 16:
                        if (e.KeyCode == Keys.P)
                        {
                            ltr = 17;
                            label16.BackColor = Color.Lime;
                        }
                        else
                        {
                            label16.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 17:
                        if (e.KeyCode == Keys.Q)
                        {
                            ltr = 18;
                            label17.BackColor = Color.Lime;
                        }
                        else
                        {
                            label17.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 18:
                        if (e.KeyCode == Keys.R)
                        {
                            ltr = 19;
                            label18.BackColor = Color.Lime;
                        }
                        else
                        {
                            label18.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 19:
                        if (e.KeyCode == Keys.S)
                        {
                            ltr = 20;
                            label19.BackColor = Color.Lime;
                        }
                        else
                        {
                            label19.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 20:
                        if (e.KeyCode == Keys.T)
                        {
                            ltr = 21;
                            label20.BackColor = Color.Lime;
                        }
                        else
                        {
                            label20.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 21:
                        if (e.KeyCode == Keys.U)
                        {
                            ltr = 22;
                            label21.BackColor = Color.Lime;
                        }
                        else
                        {
                            label21.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 22:
                        if (e.KeyCode == Keys.V)
                        {
                            ltr = 23;
                            label22.BackColor = Color.Lime;
                        }
                        else
                        {
                            label22.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 23:
                        if (e.KeyCode == Keys.W)
                        {
                            ltr = 24;
                            label23.BackColor = Color.Lime;
                        }
                        else
                        {
                            label23.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 24:
                        if (e.KeyCode == Keys.X)
                        {
                            ltr = 25;
                            label24.BackColor = Color.Lime;
                        }
                        else
                        {
                            label24.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 25:
                        if (e.KeyCode == Keys.Y)
                        {
                            ltr = 26;
                            label25.BackColor = Color.Lime;
                        }
                        else
                        {
                            label25.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    case 26:
                        if (e.KeyCode == Keys.Z)
                        {
                            stopwatch.Stop();
                            string stpwtch = stopwatch.Elapsed.ToString();
                            labelTimer.Text = stpwtch;
                            label26.BackColor = Color.Lime;
                            ltr = 27;
                            Form2 f2 = new Form2(stpwtch, err.ToString());
                            f2.FormClosing += Close;
                            f2.Show();
                        }
                        else
                        {
                            label26.BackColor = Color.Crimson;
                            err++;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        public void Close(object sender, EventArgs e)
        {
            if (Form2.reset == true)
            {
                //Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2.reset = true;
            Close();
        }
    }
}
