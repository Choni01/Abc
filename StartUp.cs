using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abc
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            f.FormClosing += fClosing;
        }
        private void fClosing(object sender, EventArgs e)
        {
            if (Form2.reset == true)
            {
                Form1 f = new Form1();
                f.Show();
                f.FormClosing += fClosing;
                Form2.reset = false;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
