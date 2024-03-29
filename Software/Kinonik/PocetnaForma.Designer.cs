﻿
namespace Kinonik
{
    partial class PocetnaForma
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
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.buttonUpravljanjeFilmovima = new System.Windows.Forms.Button();
            this.buttonUpravljanjeTerminima = new System.Windows.Forms.Button();
            this.labelUloga = new System.Windows.Forms.Label();
            this.buttonUpravljanjeProizvodima = new System.Windows.Forms.Button();
            this.btnUpravljanjeKinima = new System.Windows.Forms.Button();
            this.btnUpravljanjeDvoranama = new System.Windows.Forms.Button();
            this.btnKupiKartu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatistikaGledanosti = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(3, 9);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.labelKorisnickoIme.TabIndex = 0;
            this.labelKorisnickoIme.Text = "Korisničko ime";
            // 
            // buttonUpravljanjeFilmovima
            // 
            this.buttonUpravljanjeFilmovima.Location = new System.Drawing.Point(12, 190);
            this.buttonUpravljanjeFilmovima.Name = "buttonUpravljanjeFilmovima";
            this.buttonUpravljanjeFilmovima.Size = new System.Drawing.Size(135, 47);
            this.buttonUpravljanjeFilmovima.TabIndex = 1;
            this.buttonUpravljanjeFilmovima.Text = "Upravljanje filmovima";
            this.buttonUpravljanjeFilmovima.UseVisualStyleBackColor = true;
            this.buttonUpravljanjeFilmovima.Click += new System.EventHandler(this.buttonUpravljanjeFilmovima_Click);
            // 
            // buttonUpravljanjeTerminima
            // 
            this.buttonUpravljanjeTerminima.Location = new System.Drawing.Point(12, 137);
            this.buttonUpravljanjeTerminima.Name = "buttonUpravljanjeTerminima";
            this.buttonUpravljanjeTerminima.Size = new System.Drawing.Size(135, 47);
            this.buttonUpravljanjeTerminima.TabIndex = 2;
            this.buttonUpravljanjeTerminima.Text = "Upravljanje terminima";
            this.buttonUpravljanjeTerminima.UseVisualStyleBackColor = true;
            this.buttonUpravljanjeTerminima.Click += new System.EventHandler(this.buttonUpravljanjeTerminima_Click);
            // 
            // labelUloga
            // 
            this.labelUloga.AutoSize = true;
            this.labelUloga.Location = new System.Drawing.Point(3, 37);
            this.labelUloga.Name = "labelUloga";
            this.labelUloga.Size = new System.Drawing.Size(35, 13);
            this.labelUloga.TabIndex = 3;
            this.labelUloga.Text = "Uloga";
            // 
            // buttonUpravljanjeProizvodima
            // 
            this.buttonUpravljanjeProizvodima.Location = new System.Drawing.Point(12, 243);
            this.buttonUpravljanjeProizvodima.Name = "buttonUpravljanjeProizvodima";
            this.buttonUpravljanjeProizvodima.Size = new System.Drawing.Size(135, 47);
            this.buttonUpravljanjeProizvodima.TabIndex = 4;
            this.buttonUpravljanjeProizvodima.Text = "Upravljanje dodatnim proizvodima";
            this.buttonUpravljanjeProizvodima.UseVisualStyleBackColor = true;
            this.buttonUpravljanjeProizvodima.Click += new System.EventHandler(this.buttonUpravljanjeProizvodima_Click);
            // 
            // btnUpravljanjeKinima
            // 
            this.btnUpravljanjeKinima.Location = new System.Drawing.Point(12, 84);
            this.btnUpravljanjeKinima.Name = "btnUpravljanjeKinima";
            this.btnUpravljanjeKinima.Size = new System.Drawing.Size(135, 47);
            this.btnUpravljanjeKinima.TabIndex = 5;
            this.btnUpravljanjeKinima.Text = "Upravljanje kinima";
            this.btnUpravljanjeKinima.UseVisualStyleBackColor = true;
            this.btnUpravljanjeKinima.Click += new System.EventHandler(this.btnUpravljanjeKinima_Click);
            // 
            // btnUpravljanjeDvoranama
            // 
            this.btnUpravljanjeDvoranama.Location = new System.Drawing.Point(12, 296);
            this.btnUpravljanjeDvoranama.Name = "btnUpravljanjeDvoranama";
            this.btnUpravljanjeDvoranama.Size = new System.Drawing.Size(135, 48);
            this.btnUpravljanjeDvoranama.TabIndex = 6;
            this.btnUpravljanjeDvoranama.Text = "Upravljanje dvoranama";
            this.btnUpravljanjeDvoranama.UseVisualStyleBackColor = true;
            this.btnUpravljanjeDvoranama.Click += new System.EventHandler(this.btnUpravljanjeDvoranama_Click);
            // 
            // btnKupiKartu
            // 
            this.btnKupiKartu.Location = new System.Drawing.Point(12, 350);
            this.btnKupiKartu.Name = "btnKupiKartu";
            this.btnKupiKartu.Size = new System.Drawing.Size(135, 47);
            this.btnKupiKartu.TabIndex = 7;
            this.btnKupiKartu.Text = "Kupi kartu";
            this.btnKupiKartu.UseVisualStyleBackColor = true;
            this.btnKupiKartu.Click += new System.EventHandler(this.btnKupiKartu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelUloga);
            this.groupBox1.Controls.Add(this.labelKorisnickoIme);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 86);
            this.label1.TabIndex = 9;
            this.label1.Text = "KINONIK";
            // 
            // btnStatistikaGledanosti
            // 
            this.btnStatistikaGledanosti.Location = new System.Drawing.Point(12, 403);
            this.btnStatistikaGledanosti.Name = "btnStatistikaGledanosti";
            this.btnStatistikaGledanosti.Size = new System.Drawing.Size(135, 45);
            this.btnStatistikaGledanosti.TabIndex = 8;
            this.btnStatistikaGledanosti.Text = "Statistika gledanosti";
            this.btnStatistikaGledanosti.UseVisualStyleBackColor = true;
            this.btnStatistikaGledanosti.Click += new System.EventHandler(this.btnStatistikaGledanosti_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Roko\\Documents\\pi22-mmihaljev-arados-rmilosevi\\Software\\Kinonik\\help.chm" +
    "";
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStatistikaGledanosti);
            this.Controls.Add(this.btnKupiKartu);
            this.Controls.Add(this.btnUpravljanjeDvoranama);
            this.Controls.Add(this.btnUpravljanjeKinima);
            this.Controls.Add(this.buttonUpravljanjeProizvodima);
            this.Controls.Add(this.buttonUpravljanjeTerminima);
            this.Controls.Add(this.buttonUpravljanjeFilmovima);
            this.Name = "PocetnaForma";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna forma";
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PocetnaForma_HelpRequested);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Button buttonUpravljanjeFilmovima;
        private System.Windows.Forms.Button buttonUpravljanjeTerminima;
        private System.Windows.Forms.Label labelUloga;
        private System.Windows.Forms.Button buttonUpravljanjeProizvodima;
        private System.Windows.Forms.Button btnUpravljanjeKinima;
        private System.Windows.Forms.Button btnUpravljanjeDvoranama;
        private System.Windows.Forms.Button btnKupiKartu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStatistikaGledanosti;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

