using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        private int button1Counter = 0;
        private int button2Counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1Counter++;
            label1.Text = $"Button 1 pressed {button1Counter} times";
            label3.Text = "Button 1 pressed";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2Counter++;
            label2.Text = $"Button 2 pressed {button2Counter} times";
            label3.Text = "Button 2 pressed";
        }
    }
}
