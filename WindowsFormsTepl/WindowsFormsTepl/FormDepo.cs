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
    public partial class FormDepo : Form
    {
        private readonly Depo<Locomotive, TrumpetsTrapeze> depo;

        public FormDepo()
        {
            InitializeComponent();
            comboBoxTrumpetCount.Items.AddRange(new string[] { "1", "2", "3" });
            depo = new Depo<Locomotive, TrumpetsTrapeze>(pictureBoxDepo.Width,
            pictureBoxDepo.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depo.Draw(gr);
            pictureBoxDepo.Image = bmp;
        }
        private void buttonSetLoc_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var loc = new Locomotive(100, 1000, dialog.Color);
                if (depo + loc)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не припарковано!");
                }
            }
        }
        private void buttonSetTep_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var teplovoz = new Teplovoz(100, 1000, dialog.Color, dialogDop.Color, dialogDop.Color, 
                    Convert.ToInt32(comboBoxTrumpetCount.SelectedIndex + 1), FormOfTrumpet(), true, true);

                    buttonSecondForm.Enabled = true;
                    buttonFirstForm.Enabled = true;
                    buttonThirdForm.Enabled = true;
                    if (depo + teplovoz)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Не припарковано!");
                    }
                }
            }
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
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var train = depo - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (train != null)
                {
                    FormTepl form = new FormTepl();
                    form.SetTrain(train);
                    form.ShowDialog();
                }
                maskedTextBoxPlace.Text = "";
                Draw();
            }
        }
        private void ButtonMore_Click(object sender, EventArgs e)
        {
            int ind;
            if (Compare.Text != "")
            {
                ind = Convert.ToInt32(Compare.Text);
            }
            else { return; }
            if (checkBoxMore.Checked)
            {
                if (depo > ind)
                {
                    MessageBox.Show("Депо заполнено более, чем на " + ind + " мест(а)");
                }
                else
                {
                    MessageBox.Show("Депо заполнено не более, чем на " + ind + " мест(а)");
                }
            }

            else if (checkBoxLess.Checked)
            {
                if (depo < ind)
                {
                    MessageBox.Show("Депо заполнено менее, чем на " + ind + " мест(а)");
                }
                else
                {
                    MessageBox.Show("Депо заполнено не менее, чем на " + ind + " мест(а)");
                }
            }
        }
    }
}
