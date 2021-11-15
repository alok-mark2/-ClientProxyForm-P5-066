
namespace CilentProxyForm_P5_066
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPenjumlahan = new System.Windows.Forms.Label();
            this.labelPengurangan = new System.Windows.Forms.Label();
            this.labelPerkalian = new System.Windows.Forms.Label();
            this.labelPembagian = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angka 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelPenjumlahan
            // 
            this.labelPenjumlahan.AutoSize = true;
            this.labelPenjumlahan.Location = new System.Drawing.Point(334, 33);
            this.labelPenjumlahan.Name = "labelPenjumlahan";
            this.labelPenjumlahan.Size = new System.Drawing.Size(100, 13);
            this.labelPenjumlahan.TabIndex = 4;
            this.labelPenjumlahan.Text = "Hasil Penjumlahan :";
            this.labelPenjumlahan.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelPengurangan
            // 
            this.labelPengurangan.AutoSize = true;
            this.labelPengurangan.Location = new System.Drawing.Point(334, 59);
            this.labelPengurangan.Name = "labelPengurangan";
            this.labelPengurangan.Size = new System.Drawing.Size(103, 13);
            this.labelPengurangan.TabIndex = 5;
            this.labelPengurangan.Text = "Hasil Pengurangan :";
            // 
            // labelPerkalian
            // 
            this.labelPerkalian.AutoSize = true;
            this.labelPerkalian.Location = new System.Drawing.Point(337, 99);
            this.labelPerkalian.Name = "labelPerkalian";
            this.labelPerkalian.Size = new System.Drawing.Size(83, 13);
            this.labelPerkalian.TabIndex = 6;
            this.labelPerkalian.Text = "Hasil Perkalian :";
            // 
            // labelPembagian
            // 
            this.labelPembagian.AutoSize = true;
            this.labelPembagian.Location = new System.Drawing.Point(337, 126);
            this.labelPembagian.Name = "labelPembagian";
            this.labelPembagian.Size = new System.Drawing.Size(95, 13);
            this.labelPembagian.TabIndex = 7;
            this.labelPembagian.Text = "Hasil Pembagian  :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hasil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPembagian);
            this.Controls.Add(this.labelPerkalian);
            this.Controls.Add(this.labelPengurangan);
            this.Controls.Add(this.labelPenjumlahan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPenjumlahan;
        private System.Windows.Forms.Label labelPengurangan;
        private System.Windows.Forms.Label labelPerkalian;
        private System.Windows.Forms.Label labelPembagian;
        private System.Windows.Forms.Button button1;
    }
}

