using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTepl
{
    public class Depo<T, U> where T : class, ITrain where U : class, IDopElements
    {
        public readonly T[] _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;

        private const int _placeSizeWidth = 210;
        private const int _placeSizeHeight = 80;
        public Depo(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i] = null;
            }
        }
        public static bool operator +(Depo<T, U> p, T teplovoz)
        {
            for (int i = 0; i < p._places.Length - 3; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = teplovoz;
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, p.pictureWidth,
                    p.pictureHeight);
                    return true;
                }
            }
            return false;
        }

        public static bool operator >(Depo<T, U> d, int ind)
        {
            return d.CompareHelper() > ind;
        }

        public static bool operator <(Depo<T, U> d, int ind)
        {
            return d.CompareHelper() < ind;
        }
        private int CompareHelper()
        {
            int cnt = 0;
            for (int i = 0; i < _places.Length; ++i)
            {
                if (_places[i] != null)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        public static T operator -(Depo<T, U> p, int index)
        {
            if (index >= 0 && index < p._places.Length)
            {
                T locomotive = p._places[index];
                p._places[index] = null;
                return locomotive;
            }
            return null;
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                {
                    _places[i]?.DrawTep(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_places.Length / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _places.Length / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
    }
}
