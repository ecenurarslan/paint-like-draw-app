using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projePaint
{
    public partial class Form1 : Form
    {
        bool sec = false;
        bool basiliMi;
        bool kareMi;
        bool daireMi;
        bool ucgenMi;
        bool altigenMi;
        string yazilanRenk = "Beyaz";
        Color secilenRenk = Color.White;
        
        int x;
        int y;
        int a;
        int b;

        public Form1()
        {
            InitializeComponent();
            Graphics m = panelCizim.CreateGraphics();
            m.Clear(panelCizim.BackColor);
            File.WriteAllText("sekiller.txt", string.Empty);
        }

        private void buttonKare_Click(object sender, EventArgs e)

        {
            kareMi = true;
            ucgenMi = false;
            daireMi = false;
            altigenMi = false;
            buttonKare.FlatStyle = FlatStyle.Popup;
            buttonUcgen.FlatStyle = FlatStyle.Standard;
            buttonDaire.FlatStyle = FlatStyle.Standard;
            buttonAltigen.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonUcgen_Click(object sender, EventArgs e)
        {
            ucgenMi = true;
            daireMi = false;
            altigenMi = false;
            kareMi = false;
            buttonKare.FlatStyle = FlatStyle.Standard;
            buttonUcgen.FlatStyle = FlatStyle.Popup;
            buttonDaire.FlatStyle = FlatStyle.Standard;
            buttonAltigen.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonDaire_Click(object sender, EventArgs e)
        {
            ucgenMi = false;
            daireMi = true;
            altigenMi = false;
            kareMi = false;
            buttonKare.FlatStyle = FlatStyle.Standard;
            buttonUcgen.FlatStyle = FlatStyle.Standard;
            buttonDaire.FlatStyle = FlatStyle.Popup;
            buttonAltigen.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonAltigen_Click(object sender, EventArgs e)
        {
            ucgenMi = false;
            daireMi = false;
            altigenMi = true;
            kareMi = false;
            buttonKare.FlatStyle = FlatStyle.Standard;
            buttonUcgen.FlatStyle = FlatStyle.Standard;
            buttonDaire.FlatStyle = FlatStyle.Standard;
            buttonAltigen.FlatStyle = FlatStyle.Popup;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void panelCizim_MouseDown(object sender, MouseEventArgs e)
        {
            basiliMi = true;
            x = e.X;
            y= e.Y;
        }

        private void panelCizim_MouseUp(object sender, MouseEventArgs e)
        {
            basiliMi = false;

            if (kareMi && yazilanRenk != "Beyaz")
            {
                StreamWriter yazdir = new StreamWriter("Sekiller.txt", true);
                yazdir.WriteLine("kare" + " " + yazilanRenk + " " + Convert.ToString(x - a) + " " + Convert.ToString(y - b) + " " + Convert.ToString(x + a) + " " + Convert.ToString(y - b) + " " +
                Convert.ToString(x - a) + " " + Convert.ToString(y + b) + " " + Convert.ToString(x + a) + " " + Convert.ToString(y + b));
                yazdir.Close();
            }

            if (daireMi && yazilanRenk != "Beyaz")
            {
                StreamWriter yazdir = new StreamWriter("Sekiller.txt", true);
                yazdir.WriteLine("daire" + " " + yazilanRenk + " " + Convert.ToString(x - Convert.ToInt64(Math.Sqrt((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y)))) + " " + Convert.ToString(y - Convert.ToInt64(Math.Sqrt((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y)))) + " " + 2 * Convert.ToInt64(Math.Sqrt((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y))) + " " + Convert.ToInt64(Math.Sqrt((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y))) * 2);
                yazdir.Close();
            }

            if (ucgenMi && yazilanRenk != "Beyaz")
            {
                StreamWriter yazdir = new StreamWriter("Sekiller.txt", true);
                yazdir.WriteLine("ucgen" + " " + yazilanRenk + " " + Convert.ToString(x) + " " + Convert.ToString(y) + " " + Convert.ToString(x - (e.X - x)) + " " + Convert.ToString(e.Y) + " " +
                Convert.ToString(e.X) + " " + Convert.ToString(e.Y));
                yazdir.Close();
            }

            if (altigenMi && yazilanRenk != "Beyaz")
            {
                StreamWriter yazdir = new StreamWriter("Sekiller.txt", true);
                yazdir.WriteLine("altigen" + " " + yazilanRenk + " " + Convert.ToString(x) + " " + Convert.ToString(y) + " " + Convert.ToString(e.X) + " " + Convert.ToString(y) + " " +
                Convert.ToString(e.X + ((e.X - x) / 2)) + " " + Convert.ToString(y + ((e.Y - y) / 2)) + " " + Convert.ToString(e.X) + " " + Convert.ToString(e.Y) + " " + Convert.ToString(x) + " " + Convert.ToString(e.Y) + " " + Convert.ToString(x - ((e.X - x) / 2)) + " " + Convert.ToString(y + ((e.Y - y) / 2)));
                yazdir.Close();
            }
        }


        private void panelCizim_MouseMove(object sender, MouseEventArgs e)
        {

            Graphics m = panelCizim.CreateGraphics();
           
            a = e.X - x;
            b = e.Y - y;

            if (basiliMi && secilenRenk != Color.White)
              {

                Graphics g = panelCizim.CreateGraphics();
                Color renkOku = Color.White; 
                StreamReader dosyaOku = new StreamReader("Sekiller.txt");
                string bilgi = dosyaOku.ReadLine();
                m.Clear(panelCizim.BackColor);

                Kare kare = new Kare();
                kare.KareOku(panelCizim);
                Ucgen ucgen = new Ucgen();
                ucgen.UcgenOku(panelCizim);
                Altigen altigen = new Altigen();
                altigen.AltigenOku(panelCizim);
                Daire daire = new Daire();
                daire.DaireOku(panelCizim);

              
                if (kareMi)
                {
                    Kare kareCizme = new Kare();
                    kareCizme.KareCiz(x,a,y,b,panelCizim,secilenRenk);
                }

                if (ucgenMi)
                {
                    Ucgen ucgenCizme = new Ucgen();
                    ucgenCizme.UcgenCiz(x, y, a,b,secilenRenk, panelCizim);
                }

                if (daireMi)
                {
                    Daire daireCizme = new Daire();
                    daireCizme.DaireCiz(secilenRenk,x,y,a,b, panelCizim);
                }

                if (altigenMi)
                {
                    Altigen altigenCizme = new Altigen();
                    altigenCizme.AltigenCiz(panelCizim, x, y, a, b, secilenRenk);
                }
                dosyaOku.Close();
            }
        }

        private void buttonSiyah_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.Black;
            yazilanRenk = "Siyah";
            buttonSiyah.FlatStyle = FlatStyle.Popup;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;

        }

        private void buttonMavi_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.Aqua;
            yazilanRenk = "Aqua";
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Popup;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonKirmizi_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.Red;
            yazilanRenk = "Kirmizi";
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Popup;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonTuruncu_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.DarkOrange;
            yazilanRenk = "Turuncu";
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Popup;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonSari_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.Yellow;
            yazilanRenk = "Sari";
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Popup;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonYesil_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.Green;
            yazilanRenk = "Yesil";
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Popup;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonLacivert_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.Blue;
            yazilanRenk = "Mavi";
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Popup;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonMor_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.DarkViolet;
            yazilanRenk = "Mor";
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Popup;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void buttonPembe_Click(object sender, EventArgs e)
        {
            secilenRenk = Color.PaleVioletRed;
            yazilanRenk = "Pembe";
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Popup;
            kaydetButton.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSec.FlatStyle = FlatStyle.Standard;
        }

        private void panelCizim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSec_Click(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            sec = true;
            kare.KareSec(panelCizim, basiliMi, sec, x, y,secilenRenk);
            sec = false;
        
            buttonSec.FlatStyle = FlatStyle.Popup;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            buttonKare.FlatStyle = FlatStyle.Standard;
            buttonUcgen.FlatStyle = FlatStyle.Standard;
            buttonDaire.FlatStyle = FlatStyle.Standard;
            buttonAltigen.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;

        }

        private void buttonSilme_Click(object sender, EventArgs e)
        {
            Graphics m = panelCizim.CreateGraphics();
            m.Clear(panelCizim.BackColor);
            File.WriteAllText("sekiller.txt", string.Empty);

            buttonSec.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Popup;
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            buttonKare.FlatStyle = FlatStyle.Standard;
            buttonUcgen.FlatStyle = FlatStyle.Standard;
            buttonDaire.FlatStyle = FlatStyle.Standard;
            buttonAltigen.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Standard;
        }

        private void dosyaButton_Click(object sender, EventArgs e)
        {
            buttonSec.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            buttonKare.FlatStyle = FlatStyle.Standard;
            buttonUcgen.FlatStyle = FlatStyle.Standard;
            buttonDaire.FlatStyle = FlatStyle.Standard;
            buttonAltigen.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Popup;
            kaydetButton.FlatStyle = FlatStyle.Standard;

            Kare kare = new Kare();
            Ucgen ucgen = new Ucgen();
            Altigen altigen = new Altigen();
            Daire daire = new Daire();
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Metin dosyasi| *.txt";
            Graphics g = panelCizim.CreateGraphics();
            g.Clear(panelCizim.BackColor);
            if (file.ShowDialog() == DialogResult.OK)
            {
                File.Delete("sekiller.txt");
                File.Copy(file.FileName, "sekiller.txt");
                kare.KareOku(panelCizim);
                ucgen.UcgenOku(panelCizim);
                altigen.AltigenOku(panelCizim);
                daire.DaireOku(panelCizim);
               
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            buttonSec.FlatStyle = FlatStyle.Standard;
            buttonSilme.FlatStyle = FlatStyle.Standard;
            buttonSiyah.FlatStyle = FlatStyle.Standard;
            buttonMavi.FlatStyle = FlatStyle.Standard;
            buttonKirmizi.FlatStyle = FlatStyle.Standard;
            buttonTuruncu.FlatStyle = FlatStyle.Standard;
            buttonSari.FlatStyle = FlatStyle.Standard;
            buttonYesil.FlatStyle = FlatStyle.Standard;
            buttonLacivert.FlatStyle = FlatStyle.Standard;
            buttonMor.FlatStyle = FlatStyle.Standard;
            buttonPembe.FlatStyle = FlatStyle.Standard;
            buttonKare.FlatStyle = FlatStyle.Standard;
            buttonUcgen.FlatStyle = FlatStyle.Standard;
            buttonDaire.FlatStyle = FlatStyle.Standard;
            buttonAltigen.FlatStyle = FlatStyle.Standard;
            dosyaButton.FlatStyle = FlatStyle.Standard;
            kaydetButton.FlatStyle = FlatStyle.Popup;

            if (saveFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                StreamReader dosyaOku = new StreamReader("Sekiller.txt");
                string bilgi = dosyaOku.ReadToEnd();
                File.WriteAllText(saveFileDialog1.FileName, bilgi);
                dosyaOku.Close();
            }
        }
    }
}
