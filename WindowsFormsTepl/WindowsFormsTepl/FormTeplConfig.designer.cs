namespace WindowsFormsTepl
{
    partial class FormTeplConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTepl = new System.Windows.Forms.Panel();
            this.pictureBoxTepl = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.GroupBoxTrainType = new System.Windows.Forms.GroupBox();
            this.labelTepl = new System.Windows.Forms.Label();
            this.labelLoc = new System.Windows.Forms.Label();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxDopOrnament = new System.Windows.Forms.CheckBox();
            this.checkBoxTrumpets = new System.Windows.Forms.CheckBox();
            this.checkBoxLines = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTrumpetsTrapeze = new System.Windows.Forms.Label();
            this.labelTrumpetsTriangle = new System.Windows.Forms.Label();
            this.labelTrumpetsStandart = new System.Windows.Forms.Label();
            this.labelThreeTrumpets = new System.Windows.Forms.Label();
            this.labelTwoTrumpets = new System.Windows.Forms.Label();
            this.labelOneTrumpets = new System.Windows.Forms.Label();
            this.labelChangeTrumpets = new System.Windows.Forms.Label();
            this.panelTepl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTepl)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.GroupBoxTrainType.SuspendLayout();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTepl
            // 
            this.panelTepl.AllowDrop = true;
            this.panelTepl.Controls.Add(this.pictureBoxTepl);
            this.panelTepl.Location = new System.Drawing.Point(253, 42);
            this.panelTepl.Name = "panelTepl";
            this.panelTepl.Size = new System.Drawing.Size(268, 147);
            this.panelTepl.TabIndex = 0;
            this.panelTepl.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragDrop);
            this.panelTepl.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragEnter);
            this.panelTepl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // pictureBoxTepl
            // 
            this.pictureBoxTepl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTepl.Location = new System.Drawing.Point(12, 16);
            this.pictureBoxTepl.Name = "pictureBoxTepl";
            this.pictureBoxTepl.Size = new System.Drawing.Size(243, 118);
            this.pictureBoxTepl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTepl.TabIndex = 0;
            this.pictureBoxTepl.TabStop = false;
            this.pictureBoxTepl.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragDrop);
            this.pictureBoxTepl.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelTrain_DragEnter);
            this.pictureBoxTepl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelFuchsia);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Location = new System.Drawing.Point(558, 42);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(217, 147);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.Snow;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(161, 89);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(49, 42);
            this.panelWhite.TabIndex = 5;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(161, 43);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(49, 42);
            this.panelBlack.TabIndex = 5;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(110, 89);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(49, 42);
            this.panelGreen.TabIndex = 6;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(110, 43);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(49, 42);
            this.panelBlue.TabIndex = 4;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 17);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 23);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.labelMainColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(57, 89);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(49, 42);
            this.panelYellow.TabIndex = 7;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFuchsia.Location = new System.Drawing.Point(6, 89);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(49, 42);
            this.panelFuchsia.TabIndex = 8;
            this.panelFuchsia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(57, 43);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(49, 42);
            this.panelOrange.TabIndex = 3;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(7, 43);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(49, 42);
            this.panelRed.TabIndex = 2;
            this.panelRed.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.panelRed.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(110, 16);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 23);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.labelDopColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // GroupBoxTrainType
            // 
            this.GroupBoxTrainType.Controls.Add(this.labelTepl);
            this.GroupBoxTrainType.Controls.Add(this.labelLoc);
            this.GroupBoxTrainType.Location = new System.Drawing.Point(49, 42);
            this.GroupBoxTrainType.Name = "GroupBoxTrainType";
            this.GroupBoxTrainType.Size = new System.Drawing.Size(153, 131);
            this.GroupBoxTrainType.TabIndex = 0;
            this.GroupBoxTrainType.TabStop = false;
            this.GroupBoxTrainType.Text = "Тип поезда";
            // 
            // labelTepl
            // 
            this.labelTepl.AllowDrop = true;
            this.labelTepl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTepl.Location = new System.Drawing.Point(23, 71);
            this.labelTepl.Name = "labelTepl";
            this.labelTepl.Size = new System.Drawing.Size(106, 34);
            this.labelTepl.TabIndex = 4;
            this.labelTepl.Text = "Тепловоз";
            this.labelTepl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTepl_MouseDown);
            // 
            // labelLoc
            // 
            this.labelLoc.AllowDrop = true;
            this.labelLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoc.Location = new System.Drawing.Point(23, 26);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(106, 34);
            this.labelLoc.TabIndex = 3;
            this.labelLoc.Text = "Локомотив";
            this.labelLoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelLoc_MouseDown);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxDopOrnament);
            this.groupBoxParams.Controls.Add(this.checkBoxTrumpets);
            this.groupBoxParams.Controls.Add(this.checkBoxLines);
            this.groupBoxParams.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParams.Controls.Add(this.labelWeight);
            this.groupBoxParams.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParams.Location = new System.Drawing.Point(49, 214);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(263, 130);
            this.groupBoxParams.TabIndex = 5;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxDopOrnament
            // 
            this.checkBoxDopOrnament.AutoSize = true;
            this.checkBoxDopOrnament.Location = new System.Drawing.Point(155, 87);
            this.checkBoxDopOrnament.Name = "checkBoxDopOrnament";
            this.checkBoxDopOrnament.Size = new System.Drawing.Size(58, 17);
            this.checkBoxDopOrnament.TabIndex = 8;
            this.checkBoxDopOrnament.Text = "Трубы";
            this.checkBoxDopOrnament.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrumpets
            // 
            this.checkBoxTrumpets.AutoSize = true;
            this.checkBoxTrumpets.Location = new System.Drawing.Point(155, 64);
            this.checkBoxTrumpets.Name = "checkBoxTrumpets";
            this.checkBoxTrumpets.Size = new System.Drawing.Size(59, 17);
            this.checkBoxTrumpets.TabIndex = 7;
            this.checkBoxTrumpets.Text = "Диски";
            this.checkBoxTrumpets.UseVisualStyleBackColor = true;
            // 
            // checkBoxLines
            // 
            this.checkBoxLines.AutoSize = true;
            this.checkBoxLines.Location = new System.Drawing.Point(155, 41);
            this.checkBoxLines.Name = "checkBoxLines";
            this.checkBoxLines.Size = new System.Drawing.Size(103, 17);
            this.checkBoxLines.TabIndex = 6;
            this.checkBoxLines.Text = "Крыша + линии";
            this.checkBoxLines.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(23, 78);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 5;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(23, 41);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 4;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(20, 62);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(65, 13);
            this.labelWeight.TabIndex = 3;
            this.labelWeight.Text = "Вес поезда";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(20, 25);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(87, 13);
            this.labelMaxSpeed.TabIndex = 2;
            this.labelMaxSpeed.Text = "Макс. скорость";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(673, 289);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(673, 321);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTrumpetsTrapeze);
            this.groupBox1.Controls.Add(this.labelTrumpetsTriangle);
            this.groupBox1.Controls.Add(this.labelTrumpetsStandart);
            this.groupBox1.Controls.Add(this.labelThreeTrumpets);
            this.groupBox1.Controls.Add(this.labelTwoTrumpets);
            this.groupBox1.Controls.Add(this.labelOneTrumpets);
            this.groupBox1.Controls.Add(this.labelChangeTrumpets);
            this.groupBox1.Location = new System.Drawing.Point(321, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Трубы";
            // 
            // labelTrumpetsTrapeze
            // 
            this.labelTrumpetsTrapeze.AllowDrop = true;
            this.labelTrumpetsTrapeze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrumpetsTrapeze.Location = new System.Drawing.Point(87, 104);
            this.labelTrumpetsTrapeze.Name = "labelTrumpetsTrapeze";
            this.labelTrumpetsTrapeze.Size = new System.Drawing.Size(120, 23);
            this.labelTrumpetsTrapeze.TabIndex = 15;
            this.labelTrumpetsTrapeze.Text = "Трапеция";
            this.labelTrumpetsTrapeze.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTrumpetsForm_MouseDown);
            // 
            // labelTrumpetsTriangle
            // 
            this.labelTrumpetsTriangle.AllowDrop = true;
            this.labelTrumpetsTriangle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrumpetsTriangle.Location = new System.Drawing.Point(87, 75);
            this.labelTrumpetsTriangle.Name = "labelTrumpetsTriangle";
            this.labelTrumpetsTriangle.Size = new System.Drawing.Size(120, 23);
            this.labelTrumpetsTriangle.TabIndex = 14;
            this.labelTrumpetsTriangle.Text = "Треугольные";
            this.labelTrumpetsTriangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTrumpetsForm_MouseDown);
            // 
            // labelTrumpetsStandart
            // 
            this.labelTrumpetsStandart.AllowDrop = true;
            this.labelTrumpetsStandart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrumpetsStandart.Location = new System.Drawing.Point(87, 41);
            this.labelTrumpetsStandart.Name = "labelTrumpetsStandart";
            this.labelTrumpetsStandart.Size = new System.Drawing.Size(120, 23);
            this.labelTrumpetsStandart.TabIndex = 13;
            this.labelTrumpetsStandart.Text = "Стандартные";
            this.labelTrumpetsStandart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTrumpetsForm_MouseDown);
            // 
            // labelThreeTrumpets
            // 
            this.labelThreeTrumpets.AllowDrop = true;
            this.labelThreeTrumpets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelThreeTrumpets.Location = new System.Drawing.Point(21, 104);
            this.labelThreeTrumpets.Name = "labelThreeTrumpets";
            this.labelThreeTrumpets.Size = new System.Drawing.Size(34, 23);
            this.labelThreeTrumpets.TabIndex = 12;
            this.labelThreeTrumpets.Text = "3";
            this.labelThreeTrumpets.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelNumberTrumpets_MouseDown);
            // 
            // labelTwoTrumpets
            // 
            this.labelTwoTrumpets.AllowDrop = true;
            this.labelTwoTrumpets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTwoTrumpets.Location = new System.Drawing.Point(21, 75);
            this.labelTwoTrumpets.Name = "labelTwoTrumpets";
            this.labelTwoTrumpets.Size = new System.Drawing.Size(34, 23);
            this.labelTwoTrumpets.TabIndex = 11;
            this.labelTwoTrumpets.Text = "2";
            this.labelTwoTrumpets.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelNumberTrumpets_MouseDown);
            // 
            // labelOneTrumpets
            // 
            this.labelOneTrumpets.AllowDrop = true;
            this.labelOneTrumpets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOneTrumpets.Location = new System.Drawing.Point(21, 41);
            this.labelOneTrumpets.Name = "labelOneTrumpets";
            this.labelOneTrumpets.Size = new System.Drawing.Size(34, 23);
            this.labelOneTrumpets.TabIndex = 10;
            this.labelOneTrumpets.Text = "1";
            this.labelOneTrumpets.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelNumberTrumpets_MouseDown);
            // 
            // labelChangeTrumpets
            // 
            this.labelChangeTrumpets.AllowDrop = true;
            this.labelChangeTrumpets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChangeTrumpets.Location = new System.Drawing.Point(87, 15);
            this.labelChangeTrumpets.Name = "labelChangeTrumpets";
            this.labelChangeTrumpets.Size = new System.Drawing.Size(100, 23);
            this.labelChangeTrumpets.TabIndex = 9;
            this.labelChangeTrumpets.Text = "Изменить трубы";
            this.labelChangeTrumpets.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelChangeTrumpets_DragDrop);
            this.labelChangeTrumpets.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelChangeTrumpets_DragEnter);
            // 
            // FormTeplConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.GroupBoxTrainType);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelTepl);
            this.Name = "FormTeplConfig";
            this.Text = "Конфигурация";
            this.panelTepl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTepl)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.GroupBoxTrainType.ResumeLayout(false);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTepl;
        private System.Windows.Forms.PictureBox pictureBoxTepl;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.GroupBox GroupBoxTrainType;
        private System.Windows.Forms.Label labelTepl;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.CheckBox checkBoxTrumpets;
        private System.Windows.Forms.CheckBox checkBoxLines;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxDopOrnament;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelChangeTrumpets;
        private System.Windows.Forms.Label labelTrumpetsTrapeze;
        private System.Windows.Forms.Label labelTrumpetsTriangle;
        private System.Windows.Forms.Label labelTrumpetsStandart;
        private System.Windows.Forms.Label labelThreeTrumpets;
        private System.Windows.Forms.Label labelTwoTrumpets;
        private System.Windows.Forms.Label labelOneTrumpets;
    }
}