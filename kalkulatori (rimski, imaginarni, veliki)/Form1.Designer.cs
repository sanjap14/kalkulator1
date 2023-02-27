namespace kalkulatori__rimski__imaginarni__veliki_
{
    partial class Form1
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
            this.buttonRimski = new System.Windows.Forms.Button();
            this.buttonKompleksni = new System.Windows.Forms.Button();
            this.buttonVeliki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRimski
            // 
            this.buttonRimski.Location = new System.Drawing.Point(141, 188);
            this.buttonRimski.Name = "buttonRimski";
            this.buttonRimski.Size = new System.Drawing.Size(126, 37);
            this.buttonRimski.TabIndex = 0;
            this.buttonRimski.Text = "Rimski";
            this.buttonRimski.UseVisualStyleBackColor = true;
            this.buttonRimski.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKompleksni
            // 
            this.buttonKompleksni.Location = new System.Drawing.Point(315, 188);
            this.buttonKompleksni.Name = "buttonKompleksni";
            this.buttonKompleksni.Size = new System.Drawing.Size(126, 37);
            this.buttonKompleksni.TabIndex = 1;
            this.buttonKompleksni.Text = "Kompleksni";
            this.buttonKompleksni.UseVisualStyleBackColor = true;
            this.buttonKompleksni.Click += new System.EventHandler(this.buttonKompleksni_Click);
            // 
            // buttonVeliki
            // 
            this.buttonVeliki.Location = new System.Drawing.Point(490, 188);
            this.buttonVeliki.Name = "buttonVeliki";
            this.buttonVeliki.Size = new System.Drawing.Size(126, 37);
            this.buttonVeliki.TabIndex = 2;
            this.buttonVeliki.Text = "Veliki";
            this.buttonVeliki.UseVisualStyleBackColor = true;
            this.buttonVeliki.Click += new System.EventHandler(this.buttonVeliki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVeliki);
            this.Controls.Add(this.buttonKompleksni);
            this.Controls.Add(this.buttonRimski);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRimski;
        private System.Windows.Forms.Button buttonKompleksni;
        private System.Windows.Forms.Button buttonVeliki;
    }
}

