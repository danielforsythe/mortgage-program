using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageProg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataBtn_Click(object sender, EventArgs e)
        {
            Global.LoanAmount = mgtAmountTxtBox.Text;
            Global.LoanLength = loanLengthTxtBox.Text;
            Global.InterestRate = intRateTxtBox.Text;
            this.Close();
        }
    }
}
