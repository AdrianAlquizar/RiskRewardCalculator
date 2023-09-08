using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk_Reward_Calculator
{
    public partial class Form1 : Form
    {
        Process rr = new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtexitprice_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            rr.entryP = double.Parse(txtentryprice.Text);
            rr.exitP = double.Parse(txtexitprice.Text);
            rr.StopL = double.Parse(txtstoploss.Text);

            lbloutput.Text = rr.Calculation().ToString();
            lbloutputRR.Text = $"{rr.ee}:{rr.es} or {rr.Ratio1()}:{rr.Ratio2()}";

            btnClear.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnClear.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtentryprice.Clear();
            txtexitprice.Clear();
            txtstoploss.Clear();

            lbloutput.Text = " ";
            lbloutputRR.Text = " ";

            btnClear.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
