using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExFractionGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int den1 = Int32.Parse(tbxDen1.Text == "" ? "0" : tbxDen1.Text);
            int nom1 = Int32.Parse(tbxNom1.Text == "" ? "0" : tbxNom1.Text);
            int den2 = Int32.Parse(tbxDen2.Text == "" ? "0" : tbxDen2.Text);
            int nom2 = Int32.Parse(tbxNom2.Text == "" ? "0" : tbxNom2.Text);
            int den3 = Int32.Parse(tbxDen3.Text == "" ? "0" : tbxDen3.Text);
            int nom3 = Int32.Parse(tbxNom3.Text == "" ? "0" : tbxNom3.Text);
            float nom4 = float.Parse(tbxnombre.Text == "" ? "0" : tbxnombre.Text);

            Fraction fc1 = new Fraction(nom1, den1);
            Fraction fc2 = new Fraction(nom2, den2);
            Fraction fc3 = new Fraction(nom3, den3);
            Fraction fc4 = new Fraction(nom4);
            Fraction fc13 = fc1.Add(fc3);
            Fraction fc123 = fc1.Add(fc2.Sub(fc3));

            lblR1.Text = fc1.ToString();
            lblR2.Text = fc2.ToString();
            lblR3.Text = fc3.ToString();
            lblR4.Text = fc4.ToString();
            lblR13.Text = fc13.ToString();
            lblR123.Text = fc123.ToString();

        }
    }
}
