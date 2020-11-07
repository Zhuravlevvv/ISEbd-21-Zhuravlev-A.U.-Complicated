using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTepl
{
    class TrumpetsStandart : IDopElements
    {
        private Trumpetsenum _countTrumpet;

        public int Number { set => _countTrumpet = (Trumpetsenum)value; }

        public Color DopColor { private set; get; }

        public TrumpetsStandart(int trumpet, Color dopColor)
        {
            Number = trumpet;
            DopColor = dopColor;
        }

        public void DrawElements(Graphics g, int Posx, int Posy)
        {
            switch (_countTrumpet)
            {
                case Trumpetsenum.one:
                    Draw1Trumpet(g, Posx, Posy);
                    break;

                case Trumpetsenum.two:
                    Draw2Trumpet(g, Posx, Posy);
                    break;

                case Trumpetsenum.three:
                    Draw3Trumpet(g, Posx, Posy);
                    break;
            }

        }
        Pen pen = new Pen(Color.Black);
        private void Draw1Trumpet(Graphics g, int Posx, int Posy)
        {
            Brush m = new SolidBrush(DopColor); //2trub
            List<Point> tp = new List<Point>(4);
            tp.Add(new Point(Posx + 65, Posy + 8));
            tp.Add(new Point(Posx + 80, Posy + 8));
            tp.Add(new Point(Posx + 80, Posy + 20));
            tp.Add(new Point(Posx + 65, Posy + 20));
            g.FillPolygon(m, tp.ToArray<Point>());
        }
        private void Draw2Trumpet(Graphics g, int Posx, int Posy)
        {
            Draw1Trumpet(g, Posx, Posy);
            Brush m = new SolidBrush(DopColor); //1trub
            List<Point> tp = new List<Point>(4);
            tp.Add(new Point(Posx + 90, Posy + 8));
            tp.Add(new Point(Posx + 105, Posy + 8));
            tp.Add(new Point(Posx + 105, Posy + 20));
            tp.Add(new Point(Posx + 90, Posy + 20));
            g.FillPolygon(m, tp.ToArray<Point>());
        }
        private void Draw3Trumpet(Graphics g, int Posx, int Posy)
        {
            Draw1Trumpet(g, Posx, Posy);
            Draw2Trumpet(g, Posx, Posy);
            Brush n = new SolidBrush(DopColor);
            List<Point> tr = new List<Point>(4);
            tr.Add(new Point(Posx + 35, Posy + 8));
            tr.Add(new Point(Posx + 50, Posy + 8));
            tr.Add(new Point(Posx + 50, Posy + 20));
            tr.Add(new Point(Posx + 35, Posy + 20));
            g.FillPolygon(n, tr.ToArray<Point>());
        }
    }
}
