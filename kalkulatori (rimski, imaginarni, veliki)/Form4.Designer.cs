namespace kalkulatori__rimski__imaginarni__veliki_
{
    partial class FormVeliki
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
            this.textBoxPrvi = new System.Windows.Forms.TextBox();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.textBoxDrugi = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPrvi
            // 
            this.textBoxPrvi.Location = new System.Drawing.Point(12, 92);
            this.textBoxPrvi.Name = "textBoxPrvi";
            this.textBoxPrvi.Size = new System.Drawing.Size(760, 20);
            this.textBoxPrvi.TabIndex = 0;
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(12, 325);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(760, 20);
            this.textBoxRezultat.TabIndex = 1;
            // 
            // textBoxDrugi
            // 
            this.textBoxDrugi.Location = new System.Drawing.Point(12, 133);
            this.textBoxDrugi.Name = "textBoxDrugi";
            this.textBoxDrugi.Size = new System.Drawing.Size(760, 20);
            this.textBoxDrugi.TabIndex = 2;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(151, 205);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(76, 55);
            this.buttonPlus.TabIndex = 3;
            this.buttonPlus.Text = "button1";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(278, 205);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(76, 55);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Text = "button1";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // FormVeliki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBoxDrugi);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.textBoxPrvi);
            this.Name = "FormVeliki";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrvi;
        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.TextBox textBoxDrugi;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
    }
}