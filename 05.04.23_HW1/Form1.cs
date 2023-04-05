using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _05._04._23_HW1
{
    public partial class Form1 : Form
    {
        static int count = 1;
        Random random;
        public Form1()
        {
            InitializeComponent();
            string mb_1 = "Yes - Имя\nNo - Работа\nCancel - Угадывать числа";
            string mb_2 = Convert.ToString(mb_1.Length / 3);
            DialogResult d = MessageBox.Show(mb_1, mb_2, MessageBoxButtons.YesNoCancel);
            if (d == DialogResult.Yes)
            {
                mb_1 = "Имя - Никита Мохсени";
                mb_2 = Convert.ToString(mb_1.Length / 3);
                MessageBox.Show(mb_1, mb_2, MessageBoxButtons.OK);
                mb_1 = "Дальше идем угадывать числа)";
                mb_2 = Convert.ToString(mb_1.Length / 3);
                MessageBox.Show(mb_1, mb_2, MessageBoxButtons.OK);
            }
            else if (d == DialogResult.No)
            {
                mb_1 = "Работа - Программист";
                mb_2 = Convert.ToString(mb_1.Length / 3);
                d = MessageBox.Show(mb_1, mb_2, MessageBoxButtons.YesNo);
                if (d == DialogResult.No) 
                {
                    mb_1 = "Ну пожалуйста";
                    mb_2 = Convert.ToString(mb_1.Length / 3);
                    MessageBox.Show(mb_1, mb_2, MessageBoxButtons.OK);
                }
                mb_1 = "Дальше идем угадывать числа)";
                mb_2 = Convert.ToString(mb_1.Length / 3);
                MessageBox.Show(mb_1, mb_2, MessageBoxButtons.OK);
            }
            random = new Random();
            while (true)
            {
                int temp = random.Next(1, 2000);
                DialogResult d1 = MessageBox.Show($"Ваше число = {temp}?", "Угадываем число", MessageBoxButtons.YesNo);
                if (d1 == DialogResult.Yes)
                {
                    MessageBox.Show($"Попытки угадать число = {count}", "Угадываем число", MessageBoxButtons.OK);
                    break;
                }
                else if (d1 == DialogResult.No)
                    count++;
            }
        }
    }
}
