using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using static System.Reflection.Emit.Label;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        float a, b, c;
        int count;
        bool znak = true;



        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Cursor = Cursors.Hand;

            textBox1.ReadOnly = true;


            ToolTip = new ToolTip();
            ToolTip.AutoPopDelay = 5000; // Время отображения подсказки (5 секунд)
            ToolTip.InitialDelay = 1000; // Время задержки перед отображением подсказки (1 секунда)
            ToolTip.ReshowDelay = 500;   // Время задержки перед повторным отображением подсказки (0.5 секунды)

            ToolTip.SetToolTip(button20, "Возвести в степень");
            ToolTip.SetToolTip(button21, "Извлечь квадратный корень");
            ToolTip.SetToolTip(button22, "Возвести в квадрат");
            ToolTip.SetToolTip(button23, "Обратное значение");
            ToolTip.SetToolTip(button24, "Факториал");
            ToolTip.SetToolTip(button25, "Извлечь кубический корень");
            ToolTip.SetToolTip(button26, "Решение квадратного уравнения");

        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }


        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                case 5:
                    b = (float)Math.Pow((double)a, double.Parse(textBox1.Text));
                    textBox1.Text = b.ToString();
                    break;


                default:
                    break;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Text = null;
            count = 5;
            textBox1.Text = a.ToString() + " ^";
            znak = true;
            textBox1.Text = " ";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double number = double.Parse(textBox1.Text);
                if (number >= 0) // Проверка, что число не отрицательное
                {
                    double result = Math.Sqrt(number);
                    textBox1.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Невозможно извлечь квадратный корень из отрицательного числа.");
                }
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                float number = float.Parse(textBox1.Text);
                float result = number * number;
                textBox1.Text = result.ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                float number = float.Parse(textBox1.Text);
                if (number != 0)
                {
                    float result = 1 / number;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Деление на ноль невозможно.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        private double CubeRoot(double x)
        {
            return Math.Pow(x, 1.0 / 3.0);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    int number = int.Parse(textBox1.Text);
                    if (number >= 0)
                    {
                        int result = Factorial(number);
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Факториал можно вычислить только для неотрицательных целых чисел.");
                    }
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double number = double.Parse(textBox1.Text);
                if (number >= 0)
                {
                    double result = CubeRoot(number);
                    textBox1.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Невозможно извлечь кубический корень из отрицательного числа.");
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // Вызовите метод SolveQuadraticEquation с текущими значениями коэффициентов a, b и c
            string result = SolveQuadraticEquation(a, b, c);

            // Отобразите результат в textBox1
            textBox1.Text = result;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            // Создайте новую форму для ввода коэффициентов a, b и c
            Form inputForm = new Form();
            inputForm.Text = "Введите коэффициенты a, b и c";

            // Создайте TextBox для ввода коэффициентов a, b и c
            TextBox textBoxA = new TextBox();
            TextBox textBoxB = new TextBox();
            TextBox textBoxC = new TextBox();
            Label labelA = new Label();
            Label labelB = new Label();
            Label labelC = new Label();

            textBoxA.Location = new Point(10, 10);
            textBoxB.Location = new Point(10, 40);
            textBoxC.Location = new Point(10, 70);
            labelA.Text = "a:";
            labelB.Text = "b:";
            labelC.Text = "c:";
            labelA.Location = new Point(100, 10);
            labelB.Location = new Point(100, 40);
            labelC.Location = new Point(100, 70);

            inputForm.Controls.Add(textBoxA);
            inputForm.Controls.Add(textBoxB);
            inputForm.Controls.Add(textBoxC);
            inputForm.Controls.Add(labelA);
            inputForm.Controls.Add(labelB);
            inputForm.Controls.Add(labelC);

            // Создайте кнопку "OK" для подтверждения ввода
            Button buttonOK = new Button();
            buttonOK.Text = "OK";
            buttonOK.Location = new Point(10, 100);
            inputForm.Controls.Add(buttonOK);

            // Добавьте обработчик события для кнопки "OK"
            buttonOK.Click += (okSender, okEventArgs) =>
            {
                try
                {
                    // Получите значения коэффициентов a, b и c из TextBox
                    double a = double.Parse(textBoxA.Text);
                    double b = double.Parse(textBoxB.Text);
                    double c = double.Parse(textBoxC.Text);

                    // Решите квадратное уравнение
                    string result = SolveQuadraticEquation(a, b, c);

                    // Отобразите результат в textBox1
                    textBox1.Text = result;

                    // Закройте окно диалога
                    inputForm.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Пожалуйста, введите корректные числовые значения для коэффициентов.");
                }
            };

            // Отобразите окно диалога
            inputForm.ShowDialog();
        }

        private string SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                return "Нет действительных корней";
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return "Один корень: " + root.ToString();
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return "Два корня: " + root1.ToString() + " и " + root2.ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {


            string result = SolveQuadraticEquation(a, b, c);
            textBox1.Text = result;
        }

       

    }

}
