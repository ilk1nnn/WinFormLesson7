using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            foreach (var item in this.Controls)
            {
                if(item is Label lb)
                {
                    lb.Font = fontDialog1.Font;
                    lb.ForeColor = fontDialog1.Color;
                }
                else if(item is Button bt)
                {
                    bt.Font = fontDialog1.Font;
                    bt.ForeColor = fontDialog1.Color;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
