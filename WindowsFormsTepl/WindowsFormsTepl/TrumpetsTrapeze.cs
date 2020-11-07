﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTepl
{
    class TrumpetsTrapeze : IDopElements
    {
        private Trumpetsenum _countTrumpet;

        public int Number { set => _countTrumpet = (Trumpetsenum)value; }

        public Color DopColor { private set; get; }

        public TrumpetsTrapeze(int trumpet, Color dopColor)
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
            Brush brDopColor = new SolidBrush(DopColor);

            PointF[] cannon1Points = { new PointF(Posx + 30, Posy + 13), new PointF(Posx + 35, Posy + 6),
                                           new PointF(Posx + 45, Posy + 6), new PointF(Posx + 50, Posy + 13) };
            g.FillPolygon(brDopColor, cannon1Points);
        }
        private void Draw2Trumpet(Graphics g, int Posx, int Posy)
        {
            Brush brDopColor = new SolidBrush(DopColor);
            Draw1Trumpet(g, Posx, Posy);
            PointF[] cannon1Points = { new PointF(Posx + 55, Posy + 13), new PointF(Posx + 60, Posy + 6),
                                           new PointF(Posx + 70, Posy + 6), new PointF(Posx + 75, Posy + 13) };
            g.FillPolygon(brDopColor, cannon1Points);
        }
        private void Draw3Trumpet(Graphics g, int Posx, int Posy)
        {
            Brush brDopColor = new SolidBrush(DopColor);
            Draw1Trumpet(g, Posx, Posy);
            Draw2Trumpet(g, Posx, Posy);
            PointF[] cannon1Points = { new PointF(Posx + 80, Posy + 13), new PointF(Posx + 85, Posy + 6),
                                           new PointF(Posx + 95, Posy + 6), new PointF(Posx + 100, Posy + 13) };
            g.FillPolygon(brDopColor, cannon1Points);
        }
    }
}

