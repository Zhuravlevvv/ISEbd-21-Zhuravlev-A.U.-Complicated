using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTepl
{
    class Trumpets
    {
        private Trumpetsenum _countTrumpet;
        public int CountTrumpet
        {
            set
            {
                if (value < 1)
                {
                    _countTrumpet = Trumpetsenum.one;
                }
                if (value == 2)
                {
                    _countTrumpet = Trumpetsenum.two;
                }
                if (value > 3)
                {
                    _countTrumpet = Trumpetsenum.three;
                }
                else
                {
                    _countTrumpet = (Trumpetsenum)value;
                }
            }
        }
        public void DrawTrumpet(Graphics g, int Posx, int Posy)
        {
            if (_countTrumpet == Trumpetsenum.one)
            {
                Draw1Trumpet(g, Posx, Posy);
            }
            if (_countTrumpet == Trumpetsenum.two)
            {
                Draw2Trumpet(g, Posx, Posy);
            }
            if (_countTrumpet == Trumpetsenum.three)
            {
                Draw1Trumpet(g, Posx, Posy);
                Draw2Trumpet(g, Posx, Posy);
            }

        }
        Pen pen = new Pen(Color.Black);
        public void Draw1Trumpet(Graphics g, int Posx, int Posy)
        {
            Brush m = new SolidBrush(Color.Gray); //2trub
            List<Point> tp = new List<Point>(4);
            tp.Add(new Point(Posx + 65, Posy + 8));
            tp.Add(new Point(Posx + 80, Posy + 8));
            tp.Add(new Point(Posx + 80, Posy + 20));
            tp.Add(new Point(Posx + 65, Posy + 20));
            g.FillPolygon(m, tp.ToArray<Point>());
        }
        public void Draw2Trumpet(Graphics g, int Posx, int Posy)
        {
            Brush m = new SolidBrush(Color.Gray); //1trub
            List<Point> tp = new List<Point>(4);
            tp.Add(new Point(Posx + 90, Posy + 9));
            tp.Add(new Point(Posx + 105, Posy + 9));
            tp.Add(new Point(Posx + 105, Posy + 20));
            tp.Add(new Point(Posx + 90, Posy + 20));
            g.FillPolygon(m, tp.ToArray<Point>());
            //3trub
            Brush n = new SolidBrush(Color.Gray);
            List<Point> tr = new List<Point>(4);
            tr.Add(new Point(Posx + 35, Posy + 10));
            tr.Add(new Point(Posx + 50, Posy + 10));
            tr.Add(new Point(Posx + 50, Posy + 20));
            tr.Add(new Point(Posx + 35, Posy + 20));
            g.FillPolygon(n, tr.ToArray<Point>());
        }
    }
}
