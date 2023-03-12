namespace kalkulatori__rimski__imaginarni__veliki_
{
    partial class FormKompleksni
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
            this.textBoxKompleksni = new System.Windows.Forms.TextBox();
            this.textBoxKomp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKompleksni
            // 
            this.textBoxKompleksni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKompleksni.Location = new System.Drawing.Point(112, 142);
            this.textBoxKompleksni.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxKompleksni.Name = "textBoxKompleksni";
            this.textBoxKompleksni.Size = new System.Drawing.Size(850, 41);
            this.textBoxKompleksni.TabIndex = 17;
            this.textBoxKompleksni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxKompleksni_MouseClick);
            this.textBoxKompleksni.TextChanged += new System.EventHandler(this.textBoxKompleksni_TextChanged);
            this.textBoxKompleksni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKompleksni_KeyUp_1);
            // 
            // textBoxKomp
            // 
            this.textBoxKomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKomp.Location = new System.Drawing.Point(393, 303);
            this.textBoxKomp.Name = "textBoxKomp";
            this.textBoxKomp.Size = new System.Drawing.Size(468, 36);
            this.textBoxKomp.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(183, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "REZULTAT";
            // 
            // FormKompleksni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1132, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKomp);
            this.Controls.Add(this.textBoxKompleksni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormKompleksni";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormKompleksni_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKompleksni_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxKompleksni;
        private System.Windows.Forms.TextBox textBoxKomp;
        private System.Windows.Forms.Label label1;
    }
}