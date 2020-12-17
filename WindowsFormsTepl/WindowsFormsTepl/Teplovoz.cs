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
        private IDopElements trumpet;
        public Color DopColor { private set; get; }
        public bool Tube { private set; get; }
        public bool Line { private set; get; }
        public bool DopOrnament { protected set; get; }
        public int Trumpets { private set; get; }
        public string TrumpetsForm { private set; get; }
        public void SetDopColor(Color color)
        {
            DopColor = color;
            SetTrampet();
        }
        public void SetTrumpets(IDopElements trumpets)
        {
            trumpet = trumpets;
            TrumpetsForm = trumpet.GetType().Name;
        }

        public void SetTrumpetsNumber(int trumpetNumber)
        {
            Trumpets = trumpetNumber;
        }

        public void SetTrampet()
        {
            if (TrumpetsForm == "TrumpetsStandart")
            {
                trumpet = new TrumpetsStandart(Trumpets, DopColor);
            }
            else if (TrumpetsForm == "TrumpetsTriangle")
            {
                trumpet = new TrumpetsTriangle(Trumpets, DopColor);
            }
            else if (TrumpetsForm == "TrumpetsTrapeze")
            {
                trumpet = new TrumpetsTrapeze(Trumpets, DopColor);
            }
        }
        public Teplovoz(int maxSpeed, float weight, Color mainColor, Color dopColor, bool line, bool tube, bool dopOrnament,
         int trumpets, string trumpetsForm)
        : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Line = line;
            Tube = tube;
            DopOrnament = dopOrnament;
            Trumpets = trumpets;
            TrumpetsForm = trumpetsForm;
            SetTrampet();
        }
        public Teplovoz(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 9)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Line = Convert.ToBoolean(strs[4]);
                Tube = Convert.ToBoolean(strs[5]);
                DopOrnament = Convert.ToBoolean(strs[6]);
                Trumpets = Convert.ToInt32(strs[7]);
                TrumpetsForm = strs[8];
                SetTrampet();
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}" +
                   $"{separator}{Line}{separator}{Tube}" +
                   $"{separator}{DopOrnament}" +
                   $"{separator}{Trumpets}" +
                   $"{separator}{TrumpetsForm}";
        }

        public override void DrawTep(Graphics g) //отрисовка
        {
            if (trumpet != null)
            {
                trumpet.DrawElements(g, Posx, Posy);
            }
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

            if (DopOrnament)
            {
                Brush btBlack = new SolidBrush(DopColor); //kolesa 2
                g.FillEllipse(btBlack, Posx + 22, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 34, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 46, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 87, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 98, Posy + 52, 2, 4);
                g.FillEllipse(btBlack, Posx + 111, Posy + 52, 2, 4);
            }
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
                Brush w = new SolidBrush(DopColor);
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
        }
    }
}


