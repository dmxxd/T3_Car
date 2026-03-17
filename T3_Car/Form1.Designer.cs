using System;
using System.Drawing;
using System.Windows.Forms;

namespace T3_Car
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCreateCars;
        private Button btnClear;
        private ListBox listBoxInfo;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreateCars = new Button();
            this.btnClear = new Button();
            this.listBoxInfo = new ListBox();
            this.label1 = new Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(282, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инициализаторы объектов и класс \"Автомобиль\"";

            this.btnCreateCars.Location = new Point(15, 40);
            this.btnCreateCars.Name = "btnCreateCars";
            this.btnCreateCars.Size = new Size(200, 40);
            this.btnCreateCars.TabIndex = 1;
            this.btnCreateCars.Text = "Создать три автомобиля";
            this.btnCreateCars.UseVisualStyleBackColor = true;
            this.btnCreateCars.Click += new EventHandler(this.btnCreateCars_Click);

            this.btnClear.Location = new Point(230, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(100, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            this.listBoxInfo.Location = new Point(15, 100);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new Size(315, 160);
            this.listBoxInfo.TabIndex = 3;

            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(354, 291);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateCars);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Автомобиль";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

