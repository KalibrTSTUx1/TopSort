using Forms.formForFElemSort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class solutionBlank : Form
    {
        public solutionBlank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 tForm = new Form1();
            tForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FElemForm fForm = new FElemForm();
            fForm.Show();
        }
    }
}
