namespace Vektorel.Windows.KaçanButonApp
{
    partial class Form3
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
            this.sayi1 = new System.Windows.Forms.Button();
            this.sayi2 = new System.Windows.Forms.Button();
            this.sayi3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(30, 28);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(75, 23);
            this.sayi1.TabIndex = 0;
            this.sayi1.Text = "sayi 1";
            this.sayi1.UseVisualStyleBackColor = true;
            this.sayi1.Click += new System.EventHandler(this.Sayi1_Click);
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(30, 78);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(75, 23);
            this.sayi2.TabIndex = 1;
            this.sayi2.Text = "sayi 2";
            this.sayi2.UseVisualStyleBackColor = true;
            this.sayi2.Click += new System.EventHandler(this.Sayi1_Click);
            // 
            // sayi3
            // 
            this.sayi3.Location = new System.Drawing.Point(30, 128);
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(75, 23);
            this.sayi3.TabIndex = 2;
            this.sayi3.Text = "sayi 3";
            this.sayi3.UseVisualStyleBackColor = true;
            this.sayi3.Click += new System.EventHandler(this.Sayi1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(195, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sonucu Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sayi1);
            this.groupBox1.Controls.Add(this.sayi2);
            this.groupBox1.Controls.Add(this.sayi3);
            this.groupBox1.Location = new System.Drawing.Point(195, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sayi1;
        private System.Windows.Forms.Button sayi2;
        private System.Windows.Forms.Button sayi3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}