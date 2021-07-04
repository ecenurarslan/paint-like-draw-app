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
    class Ucgen
    {
        RenkCagir renkCagir = new RenkCagir();
        public void UcgenOku(Panel panelCizim)
        {
            Graphics g = panelCizim.CreateGraphics();
            Color renkOku = Color.White;
            StreamReader dosyaOku = new StreamReader("Sekiller.txt");
            string bilgi = dosyaOku.ReadLine();
            string[] satir;

            while (bilgi != null)
            {
                satir = bilgi.Split(' ');
                if (satir[0] == "ucgen")
                {
                    Point nokta1 = new Point(Convert.ToInt32(satir[2]), Convert.ToInt32(satir[3]));
                    Point nokta2 = new Point(Convert.ToInt32(satir[4]), Convert.ToInt32(satir[5]));
                    Point nokta3 = new Point(Convert.ToInt32(satir[6]), Convert.ToInt32(satir[7]));

                    Point[] noktalar =
                        {
                         nokta1,
                         nokta2,
                         nokta3
                        };
                    g.FillPolygon(new SolidBrush(renkCagir.renkCagir(panelCizim, bilgi)), noktalar);
                }
                bilgi = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
        }

        public void UcgenCiz(int x, int y, int a, int b, Color secilenRenk, Panel panelCizim)
        {
            Graphics g = panelCizim.CreateGraphics();
            Point nokta1 = new Point(x, y);
            Point nokta2 = new Point(x - (a), b + y);
            Point nokta3 = new Point(a + x, b + y);

            Point[] noktalar =
                {
                         nokta1,
                         nokta2,
                         nokta3
                        };

            g.FillPolygon(new SolidBrush(secilenRenk), noktalar);
        }
    }
}
