
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
            if (!textBox1.Text.Contains(",")) // ��������, ����� �� ���� ������ ����� �������
                textBox1.Text = textBox1.Text + ",";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // �������� ��� ������ (���� �����)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // �������� ��� ������ (���� �����)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // �������� ��� ������ (���� �����)
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
            // ���� ������ ���������: ������ ���� �����
            if (textBox1.Text != "")
            {
                float value = float.Parse(textBox1.Text);
                textBox1.Text = (-value).ToString();
            }
        }

        float a, b;
        int count; // 1 = ��������, 2 = ���������, 3 = ���������, 4 = �������
        bool znak = false;

        // �������� ��������
        private void btnplus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("sin") || textBox1.Text.Contains("cos") || textBox1.Text.Contains("tan") || textBox1.Text.Contains("log") || textBox1.Text.Contains("e"))
            {
                var b = textBox1.Text.Remove(0, 4);
                a = float.Parse(b);
                textBox1.Clear();
                count = 1;  // ��������
                label1.Text = a.ToString() + "+";
                znak = true;
            }
        }

        // �������� ���������
        private void bthminus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;  // ���������
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        // �������� ���������
        private void bthmiltiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;  // ���������
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        // �������� �������
        private void bthdivision_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;  // �������
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        // ����� (=)
        private void bthequation_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        // ����� ��� ���������� ����������
        private void calculate()
        {
            if (znak)
                b = float.Parse(textBox1.Text);
            if (textBox1.Text.Contains("sin"))
            {
                var a = textBox1.Text.Remove(0, 4);
                double degrees = double.Parse(a);

                // ������� �������� � �������
                double radians = degrees * (Math.PI / 180);

                // ���������� ������
                double result = Math.Sin(radians);

                textBox1.Text = result.ToString();
            }
            if (textBox1.Text.Contains("cos"))
            {
                var a = textBox1.Text.Remove(0, 4);
                double degrees = double.Parse(a);

                // ������� �������� � �������
                double radians = degrees * (Math.PI / 180);

                // ���������� ��������
                double result = Math.Cos(radians);

                // ����� ���������� � TextBox2
                textBox1.Text = result.ToString();
            }
            if (textBox1.Text.Contains("tan"))
            {
                var a = textBox1.Text.Remove(0, 4);
                double degrees = double.Parse(a);

                // ������� �������� � �������
                double radians = degrees * (Math.PI / 180);

   
                double result = Math.Tan(radians);

                // ����� ���������� � TextBox2
                textBox1.Text = result.ToString();
            }
            if (textBox1.Text.Contains("log"))
            {
                var a = textBox1.Text.Remove(0, 3);
                // ������ �������� �� TextBox
                double number = double.Parse(a);

                // ���������� ����������� ��������� (�� ��������� 10)
                double result = Math.Log10(number);

                // ����� ���������� � TextBox2
                textBox1.Text = result.ToString();
            }
            if (textBox1.Text.Contains("e"))
            {
                var a = textBox1.Text.Remove(0, 1);
                // �������� �������� �� ���������� ����
                double x = double.Parse(a);

                // ��������� ���������������� ��������� e^x
                double result = Math.Exp(x);

                // ������� ��������� � �����
                label1.Text = "e^" + x + " = " + result.ToString();
            }
            switch (count)
            {
                case 1:
                    textBox1.Text = (a + b).ToString();  // ��������
                    break;
                case 2:
                    textBox1.Text = (a - b).ToString();  // ���������
                    break;
                case 3:
                    textBox1.Text = (a * b).ToString();  // ���������
                    break;
                case 4:
                    if (b != 0)
                    {
                        textBox1.Text = (a / b).ToString();  // �������
                    }
                    else
                    {
                        textBox1.Text = "������";  // ������ ��� ������� �� ����
                    }
                    break;
                default:
                    break;
            }
            znak = false;
        }

        // ������ ������ ("C")
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";  // �������� ����
            label1.Text = "";    // �������� �����
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
