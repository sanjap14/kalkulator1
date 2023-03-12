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
            this.buttonRimski.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRimski.Location = new System.Drawing.Point(343, 53);
            this.buttonRimski.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRimski.Name = "buttonRimski";
            this.buttonRimski.Size = new System.Drawing.Size(397, 100);
            this.buttonRimski.TabIndex = 0;
            this.buttonRimski.Text = "Rimski";
            this.buttonRimski.UseVisualStyleBackColor = true;
            this.buttonRimski.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonKompleksni
            // 
            this.buttonKompleksni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKompleksni.Location = new System.Drawing.Point(343, 224);
            this.buttonKompleksni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKompleksni.Name = "buttonKompleksni";
            this.buttonKompleksni.Size = new System.Drawing.Size(397, 100);
            this.buttonKompleksni.TabIndex = 1;
            this.buttonKompleksni.Text = "Kompleksni";
            this.buttonKompleksni.UseVisualStyleBackColor = true;
            this.buttonKompleksni.Click += new System.EventHandler(this.buttonKompleksni_Click);
            // 
            // buttonVeliki
            // 
            this.buttonVeliki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVeliki.Location = new System.Drawing.Point(343, 396);
            this.buttonVeliki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVeliki.Name = "buttonVeliki";
            this.buttonVeliki.Size = new System.Drawing.Size(397, 100);
            this.buttonVeliki.TabIndex = 2;
            this.buttonVeliki.Text = "Veliki";
            this.buttonVeliki.UseVisualStyleBackColor = true;
            this.buttonVeliki.Click += new System.EventHandler(this.buttonVeliki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonVeliki);
            this.Controls.Add(this.buttonKompleksni);
            this.Controls.Add(this.buttonRimski);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

