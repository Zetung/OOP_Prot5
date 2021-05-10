using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Prot5
{
    class Pryamougolnik : palochka
    {
        private int x1, y1, x2, y2;
        private int tolshina;
        Color CvetObvodka,CvetZapol;
        Graphics risovka;
        public new int X1
        {
            get
            {
                return x1;
            }
            set
            {
                x1 = value;
            }
        }

        public new int Y1
        {
            get
            {
                return y1;
            }
            set
            {
                y1 = value;
            }
        }

        public new int X2
        {
            get
            {
                return x2;
            }
            set
            {
                x2 = value;
            }
        }

        public new int Y2
        {
            get
            {
                return y2;
            }
            set
            {
                y2 = value;
            }
        }
        public override void Init(Graphics pole, int tolsh, Color cvetO, Color cvetZ)
        {
            risovka = pole;
            tolshina = tolsh;
            CvetObvodka = cvetO;
            CvetZapol = cvetZ;
        }

        public override void Draw()
        {
            Pen myWind = new Pen(CvetObvodka, tolshina);
            SolidBrush myBrush = new SolidBrush(CvetZapol);
            risovka.DrawRectangle(myWind, x1, y1, x2 - x1, y2 - y1);
            risovka.FillRectangle(myBrush, x1, y1, x2 - x1, y2 - y1);
        }
    }
}
