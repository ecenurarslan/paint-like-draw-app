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
    class Altigen
    {
        RenkCagir renkCagir = new RenkCagir();
        public void AltigenOku(Panel panelCizim)
        {
            Graphics g = panelCizim.CreateGraphics();
            Color renkOku = Color.White;
            StreamReader dosyaOku = new StreamReader("Sekiller.txt");
            string bilgi = dosyaOku.ReadLine();
            string[] satir;

            while (bilgi != null)
            {
                satir = bilgi.Split(' ');
                if (satir[0] == "altigen")
                {
                    Point nokta1 = new Point(Convert.ToInt32(satir[2]), Convert.ToInt32(satir[3]));
                    Point nokta2 = new Point(Convert.ToInt32(satir[4]), Convert.ToInt32(satir[5]));
                    Point nokta3 = new Point(Convert.ToInt32(satir[6]), Convert.ToInt32(satir[7]));
                    Point nokta4 = new Point(Convert.ToInt32(satir[8]), Convert.ToInt32(satir[9]));
                    Point nokta5 = new Point(Convert.ToInt32(satir[10]), Convert.ToInt32(satir[11]));
                    Point nokta6 = new Point(Convert.ToInt32(satir[12]), Convert.ToInt32(satir[13]));

                    Point[] noktalar =
                        {
                         nokta1,
                         nokta2,
                         nokta3,
                         nokta4,
                         nokta5,
                         nokta6
                        };
                    g.FillPolygon(new SolidBrush(renkCagir.renkCagir(panelCizim, bilgi)), noktalar);
                }
                bilgi = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
        }

        public void AltigenCiz(Panel panelCizim , int x, int y, int a, int b, Color secilenRenk)
        {
            Graphics g = panelCizim.CreateGraphics();
            Point nokta1 = new Point(x, y);
            Point nokta2 = new Point((a + x), y);
            Point nokta3 = new Point((a+x) + ((a) / 2), y + ((b) / 2));
            Point nokta4 = new Point(a+x, b+y);
            Point nokta5 = new Point(x, b+y);
            Point nokta6 = new Point(x - ((a) / 2), y + ((b) / 2));

            Point[] noktalar =
                {
                         nokta1,
                         nokta2,
                         nokta3,
                         nokta4,
                         nokta5,
                         nokta6

                        };

            g.FillPolygon(new SolidBrush(secilenRenk), noktalar);
        }
    }
}
