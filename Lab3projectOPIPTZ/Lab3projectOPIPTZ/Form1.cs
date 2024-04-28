using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3projectOPIPTZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання значень з TextBox
                double radius = double.Parse(radiusTextBox.Text);
                double angleDegrees = double.Parse(angleTextBox.Text);

                // Переведення кута в радіани
                double angleRadians = angleDegrees * Math.PI / 180.0;

                // Обчислення довжини дуги
                double arcLength = radius * angleRadians;

                // Виведення результату
                resultLabel.Text = $"Довжина дуги кола: {arcLength:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні значення для радіусу та кута.");
            }
        }
    }
}
