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
    public partial class formElementAdd : Form
    {
        public formElementAdd()
        {
            InitializeComponent();
            labelLogo.Font = new Font("Times New Roman", 16);
            labelLogo.Text = "Добавление элемента:";
            txBxAdd.Location = new Point(labelLogo.Location.X, labelLogo.Location.Y + 25);
            buttonAdd.Location = new Point(txBxAdd.Location.X, txBxAdd.Location.Y + 25);
        }

        private void txBxAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                if (txBxAdd.Text.Trim() == String.Empty)
                {
                    Close();
                } else { main.listBoxElements.Items.Add(txBxAdd.Text.Trim()); }
            }
            Close();
        }
    }
}
