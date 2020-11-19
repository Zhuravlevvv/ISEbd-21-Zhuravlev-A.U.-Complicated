namespace WindowsFormsTepl
{
    partial class FormDepo
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
            this.pictureBoxDepo = new System.Windows.Forms.PictureBox();
            this.groupBoxSetTep = new System.Windows.Forms.GroupBox();
            this.labelForms = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonCreateLoc = new System.Windows.Forms.Button();
            this.buttonSetTep = new System.Windows.Forms.Button();
            this.buttonThirdForm = new System.Windows.Forms.Button();
            this.comboBoxTrumpetCount = new System.Windows.Forms.ComboBox();
            this.buttonSecondForm = new System.Windows.Forms.Button();
            this.buttonFirstForm = new System.Windows.Forms.Button();
            this.groupBoxTakeTrain = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonTakeTrain = new System.Windows.Forms.Button();
            this.groupBoxCompare = new System.Windows.Forms.GroupBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.checkBoxLess = new System.Windows.Forms.CheckBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.Compare = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).BeginInit();
            this.groupBoxSetTep.SuspendLayout();
            this.groupBoxTakeTrain.SuspendLayout();
            this.groupBoxCompare.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDepo
            // 
            this.pictureBoxDepo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxDepo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDepo.Name = "pictureBoxDepo";
            this.pictureBoxDepo.Size = new System.Drawing.Size(769, 543);
            this.pictureBoxDepo.TabIndex = 0;
            this.pictureBoxDepo.TabStop = false;
            // 
            // groupBoxSetTep
            // 
            this.groupBoxSetTep.Controls.Add(this.labelForms);
            this.groupBoxSetTep.Controls.Add(this.labelCount);
            this.groupBoxSetTep.Controls.Add(this.buttonSetTep);
            this.groupBoxSetTep.Controls.Add(this.buttonThirdForm);
            this.groupBoxSetTep.Controls.Add(this.comboBoxTrumpetCount);
            this.groupBoxSetTep.Controls.Add(this.buttonSecondForm);
            this.groupBoxSetTep.Controls.Add(this.buttonFirstForm);
            this.groupBoxSetTep.Location = new System.Drawing.Point(775, 45);
            this.groupBoxSetTep.Name = "groupBoxSetTep";
            this.groupBoxSetTep.Size = new System.Drawing.Size(200, 116);
            this.groupBoxSetTep.TabIndex = 5;
            this.groupBoxSetTep.TabStop = false;
            this.groupBoxSetTep.Text = "Припарковать тепловоз";
            // 
            // labelForms
            // 
            this.labelForms.AutoSize = true;
            this.labelForms.Location = new System.Drawing.Point(6, 57);
            this.labelForms.Name = "labelForms";
            this.labelForms.Size = new System.Drawing.Size(69, 13);
            this.labelForms.TabIndex = 13;
            this.labelForms.Text = "Форма труб";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(6, 26);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 13);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = "Кол-во труб";
            // 
            // buttonCreateLoc
            // 
            this.buttonCreateLoc.Location = new System.Drawing.Point(784, 12);
            this.buttonCreateLoc.Name = "buttonCreateLoc";
            this.buttonCreateLoc.Size = new System.Drawing.Size(187, 27);
            this.buttonCreateLoc.TabIndex = 8;
            this.buttonCreateLoc.Text = "Припарковать локомотив";
            this.buttonCreateLoc.UseVisualStyleBackColor = true;
            this.buttonCreateLoc.AutoSizeChanged += new System.EventHandler(this.buttonSetLoc_Click);
            this.buttonCreateLoc.Click += new System.EventHandler(this.buttonSetLoc_Click);
            // 
            // buttonSetTep
            // 
            this.buttonSetTep.Location = new System.Drawing.Point(9, 89);
            this.buttonSetTep.Name = "buttonSetTep";
            this.buttonSetTep.Size = new System.Drawing.Size(185, 21);
            this.buttonSetTep.TabIndex = 7;
            this.buttonSetTep.Text = "Припарковать";
            this.buttonSetTep.UseVisualStyleBackColor = true;
            this.buttonSetTep.Click += new System.EventHandler(this.buttonSetTep_Click);
            // 
            // buttonThirdForm
            // 
            this.buttonThirdForm.Location = new System.Drawing.Point(161, 57);
            this.buttonThirdForm.Name = "buttonThirdForm";
            this.buttonThirdForm.Size = new System.Drawing.Size(35, 20);
            this.buttonThirdForm.TabIndex = 11;
            this.buttonThirdForm.Text = "3Ф";
            this.buttonThirdForm.UseVisualStyleBackColor = true;
            this.buttonThirdForm.AutoSizeChanged += new System.EventHandler(this.buttonTrumpetsForm_Click);
            // 
            // comboBoxTrumpetCount
            // 
            this.comboBoxTrumpetCount.FormattingEnabled = true;
            this.comboBoxTrumpetCount.Location = new System.Drawing.Point(78, 23);
            this.comboBoxTrumpetCount.Name = "comboBoxTrumpetCount";
            this.comboBoxTrumpetCount.Size = new System.Drawing.Size(65, 21);
            this.comboBoxTrumpetCount.TabIndex = 6;
            // 
            // buttonSecondForm
            // 
            this.buttonSecondForm.Location = new System.Drawing.Point(118, 57);
            this.buttonSecondForm.Name = "buttonSecondForm";
            this.buttonSecondForm.Size = new System.Drawing.Size(37, 20);
            this.buttonSecondForm.TabIndex = 10;
            this.buttonSecondForm.Text = "2Ф";
            this.buttonSecondForm.UseVisualStyleBackColor = true;
            this.buttonSecondForm.AutoSizeChanged += new System.EventHandler(this.buttonTrumpetsForm_Click);
            // 
            // buttonFirstForm
            // 
            this.buttonFirstForm.Location = new System.Drawing.Point(78, 57);
            this.buttonFirstForm.Name = "buttonFirstForm";
            this.buttonFirstForm.Size = new System.Drawing.Size(34, 20);
            this.buttonFirstForm.TabIndex = 9;
            this.buttonFirstForm.Text = "1Ф";
            this.buttonFirstForm.UseVisualStyleBackColor = true;
            this.buttonFirstForm.AutoSizeChanged += new System.EventHandler(this.buttonTrumpetsForm_Click);
            // 
            // groupBoxTakeTrain
            // 
            this.groupBoxTakeTrain.Controls.Add(this.buttonTakeTrain);
            this.groupBoxTakeTrain.Controls.Add(this.labelPlace);
            this.groupBoxTakeTrain.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeTrain.Location = new System.Drawing.Point(775, 168);
            this.groupBoxTakeTrain.Name = "groupBoxTakeTrain";
            this.groupBoxTakeTrain.Size = new System.Drawing.Size(200, 77);
            this.groupBoxTakeTrain.TabIndex = 15;
            this.groupBoxTakeTrain.TabStop = false;
            this.groupBoxTakeTrain.Text = "Забрать поезд";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(54, 19);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(130, 20);
            this.maskedTextBoxPlace.TabIndex = 0;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 22);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 13;
            this.labelPlace.Text = "Место:";
            // 
            // buttonTakeTrain
            // 
            this.buttonTakeTrain.Location = new System.Drawing.Point(9, 45);
            this.buttonTakeTrain.Name = "buttonTakeTrain";
            this.buttonTakeTrain.Size = new System.Drawing.Size(183, 23);
            this.buttonTakeTrain.TabIndex = 14;
            this.buttonTakeTrain.Text = "Забрать";
            this.buttonTakeTrain.UseVisualStyleBackColor = true;
            this.buttonTakeTrain.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // groupBoxCompare
            // 
            this.groupBoxCompare.Controls.Add(this.Compare);
            this.groupBoxCompare.Controls.Add(this.buttonCompare);
            this.groupBoxCompare.Controls.Add(this.checkBoxLess);
            this.groupBoxCompare.Controls.Add(this.checkBoxMore);
            this.groupBoxCompare.Location = new System.Drawing.Point(775, 251);
            this.groupBoxCompare.Name = "groupBoxCompare";
            this.groupBoxCompare.Size = new System.Drawing.Size(200, 72);
            this.groupBoxCompare.TabIndex = 16;
            this.groupBoxCompare.TabStop = false;
            this.groupBoxCompare.Text = "Сравнить";
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 20);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(65, 17);
            this.checkBoxMore.TabIndex = 0;
            this.checkBoxMore.Text = "Больше";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // checkBoxLess
            // 
            this.checkBoxLess.AutoSize = true;
            this.checkBoxLess.Location = new System.Drawing.Point(9, 43);
            this.checkBoxLess.Name = "checkBoxLess";
            this.checkBoxLess.Size = new System.Drawing.Size(67, 17);
            this.checkBoxLess.TabIndex = 1;
            this.checkBoxLess.Text = "Меньше";
            this.checkBoxLess.UseVisualStyleBackColor = true;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(78, 40);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(116, 26);
            this.buttonCompare.TabIndex = 15;
            this.buttonCompare.Text = "Сравнить";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.ButtonMore_Click);
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(78, 14);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(116, 20);
            this.Compare.TabIndex = 16;
            // 
            // FormDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.groupBoxCompare);
            this.Controls.Add(this.groupBoxTakeTrain);
            this.Controls.Add(this.groupBoxSetTep);
            this.Controls.Add(this.pictureBoxDepo);
            this.Controls.Add(this.buttonCreateLoc);
            this.Name = "FormDepo";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).EndInit();
            this.groupBoxSetTep.ResumeLayout(false);
            this.groupBoxSetTep.PerformLayout();
            this.groupBoxTakeTrain.ResumeLayout(false);
            this.groupBoxTakeTrain.PerformLayout();
            this.groupBoxCompare.ResumeLayout(false);
            this.groupBoxCompare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepo;
        private System.Windows.Forms.GroupBox groupBoxSetTep;
        private System.Windows.Forms.Label labelForms;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonSetTep;
        private System.Windows.Forms.Button buttonThirdForm;
        private System.Windows.Forms.ComboBox comboBoxTrumpetCount;
        private System.Windows.Forms.Button buttonSecondForm;
        private System.Windows.Forms.Button buttonFirstForm;
        private System.Windows.Forms.Button buttonCreateLoc;
        private System.Windows.Forms.GroupBox groupBoxTakeTrain;
        private System.Windows.Forms.Button buttonTakeTrain;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.GroupBox groupBoxCompare;
        private System.Windows.Forms.MaskedTextBox Compare;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.CheckBox checkBoxLess;
        private System.Windows.Forms.CheckBox checkBoxMore;
    }
}