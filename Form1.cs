
using System.Linq;

namespace wincalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bthpoint_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")) // Проверка, чтобы не было больше одной запятой
                textBox1.Text = textBox1.Text + ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Действие для кнопки (если нужно)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Действие для кнопки (если нужно)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Действие для кнопки (если нужно)
        }

        private void bthzero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void bthtwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void bththree_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void bthsix_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void bthfour_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void bthfive_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void bthone_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void btndenial_Click(object sender, EventArgs e)
        {
            // Если кнопка отрицания: меняем знак числа
            if (textBox1.Text != "")
            {
                float value = float.Parse(textBox1.Text);
                textBox1.Text = (-value).ToString();
            }
        }

        float a, b;
        int count; // 1 = сложение, 2 = вычитание, 3 = умножение, 4 = деление
        bool znak = false;

        // Операция сложения
        private void btnplus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("sin") || textBox1.Text.Contains("cos") || textBox1.Text.Contains("tan") || textBox1.Text.Contains("log") || textBox1.Text.Contains("e"))
            {
                var b = textBox1.Text.Remove(0, 4);
                a = float.Parse(b);
                textBox1.Clear();
                count = 1;  // Сложение
                label1.Text = a.ToString() + "+";
                znak = true;
            }
        }

        // Операция вычитания
        private void bthminus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;  // Вычитание
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        // Операция умножения
        private void bthmiltiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;  // Умножение
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        // Операция деления
        private void bthdivision_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;  // Деление
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        // Равно (=)
        private void bthequation_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        // Метод для выполнения вычислений
        private void calculate()
        {
            if (znak)
                b = float.Parse(textBox1.Text);
            if (textBox1.Text.Contains("sin"))
            {
                var a = textBox1.Text.Remove(0, 4);
                double degrees = double.Parse(a);

                // Перевод градусов в радианы
                double radians = degrees * (Math.PI / 180);

                // Вычисление синуса
                double result = Math.Sin(radians);

                textBox1.Text = result.ToString();
            }
            if (textBox1.Text.Contains("cos"))
            {
                var a = textBox1.Text.Remove(0, 4);
                double degrees = double.Parse(a);

                // Перевод градусов в радианы
                double radians = degrees * (Math.PI / 180);

                // Вычисление косинуса
                double result = Math.Cos(radians);

                // Вывод результата в TextBox2
                textBox1.Text = result.ToString();
            }
            if (textBox1.Text.Contains("tan"))
            {
                var a = textBox1.Text.Remove(0, 4);
                double degrees = double.Parse(a);

                // Перевод градусов в радианы
                double radians = degrees * (Math.PI / 180);

   
                double result = Math.Tan(radians);

                // Вывод результата в TextBox2
                textBox1.Text = result.ToString();
            }
            if (textBox1.Text.Contains("log"))
            {
                var a = textBox1.Text.Remove(0, 3);
                // Чтение значения из TextBox
                double number = double.Parse(a);

                // Вычисление десятичного логарифма (по основанию 10)
                double result = Math.Log10(number);

                // Вывод результата в TextBox2
                textBox1.Text = result.ToString();
            }
            if (textBox1.Text.Contains("e"))
            {
                var a = textBox1.Text.Remove(0, 1);
                // Получаем значение из текстового поля
                double x = double.Parse(a);

                // Вычисляем экспоненциальное выражение e^x
                double result = Math.Exp(x);

                // Выводим результат в метку
                label1.Text = "e^" + x + " = " + result.ToString();
            }
            switch (count)
            {
                case 1:
                    textBox1.Text = (a + b).ToString();  // Сложение
                    break;
                case 2:
                    textBox1.Text = (a - b).ToString();  // Вычитание
                    break;
                case 3:
                    textBox1.Text = (a * b).ToString();  // Умножение
                    break;
                case 4:
                    if (b != 0)
                    {
                        textBox1.Text = (a / b).ToString();  // Деление
                    }
                    else
                    {
                        textBox1.Text = "Ошибка";  // Ошибка при делении на ноль
                    }
                    break;
                default:
                    break;
            }
            znak = false;
        }

        // Кнопка сброса ("C")
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";  // Очистить поле
            label1.Text = "";    // Очистить метку
            a = 0;
            b = 0;
            count = 0;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btneigth_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ln(";
        }

        private void cos_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "cos(";
        }

        private void tan_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "tan(";
        }

        private void bthsinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "sin(";
        }

        private void e_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "e";
        }
    }
}
