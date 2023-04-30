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

namespace Forms.formForFElemSort
{
    public partial class FElemForm : Form
    {

        public FElemForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string result;
            string input = txBxInput.Text.Replace(" ", "").ToUpper();
            txBxResult.Text = string.Empty;
            if (chekCorrectInput(input))
            {
                FElemsSort sort = new FElemsSort(input.ToCharArray());
                result = new string(sort.GetSorted());
                setResult(result);
            }
            else { errorProvider1.SetError(txBxInput, "Некорректный ввод!"); }
        }

        private void setResult(string result)
        {
            txBxResult.Text += $"{result[0]}";
            for (int i = 1; i < result.Length; i++)
                txBxResult.Text += $" {result[i]}";
            txBxResult.Visible = true;
            labelRes.Visible = true;
        }

        private void txBxInput_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private bool chekCorrectInput(string str)
        {
            if (str.Length > 1)
            {
                char[] chars = new char[4];
                int j = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (chars.Contains(str[i]) || str[i] == ' ')
                        continue;
                    try
                    {
                        chars[j] = str[i];
                        j++;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                if (j != 4) { return false; }
            }
            else { return false; }
            return true;
        }
    }
}
