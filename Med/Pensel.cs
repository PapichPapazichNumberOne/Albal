using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Med
{
    public partial class Pensel : Form
    {
        public Pensel()
        {
            InitializeComponent();
        }

        private void IMT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            double weight = double.Parse(textBox1.Text);
            double height = double.Parse(textBox2.Text) / 100;

            label6.Text = (weight / Math.Pow(height, 2)).ToString();

            MessageBox.Show("Масса тела    Эноксапарин натрия\n" +
                "<50 кг            20 мг\n" +
                "50-90 кг         40 мг\n" +
                "91-130 кг       60 мг\n" +
                "131-170 кг     70 мг\n" +
                ">170 кг          0,6 мг/кг", "Режим дозирования низкомолекулярных гепаринов (НМГ)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
