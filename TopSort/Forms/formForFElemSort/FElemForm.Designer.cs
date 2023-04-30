namespace Forms.formForFElemSort
{
    partial class FElemForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txBxInput = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txBxResult = new System.Windows.Forms.TextBox();
            this.labelRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сортировка четырех элементов";
            // 
            // txBxInput
            // 
            this.txBxInput.Location = new System.Drawing.Point(12, 67);
            this.txBxInput.Name = "txBxInput";
            this.txBxInput.Size = new System.Drawing.Size(711, 23);
            this.txBxInput.TabIndex = 1;
            this.txBxInput.TextChanged += new System.EventHandler(this.txBxInput_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 115);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 34);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Отсортировать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Входная строка";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // txBxResult
            // 
            this.txBxResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txBxResult.Location = new System.Drawing.Point(12, 155);
            this.txBxResult.Name = "txBxResult";
            this.txBxResult.ReadOnly = true;
            this.txBxResult.Size = new System.Drawing.Size(711, 29);
            this.txBxResult.TabIndex = 4;
            this.txBxResult.Visible = false;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRes.Location = new System.Drawing.Point(12, 187);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(72, 19);
            this.labelRes.TabIndex = 5;
            this.labelRes.Text = "Результат";
            this.labelRes.Visible = false;
            // 
            // FElemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 221);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.txBxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.txBxInput);
            this.Controls.Add(this.label1);
            this.Name = "FElemForm";
            this.Text = "inputForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txBxInput;
        private Button buttonStart;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Label labelRes;
        private TextBox txBxResult;
    }
}