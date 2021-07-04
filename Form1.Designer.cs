namespace projePaint
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
            this.panelCizim = new System.Windows.Forms.Panel();
            this.panelRenkler = new System.Windows.Forms.Panel();
            this.buttonPembe = new System.Windows.Forms.Button();
            this.buttonMor = new System.Windows.Forms.Button();
            this.buttonLacivert = new System.Windows.Forms.Button();
            this.buttonYesil = new System.Windows.Forms.Button();
            this.buttonSari = new System.Windows.Forms.Button();
            this.buttonTuruncu = new System.Windows.Forms.Button();
            this.buttonKirmizi = new System.Windows.Forms.Button();
            this.buttonMavi = new System.Windows.Forms.Button();
            this.buttonSiyah = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSekilislemi = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDosyaislemi = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSekiller = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.dosyaButton = new System.Windows.Forms.Button();
            this.buttonSilme = new System.Windows.Forms.Button();
            this.buttonSec = new System.Windows.Forms.Button();
            this.buttonAltigen = new System.Windows.Forms.Button();
            this.buttonUcgen = new System.Windows.Forms.Button();
            this.buttonDaire = new System.Windows.Forms.Button();
            this.buttonKare = new System.Windows.Forms.Button();
            this.panelRenkler.SuspendLayout();
            this.panelSekilislemi.SuspendLayout();
            this.panelDosyaislemi.SuspendLayout();
            this.panelSekiller.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCizim
            // 
            this.panelCizim.Location = new System.Drawing.Point(0, 5);
            this.panelCizim.Name = "panelCizim";
            this.panelCizim.Size = new System.Drawing.Size(580, 408);
            this.panelCizim.TabIndex = 0;
            this.panelCizim.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCizim_Paint);
            this.panelCizim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCizim_MouseDown);
            this.panelCizim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCizim_MouseMove);
            this.panelCizim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCizim_MouseUp);
            // 
            // panelRenkler
            // 
            this.panelRenkler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelRenkler.Controls.Add(this.buttonPembe);
            this.panelRenkler.Controls.Add(this.buttonMor);
            this.panelRenkler.Controls.Add(this.buttonLacivert);
            this.panelRenkler.Controls.Add(this.buttonYesil);
            this.panelRenkler.Controls.Add(this.buttonSari);
            this.panelRenkler.Controls.Add(this.buttonTuruncu);
            this.panelRenkler.Controls.Add(this.buttonKirmizi);
            this.panelRenkler.Controls.Add(this.buttonMavi);
            this.panelRenkler.Controls.Add(this.buttonSiyah);
            this.panelRenkler.Controls.Add(this.label2);
            this.panelRenkler.Location = new System.Drawing.Point(586, 125);
            this.panelRenkler.Name = "panelRenkler";
            this.panelRenkler.Size = new System.Drawing.Size(114, 103);
            this.panelRenkler.TabIndex = 2;
            // 
            // buttonPembe
            // 
            this.buttonPembe.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonPembe.Location = new System.Drawing.Point(80, 74);
            this.buttonPembe.Name = "buttonPembe";
            this.buttonPembe.Size = new System.Drawing.Size(25, 23);
            this.buttonPembe.TabIndex = 10;
            this.buttonPembe.UseVisualStyleBackColor = false;
            this.buttonPembe.Click += new System.EventHandler(this.buttonPembe_Click);
            // 
            // buttonMor
            // 
            this.buttonMor.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonMor.Location = new System.Drawing.Point(43, 74);
            this.buttonMor.Name = "buttonMor";
            this.buttonMor.Size = new System.Drawing.Size(25, 23);
            this.buttonMor.TabIndex = 9;
            this.buttonMor.UseVisualStyleBackColor = false;
            this.buttonMor.Click += new System.EventHandler(this.buttonMor_Click);
            // 
            // buttonLacivert
            // 
            this.buttonLacivert.BackColor = System.Drawing.Color.Blue;
            this.buttonLacivert.Location = new System.Drawing.Point(7, 74);
            this.buttonLacivert.Name = "buttonLacivert";
            this.buttonLacivert.Size = new System.Drawing.Size(25, 23);
            this.buttonLacivert.TabIndex = 8;
            this.buttonLacivert.UseVisualStyleBackColor = false;
            this.buttonLacivert.Click += new System.EventHandler(this.buttonLacivert_Click);
            // 
            // buttonYesil
            // 
            this.buttonYesil.BackColor = System.Drawing.Color.Green;
            this.buttonYesil.Location = new System.Drawing.Point(80, 45);
            this.buttonYesil.Name = "buttonYesil";
            this.buttonYesil.Size = new System.Drawing.Size(25, 23);
            this.buttonYesil.TabIndex = 7;
            this.buttonYesil.UseVisualStyleBackColor = false;
            this.buttonYesil.Click += new System.EventHandler(this.buttonYesil_Click);
            // 
            // buttonSari
            // 
            this.buttonSari.BackColor = System.Drawing.Color.Yellow;
            this.buttonSari.Location = new System.Drawing.Point(43, 45);
            this.buttonSari.Name = "buttonSari";
            this.buttonSari.Size = new System.Drawing.Size(25, 23);
            this.buttonSari.TabIndex = 6;
            this.buttonSari.UseVisualStyleBackColor = false;
            this.buttonSari.Click += new System.EventHandler(this.buttonSari_Click);
            // 
            // buttonTuruncu
            // 
            this.buttonTuruncu.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonTuruncu.Location = new System.Drawing.Point(6, 45);
            this.buttonTuruncu.Name = "buttonTuruncu";
            this.buttonTuruncu.Size = new System.Drawing.Size(25, 23);
            this.buttonTuruncu.TabIndex = 5;
            this.buttonTuruncu.UseVisualStyleBackColor = false;
            this.buttonTuruncu.Click += new System.EventHandler(this.buttonTuruncu_Click);
            // 
            // buttonKirmizi
            // 
            this.buttonKirmizi.BackColor = System.Drawing.Color.Red;
            this.buttonKirmizi.Location = new System.Drawing.Point(79, 16);
            this.buttonKirmizi.Name = "buttonKirmizi";
            this.buttonKirmizi.Size = new System.Drawing.Size(25, 23);
            this.buttonKirmizi.TabIndex = 4;
            this.buttonKirmizi.UseVisualStyleBackColor = false;
            this.buttonKirmizi.Click += new System.EventHandler(this.buttonKirmizi_Click);
            // 
            // buttonMavi
            // 
            this.buttonMavi.BackColor = System.Drawing.Color.Aqua;
            this.buttonMavi.Location = new System.Drawing.Point(42, 16);
            this.buttonMavi.Name = "buttonMavi";
            this.buttonMavi.Size = new System.Drawing.Size(25, 23);
            this.buttonMavi.TabIndex = 3;
            this.buttonMavi.UseVisualStyleBackColor = false;
            this.buttonMavi.Click += new System.EventHandler(this.buttonMavi_Click);
            // 
            // buttonSiyah
            // 
            this.buttonSiyah.BackColor = System.Drawing.Color.Black;
            this.buttonSiyah.Location = new System.Drawing.Point(6, 16);
            this.buttonSiyah.Name = "buttonSiyah";
            this.buttonSiyah.Size = new System.Drawing.Size(25, 23);
            this.buttonSiyah.TabIndex = 2;
            this.buttonSiyah.UseVisualStyleBackColor = false;
            this.buttonSiyah.Click += new System.EventHandler(this.buttonSiyah_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Renk Seçimi";
            // 
            // panelSekilislemi
            // 
            this.panelSekilislemi.BackColor = System.Drawing.Color.White;
            this.panelSekilislemi.Controls.Add(this.buttonSilme);
            this.panelSekilislemi.Controls.Add(this.buttonSec);
            this.panelSekilislemi.Controls.Add(this.label3);
            this.panelSekilislemi.Location = new System.Drawing.Point(586, 234);
            this.panelSekilislemi.Name = "panelSekilislemi";
            this.panelSekilislemi.Size = new System.Drawing.Size(114, 89);
            this.panelSekilislemi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şekil İşlemleri";
            // 
            // panelDosyaislemi
            // 
            this.panelDosyaislemi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelDosyaislemi.Controls.Add(this.kaydetButton);
            this.panelDosyaislemi.Controls.Add(this.dosyaButton);
            this.panelDosyaislemi.Controls.Add(this.label4);
            this.panelDosyaislemi.Location = new System.Drawing.Point(586, 329);
            this.panelDosyaislemi.Name = "panelDosyaislemi";
            this.panelDosyaislemi.Size = new System.Drawing.Size(114, 84);
            this.panelDosyaislemi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dosya İşlemleri";
            // 
            // panelSekiller
            // 
            this.panelSekiller.BackColor = System.Drawing.Color.White;
            this.panelSekiller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelSekiller.Controls.Add(this.buttonAltigen);
            this.panelSekiller.Controls.Add(this.buttonUcgen);
            this.panelSekiller.Controls.Add(this.buttonDaire);
            this.panelSekiller.Controls.Add(this.buttonKare);
            this.panelSekiller.Controls.Add(this.label1);
            this.panelSekiller.Location = new System.Drawing.Point(586, 5);
            this.panelSekiller.Name = "panelSekiller";
            this.panelSekiller.Size = new System.Drawing.Size(114, 114);
            this.panelSekiller.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çizim Şekli";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kaydetButton
            // 
            this.kaydetButton.BackgroundImage = global::projePaint.Properties.Resources.save;
            this.kaydetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kaydetButton.Location = new System.Drawing.Point(63, 18);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(42, 57);
            this.kaydetButton.TabIndex = 5;
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // dosyaButton
            // 
            this.dosyaButton.BackgroundImage = global::projePaint.Properties.Resources.fileopen;
            this.dosyaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dosyaButton.Location = new System.Drawing.Point(8, 18);
            this.dosyaButton.Name = "dosyaButton";
            this.dosyaButton.Size = new System.Drawing.Size(42, 57);
            this.dosyaButton.TabIndex = 4;
            this.dosyaButton.UseVisualStyleBackColor = true;
            this.dosyaButton.Click += new System.EventHandler(this.dosyaButton_Click);
            // 
            // buttonSilme
            // 
            this.buttonSilme.BackgroundImage = global::projePaint.Properties.Resources.sil;
            this.buttonSilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSilme.Location = new System.Drawing.Point(63, 16);
            this.buttonSilme.Name = "buttonSilme";
            this.buttonSilme.Size = new System.Drawing.Size(42, 57);
            this.buttonSilme.TabIndex = 3;
            this.buttonSilme.UseVisualStyleBackColor = true;
            this.buttonSilme.Click += new System.EventHandler(this.buttonSilme_Click);
            // 
            // buttonSec
            // 
            this.buttonSec.BackgroundImage = global::projePaint.Properties.Resources.sec1;
            this.buttonSec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSec.Location = new System.Drawing.Point(7, 16);
            this.buttonSec.Name = "buttonSec";
            this.buttonSec.Size = new System.Drawing.Size(43, 57);
            this.buttonSec.TabIndex = 2;
            this.buttonSec.UseVisualStyleBackColor = true;
            this.buttonSec.Click += new System.EventHandler(this.buttonSec_Click);
            // 
            // buttonAltigen
            // 
            this.buttonAltigen.BackgroundImage = global::projePaint.Properties.Resources.altigen;
            this.buttonAltigen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAltigen.Location = new System.Drawing.Point(62, 70);
            this.buttonAltigen.Name = "buttonAltigen";
            this.buttonAltigen.Size = new System.Drawing.Size(44, 33);
            this.buttonAltigen.TabIndex = 4;
            this.buttonAltigen.UseVisualStyleBackColor = true;
            this.buttonAltigen.Click += new System.EventHandler(this.buttonAltigen_Click);
            // 
            // buttonUcgen
            // 
            this.buttonUcgen.BackgroundImage = global::projePaint.Properties.Resources.ucgen;
            this.buttonUcgen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUcgen.Location = new System.Drawing.Point(6, 70);
            this.buttonUcgen.Name = "buttonUcgen";
            this.buttonUcgen.Size = new System.Drawing.Size(44, 33);
            this.buttonUcgen.TabIndex = 3;
            this.buttonUcgen.UseVisualStyleBackColor = true;
            this.buttonUcgen.Click += new System.EventHandler(this.buttonUcgen_Click);
            // 
            // buttonDaire
            // 
            this.buttonDaire.BackgroundImage = global::projePaint.Properties.Resources.daire;
            this.buttonDaire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDaire.Location = new System.Drawing.Point(62, 31);
            this.buttonDaire.Name = "buttonDaire";
            this.buttonDaire.Size = new System.Drawing.Size(44, 33);
            this.buttonDaire.TabIndex = 2;
            this.buttonDaire.UseVisualStyleBackColor = true;
            this.buttonDaire.Click += new System.EventHandler(this.buttonDaire_Click);
            // 
            // buttonKare
            // 
            this.buttonKare.BackgroundImage = global::projePaint.Properties.Resources.kare;
            this.buttonKare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonKare.Location = new System.Drawing.Point(6, 31);
            this.buttonKare.Name = "buttonKare";
            this.buttonKare.Size = new System.Drawing.Size(44, 33);
            this.buttonKare.TabIndex = 1;
            this.buttonKare.UseVisualStyleBackColor = true;
            this.buttonKare.Click += new System.EventHandler(this.buttonKare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 416);
            this.Controls.Add(this.panelDosyaislemi);
            this.Controls.Add(this.panelSekilislemi);
            this.Controls.Add(this.panelRenkler);
            this.Controls.Add(this.panelSekiller);
            this.Controls.Add(this.panelCizim);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 454);
            this.MinimumSize = new System.Drawing.Size(719, 454);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelRenkler.ResumeLayout(false);
            this.panelRenkler.PerformLayout();
            this.panelSekilislemi.ResumeLayout(false);
            this.panelSekilislemi.PerformLayout();
            this.panelDosyaislemi.ResumeLayout(false);
            this.panelDosyaislemi.PerformLayout();
            this.panelSekiller.ResumeLayout(false);
            this.panelSekiller.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCizim;
        private System.Windows.Forms.Panel panelSekiller;
        private System.Windows.Forms.Button buttonAltigen;
        private System.Windows.Forms.Button buttonUcgen;
        private System.Windows.Forms.Button buttonDaire;
        private System.Windows.Forms.Button buttonKare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRenkler;
        private System.Windows.Forms.Button buttonPembe;
        private System.Windows.Forms.Button buttonMor;
        private System.Windows.Forms.Button buttonLacivert;
        private System.Windows.Forms.Button buttonYesil;
        private System.Windows.Forms.Button buttonSari;
        private System.Windows.Forms.Button buttonTuruncu;
        private System.Windows.Forms.Button buttonKirmizi;
        private System.Windows.Forms.Button buttonMavi;
        private System.Windows.Forms.Button buttonSiyah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelSekilislemi;
        private System.Windows.Forms.Button buttonSilme;
        private System.Windows.Forms.Button buttonSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDosyaislemi;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button dosyaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

