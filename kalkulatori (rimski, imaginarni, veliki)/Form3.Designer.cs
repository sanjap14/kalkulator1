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
            this.SuspendLayout();
            // 
            // textBoxKompleksni
            // 
            this.textBoxKompleksni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKompleksni.Location = new System.Drawing.Point(124, 234);
            this.textBoxKompleksni.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxKompleksni.Name = "textBoxKompleksni";
            this.textBoxKompleksni.Size = new System.Drawing.Size(850, 35);
            this.textBoxKompleksni.TabIndex = 17;
            this.textBoxKompleksni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxKompleksni_MouseClick);
            this.textBoxKompleksni.TextChanged += new System.EventHandler(this.textBoxKompleksni_TextChanged);
            this.textBoxKompleksni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKompleksni_KeyUp_1);
            // 
            // FormKompleksni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1132, 555);
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
    }
}