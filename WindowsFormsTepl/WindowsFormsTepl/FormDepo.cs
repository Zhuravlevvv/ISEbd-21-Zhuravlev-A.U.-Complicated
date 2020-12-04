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
     
        private readonly DepoCollection depoCollection;
        private readonly Stack<Train> trainStack;
        public FormDepo()
        {
            InitializeComponent();
            comboBoxTrumpetCount.Items.AddRange(new string[] { "1", "2", "3" });
            depoCollection = new DepoCollection(pictureBoxDepo.Width, pictureBoxDepo.Height);
            trainStack = new Stack<Train>();
            Draw();
        }
        private void ReloadLevels()
        {
            int index = listBoxDepo.SelectedIndex;
            listBoxDepo.Items.Clear();
            for (int i = 0; i < depoCollection.Keys.Count; i++)
            {
                listBoxDepo.Items.Add(depoCollection.Keys[i]);
            }
            if (listBoxDepo.Items.Count > 0 && (index == -1 || index >=
            listBoxDepo.Items.Count))
            {
                listBoxDepo.SelectedIndex = 0;
            }
            else if (listBoxDepo.Items.Count > 0 && index > -1 && index <
            listBoxDepo.Items.Count)
            {
                listBoxDepo.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxDepo.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDepo.Width, pictureBoxDepo.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depoCollection[listBoxDepo.SelectedItem.ToString()].Draw(gr);
                pictureBoxDepo.Image = bmp;
            }                
        }
        private void buttonAddDepo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название депо", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            depoCollection.AddDepo(textBoxNewLevelName.Text);
            textBoxNewLevelName.Text = "";
            ReloadLevels();
            Draw();
        }
        private void buttonDelDepo_Click(object sender, EventArgs e)
        {
            if (listBoxDepo.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо { listBoxDepo.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    depoCollection.DelDepo(listBoxDepo.Text);
                    ReloadLevels();
                }
            }
        }
        private void buttonSetLoc_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var train = new Locomotive(100, 1000, dialog.Color);
                if (depoCollection[listBoxDepo.SelectedItem.ToString()] + train)
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
                    buttonSecondForm.Enabled = true;
                    buttonFirstForm.Enabled = true;
                    buttonThirdForm.Enabled = true;
                    var train = new Teplovoz(100, 1000, dialog.Color, dialogDop.Color, dialogDop.Color, true, true, Convert.ToInt32(comboBoxTrumpetCount.SelectedIndex + 1), FormOfTrumpet());
                    if (depoCollection[listBoxDepo.SelectedItem.ToString()] + train)
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
                var train = depoCollection[listBoxDepo.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (train != null)
                {
                    trainStack.Push(train);
                }
                maskedTextBoxPlace.Text = "";
                Draw();
            }
        }
        private void buttonCheckTrain_Click(object sender, EventArgs e)
        {
            if (trainStack.Count() > 0)
            {
                FormTepl form = new FormTepl();
                form.SetTrain(trainStack.Pop());
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Все поезда просмотрены");
            }
        }
    }
}
