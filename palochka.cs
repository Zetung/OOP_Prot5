using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Prot5
{
    class palochka: IFigure
    {
        private int x1, y1, x2, y2;
        private int tolshina;
        Color CvetObvodka;
        Graphics risovka;


        // свойства
        // Первоначально в свойства я пихал проверку чзначения, на знак, но позже понял что это не нужно
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

        //конструктор
        public virtual void Init(Graphics pole, int tolsh, Color cvet, Color Nasled)
        {
            risovka = pole;
            tolshina = tolsh;
            CvetObvodka = cvet;
        }

        public virtual void Draw()
        {
            Pen myWind = new Pen(CvetObvodka, tolshina);
            PointF point1 = new PointF(x1, y1);
            PointF point2 = new PointF(x2, y2);
            risovka.DrawLine(myWind, point1, point2);
        }
    }
}
