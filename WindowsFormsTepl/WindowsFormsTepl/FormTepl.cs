using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTepl
{
    public partial class FormTepl : Form
    {
        private ITrain tep;
        public FormTepl()
        {
            InitializeComponent();
            comboBoxTrumpetCount.Items.AddRange(new string[] { "1", "2", "3" });
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTep.Width, pictureBoxTep.Height);
            Graphics gr = Graphics.FromImage(bmp);
            tep.DrawTep(gr);
            pictureBoxTep.Image = bmp;
        }

        private void buttonCreateTep_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(120);

            tep = new Teplovoz(rnd.Next(70, 300), rnd.Next(1000, 2000), Color.ForestGreen,
            Color.Yellow, Color.Gray, Convert.ToInt32(comboBoxTrumpetCount.SelectedIndex + 1), FormOfTrumpet(), true, true);
            tep.SetPosition(rnd.Next(40, 600), rnd.Next(10, 100), pictureBoxTep.Width,
            pictureBoxTep.Height);

            buttonSecondForm.Enabled = true;
            buttonFirstForm.Enabled = true;
            buttonThirdForm.Enabled = true;

            Draw();
        }
        private void buttonCreateLoc_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(120);

            tep = new Locomotive(rnd.Next(70, 300), rnd.Next(1000, 2000), Color.Green);
            tep.SetPosition(rnd.Next(40, 600), rnd.Next(10, 100), pictureBoxTep.Width,
           pictureBoxTep.Height);

            Draw();
        }
        private void buttonTrumpetsForm_Click(object sender, EventArgs e)
        {
            if (sender == buttonFirstForm)
            {
                buttonSecondForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else if (sender == buttonSecondForm)
            {
                buttonFirstForm.Enabled = false;
                buttonThirdForm.Enabled = false;
            }
            else
            {
                buttonFirstForm.Enabled = false;
                buttonSecondForm.Enabled = false;
            }
        }
        private int FormOfTrumpet()
        {
            if (buttonFirstForm.Enabled == true)
            {
                return 0;
            }
            else if (buttonSecondForm.Enabled == true)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    tep.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    tep.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    tep.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    tep.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
