using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.AllForms
{
    public partial class formConstrains : Form
    {
        
        public formConstrains(List<string> elem)
        {
            InitializeComponent();
            listToCmBx(cmBxFirst, elem);
            listToCmBx(cmBxSecond, elem);
        }

        private void buttonConf_Click(object sender, EventArgs e)
        {
            errorHandler.Clear();
            if (cmBxFirst.Text == cmBxSecond.Text)
            {
                errorHandler.SetError(button1, "Элементы совпадают!");
            }
            else
            {
                Form1 main = this.Owner as Form1;
                if (main != null)
                {
                    main.labelConstrains.Text += $"{cmBxFirst.Text} : {cmBxSecond.Text}\n";
                    main.labelConstrains.Visible = true;
                }
                Close();
            }
            
        }
        private void listToCmBx(ComboBox cmBx, List<string> elem)
        {
            for (int i = 0; i < elem.Count; i++)
                cmBx.Items.Add(elem[i]);
        }

        private void cmBxFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorHandler.Clear();
            cmBxSecond.Enabled = true;
        }
    }
}
