namespace Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxElements = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonConstrains = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chBxFast = new System.Windows.Forms.CheckBox();
            this.labelConstrains = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.errorHandler = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.chBxRand = new System.Windows.Forms.CheckBox();
            this.buttonRandMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxElements
            // 
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.ItemHeight = 15;
            this.listBoxElements.Location = new System.Drawing.Point(12, 48);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.Size = new System.Drawing.Size(120, 19);
            this.listBoxElements.TabIndex = 0;
            this.listBoxElements.SelectedIndexChanged += new System.EventHandler(this.listBoxElements_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 73);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 40);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить элемент";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonConstrains
            // 
            this.buttonConstrains.Location = new System.Drawing.Point(12, 119);
            this.buttonConstrains.Name = "buttonConstrains";
            this.buttonConstrains.Size = new System.Drawing.Size(120, 40);
            this.buttonConstrains.TabIndex = 2;
            this.buttonConstrains.Text = "Добавить ограничение";
            this.buttonConstrains.UseVisualStyleBackColor = true;
            this.buttonConstrains.Click += new System.EventHandler(this.buttonConstrains_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Топологическая сортировка";
            // 
            // chBxFast
            // 
            this.chBxFast.AutoSize = true;
            this.chBxFast.Location = new System.Drawing.Point(4, 190);
            this.chBxFast.Name = "chBxFast";
            this.chBxFast.Size = new System.Drawing.Size(139, 19);
            this.chBxFast.TabIndex = 4;
            this.chBxFast.Text = "Быстрая сортировка";
            this.chBxFast.UseVisualStyleBackColor = true;
            this.chBxFast.CheckedChanged += new System.EventHandler(this.chBxFast_CheckedChanged);
            // 
            // labelConstrains
            // 
            this.labelConstrains.AutoSize = true;
            this.labelConstrains.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConstrains.Location = new System.Drawing.Point(138, 48);
            this.labelConstrains.Name = "labelConstrains";
            this.labelConstrains.Size = new System.Drawing.Size(0, 21);
            this.labelConstrains.TabIndex = 5;
            this.labelConstrains.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 215);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 40);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Отсортировать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // errorHandler
            // 
            this.errorHandler.ContainerControl = this;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 15;
            this.listBoxResult.Location = new System.Drawing.Point(165, 165);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(120, 4);
            this.listBoxResult.TabIndex = 7;
            // 
            // chBxRand
            // 
            this.chBxRand.AutoSize = true;
            this.chBxRand.Location = new System.Drawing.Point(4, 165);
            this.chBxRand.Name = "chBxRand";
            this.chBxRand.Size = new System.Drawing.Size(125, 19);
            this.chBxRand.TabIndex = 8;
            this.chBxRand.Text = "Создать случайно";
            this.chBxRand.UseVisualStyleBackColor = true;
            this.chBxRand.CheckedChanged += new System.EventHandler(this.chBxRand_CheckedChanged);
            // 
            // buttonRandMenu
            // 
            this.buttonRandMenu.Location = new System.Drawing.Point(12, 73);
            this.buttonRandMenu.Name = "buttonRandMenu";
            this.buttonRandMenu.Size = new System.Drawing.Size(120, 40);
            this.buttonRandMenu.TabIndex = 9;
            this.buttonRandMenu.Text = "Меню случайного заполнения";
            this.buttonRandMenu.UseVisualStyleBackColor = true;
            this.buttonRandMenu.Visible = false;
            this.buttonRandMenu.Click += new System.EventHandler(this.buttonRandMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(444, 288);
            this.Controls.Add(this.buttonRandMenu);
            this.Controls.Add(this.chBxRand);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelConstrains);
            this.Controls.Add(this.chBxFast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConstrains);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxElements);
            this.Name = "Form1";
            this.Text = "TopologSort";
            ((System.ComponentModel.ISupportInitialize)(this.errorHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonAdd;
        public ListBox listBoxElements;
        private Button buttonConstrains;
        private Label label1;
        private CheckBox chBxFast;
        public Label labelConstrains;
        private Button buttonStart;
        private ErrorProvider errorHandler;
        private ListBox listBoxResult;
        private CheckBox chBxRand;
        private Button buttonRandMenu;
    }
}