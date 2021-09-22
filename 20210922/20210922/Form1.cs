using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210922
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnkor_Click(object sender, EventArgs e)
        {
            double sugar = double.Parse(lblsugar.Text);
            lblkerulet.Text = "Kör kerülete";
            lblterulet.Text = "Kör területe";
            double kerulet = 2 * sugar * Math.PI;
            double terulet = Math.Pow(sugar, 2) * Math.PI;
            textBox2.Text =Convert.ToString( kerulet);
            textBox1.Text = Convert.ToString(terulet);

        }

        private void Btngomb_Click(object sender, EventArgs e)
        {
            double sugar = double.Parse(lblsugar.Text);
            lblkerulet.Text = "Gömb felszíne";
            lblterulet.Text = "Gömb térfogata";
            double felszine = 4*Math.PI *Math.Pow( sugar,2);
            double terfogata =4* Math.PI/3 * Math.Pow(sugar, 3);
            textBox2.Text = Convert.ToString(felszine);
            textBox1.Text = Convert.ToString(terfogata);
        }
    }
}
