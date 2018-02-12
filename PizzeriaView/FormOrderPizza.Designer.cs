﻿namespace PizzeriaView
{
    partial class FormOrderPizza
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
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.comboBoxVisitor = new System.Windows.Forms.ComboBox();
            this.labelVisitor = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.comboBoxPizza = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelPizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(15, 95);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(44, 13);
            this.labelSum.TabIndex = 16;
            this.labelSum.Text = "Сумма:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(90, 92);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(217, 20);
            this.textBoxSum.TabIndex = 17;
            // 
            // comboBoxVisitor
            // 
            this.comboBoxVisitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisitor.FormattingEnabled = true;
            this.comboBoxVisitor.Location = new System.Drawing.Point(90, 12);
            this.comboBoxVisitor.Name = "comboBoxVisitor";
            this.comboBoxVisitor.Size = new System.Drawing.Size(217, 21);
            this.comboBoxVisitor.TabIndex = 11;
            // 
            // labelVisitor
            // 
            this.labelVisitor.AutoSize = true;
            this.labelVisitor.Location = new System.Drawing.Point(15, 15);
            this.labelVisitor.Name = "labelVisitor";
            this.labelVisitor.Size = new System.Drawing.Size(70, 13);
            this.labelVisitor.TabIndex = 10;
            this.labelVisitor.Text = "Посетитель:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(15, 69);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(69, 13);
            this.labelCount.TabIndex = 14;
            this.labelCount.Text = "Количество:";
            // 
            // comboBoxPizza
            // 
            this.comboBoxPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPizza.FormattingEnabled = true;
            this.comboBoxPizza.Location = new System.Drawing.Point(90, 39);
            this.comboBoxPizza.Name = "comboBoxPizza";
            this.comboBoxPizza.Size = new System.Drawing.Size(217, 21);
            this.comboBoxPizza.TabIndex = 13;
            this.comboBoxPizza.SelectedIndexChanged += new System.EventHandler(this.comboBoxPizza_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(222, 118);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(141, 118);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(90, 66);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(217, 20);
            this.textBoxCount.TabIndex = 15;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // labelPizza
            // 
            this.labelPizza.AutoSize = true;
            this.labelPizza.Location = new System.Drawing.Point(15, 42);
            this.labelPizza.Name = "labelPizza";
            this.labelPizza.Size = new System.Drawing.Size(42, 13);
            this.labelPizza.TabIndex = 12;
            this.labelPizza.Text = "Пицца:";
            // 
            // FormOrderPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 148);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.comboBoxVisitor);
            this.Controls.Add(this.labelVisitor);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.comboBoxPizza);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelPizza);
            this.Name = "FormOrderPizza";
            this.Text = "FormOrderPizza";
            this.Load += new System.EventHandler(this.FormOrderPizza_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.ComboBox comboBoxVisitor;
        private System.Windows.Forms.Label labelVisitor;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.ComboBox comboBoxPizza;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelPizza;
    }
}