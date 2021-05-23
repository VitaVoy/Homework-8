using System; // Войтов Виталий
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_8._2 // Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Введите число от 3 до 6 и нажмите Получить");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 3)
            {
                MessageBox.Show($"З, А, Г");
            }

            if (numericUpDown1.Value == 4)
            {
                MessageBox.Show($"М, А, Р, А");
            }

            if (numericUpDown1.Value == 5)
            {
                MessageBox.Show($"З, А, Р, О, Г");
            }

            if (numericUpDown1.Value == 6)
            {
                MessageBox.Show($"Т, А, К, О, С, Н");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Газ" || textBox1.Text == "газ" || textBox1.Text == "ГАЗ")
            {
                MessageBox.Show($"Ура, вы победили");
            }

            else if(textBox1.Text == "Рама" || textBox1.Text == "рама" || textBox1.Text == "РАМА")
            {
                MessageBox.Show($"Ура, вы победили");
            }

            else if (textBox1.Text == "Гроза" || textBox1.Text == "гроза" || textBox1.Text == "ГРОЗА")
            {
                MessageBox.Show($"Ура, вы победили");
            }

            else if (textBox1.Text == "Станок" || textBox1.Text == "станок" || textBox1.Text == "СТАНОК")
            {
                MessageBox.Show($"Ура, вы победили");
            }

            else
            {
                MessageBox.Show($"Вы проиграли");
            }                 
                
        }

        private void aboutProgrammToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Программа создана через пень колоду");
        }
    }
}
