using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            label1.Text = $"X :{e.Location.X} Y :{e.Location.Y}";
            label1.BackColor = Color.GreenYellow;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Blue;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            Control control = new Button();
            control.Click += Control_Click;
            control.Location = e.Location;
            control.Size = new Size(100, 100);
            this.Controls.Add(control);

        }

        private void Control_Click(object sender, EventArgs e)
        {
            var but = sender as Button;

            but.Dispose();
            
        }
    }
}
