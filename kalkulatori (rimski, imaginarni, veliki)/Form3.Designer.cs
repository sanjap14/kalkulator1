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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxKompleksni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(446, 281);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(97, 29);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "button1";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxKompleksni
            // 
            this.textBoxKompleksni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKompleksni.Location = new System.Drawing.Point(195, 65);
            this.textBoxKompleksni.Name = "textBoxKompleksni";
            this.textBoxKompleksni.Size = new System.Drawing.Size(585, 35);
            this.textBoxKompleksni.TabIndex = 17;
            this.textBoxKompleksni.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxKompleksni_MouseClick);
            this.textBoxKompleksni.TextChanged += new System.EventHandler(this.textBoxKompleksni_TextChanged);
            this.textBoxKompleksni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxKompleksni_KeyUp_1);
            // 
            // FormKompleksni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.textBoxKompleksni);
            this.Controls.Add(this.buttonEnter);
            this.Name = "FormKompleksni";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormKompleksni_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKompleksni_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxKompleksni;
    }
}