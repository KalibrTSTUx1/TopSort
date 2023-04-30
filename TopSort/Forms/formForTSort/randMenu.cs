using Forms.ClassForTSotr;
using lection1404;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.formForTSort
{
    public partial class randMenu : Form
    {
        public randMenu()
        {
            InitializeComponent();
            chBxLinear.Checked = true;
        }
        private List<int> elems;
        private List<QuickTopS.Pair<int>> constrains;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                getElems();
                foreach (int elem in elems)
                {
                    main.listBoxElements.Items.Add(elem.ToString());
                    
                }
                main.elemsInt = elems;
                main.constrainsInt = constrains;
                main.locUpdate(main.listBoxElements.Items.Count >= 20 ? 20 : main.listBoxElements.Items.Count);
            }
            Close();
        }
        private void getElems()
        {
            randElemHandler rndEl = new(int.Parse(txBxCount.Text), chBxLinear.Checked);
            elems = rndEl.elements;
            constrains = rndEl.cnst;
        }

        private void chBxBr_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxBr.Checked == true)
            {
                chBxLinear.Checked = false;
            } else { chBxLinear.Checked = true; }
            
        }

        private void chBxLinear_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxLinear.Checked == true)
            {
                chBxBr.Checked = false;
            }
            else { chBxBr.Checked = true; }
        }
    }
}
