﻿
namespace ödev1
{
    partial class frmSatis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.marka = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kategori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(599, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 125);
            this.panel1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 76);
            this.button4.TabIndex = 13;
            this.button4.Text = "Müşteri Listeleme";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 76);
            this.button6.TabIndex = 10;
            this.button6.Text = "Müşteri Ekleme";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 76);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ürün Ekleme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(629, 418);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(171, 76);
            this.marka.TabIndex = 12;
            this.marka.Text = "Marka";
            this.marka.UseVisualStyleBackColor = true;
            this.marka.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 76);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ürün Listeleme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kategori
            // 
            this.kategori.Location = new System.Drawing.Point(629, 307);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(171, 76);
            this.kategori.TabIndex = 11;
            this.kategori.Text = "Kategori";
            this.kategori.UseVisualStyleBackColor = true;
            this.kategori.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Müşteri İşlemleri";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(830, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button musteriListele;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button marka;
        private System.Windows.Forms.Button kategori;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

