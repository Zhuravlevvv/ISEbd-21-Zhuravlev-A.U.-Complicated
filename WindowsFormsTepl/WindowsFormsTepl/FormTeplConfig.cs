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
    public partial class FormTeplConfig : Form
    {
        Train train = null;

        public event Action<Train> eventAddTrain;

        public FormTeplConfig()
        {
            InitializeComponent();
            panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawTep()
        {
            if (train != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTepl.Width, pictureBoxTepl.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(5, 25, pictureBoxTepl.Width, pictureBoxTepl.Height);
                train.DrawTep(gr);
                pictureBoxTepl.Image = bmp;
            }
        }
        private void LabelLoc_MouseDown(object sender, MouseEventArgs e)
        {
            labelLoc.DoDragDrop(labelLoc.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void LabelTepl_MouseDown(object sender, MouseEventArgs e)
        {
            labelTepl.DoDragDrop(labelTepl.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void PanelTrain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Локомотив":
                    train = new Locomotive((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Green);
                    break;
                case "Тепловоз":
                    train = new Teplovoz((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value,
                         Color.Green, Color.Gray, checkBoxLines.Checked, checkBoxDopOrnament.Checked, checkBoxTrumpets.Checked, 0, "TrumpetsStandart");
                    break;
            }
            DrawTep();
        }
        private void PanelTrain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        public void AddEvent(Action<Train> ev)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain = new Action<Train>(ev);
            }
            else
            {
                eventAddTrain += ev;
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            train.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawTep();

        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train is Teplovoz)
            {
                (train as Teplovoz).SetDopColor((Color)(e.Data.GetData(typeof(Color))));
                DrawTep();
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);
            Close();
        }
        ///ДОБАВИЛИ В 5
        private void LabelChangeTrumpets_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TrumpetsStandart)) || e.Data.GetDataPresent(typeof(TrumpetsTriangle))
                || e.Data.GetDataPresent(typeof(TrumpetsTrapeze)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void LabelChangeTrumpets_DragDrop(object sender, DragEventArgs e)
        {
            if (train is Teplovoz t)
            {
                if (e.Data.GetData(typeof(TrumpetsStandart)) != null)
                {
                    t.SetTrumpets((TrumpetsStandart)e.Data.GetData(typeof(TrumpetsStandart)));
                }
                else if (e.Data.GetData(typeof(TrumpetsTriangle)) != null)
                {
                    t.SetTrumpets((TrumpetsTriangle)e.Data.GetData(typeof(TrumpetsTriangle)));
                }
                else if (e.Data.GetData(typeof(TrumpetsTrapeze)) != null)
                {
                    t.SetTrumpets((TrumpetsTrapeze)e.Data.GetData(typeof(TrumpetsTrapeze)));
                }
                DrawTep();
            }
        }
        private void LabelTrumpetsForm_MouseDown(object sender, MouseEventArgs e)
        {
            IDopElements trumpet = null;
            if (train is Teplovoz t)
            {
                switch (((Label)sender).Text)
                {
                    case "Стандартные":
                        trumpet = new TrumpetsStandart(t.Trumpets, t.DopColor);
                        break;
                    case "Треугольные":
                        trumpet = new TrumpetsTriangle(t.Trumpets, t.DopColor);
                        break;
                    case "Трапеция":
                        trumpet = new TrumpetsTrapeze(t.Trumpets, t.DopColor);
                        break;
                }
                if (trumpet != null)
                {
                    ((Label)sender).DoDragDrop(trumpet, DragDropEffects.Move | DragDropEffects.Copy);
                }
            }

        }
        private void LabelNumberTrumpets_MouseDown(object sender, MouseEventArgs e)
        {
            if (train is Teplovoz t)
            {
                IDopElements trumpet = null;
                int trumpetsNumber = Convert.ToInt32(((Label)sender).Text);
                switch (t.TrumpetsForm)
                {
                    case "TrumpetsStandart":
                        trumpet = new TrumpetsStandart(trumpetsNumber, t.DopColor);
                        break;
                    case "TrumpetsTriangle":
                        trumpet = new TrumpetsTriangle(trumpetsNumber, t.DopColor);
                        break;
                    case "TrumpetsTrapeze":
                        trumpet = new TrumpetsTrapeze(trumpetsNumber, t.DopColor);
                        break;
                }
                if (trumpet != null)
                {
                    ((Label)sender).DoDragDrop(trumpet, DragDropEffects.Move | DragDropEffects.Copy);
                    t.SetTrumpetsNumber(trumpetsNumber);
                }
            }
        }
    }
}
