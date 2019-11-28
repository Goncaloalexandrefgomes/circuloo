using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circuloo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        circulo C = new circulo();

        private void Button1_Click(object sender, EventArgs e)
        {
            C.Raio = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked) label3.Text = C.Area.ToString();
            else if (radioButton2.Checked) label3.Text = C.Perimetro.ToString();
            else if (radioButton3.Checked) label3.Text = C.Diametro.ToString();
        }
    }
}
