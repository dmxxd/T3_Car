using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateCars_Click(object sender, EventArgs e)
        {
            Car car1 = new Car { brand = "Toyota", model = "Camry", year = 2020 };
            Car car2 = new Car { brand = "BMW", model = "X5", year = 2022 };
            Car car3 = new Car { brand = "Lada", model = "Vesta" };

            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Список автомобилей:");
            listBoxInfo.Items.Add($"Марка: {car1.brand}, Модель: {car1.model}, Год: {car1.year}");
            listBoxInfo.Items.Add($"Марка: {car2.brand}, Модель: {car2.model}, Год: {car2.year}");
            listBoxInfo.Items.Add($"Марка: {car3.brand}, Модель: {car3.model}, Год: {car3.year}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
        }
    }
}