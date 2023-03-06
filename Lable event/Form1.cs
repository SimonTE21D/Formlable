using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lable_event
{
    public partial class Form1 : Form
    {

        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.Magenta;
            label3.ForeColor = Color.White;
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Magenta;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            
            x++;
            this.Text = x.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label9.Text = "Tack för att du besökte oss!";
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label9.Text = "Kom hit!!";
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label7.Text = "Tack för att du besökte oss!";
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = "Kom hit!!";
        }

        private void label8_MouseHower(object sender, EventArgs e)
        {

            int x, y;
            Random random = new Random();
                x = random.Next(0, 800);
                y = random.Next(0, 500);

                label8.Top = y;
                label8.Left = x;

                
        }
    }
}
