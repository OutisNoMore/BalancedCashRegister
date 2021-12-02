using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancedCashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Country country = Country.Invalid;
            if (Canada.Checked)
            {
                country = Country.Canada;
            }
            else if (United_States.Checked)
            {
                country = Country.United_States;
            }

            Money money = new Money(country);
            Debug_Output.Text = money.Dbg();
        }
    }
}
