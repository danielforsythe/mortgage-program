using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Diagnostics;
using LumenWorks.Framework.IO.Csv;
using System.Windows;
using System.Windows.Input;

namespace MortgageProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Select file
            string filename = openFileDialog1.FileName;
            string dataFile = File.ReadAllText(filename);

            using (var csv = new CachedCsvReader(new StreamReader(filename), true))
            {
                dataGridView1.DataSource = csv;
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 dataEntry = new Form2();
            dataEntry.ShowDialog();

            mortgageInfoLabel.Text = "Mortgage: $\t" + Global.LoanAmount + " @ " + Global.InterestRate + "% For \t" + Global.LoanLength + " Months";
        }
    }
}