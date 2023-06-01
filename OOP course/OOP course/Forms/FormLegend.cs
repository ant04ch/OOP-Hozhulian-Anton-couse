using System;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OOP_course
{
    public partial class FormLegend : MaterialForm
    {
        public FormLegend()
        {
            InitializeComponent();
            label1.Text = "\"+\" - Addition\r\n\"-\" - Subtraction\r\n\"×\" - Multiplication\r\n\"÷\" - Division\r\n\"<=>\" - Comparison\r\n\"Raise to a power\" - Operations of ratios\r\n\"About\" - Contractor of work";
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormLegend form3 = new FormLegend();
            form3.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "\"+\" - Addition\r\n\"-\" - Subtraction\r\n\"×\" - Multiplication\r\n\"÷\" - Division\r\n\"<=>\" - Comparison\r\n\"Raise to a power\" - Operations of ratios\r\n\"About\" - Contractor of work";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "\"+\" - Додавання\r\n\"-\" - Віднімання\r\n\"×\" - Множення\r\n\"÷\" - Ділення\r\n\"<=>\" - Порівняння чисел\r\n\" - Піднесення до степеня\r\n\"Про програму\" - Виконавець роботи";
        }
    }
}
