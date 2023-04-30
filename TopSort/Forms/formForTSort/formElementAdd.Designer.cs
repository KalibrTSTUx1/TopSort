namespace Forms
{
    partial class formElementAdd
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
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.txBxAdd = new System.Windows.Forms.TextBox();
            this.errorHandler = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new System.Drawing.Point(12, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(38, 15);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "label1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // txBxAdd
            // 
            this.txBxAdd.Location = new System.Drawing.Point(12, 27);
            this.txBxAdd.Name = "txBxAdd";
            this.txBxAdd.Size = new System.Drawing.Size(240, 23);
            this.txBxAdd.TabIndex = 2;
            this.txBxAdd.TextChanged += new System.EventHandler(this.txBxAdd_TextChanged);
            // 
            // errorHandler
            // 
            this.errorHandler.ContainerControl = this;
            // 
            // formElementAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(264, 107);
            this.Controls.Add(this.txBxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLogo);
            this.MaximizeBox = false;
            this.Name = "formElementAdd";
            this.Text = "formElementAdd";
            ((System.ComponentModel.ISupportInitialize)(this.errorHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLogo;
        private Button buttonAdd;
        private TextBox txBxAdd;
        private ErrorProvider errorHandler;
    }
}