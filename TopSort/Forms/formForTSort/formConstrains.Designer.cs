namespace Forms.AllForms
{
    partial class formConstrains
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
            this.cmBxFirst = new System.Windows.Forms.ComboBox();
            this.cmBxSecond = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorHandler = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorHandler)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBxFirst
            // 
            this.cmBxFirst.FormattingEnabled = true;
            this.cmBxFirst.Location = new System.Drawing.Point(12, 86);
            this.cmBxFirst.Name = "cmBxFirst";
            this.cmBxFirst.Size = new System.Drawing.Size(121, 23);
            this.cmBxFirst.TabIndex = 0;
            this.cmBxFirst.SelectedIndexChanged += new System.EventHandler(this.cmBxFirst_SelectedIndexChanged);
            // 
            // cmBxSecond
            // 
            this.cmBxSecond.Enabled = false;
            this.cmBxSecond.FormattingEnabled = true;
            this.cmBxSecond.Location = new System.Drawing.Point(139, 86);
            this.cmBxSecond.Name = "cmBxSecond";
            this.cmBxSecond.Size = new System.Drawing.Size(121, 23);
            this.cmBxSecond.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ограничения";
            // 
            // errorHandler
            // 
            this.errorHandler.ContainerControl = this;
            // 
            // formConstrains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(291, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmBxSecond);
            this.Controls.Add(this.cmBxFirst);
            this.Name = "formConstrains";
            this.Text = "fornConstrains";
            ((System.ComponentModel.ISupportInitialize)(this.errorHandler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmBxFirst;
        private ComboBox cmBxSecond;
        private Button button1;
        private Label label1;
        private ErrorProvider errorHandler;
    }
}