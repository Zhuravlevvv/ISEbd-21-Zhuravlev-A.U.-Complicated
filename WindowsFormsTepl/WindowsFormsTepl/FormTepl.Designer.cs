namespace WindowsFormsTepl
{
    partial class FormTepl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTepl));
            this.pictureBoxTep = new System.Windows.Forms.PictureBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelForms = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonCreateLoc = new System.Windows.Forms.Button();
            this.buttonCreateTep = new System.Windows.Forms.Button();
            this.buttonThirdForm = new System.Windows.Forms.Button();
            this.comboBoxTrumpetCount = new System.Windows.Forms.ComboBox();
            this.buttonSecondForm = new System.Windows.Forms.Button();
            this.buttonFirstForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTep)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTep
            // 
            this.pictureBoxTep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTep.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTep.Name = "pictureBoxTep";
            this.pictureBoxTep.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxTep.TabIndex = 0;
            this.pictureBoxTep.TabStop = false;
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRight.Location = new System.Drawing.Point(758, 408);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDown.Location = new System.Drawing.Point(722, 408);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeft.Location = new System.Drawing.Point(686, 408);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUp.Location = new System.Drawing.Point(722, 372);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelForms);
            this.groupBox1.Controls.Add(this.labelCount);
            this.groupBox1.Controls.Add(this.buttonCreateLoc);
            this.groupBox1.Controls.Add(this.buttonCreateTep);
            this.groupBox1.Controls.Add(this.buttonThirdForm);
            this.groupBox1.Controls.Add(this.comboBoxTrumpetCount);
            this.groupBox1.Controls.Add(this.buttonSecondForm);
            this.groupBox1.Controls.Add(this.buttonFirstForm);
            this.groupBox1.Location = new System.Drawing.Point(600, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 98);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать";
            // 
            // labelForms
            // 
            this.labelForms.AutoSize = true;
            this.labelForms.Location = new System.Drawing.Point(6, 80);
            this.labelForms.Name = "labelForms";
            this.labelForms.Size = new System.Drawing.Size(69, 13);
            this.labelForms.TabIndex = 13;
            this.labelForms.Text = "Форма труб";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(6, 49);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(66, 13);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = "Кол-во труб";
            // 
            // buttonCreateLoc
            // 
            this.buttonCreateLoc.Location = new System.Drawing.Point(6, 19);
            this.buttonCreateLoc.Name = "buttonCreateLoc";
            this.buttonCreateLoc.Size = new System.Drawing.Size(80, 21);
            this.buttonCreateLoc.TabIndex = 8;
            this.buttonCreateLoc.Text = "Локомотив";
            this.buttonCreateLoc.UseVisualStyleBackColor = true;
            this.buttonCreateLoc.Click += new System.EventHandler(this.buttonCreateLoc_Click);
            // 
            // buttonCreateTep
            // 
            this.buttonCreateTep.Location = new System.Drawing.Point(91, 19);
            this.buttonCreateTep.Name = "buttonCreateTep";
            this.buttonCreateTep.Size = new System.Drawing.Size(76, 21);
            this.buttonCreateTep.TabIndex = 7;
            this.buttonCreateTep.Text = "Тепловоз";
            this.buttonCreateTep.UseVisualStyleBackColor = true;
            this.buttonCreateTep.Click += new System.EventHandler(this.buttonCreateTep_Click);
            // 
            // buttonThirdForm
            // 
            this.buttonThirdForm.Location = new System.Drawing.Point(161, 73);
            this.buttonThirdForm.Name = "buttonThirdForm";
            this.buttonThirdForm.Size = new System.Drawing.Size(35, 20);
            this.buttonThirdForm.TabIndex = 11;
            this.buttonThirdForm.Text = "3Ф";
            this.buttonThirdForm.UseVisualStyleBackColor = true;
            this.buttonThirdForm.Click += new System.EventHandler(this.buttonTrumpetsForm_Click);
            // 
            // comboBoxTrumpetCount
            // 
            this.comboBoxTrumpetCount.FormattingEnabled = true;
            this.comboBoxTrumpetCount.Location = new System.Drawing.Point(78, 46);
            this.comboBoxTrumpetCount.Name = "comboBoxTrumpetCount";
            this.comboBoxTrumpetCount.Size = new System.Drawing.Size(46, 21);
            this.comboBoxTrumpetCount.TabIndex = 6;
            // 
            // buttonSecondForm
            // 
            this.buttonSecondForm.Location = new System.Drawing.Point(118, 73);
            this.buttonSecondForm.Name = "buttonSecondForm";
            this.buttonSecondForm.Size = new System.Drawing.Size(37, 20);
            this.buttonSecondForm.TabIndex = 10;
            this.buttonSecondForm.Text = "2Ф";
            this.buttonSecondForm.UseVisualStyleBackColor = true;
            this.buttonSecondForm.Click += new System.EventHandler(this.buttonTrumpetsForm_Click);
            // 
            // buttonFirstForm
            // 
            this.buttonFirstForm.Location = new System.Drawing.Point(78, 73);
            this.buttonFirstForm.Name = "buttonFirstForm";
            this.buttonFirstForm.Size = new System.Drawing.Size(34, 20);
            this.buttonFirstForm.TabIndex = 9;
            this.buttonFirstForm.Text = "1Ф";
            this.buttonFirstForm.UseVisualStyleBackColor = true;
            this.buttonFirstForm.Click += new System.EventHandler(this.buttonTrumpetsForm_Click);
            // 
            // FormTepl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.pictureBoxTep);
            this.Name = "FormTepl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тепловоз";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTep;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelForms;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonCreateLoc;
        private System.Windows.Forms.Button buttonCreateTep;
        private System.Windows.Forms.Button buttonThirdForm;
        private System.Windows.Forms.ComboBox comboBoxTrumpetCount;
        private System.Windows.Forms.Button buttonSecondForm;
        private System.Windows.Forms.Button buttonFirstForm;
    }
}

