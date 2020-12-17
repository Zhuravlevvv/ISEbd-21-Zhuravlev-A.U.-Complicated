using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsTepl
{
    public partial class FormDepo : Form
    {
        private readonly DepoCollection depoCollection;
        private readonly Stack<Train> trainStack;
        private readonly Logger logger;
        public FormDepo()
        {
            InitializeComponent();
            depoCollection = new DepoCollection(pictureBoxDepo.Width, pictureBoxDepo.Height);
            trainStack = new Stack<Train>();
            logger = LogManager.GetCurrentClassLogger();
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
                MessageBox.Show("Введите название депо", "Ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            depoCollection.AddDepo(textBoxNewLevelName.Text);
            textBoxNewLevelName.Text = "";
            ReloadLevels();
            Draw();
            logger.Info("Добавили депо " + textBoxNewLevelName.Text);
        }
        private void buttonDelDepo_Click(object sender, EventArgs e)
        {
            if (listBoxDepo.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо { listBoxDepo.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    depoCollection.DelDepo(listBoxDepo.Text);
                    logger.Info($"Удалили депо {listBoxDepo.SelectedItem.ToString()}");
                    ReloadLevels();
                }
            }
        }
        private void buttonAddTrain_Click(object sender, EventArgs e)
        {
            if (listBoxDepo.SelectedItem == null)
            {
                logger.Fatal("Депо не обнаружено.");
                MessageBox.Show("Депо не обнаружено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var formTeplonfig = new FormTeplConfig();
            formTeplonfig.AddEvent(AddTrain);
            formTeplonfig.Show();
        }
        private void AddTrain(Train train)
        {
            if (train != null && listBoxDepo.SelectedIndex > -1)
            {
                try
                {
                    if ((depoCollection[listBoxDepo.SelectedItem.ToString()]) + train)
                    {
                        logger.Info($"Поезд {train} добавлен!");
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Поезд не удалось поставить");
                    }
                }
                catch (DepoOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal(ex.Message);
                }
            }
        }
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                try
                {
                    var train = depoCollection[listBoxDepo.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (train != null)
                    {
                        trainStack.Push(train);
                    }
                    Draw();
                    logger.Info($"Забрали поезд {train} с места {maskedTextBoxPlace.Text}");
                    maskedTextBoxPlace.Text = "";
                }
                catch (DepoNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal(ex.Message);
                }
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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (listBoxDepo.SelectedIndex > -1)
                {
                    try
                    {
                        depoCollection.SaveData(saveFileDialog.FileName, listBoxDepo.SelectedItem.ToString());
                        MessageBox.Show("Сохранение прошло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении");
                        logger.Fatal(ex.Message);
                    }
                }
            }
        }

        private void всеДепоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depoCollection.LoadDepoCollection(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                    logger.Info("Загружено из файла" + openFileDialog.FileName);
                }
                catch (DepoOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error(ex.Message);
                }
                catch (FileLoadException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не загружен", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal(ex.Message);
                }
            }
        }

        private void одноДепоToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depoCollection.LoadDepo(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                catch (DepoOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error(ex.Message);
                }
                catch (FileLoadException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не загружен", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal(ex.Message);
                }
            }
        }

        private void listBoxDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info("Перешли на депо " + listBoxDepo.SelectedItem.ToString());
            Draw();
        }
    }
}
