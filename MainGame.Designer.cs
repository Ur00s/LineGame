using System;
using System.Windows.Forms;

namespace Linije_73_2019
{
    partial class MainGame
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brojPoena = new System.Windows.Forms.Label();
            this.brojPoenaNajbolji = new System.Windows.Forms.Label();
            this.novaIgra = new System.Windows.Forms.Button();
            this.kraj = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dugmeIzbor1 = new System.Windows.Forms.PictureBox();
            this.dugmeIzbor2 = new System.Windows.Forms.PictureBox();
            this.dugmeIzbor3 = new System.Windows.Forms.PictureBox();
            this.minuti = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sekunde = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dugmeIzbor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dugmeIzbor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dugmeIzbor3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Сакупио:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Најбоље:";
            // 
            // brojPoena
            // 
            this.brojPoena.AutoSize = true;
            this.brojPoena.Location = new System.Drawing.Point(99, 21);
            this.brojPoena.Name = "brojPoena";
            this.brojPoena.Size = new System.Drawing.Size(14, 16);
            this.brojPoena.TabIndex = 86;
            this.brojPoena.Text = "0";
            // 
            // brojPoenaNajbolji
            // 
            this.brojPoenaNajbolji.AutoSize = true;
            this.brojPoenaNajbolji.Location = new System.Drawing.Point(99, 60);
            this.brojPoenaNajbolji.Name = "brojPoenaNajbolji";
            this.brojPoenaNajbolji.Size = new System.Drawing.Size(14, 16);
            this.brojPoenaNajbolji.TabIndex = 87;
            this.brojPoenaNajbolji.Text = "0";
            // 
            // novaIgra
            // 
            this.novaIgra.Location = new System.Drawing.Point(976, 95);
            this.novaIgra.Name = "novaIgra";
            this.novaIgra.Size = new System.Drawing.Size(94, 46);
            this.novaIgra.TabIndex = 89;
            this.novaIgra.Text = "Нова игра";
            this.novaIgra.UseVisualStyleBackColor = true;
            this.novaIgra.Click += new System.EventHandler(this.novaIgra_Click);
            // 
            // kraj
            // 
            this.kraj.Location = new System.Drawing.Point(976, 658);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(94, 43);
            this.kraj.TabIndex = 90;
            this.kraj.Text = "Крај";
            this.kraj.UseVisualStyleBackColor = true;
            this.kraj.Click += new System.EventHandler(this.kraj_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.tickTimer);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 92;
            this.label6.Text = "Време:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.0303F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 150);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 606);
            this.tableLayoutPanel1.TabIndex = 93;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.control_MouseClick);
            // 
            // dugmeIzbor1
            // 
            this.dugmeIzbor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dugmeIzbor1.Location = new System.Drawing.Point(318, 40);
            this.dugmeIzbor1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.dugmeIzbor1.Name = "dugmeIzbor1";
            this.dugmeIzbor1.Size = new System.Drawing.Size(62, 60);
            this.dugmeIzbor1.TabIndex = 94;
            this.dugmeIzbor1.TabStop = false;
            this.dugmeIzbor1.Click += new System.EventHandler(this.dugmeIzbor1_Click);
            // 
            // dugmeIzbor2
            // 
            this.dugmeIzbor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dugmeIzbor2.Location = new System.Drawing.Point(399, 40);
            this.dugmeIzbor2.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.dugmeIzbor2.Name = "dugmeIzbor2";
            this.dugmeIzbor2.Size = new System.Drawing.Size(68, 60);
            this.dugmeIzbor2.TabIndex = 95;
            this.dugmeIzbor2.TabStop = false;
            this.dugmeIzbor2.Click += new System.EventHandler(this.dugmeIzbor2_Click);
            // 
            // dugmeIzbor3
            // 
            this.dugmeIzbor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dugmeIzbor3.Location = new System.Drawing.Point(480, 40);
            this.dugmeIzbor3.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.dugmeIzbor3.Name = "dugmeIzbor3";
            this.dugmeIzbor3.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.dugmeIzbor3.Size = new System.Drawing.Size(68, 60);
            this.dugmeIzbor3.TabIndex = 96;
            this.dugmeIzbor3.TabStop = false;
            // 
            // minuti
            // 
            this.minuti.AutoSize = true;
            this.minuti.Location = new System.Drawing.Point(75, 101);
            this.minuti.Name = "minuti";
            this.minuti.Size = new System.Drawing.Size(21, 16);
            this.minuti.TabIndex = 0;
            this.minuti.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 98;
            this.label3.Text = ":";
            // 
            // sekunde
            // 
            this.sekunde.AutoSize = true;
            this.sekunde.Location = new System.Drawing.Point(107, 101);
            this.sekunde.Name = "sekunde";
            this.sekunde.Size = new System.Drawing.Size(21, 16);
            this.sekunde.TabIndex = 99;
            this.sekunde.Text = "00";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(976, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 46);
            this.button2.TabIndex = 101;
            this.button2.Text = "Приказ резултата";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.prikazRezultata);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 775);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sekunde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minuti);
            this.Controls.Add(this.dugmeIzbor3);
            this.Controls.Add(this.dugmeIzbor2);
            this.Controls.Add(this.dugmeIzbor1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kraj);
            this.Controls.Add(this.novaIgra);
            this.Controls.Add(this.brojPoenaNajbolji);
            this.Controls.Add(this.brojPoena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainGame";
            this.Text = "Linije Igra";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dugmeIzbor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dugmeIzbor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dugmeIzbor3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label brojPoena;
        private System.Windows.Forms.Label brojPoenaNajbolji;
        private System.Windows.Forms.Button novaIgra;
        private System.Windows.Forms.Button kraj;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PictureBox dugmeIzbor1;
        private PictureBox dugmeIzbor2;
        private PictureBox dugmeIzbor3;
        private Label minuti;
        private Label label3;
        private Label sekunde;
        private Button button2;
    }
}