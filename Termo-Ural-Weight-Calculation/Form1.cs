using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Termo_Ural_Weight_Calculation
{
    public partial class Form1 : Form
    {

        double Dout;// Диаметр наружной оболочки, мм
        double Dpipe;// Диаметр трубы, мм
        double SizePipe;//Длина оболочки, м
        double D1out;// Диаметр наружной оболочки, м
        double D1pipe;// Диаметр трубы, м
        double M;//Общий заливочный вес изделия, кг
                
       

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText1 = richTextBoxDpipe.Text;
            if (double.TryParse(inputText1, out Dpipe))
            {
                MessageBox.Show("Диаметр трубы,мм: " + Dpipe);
            }
            else
            {
                MessageBox.Show("Неверный формат числа ");
            }

            string inputText2 = richTextBoxDout.Text;
            if (double.TryParse(inputText2, out Dout))
            {
                MessageBox.Show("Диаметр оболочки,мм: " + Dout);
            }
            else
            {
                MessageBox.Show("Неверный формат числа ");
            }

            string inputText3 = richTextBoxSizePipe.Text;
            if (double.TryParse(inputText3, out SizePipe))
            {
                MessageBox.Show("Длина оболочки,мм: " + SizePipe);
            }
            else
            {
                MessageBox.Show("Неверный формат числа ");
            }

            //Значение - константа , которое вводится Администратором в таблицу БАЗОВЫЕ ПАРАМЕТРЫ:
            double FoamDensity = 70;// Плотность готовой пены , кг/м3

            //Расчет веса
            D1pipe = Dpipe / 1000;
            D1out = Dout / 1000;
            M = 3.14 / 4 * (D1out * D1out   -  D1pipe * D1pipe  ) * SizePipe * FoamDensity;

            //Отображение на экране
            richTextBoxM.Text = $"{M}";

        }


    }
}
