using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace Numeric_addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN_Sum_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(TBX_Input.Text, out BigInteger i))
            {
                char[] ints = TBX_Input.Text.ToCharArray();
                int output = 0;
                foreach (char j in ints)
                {
                    output += int.Parse(j.ToString());
                }
                TBX_Output.Text = output.ToString();
            }
            else
            {
                MessageBox.Show("Please enter an integer.");
            }
        }
    }
}