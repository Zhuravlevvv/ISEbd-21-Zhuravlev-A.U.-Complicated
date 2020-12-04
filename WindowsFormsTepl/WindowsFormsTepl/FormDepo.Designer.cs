﻿namespace WindowsFormsTepl
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
            this.groupBoxTakeTrain = new System.Windows.Forms.GroupBox();
            this.buttonCheckTrain = new System.Windows.Forms.Button();
            this.buttonTakeTrain = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxDepo = new System.Windows.Forms.GroupBox();
            this.labelDepo = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonDelDepo = new System.Windows.Forms.Button();
            this.listBoxDepo = new System.Windows.Forms.ListBox();
            this.buttonAddDepo = new System.Windows.Forms.Button();
            this.buttonAddTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).BeginInit();
            this.groupBoxTakeTrain.SuspendLayout();
            this.groupBoxDepo.SuspendLayout();
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
            // groupBoxTakeTrain
            // 
            this.groupBoxTakeTrain.Controls.Add(this.buttonCheckTrain);
            this.groupBoxTakeTrain.Controls.Add(this.buttonTakeTrain);
            this.groupBoxTakeTrain.Controls.Add(this.labelPlace);
            this.groupBoxTakeTrain.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeTrain.Location = new System.Drawing.Point(775, 151);
            this.groupBoxTakeTrain.Name = "groupBoxTakeTrain";
            this.groupBoxTakeTrain.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTakeTrain.TabIndex = 15;
            this.groupBoxTakeTrain.TabStop = false;
            this.groupBoxTakeTrain.Text = "Забрать поезд";
            // 
            // buttonCheckTrain
            // 
            this.buttonCheckTrain.Location = new System.Drawing.Point(9, 71);
            this.buttonCheckTrain.Name = "buttonCheckTrain";
            this.buttonCheckTrain.Size = new System.Drawing.Size(183, 23);
            this.buttonCheckTrain.TabIndex = 15;
            this.buttonCheckTrain.Text = "Посмотреть";
            this.buttonCheckTrain.UseVisualStyleBackColor = true;
            this.buttonCheckTrain.Click += new System.EventHandler(this.buttonCheckTrain_Click);
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
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 22);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 13;
            this.labelPlace.Text = "Место:";
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(54, 19);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(130, 20);
            this.maskedTextBoxPlace.TabIndex = 0;
            // 
            // groupBoxDepo
            // 
            this.groupBoxDepo.Controls.Add(this.labelDepo);
            this.groupBoxDepo.Controls.Add(this.textBoxNewLevelName);
            this.groupBoxDepo.Controls.Add(this.buttonDelDepo);
            this.groupBoxDepo.Controls.Add(this.listBoxDepo);
            this.groupBoxDepo.Controls.Add(this.buttonAddDepo);
            this.groupBoxDepo.Location = new System.Drawing.Point(775, 0);
            this.groupBoxDepo.Name = "groupBoxDepo";
            this.groupBoxDepo.Size = new System.Drawing.Size(200, 100);
            this.groupBoxDepo.TabIndex = 16;
            this.groupBoxDepo.TabStop = false;
            this.groupBoxDepo.Text = "Депо";
            // 
            // labelDepo
            // 
            this.labelDepo.AutoSize = true;
            this.labelDepo.Location = new System.Drawing.Point(25, 15);
            this.labelDepo.Name = "labelDepo";
            this.labelDepo.Size = new System.Drawing.Size(59, 13);
            this.labelDepo.TabIndex = 4;
            this.labelDepo.Text = "Имя депо:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(90, 12);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(104, 20);
            this.textBoxNewLevelName.TabIndex = 3;
            // 
            // buttonDelDepo
            // 
            this.buttonDelDepo.Location = new System.Drawing.Point(9, 67);
            this.buttonDelDepo.Name = "buttonDelDepo";
            this.buttonDelDepo.Size = new System.Drawing.Size(75, 23);
            this.buttonDelDepo.TabIndex = 2;
            this.buttonDelDepo.Text = "Удалить";
            this.buttonDelDepo.UseVisualStyleBackColor = true;
            this.buttonDelDepo.Click += new System.EventHandler(this.buttonDelDepo_Click);
            // 
            // listBoxDepo
            // 
            this.listBoxDepo.FormattingEnabled = true;
            this.listBoxDepo.Location = new System.Drawing.Point(90, 38);
            this.listBoxDepo.Name = "listBoxDepo";
            this.listBoxDepo.Size = new System.Drawing.Size(104, 56);
            this.listBoxDepo.TabIndex = 1;
            // 
            // buttonAddDepo
            // 
            this.buttonAddDepo.Location = new System.Drawing.Point(9, 38);
            this.buttonAddDepo.Name = "buttonAddDepo";
            this.buttonAddDepo.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDepo.TabIndex = 0;
            this.buttonAddDepo.Text = " Создать";
            this.buttonAddDepo.UseVisualStyleBackColor = true;
            this.buttonAddDepo.Click += new System.EventHandler(this.buttonAddDepo_Click);
            // 
            // buttonAddTrain
            // 
            this.buttonAddTrain.Location = new System.Drawing.Point(776, 107);
            this.buttonAddTrain.Name = "buttonAddTrain";
            this.buttonAddTrain.Size = new System.Drawing.Size(191, 38);
            this.buttonAddTrain.TabIndex = 17;
            this.buttonAddTrain.Text = "Поставить поезд";
            this.buttonAddTrain.UseVisualStyleBackColor = true;
            this.buttonAddTrain.Click += new System.EventHandler(this.buttonAddTrain_Click);
            // 
            // FormDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.buttonAddTrain);
            this.Controls.Add(this.groupBoxDepo);
            this.Controls.Add(this.groupBoxTakeTrain);
            this.Controls.Add(this.pictureBoxDepo);
            this.Name = "FormDepo";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepo)).EndInit();
            this.groupBoxTakeTrain.ResumeLayout(false);
            this.groupBoxTakeTrain.PerformLayout();
            this.groupBoxDepo.ResumeLayout(false);
            this.groupBoxDepo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepo;
        private System.Windows.Forms.GroupBox groupBoxTakeTrain;
        private System.Windows.Forms.Button buttonTakeTrain;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Button buttonCheckTrain;
        private System.Windows.Forms.GroupBox groupBoxDepo;
        private System.Windows.Forms.Label labelDepo;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonDelDepo;
        private System.Windows.Forms.ListBox listBoxDepo;
        private System.Windows.Forms.Button buttonAddDepo;
        private System.Windows.Forms.Button buttonAddTrain;
    }
}