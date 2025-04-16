using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toko_buku
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.AddXY("Jan", 30);
            chart1.Series["Series1"].Points.AddXY("Feb", 50);
            chart1.Series["Series1"].Points.AddXY("Maret", 40);
            chart1.Series["Series1"].Points.AddXY("April", 10);

            chart2.Series["Series1"].Points.AddXY("Mouse", 150);
            chart2.Series["Series1"].Points.AddXY("Keyboard", 20);
            chart2.Series["Series1"].Points.AddXY("Monitor", 50);
            chart2.Series["Series1"].Points.AddXY("Mousepad", 30);
            chart2.Series["Series1"].Points.AddXY("Modem", 70);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
