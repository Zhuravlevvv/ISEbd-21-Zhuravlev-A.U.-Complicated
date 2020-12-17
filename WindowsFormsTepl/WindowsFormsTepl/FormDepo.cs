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
        private void buttonAddTrain_Click(object sender, EventArgs e)
        {
            var formTeplonfig = new FormTeplConfig();
            formTeplonfig.AddEvent(AddTrain);
            formTeplonfig.Show();
        }
        private void AddTrain(Train train)
        {
            if (train != null && listBoxDepo.SelectedIndex > -1)
            {
                if ((depoCollection[listBoxDepo.SelectedItem.ToString()]) + train)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Поезд не удалось поставить");
                }
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

        private void одноДепоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (listBoxDepo.SelectedIndex > -1)
                {
                    if (depoCollection.SaveData(saveFileDialog.FileName, listBoxDepo.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Сохранение прошло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не сохранилось", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void всеДепоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (depoCollection.SaveData(saveFileDialog.FileName))
                    {
                        MessageBox.Show("Сохранение прошло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не сохранилось", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void всеДепоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (depoCollection.LoadDepoCollection(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void одноДепоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (depoCollection.LoadDepo(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    }
}
