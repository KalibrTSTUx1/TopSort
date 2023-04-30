using Forms.AllForms;
using Forms.Class;
using Forms.formForTSort;
using lection1404;

namespace Forms
{
    
    public partial class Form1 : Form
    {
        
        List<string> constrains = new List<string>();
        List<string> elems = new List<string>();

        public List<int> elemsInt;
        public List<QuickTopS.Pair<int>> constrainsInt;

        public Form1()
        {
            InitializeComponent();
            listBoxResult.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            errorHandler.Clear();
            formElementAdd fEAdd = new formElementAdd();
            fEAdd.Owner = this;
            fEAdd.Show();
            locationUpdate();
        }
        
        private List<string> listBoxToList()
        {
            elems.Clear();
            for (int i = 0; i < listBoxElements.Items.Count; i++)
                elems.Add(listBoxElements.Items[i].ToString());
            return elems;
        }
        private void locationUpdate()
        {
            int elCount = listBoxElements.Items.Count;
            if (elCount > 0)
            {
                listBoxElements.Size = new System.Drawing.Size(listBoxElements.Width, listBoxElements.Height + 15);
                buttonAdd.Location = new Point(buttonAdd.Location.X, buttonAdd.Location.Y + 15);
                buttonRandMenu.Location = new Point(buttonRandMenu.Location.X, buttonRandMenu.Location.Y + 15);
                buttonConstrains.Location = new Point(buttonConstrains.Location.X, buttonConstrains.Location.Y + 15);
                buttonStart.Location = new Point(buttonStart.Location.X, buttonStart.Location.Y + 15);
                chBxRand.Location = new Point(chBxRand.Location.X, chBxRand.Location.Y + 15);
                chBxFast.Location = new Point(chBxFast.Location.X, chBxFast.Location.Y + 15);
                this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 15);
            }
        }

        private void buttonConstrains_Click(object sender, EventArgs e)
        {
            listBoxResult.Visible = false;
            errorHandler.Clear();
            elems = listBoxToList();
            if (elems.Count < 2)
            {
                errorHandler.SetError(buttonConstrains, "Ёлементов меньше двух!");
            }
            else
            {
                formConstrains fC = new formConstrains(elems);
                fC.Owner = this;
                fC.Show();
            }
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            listBoxResult.Items.Clear();
            switch (chBxRand.Checked)
            {
                case true:
                    List<int> resultInt = new List<int>();
                    entryPoint enPointInt = new(elemsInt, constrainsInt);
                    if (constrainsInt.Count > 0)
                    {
                        if (chBxFast.Checked)
                        {
                            resultInt = enPointInt.tQuickSortInt();
                        }
                        else
                        {
                            resultInt = enPointInt.tSortInt();
                        }
                    }
                    else { resultInt = elemsInt; }
                    writeResultInt(resultInt);
                    break;
                case false:
                    elems = listBoxToList();
                    List<string> result = new List<string>();
                    constrainsList();
                    if (listBoxElements.Items.Count > 0)
                    {
                        entryPoint enPoint = new(elems, constrains);
                        if (constrains.Count > 0)
                        {
                            if (chBxFast.Checked)
                            {
                                result = enPoint.tQuickSort();
                            }
                            else
                            {
                                result = enPoint.tSort();
                            }
                        }
                        else { result = elems; }
                    }
                    writeResult(result);
                    break;
                
            }
            buttonStart.Enabled = false;
            
            
        }

        private void writeResultInt(List<int> resultInt)
        {
            for (int i = 0; i < resultInt.Count; i++)
            {
                listBoxResult.Items.Add($"{i + 1}. {Convert.ToString(resultInt[i])}");
            }
            listBoxResult.Location = new Point(chBxFast.Location.X + chBxFast.Size.Width + 10, labelConstrains.Location.Y + labelConstrains.Size.Height + 10);
            listBoxResult.Size = new System.Drawing.Size(listBoxResult.Width, resultInt.Count > 20 ? (4 + (15 * 20)) : (4 + (15 * resultInt.Count)));
            listBoxResult.Visible = true;
        }

        private void writeResult(List<string> result)
        {
            listBoxResult.Location = new Point(chBxFast.Location.X + chBxFast.Size.Width + 10, labelConstrains.Location.Y + labelConstrains.Size.Height + 10);
            listBoxResult.Size = new System.Drawing.Size(listBoxResult.Width, 4 + (15 * result.Count));
            listBoxResult.Visible = true;
            for (int i = 0; i < result.Count; i++)
            {
                listBoxResult.Items.Add($"{i + 1}.{result[i]}");
            }
        }

        private void constrainsList()
        {
            string[] buf = labelConstrains.Text.Split('\n', ':');
            for (int i = 0; i < buf.Length - 1; i++)
            {
                constrains.Add(buf[i].Trim());
            }
        }
       
        private void chBxRand_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxRand.Checked == true)
            {
                buttonConstrains.Enabled = false;
                buttonAdd.Enabled = false;
                buttonAdd.Visible = false;
                buttonRandMenu.Visible = true;
            } 
            else
            {
                buttonConstrains.Enabled = true;
                buttonAdd.Enabled = true;
                buttonAdd.Visible = true;
                buttonRandMenu.Visible = false;
            }
        }
               
        private void chBxFast_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonRandMenu_Click(object sender, EventArgs e)
        {
            errorHandler.Clear();
            randMenu rndMenu = new randMenu();
            rndMenu.Owner = this;
            rndMenu.Show();
            chBxRand.Enabled = false;
        }

        public void locUpdate(int elCount)
        {
            string constrainsLabel = "";
            int up = 15 * (elCount - 1);
            if (elCount > 0)
            {
                listBoxElements.Size = new System.Drawing.Size(listBoxElements.Width, listBoxElements.Height + up);
                buttonAdd.Location = new Point(buttonAdd.Location.X, buttonAdd.Location.Y + up);
                buttonRandMenu.Location = new Point(buttonRandMenu.Location.X, buttonRandMenu.Location.Y + up);
                buttonConstrains.Location = new Point(buttonConstrains.Location.X, buttonConstrains.Location.Y + up);
                buttonStart.Location = new Point(buttonStart.Location.X, buttonStart.Location.Y + up);
                chBxRand.Location = new Point(chBxRand.Location.X, chBxRand.Location.Y + up);
                chBxFast.Location = new Point(chBxFast.Location.X, chBxFast.Location.Y + up);
                this.Size = new System.Drawing.Size(this.Size.Width, (buttonStart.Location.Y + 40));
            }
            for (int i = 0; i < (constrainsInt.Count >= 20 ? 20 : constrainsInt.Count); i++)
            {
                constrainsLabel += $"{constrainsInt[i].Item} : {constrainsInt[i].next}\n";
            }
            if (constrainsInt.Count > 20)
            {
                constrainsLabel += ".........";
            }
            labelConstrains.Text = constrainsLabel;
            labelConstrains.Visible = true;
        }

        private void sortStart_Click(object sender, EventArgs e)
        {

        }
    }
    

}