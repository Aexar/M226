using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnConvert_Click(object sender, EventArgs e)
        {
            double rate = double.Parse(tbxRate.Text);
            double source = double.Parse(tbxSource.Text);
            CCModel model = new CCModel(rate);
            tbxDestination.Text = model.Convert(source).ToString();


        }

        public void tbxSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if a decimal separator (point, comma...according culture) is already in tebDisplay control
            if (e.KeyChar == '.' &&
                (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
            else
            {
                //// authorized chararacters : 0 1 2 3 4 5 6 7 8 9 DecimalSeparator Backspace
                if (((e.KeyChar < '0') || (e.KeyChar > '9')) &&
                    (e.KeyChar != (char)Keys.Delete) &&
                    (e.KeyChar != (char)Keys.Back))
                {
                // Stop the character outside authorized characters
                e.Handled = true;
                }
            }
            return;
        }
    }
}
