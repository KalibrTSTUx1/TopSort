namespace Forms.formForTSort
{
    partial class randMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txBxCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chBxLinear = new System.Windows.Forms.CheckBox();
            this.chBxBr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню случайного создания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество элементов:";
            // 
            // txBxCount
            // 
            this.txBxCount.Location = new System.Drawing.Point(231, 38);
            this.txBxCount.Name = "txBxCount";
            this.txBxCount.Size = new System.Drawing.Size(100, 23);
            this.txBxCount.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chBxLinear
            // 
            this.chBxLinear.AutoSize = true;
            this.chBxLinear.Location = new System.Drawing.Point(12, 63);
            this.chBxLinear.Name = "chBxLinear";
            this.chBxLinear.Size = new System.Drawing.Size(112, 19);
            this.chBxLinear.TabIndex = 4;
            this.chBxLinear.Text = "Линейная связь";
            this.chBxLinear.UseVisualStyleBackColor = true;
            this.chBxLinear.CheckedChanged += new System.EventHandler(this.chBxLinear_CheckedChanged);
            // 
            // chBxBr
            // 
            this.chBxBr.AutoSize = true;
            this.chBxBr.Location = new System.Drawing.Point(130, 63);
            this.chBxBr.Name = "chBxBr";
            this.chBxBr.Size = new System.Drawing.Size(138, 19);
            this.chBxBr.TabIndex = 5;
            this.chBxBr.Text = "Разветвленная связь";
            this.chBxBr.UseVisualStyleBackColor = true;
            this.chBxBr.CheckedChanged += new System.EventHandler(this.chBxBr_CheckedChanged);
            // 
            // randMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 152);
            this.Controls.Add(this.chBxBr);
            this.Controls.Add(this.chBxLinear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txBxCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "randMenu";
            this.Text = "randMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txBxCount;
        private Button button1;
        private CheckBox chBxLinear;
        private CheckBox chBxBr;
    }
}