using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labCsharp2
{
    public partial class Form1 : Form
    {
        Triangle triangle; //Объявляешь другой класс
        Equilateraltriangle tr;

        public Form1()
        {
            InitializeComponent();
            triangle = new Triangle(); // Создаёшь объект
            tr = new Equilateraltriangle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            triangle.Title = "             Информация о треугольнике\n";
            triangle.Firstside = Convert.ToDouble(txtTriangleFirstside.Text == "" ? "0" : txtTriangleFirstside.Text);
            triangle.Secondside = Convert.ToDouble(txtTriangleSecondside.Text == "" ? "0" : txtTriangleSecondside.Text);
            triangle.Thirdtside = Convert.ToDouble(txtTriangleThirdtside.Text == "" ? "0" : txtTriangleThirdtside.Text);
            richTextBoxTriangle.Text = triangle.ToString();

            tr.Firstside = Convert.ToDouble(txtTriangleFirstside.Text == "" ? "0" : txtTriangleFirstside.Text);
            tr.Secondside = Convert.ToDouble(txtTriangleSecondside.Text == "" ? "0" : txtTriangleSecondside.Text);
            tr.Thirdtside = Convert.ToDouble(txtTriangleThirdtside.Text == "" ? "0" : txtTriangleThirdtside.Text);
            richTextBox2.Text = tr.Ec();

            dataGridView1.Rows.Add(txtTriangleFirstside.Text, txtTriangleSecondside.Text, txtTriangleThirdtside.Text, triangle.Square(), tr.Equilateral());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RichTextBoxResult.Text = GetResult();
        }

        public string AverageVolume()
        {
            double averagevolume = 0, k = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)) != (Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value)) || (Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)) != (Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value)) || (Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value)) != (Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value)))
                {
                    averagevolume += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    k += 1;
                }
            }
            averagevolume = averagevolume / k;

            return "\nСредняя площади не равносторонних треугольников = " + Convert.ToString(averagevolume);
        }

        public string MaxSide()
        {
            double maxside = 0;
            int number = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) > maxside) && (triangle.Firstside == triangle.Secondside) && (triangle.Secondside == triangle.Thirdtside))
                {
                    maxside = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    number = i;
                }
            }
            return "\nНайбольшая сторона равностороннего треугольника = " + Convert.ToString(maxside);
        }
        public string GetResult()
        {
            return MaxSide() + AverageVolume();
        }
    }
}
