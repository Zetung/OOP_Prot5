using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Prot5
{
    class ElipseOb : IFigure
    {
        private int x1, y1, x2, y2;
        private int thicknessVal;
        Color colorOutline, colorFull;
        Graphics pictureG;
        public int X1
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

        public int Y1
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

        public int X2
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

        public int Y2
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
        public void Init(Graphics pole, int thick, Color colO, Color colZ)
        {
            pictureG = pole;
            thicknessVal = thick;
            colorOutline = colO;
            colorFull = colZ;
        }

        public void Draw()
        {
            Pen myWind = new Pen(colorOutline, thicknessVal);
            SolidBrush myBrush = new SolidBrush(colorFull);
            int xStart, yStart;

            if (x1 <= x2) xStart = x1;
            else xStart = x2;

            if (y1 <= y2) yStart = y1;
            else yStart = y2;

            pictureG.DrawEllipse(myWind, xStart, yStart, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            pictureG.FillEllipse(myBrush, xStart, yStart, Math.Abs(x2 - x1), Math.Abs(y2 - y1));
        }
    }
}
