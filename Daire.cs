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
    class Daire
    {
        RenkCagir renkCagir = new RenkCagir();
        public void DaireOku(Panel panelCizim)
        {
            Graphics g = panelCizim.CreateGraphics();
            Color renkOku = Color.White;
            StreamReader dosyaOku = new StreamReader("Sekiller.txt");
            string bilgi = dosyaOku.ReadLine();
            string[] satir;

            while (bilgi != null)
            {
                satir = bilgi.Split(' ');
                if (satir[0] == "daire")
                {
                    g.FillEllipse(new SolidBrush(renkCagir.renkCagir(panelCizim, bilgi)), Convert.ToInt32(satir[2]), Convert.ToInt32(satir[3]), Convert.ToInt32(satir[4]), Convert.ToInt32(satir[5]));

                }
                bilgi = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
        }

        public void DaireCiz(Color secilenRenk,int x, int y, int a, int b, Panel panelCizim)
        {
            Graphics g = panelCizim.CreateGraphics();
            float yaricap = Convert.ToInt64(Math.Sqrt((a) * (a) + (b) * (b)));
            g.FillEllipse(new SolidBrush(secilenRenk), x - yaricap, y - yaricap, 2 * yaricap, 2 * yaricap);
        }
    }
}
