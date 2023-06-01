using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics; // Підключення вбудований тип даних BigInteger
using MaterialSkin;
using MaterialSkin.Controls; // Підключення бібліотеки для оформлення користувацького інтерфейсу


namespace OOP_course
{
    public partial class FormLongNum : MaterialForm
    {
        public FormLongNum() // Зміна тексту, та кольору для кнопок і лейблів
        {
            InitializeComponent();
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "×";
            button4.Text = "÷";
            button5.Text = "<=>";
            button7.Text = "Raise a number to a power";
            button8.Text = "Delete";
            button6.Text = "About";
            button9.Text = "Legend";
            materialLabel1.ForeColor = Color.Black;
            materialLabel1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) // Додавання довгих чисел
        {
            materialLabel1.ForeColor = Color.Black; // Початковий колір лейблу чорний
            BigInteger num1, num2; // Оголошує дві змінні типу BigInteger: num1 та num2
            bool isValidNum1 = BigInteger.TryParse(maskedTextBox1.Text, out num1); // Парсить текст з maskedTextBox1 у BigInteger
            bool isValidNum2 = BigInteger.TryParse(maskedTextBox2.Text, out num2);

            if (isValidNum1 && isValidNum2)
            {
                string imagePath = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-сложение-50.png"; // Шлях до картинки з плюсом
                pictureBox3.BackgroundImage = Image.FromFile(imagePath); // Завантажує зображення з файлу
                BigInteger sum = num1 + num2; // Додає num1 та num2 і зберігає результат у sum
                materialLabel1.Text = sum.ToString(); // Конвертує sum у рядок і встановлює його як текст materialLabel1
            }
            else // Якщо якась помилка в maskedTextBox1.Text
            {
                if (button6.Text == "About")
                {
                    pictureBox3.BackgroundImage = null;
                    materialLabel1.ForeColor = Color.Red;
                    materialLabel1.Text = "Invalid number format"; // Англ. локалізація
                }
                else
                {
                    pictureBox3.BackgroundImage = null;
                    materialLabel1.ForeColor = Color.Red;
                    materialLabel1.Text = "Неправильний формат числа"; // Укр. локалізація
                }
            }
        }
        private void button2_Click(object sender, EventArgs e) // Віднімання довгих чисел
        {
            materialLabel1.ForeColor = Color.Black;
            BigInteger num1, num2;
            bool isValidNum1 = BigInteger.TryParse(maskedTextBox1.Text, out num1);
            bool isValidNum2 = BigInteger.TryParse(maskedTextBox2.Text, out num2);

            if (isValidNum1 && isValidNum2)
            {
                string imagePath = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-минус-48.png";
                pictureBox3.BackgroundImage = Image.FromFile(imagePath);
                BigInteger difference = num1 - num2;
                materialLabel1.Text = difference.ToString();
            }
            else
            {
                if (button6.Text == "About")
                {
                    pictureBox3.BackgroundImage = null;
                    materialLabel1.ForeColor = Color.Red;
                    materialLabel1.Text = "Invalid number format";
                }
                else
                {
                    pictureBox3.BackgroundImage = null;
                    materialLabel1.ForeColor = Color.Red;
                    materialLabel1.Text = "Неправильний формат числа";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) // Множення довгих чисел
        {
            materialLabel1.ForeColor = Color.Black;
            BigInteger num1, num2;
            bool isValidNum1 = BigInteger.TryParse(maskedTextBox1.Text, out num1);
            bool isValidNum2 = BigInteger.TryParse(maskedTextBox2.Text, out num2);

            if (isValidNum1 && isValidNum2)
            {
                string imagePath = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-умножение-60.png";
                pictureBox3.BackgroundImage = Image.FromFile(imagePath);
                BigInteger product = num1 * num2;
                materialLabel1.Text = product.ToString();
            }
            else
            {
                if (button6.Text == "About")
                {
                    pictureBox3.BackgroundImage = null;
                    materialLabel1.ForeColor = Color.Red;
                    materialLabel1.Text = "Invalid number format";
                }
                else
                {
                    pictureBox3.BackgroundImage = null;
                    materialLabel1.ForeColor = Color.Red;
                    materialLabel1.Text = "Неправильний формат числа";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // Ділення з остачею
        {
            materialLabel1.ForeColor = Color.Black;
            BigInteger num1, num2;
            bool isValidNum1 = BigInteger.TryParse(maskedTextBox1.Text, out num1);
            bool isValidNum2 = BigInteger.TryParse(maskedTextBox2.Text, out num2);

            if (isValidNum1 && isValidNum2)
            {
                if (button6.Text == "About")
                {
                    string imagePath = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-деление-60.png";
                    pictureBox3.BackgroundImage = Image.FromFile(imagePath);
                    if (num2 != 0)
                    {
                        BigInteger quotient = BigInteger.DivRem(num1, num2, out BigInteger remainder);
                        materialLabel1.Text = "Quotient: " + quotient.ToString() + " Remainder: " + remainder.ToString();
                    }
                    else
                    {
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Divisor cannot be zero";
                    }
                }
                else 
                {
                    string imagePath = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-деление-60.png";
                    pictureBox3.BackgroundImage = Image.FromFile(imagePath);
                    if (num2 != 0)
                    {
                        BigInteger quotient = BigInteger.DivRem(num1, num2, out BigInteger remainder);
                        materialLabel1.Text = "Частка: " + quotient.ToString() + " Залишок: " + remainder.ToString();
                    }
                    else
                    {
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Друге число не може бути нулем";
                    }
                }
            }
            else
            {
                if (button6.Text == "About")
                {
                    pictureBox3.BackgroundImage = null;
                    materialLabel1.ForeColor = Color.Red;
                    materialLabel1.Text = "Invalid number format";
                }
                else
                {
                    pictureBox3.BackgroundImage = null;
                    materialLabel1.ForeColor = Color.Red;
                    materialLabel1.Text = "Неправильний формат числа";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e) // Порівняння
        {
            materialLabel1.ForeColor = Color.Black;
            string num1Text = maskedTextBox1.Text;
            string num2Text = maskedTextBox2.Text;

            BigInteger num1, num2;
            bool isValidNum1 = BigInteger.TryParse(num1Text, out num1);
            bool isValidNum2 = BigInteger.TryParse(num2Text, out num2);
            if (button6.Text == "About") // Для анг локалізації
            {
                if (isValidNum1 && isValidNum2)
                {
                    int comparisonResult = BigInteger.Compare(num1, num2);
                    if (comparisonResult > 0)
                    {
                        string imagePath = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-математик2а-64.png";
                        pictureBox3.BackgroundImage = Image.FromFile(imagePath);
                        materialLabel1.Text = "The first number is larger than the second";
                    }
                    else if (comparisonResult < 0)
                    {
                        string imagePath1 = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-математика-64.png";
                        pictureBox3.BackgroundImage = Image.FromFile(imagePath1);
                        materialLabel1.Text = "The first number is less than the second";
                    }
                    else
                    {
                        string imagePath2 = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-знак-равенства-60.png";
                        pictureBox3.BackgroundImage = Image.FromFile(imagePath2);
                        materialLabel1.Text = "Numbers are equal";
                    }
                }
                else
                {
                    if (button6.Text == "About")
                    {
                        pictureBox3.BackgroundImage = null;
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Invalid number format";
                    }
                    else
                    {
                        pictureBox3.BackgroundImage = null;
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Неправильний формат числа";
                    }
                }
            }
            else // Для укр локалізації
            {
                if (isValidNum1 && isValidNum2)
                {
                    int comparisonResult = BigInteger.Compare(num1, num2);
                    if (comparisonResult > 0)
                    {
                        string imagePath = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-математик2а-64.png";
                        pictureBox3.BackgroundImage = Image.FromFile(imagePath);
                        materialLabel1.Text = "Перше число більше за друге";
                    }
                    else if (comparisonResult < 0)
                    {
                        string imagePath1 = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-математика-64.png";
                        pictureBox3.BackgroundImage = Image.FromFile(imagePath1);
                        materialLabel1.Text = "Перше число менше за друге";
                    }
                    else
                    {
                        string imagePath2 = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-знак-равенства-60.png";
                        pictureBox3.BackgroundImage = Image.FromFile(imagePath2);
                        materialLabel1.Text = "Числа рівні";
                    }
                }
                else
                {
                    if (button6.Text == "About")
                    {
                        pictureBox3.BackgroundImage = null;
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Invalid number format";
                    }
                    else
                    {
                        pictureBox3.BackgroundImage = null;
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Неправильний формат числа";
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e) // Піднесення до степеня
        {
            materialLabel1.ForeColor = Color.Black;
            string baseNumberString = maskedTextBox1.Text;
            string exponentString = maskedTextBox2.Text;

            BigInteger baseNumber, exponent;
            bool isValidBaseNumber = BigInteger.TryParse(baseNumberString, out baseNumber);
            bool isValidExponent = BigInteger.TryParse(exponentString, out exponent);
            if (maskedTextBox2.TextLength < 3)
            {
                if (isValidBaseNumber && isValidExponent)
                {
                    string imagePath2 = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-выровнять-50.png";
                    pictureBox3.BackgroundImage = Image.FromFile(imagePath2);

                    BigInteger result;
                    if (exponent < 0)
                    {
                        // Обробка від'ємних степенів
                        result = BigInteger.Pow(baseNumber, (int)BigInteger.Abs(exponent));
                        if (BigInteger.Abs(exponent) % 2 == 1)
                        {
                            result = BigInteger.Negate(result);
                        }
                    }
                    else
                    {
                        result = BigInteger.Pow(baseNumber, (int)exponent);
                    }

                    materialLabel1.Text = result.ToString();
                }
                else
                {
                    if (button6.Text == "About")
                    {
                        pictureBox3.BackgroundImage = null;
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Invalid number format";
                    }
                    else
                    {
                        pictureBox3.BackgroundImage = null;
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Неправильний формат числа";
                    }
                }
            }
            else if (maskedTextBox2.TextLength >= 3) // Запит користувача, якщо в другому полі трьохцифрове число (або більше)
            {
                DialogResult resulte = MessageBox.Show("Ви ввели велике число в степінь, ви впевнені, що хочете виконати цю дію ?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resulte == DialogResult.Yes)
                {
                    if (isValidBaseNumber && isValidExponent)
                    {
                        string imagePath2 = "C:\\Users\\lox22\\source\\repos\\OOP course\\OOP course\\Resources\\icons8-выровнять-50.png"; 
                        pictureBox3.BackgroundImage = Image.FromFile(imagePath2);

                        BigInteger result;
                        if (exponent < 0)
                        {
                            // Обробка від'ємних степенів
                            result = BigInteger.Pow(baseNumber, (int)BigInteger.Abs(exponent));
                            if (BigInteger.Abs(exponent) % 2 == 1)
                            {
                                result = BigInteger.Negate(result);
                            }
                        }
                        else
                        {
                            result = BigInteger.Pow(baseNumber, (int)exponent);
                        }

                        materialLabel1.Text = result.ToString();
                    }
                    else
                    {
                        if (button6.Text == "About")
                        {
                            pictureBox3.BackgroundImage = null;
                            materialLabel1.ForeColor = Color.Red;
                            materialLabel1.Text = "Invalid number format";
                        }
                        else
                        {
                            pictureBox3.BackgroundImage = null;
                            materialLabel1.ForeColor = Color.Red;
                            materialLabel1.Text = "Неправильний формат числа";
                        }
                    }
                }
                else if (resulte == DialogResult.No)
                {
                    if (button6.Text == "About")
                    {
                        pictureBox3.BackgroundImage = null;
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Invalid number format";
                    }
                    else
                    {
                        pictureBox3.BackgroundImage = null;
                        materialLabel1.ForeColor = Color.Red;
                        materialLabel1.Text = "Неправильний формат числа";
                    }
                }
            }
        }

        private async void button8_Click(object sender, EventArgs e) // Видалення чисел, та materialLabel1.Text
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";

            if (button6.Text == "About") // укр. локалізація
            {
                pictureBox3.BackgroundImage = null;
                materialLabel1.ForeColor = Color.Red;
                materialLabel1.Text = "Deleted";
                await Task.Delay(1500); // Поява Deleted на 1,5 сек
                materialLabel1.Text = "";
                materialLabel1.ForeColor = Color.Black;
            }
            else // анг. локалізація
            {
                pictureBox3.BackgroundImage = null;
                materialLabel1.ForeColor = Color.Red;
                materialLabel1.Text = "Видалено";
                await Task.Delay(1500);
                materialLabel1.Text = "";
                materialLabel1.ForeColor = Color.Black;
            }

            pictureBox3.BackgroundImage = null;
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e) // Захист
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }

            if (e.KeyChar == '-')
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    maskedTextBox2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }// Захист для поля

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e) // Захист
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }

            if (e.KeyChar == '-')
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    maskedTextBox2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }// Захист для поля

        private void button6_Click(object sender, EventArgs e) // Відкриття форми Про программу
        {
            FormAbout form2 = new FormAbout();
            form2.Show();
        }

        private void button9_Click(object sender, EventArgs e) // Відкриття форми Легенда
        {
            FormLegend form3 = new FormLegend();
            form3.Show();
        }

        private void button11_Click(object sender, EventArgs e) // Англійська мова
        {
            button7.Text = "Raise a number to a power";
            button8.Text = "Delete";
            button6.Text = "About";
            button9.Text = "Legend";
            materialLabel1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e) // Українська мова
        {
            button7.Text = "Піднести число до степеня";
            button8.Text = "Видалити";
            button6.Text = "Про програму";
            button9.Text = "Легенда";
            materialLabel1.Text = "";
        }
    }
}
