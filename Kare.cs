using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projePaint
{
    class Kare

    {
        RenkCagir renkCagir = new RenkCagir();

        public void KareSec(Panel panelcizim, bool ciz, bool sec, int x, int y,Color secilenrenk)
        { Graphics g = panelcizim.CreateGraphics();
            string satir;
        string[] oku;

            if (ciz == true && sec == true && secilenrenk != Color.White)
            {
                StreamReader dosyaOku = new StreamReader("sekiller.txt");
                while ((satir = dosyaOku.ReadLine()) != null)
                {
                    oku = satir.Split(' ');
                    if (oku[0] == "kare")
                    {
                        g.FillRectangle(new SolidBrush(renkCagir.renkCagir(panelcizim,satir)), Convert.ToInt32(oku[2]), Convert.ToInt32(oku[3]), Convert.ToInt32(oku[4]), Convert.ToInt32(oku[5]));
                        if (x > Convert.ToInt32(oku[2]) && x<(Convert.ToInt32(oku[4]) + Convert.ToInt32(oku[2])) && y > Convert.ToInt32(oku[3]) && y<(Convert.ToInt32(oku[5]) + Convert.ToInt32(oku[3])))
                        {
                            g.DrawRectangle(new Pen(Color.SkyBlue, 7), Convert.ToInt32(oku[2]), Convert.ToInt32(oku[3]), Convert.ToInt32(oku[4]), Convert.ToInt32(oku[5]));
                        }
}
                }
                dosyaOku.Close();
            }}
        
        public void KareOku( Panel panelCizim)
        {

            Graphics g = panelCizim.CreateGraphics();
            Color renkOku = Color.White;
            StreamReader dosyaOku = new StreamReader("Sekiller.txt");
            string bilgi = dosyaOku.ReadLine();
            string[] satir;
         
            while (bilgi != null)
            {
                satir = bilgi.Split(' ');
                if (satir[0] == "kare")
                {
                    Point nokta1 = new Point(Convert.ToInt32(satir[2]), Convert.ToInt32(satir[3]));
                    Point nokta2 = new Point(Convert.ToInt32(satir[4]), Convert.ToInt32(satir[5]));
                    Point nokta3 = new Point(Convert.ToInt32(satir[6]), Convert.ToInt32(satir[7]));
                    Point nokta4 = new Point(Convert.ToInt32(satir[8]), Convert.ToInt32(satir[9]));

                    Point[] noktalar =
                        {
                         nokta1,
                         nokta2,
                         nokta4,
                         nokta3
                        };
                    g.FillPolygon(new SolidBrush(renkCagir.renkCagir(panelCizim, bilgi)), noktalar);
                }
                bilgi = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
        }

        public void KareCiz(int x, int a, int y, int b, Panel panelCizim, Color secilenRenk)
        {
            Graphics g = panelCizim.CreateGraphics();
            Point nokta1 = new Point(x - a, y - b);
            Point nokta2 = new Point(x + a, y - b);
            Point nokta3 = new Point(x - a, y + b);
            Point nokta4 = new Point(x + a, y + b);

            Point[] noktalar =
                {
                         nokta1,
                         nokta2,
                         nokta4,
                         nokta3
                        };
            g.FillPolygon(new SolidBrush(secilenRenk), noktalar);
        }
    }
}
