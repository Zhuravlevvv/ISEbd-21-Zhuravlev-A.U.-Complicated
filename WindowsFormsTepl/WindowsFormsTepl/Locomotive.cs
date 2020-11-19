﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Collections.IEnumerable;

namespace WindowsFormsTepl
{
    public class Locomotive : Train
    {
        protected readonly int trainWidth = 120;
        protected readonly int trainHeight = 80;

        public Locomotive(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        //Конструктор с изменением размеров самолета
        protected Locomotive(int maxSpeed, float weight, Color mainColor, int trainWidth, int trainHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.trainWidth = trainWidth;
            this.trainHeight = trainHeight;
        }
        public override void MoveTransport(Direction direction) //передвижение
        {
            float step1 = MaxSpeed * 40 / Weight;
            int step = Convert.ToInt32(step1);
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (Posx + step < pctrWidth - trainWidth)
                    {
                        Posx += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (Posx - step > 0 + 1)

                    {
                        Posx -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (Posy - step > 0)
                    {
                        Posy -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (Posy + step < pctrHeight - trainHeight)
                    {
                        Posy += step;
                    }
                    break;
            }
        }
        public override void DrawTep(Graphics g) //отрисовка
        {
            Pen pen = new Pen(Color.Black);
            Brush brBlack = new SolidBrush(Color.Black); //kolesa 1
            g.FillEllipse(brBlack, Posx + 15, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 27, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 39, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 80, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 92, Posy + 44, 15, 15);
            g.FillEllipse(brBlack, Posx + 104, Posy + 44, 15, 15);

            Brush n = new SolidBrush(MainColor); //kuzov
            List<Point> l = new List<Point>(4);
            l.Add(new Point(Posx + 85, Posy + 35));
            l.Add(new Point(Posx + 85, Posy + 30));
            l.Add(new Point(Posx + 90, Posy + 20));
            l.Add(new Point(Posx + 90, Posy + 35));
            g.FillPolygon(n, l.ToArray<Point>());
            Brush b = new SolidBrush(MainColor);
            List<Point> p = new List<Point>(11);
            p.Add(new Point(Posx + 10, Posy + 19));
            p.Add(new Point(Posx + 10, Posy + 50));
            p.Add(new Point(Posx + 80, Posy + 50));
            p.Add(new Point(Posx + 120, Posy + 50));
            p.Add(new Point(Posx + 120, Posy + 20));
            p.Add(new Point(Posx + 75, Posy + 15));
            g.FillPolygon(b, p.ToArray<Point>());


            Brush m = new SolidBrush(MainColor); //linered
            List<Point> tp = new List<Point>(4);
            tp.Add(new Point(Posx + 10, Posy + 40));
            tp.Add(new Point(Posx + 10, Posy + 35));
            tp.Add(new Point(Posx + 90, Posy + 35));
            tp.Add(new Point(Posx + 90, Posy + 40));
            g.FillPolygon(m, tp.ToArray<Point>());

            Brush q = new SolidBrush(MainColor); //verx
            List<Point> tq = new List<Point>(4);
            tq.Add(new Point(Posx + 7, Posy + 21));
            tq.Add(new Point(Posx + 121, Posy + 21));
            tq.Add(new Point(Posx + 110, Posy + 14));
            tq.Add(new Point(Posx + 20, Posy + 14));
            g.FillPolygon(q, tq.ToArray<Point>());
        }
    }
}
