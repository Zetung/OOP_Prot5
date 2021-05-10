using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace OOP_Prot5
{
    interface IFigure
    {
        int X1 { get; set; }
        int Y1 { get; set; }
        int X2 { get; set; }
        int Y2 { get; set; }
        void Init(Graphics pole, int tolsh, Color cvet, Color Nasled);
        void Draw();
    };
    public partial class Form1 : Form
    {
        private Graphics g;
        private int windowTop;
        private int windowLeft;
        private IFigure num1;
        private bool DrawPermission = false;
        public delegate void DrawDelegate();
        public event DrawDelegate ToDraw;

        private Assembly assembly = Assembly.GetExecutingAssembly();


        public Form1()
        {
            InitializeComponent();

            g = pictureBox1.CreateGraphics();

            ColorBox.SelectedIndex = 0;
            TolshinaBox.SelectedIndex = 0;
            ColorFillBox.SelectedIndex = 0;
            FigureBox.SelectedIndex = 0;
            
        }

        //e62020 red
        //2320e6 blue
        //41e620 SALATOVAYA SYLA
        private Color ChooseColor(System.Windows.Forms.ComboBox ColorBox)
        {
            ColorBox.Items[0] = "#e62020";
            ColorBox.Items[1] = "#2320e6";
            ColorBox.Items[2] = "#41e620";

            Color temp;
            string hexValue = ColorBox.Items[ColorBox.SelectedIndex].ToString();
            temp = System.Drawing.ColorTranslator.FromHtml(hexValue);

            ColorBox.Items[0] = "Red";
            ColorBox.Items[1] = "Blue";
            ColorBox.Items[2] = "SALATOVAYA SYLA";
            return temp;
        }

        private string ChooseFigure(int num)
        {
            string[] arr = {"palochka","Pryamougolnik"};
            return arr[num];
        }
        private void Click_Button(object sender, EventArgs e)
        {
            //int t = TolshinaBox.SelectedIndex*5 + 1;
            Pryamougolnik num2 = new Pryamougolnik();
            num2.Init(g, TolshinaBox.SelectedIndex * 5 + 1, ChooseColor(ColorBox), Color.Black);
            num2.X1 = 100;
            num2.Y1 = 100;
            num2.X2 = 200;
            num2.Y2 = 200;
            num2.Draw();
            label1.Text = ChooseFigure(FigureBox.SelectedIndex);
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            windowTop = Top + 44;
            windowLeft = Left + 21;
            //num1 = new palochka();
            string temp = ChooseFigure(FigureBox.SelectedIndex);
            Type type = assembly.GetType(temp);
            num1 = Activator.CreateInstance(type) as IFigure;
            num1.Init(g, TolshinaBox.SelectedIndex * 5 + 1, ChooseColor(ColorBox), ChooseColor(ColorFillBox));
            num1.X1 = MousePosition.X - windowLeft;
            num1.Y1 = MousePosition.Y - windowTop;
            label1.Text = num1.X1.ToString()+ " " + num1.Y1.ToString();

            DrawPermission = false;
        }


        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            
            if (MouseButtons == MouseButtons.Left && DrawPermission)
            {

                g.Clear(System.Drawing.SystemColors.Control);
                windowTop = Top + 44;
                windowLeft = Left + 21;
                num1.X2 = MousePosition.X - windowLeft;
                num1.Y2 = MousePosition.Y - windowTop;
                ToDraw?.Invoke();
                num1.Draw();
                label1.Text = num1.X2.ToString() + " " + num1.Y2.ToString();
            }
            else DrawPermission = true;
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            ToDraw += num1.Draw;
            DrawPermission = false;
        }

        
    }
}
