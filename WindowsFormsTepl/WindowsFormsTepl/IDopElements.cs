using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsTepl
{
    public interface IDopElements
    {
        int Number { set; }
        void DrawElements(Graphics g, int Posx, int Posy);
    }
}
