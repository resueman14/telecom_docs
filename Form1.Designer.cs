namespace telecom_docs
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
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.buttonMake = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelEtrap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(93, 27);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(204, 20);
            this.textBoxAdres.TabIndex = 0;
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(13, 30);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(34, 13);
            this.labelAdres.TabIndex = 1;
            this.labelAdres.Text = "Adres";
            // 
            // buttonMake
            // 
            this.buttonMake.Location = new System.Drawing.Point(360, 12);
            this.buttonMake.Name = "buttonMake";
            this.buttonMake.Size = new System.Drawing.Size(139, 81);
            this.buttonMake.TabIndex = 2;
            this.buttonMake.Text = "Make images";
            this.buttonMake.UseVisualStyleBackColor = true;
            this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Charjew etr",
            "Turkmenabat shah"});
            this.comboBox1.Location = new System.Drawing.Point(93, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // labelEtrap
            // 
            this.labelEtrap.AutoSize = true;
            this.labelEtrap.Location = new System.Drawing.Point(13, 67);
            this.labelEtrap.Name = "labelEtrap";
            this.labelEtrap.Size = new System.Drawing.Size(50, 13);
            this.labelEtrap.TabIndex = 4;
            this.labelEtrap.Text = "Etr/Shah";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 340);
            this.Controls.Add(this.labelEtrap);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonMake);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.textBoxAdres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Button buttonMake;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelEtrap;
    }
}

