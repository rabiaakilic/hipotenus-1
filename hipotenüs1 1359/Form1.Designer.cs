namespace hipotenüs1_1359
{
    partial class lblHipotenus
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHipoten = new System.Windows.Forms.Label();
            this.txtKenar1 = new System.Windows.Forms.TextBox();
            this.txtKenar2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(31, 110);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(140, 39);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kenar 1";
            // 
            // lblHipoten
            // 
            this.lblHipoten.AutoSize = true;
            this.lblHipoten.Location = new System.Drawing.Point(28, 174);
            this.lblHipoten.Name = "lblHipoten";
            this.lblHipoten.Size = new System.Drawing.Size(36, 13);
            this.lblHipoten.TabIndex = 3;
            this.lblHipoten.Text = "sonuç";
            // 
            // txtKenar1
            // 
            this.txtKenar1.Location = new System.Drawing.Point(103, 39);
            this.txtKenar1.Name = "txtKenar1";
            this.txtKenar1.Size = new System.Drawing.Size(100, 20);
            this.txtKenar1.TabIndex = 4;
            // 
            // txtKenar2
            // 
            this.txtKenar2.Location = new System.Drawing.Point(103, 76);
            this.txtKenar2.Name = "txtKenar2";
            this.txtKenar2.Size = new System.Drawing.Size(100, 20);
            this.txtKenar2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "kenar2";
            // 
            // lblHipotenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKenar2);
            this.Controls.Add(this.txtKenar1);
            this.Controls.Add(this.lblHipoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Name = "lblHipotenus";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHipoten;
        private System.Windows.Forms.TextBox txtKenar1;
        private System.Windows.Forms.TextBox txtKenar2;
        private System.Windows.Forms.Label label2;
    }
}

