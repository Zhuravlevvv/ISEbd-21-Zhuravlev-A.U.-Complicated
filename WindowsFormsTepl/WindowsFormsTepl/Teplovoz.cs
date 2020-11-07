using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTepl
{
    public class Teplovoz : Locomotive
    {
        public Color DopColor { private set; get; }

        private IDopElements trumpets;

        public bool Tube { private set; get; }
        public bool Line { private set; get; }

        public Teplovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, Color trumpColor,
        int trumpet, int trumpetsForm, bool line, bool tube)
        : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Tube = tube;
            Line = line;

            if (trumpetsForm == 0)
            {
                trumpets = new TrumpetsStandart(trumpet, trumpColor);
            }
            else if (trumpetsForm == 1)
            {
                trumpets = new TrumpetsTriangle(trumpet, trumpColor);
            }
            else if (trumpetsForm == 2)
            {
                trumpets = new TrumpetsTrapeze(trumpet, trumpColor);
            }
        }

        public override void DrawTep(Graphics g) //отрисовка
        {
            base.DrawTep(g);
            Pen pen = new Pen(Color.Black);
            //колёса
            Brush brBlack = new SolidBrush(Color.Black); //kolesa 1
            g.FillEllipse(brBlack, Posx + 15, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 27, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 39, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 80, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 92, Posy + 45, 15, 15);
            g.FillEllipse(brBlack, Posx + 104, Posy + 45, 15, 15);

            Brush btBlack = new SolidBrush(DopColor); //kolesa 2
            g.FillEllipse(btBlack, Posx + 22, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 34, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 46, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 87, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 98, Posy + 52, 2, 4);
            g.FillEllipse(btBlack, Posx + 111, Posy + 52, 2, 4);

            if (Tube)
            {
                Brush n = new SolidBrush(MainColor);
                List<Point> l = new List<Point>(4);
                l.Add(new Point(Posx + 85, Posy + 35));
                l.Add(new Point(Posx + 85, Posy + 30));
                l.Add(new Point(Posx + 90, Posy + 20));
                l.Add(new Point(Posx + 90, Posy + 35));

                g.FillPolygon(n, l.ToArray<Point>());
            }

            Brush b = new SolidBrush(MainColor);
            List<Point> p = new List<Point>(11);
            p.Add(new Point(Posx + 10, Posy + 19));
            p.Add(new Point(Posx + 10, Posy + 50));
            p.Add(new Point(Posx + 80, Posy + 50));
            p.Add(new Point(Posx + 120, Posy + 50));
            p.Add(new Point(Posx + 120, Posy + 20));
            p.Add(new Point(Posx + 75, Posy + 15));

            g.FillPolygon(b, p.ToArray<Point>());

            if (Line)//1
            {
                Brush m = new SolidBrush(DopColor);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 10, Posy + 40));
                tp.Add(new Point(Posx + 10, Posy + 35));
                tp.Add(new Point(Posx + 120, Posy + 35));
                tp.Add(new Point(Posx + 120, Posy + 40));

                g.FillPolygon(m, tp.ToArray<Point>());
            }
            if (Tube)
            {
                //verx        
                Brush w = new SolidBrush(Color.Gray);
                List<Point> qw = new List<Point>(4);
                qw.Add(new Point(Posx + 3, Posy + 23));
                qw.Add(new Point(Posx + 125, Posy + 23));
                qw.Add(new Point(Posx + 110, Posy + 13));
                qw.Add(new Point(Posx + 20, Posy + 13));
                g.FillPolygon(w, qw.ToArray<Point>());
            }
            if (Line)//2
            {
                Brush m = new SolidBrush(DopColor);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 105, Posy + 22));
                tp.Add(new Point(Posx + 108, Posy + 22));
                tp.Add(new Point(Posx + 108, Posy + 48));
                tp.Add(new Point(Posx + 105, Posy + 48));

                g.FillPolygon(m, tp.ToArray<Point>());
            }

            if (Line)//3
            {
                Brush m = new SolidBrush(DopColor);
                List<Point> tp = new List<Point>(4);
                tp.Add(new Point(Posx + 90, Posy + 22));
                tp.Add(new Point(Posx + 93, Posy + 22));
                tp.Add(new Point(Posx + 93, Posy + 48));
                tp.Add(new Point(Posx + 90, Posy + 48));
                g.FillPolygon(m, tp.ToArray<Point>());
            }
            trumpets.DrawElements(g, Posx, Posy);
        }
    }
}


