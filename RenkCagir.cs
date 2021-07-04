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
    class RenkCagir

    {
        
        public Color renkCagir(Panel panelCizim,string bilgi)
        {
            Graphics g = panelCizim.CreateGraphics();
            string[] satir;
            Color renkOku = Color.White;
                satir = bilgi.Split(' ');
                switch (satir[1])
                {
                    case "Siyah":
                        renkOku = Color.Black;
                        break;
                    case "Aqua":
                        renkOku = Color.Aqua;
                        break;
                    case "Kirmizi":
                        renkOku = Color.Red;
                        break;
                    case "Turuncu":
                        renkOku = Color.DarkOrange;
                        break;
                    case "Sari":
                        renkOku = Color.Yellow;
                        break;
                    case "Yesil":
                        renkOku = Color.Green;
                        break;
                    case "Mavi":
                        renkOku = Color.Blue;
                        break;
                    case "Mor":
                        renkOku = Color.DarkViolet;
                        break;
                    case "Pembe":
                        renkOku = Color.PaleVioletRed;
                        break;
                }
                
            
            return renkOku;
        }
    }
}
























