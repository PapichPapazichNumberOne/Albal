namespace Med
{
    public partial class Main : Form
    {
        int points = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel4.AutoScroll = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Антифосфолипидный синдром (АФС) \n" +
                " Гомозиготная мутация гена фактора V (мутация Лейден F5 G1691A) или rs 6025 (далее – мутация F5)" +
                "\n Гомозиготная мутация гена фактора II (протромбина) F2 G20210А или rs 179996 (далее – мутация F2)" +
                "\n Сочетание гетерозиготных мутаций факторов V (Лейден) и II (протромбина)" +
                "\n Дефицит АТ" +
                "\n Дефицит протеина С" +
                "\n Дефицит протеина S", "Тромбофилия высокого риска", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(Object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pensel iMT = new Pensel();
            iMT.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Онкологическое заболевание" +
                "\n Пароксизмальная ночная гемоглобинурия" +
                "\n Сердечная недостаточность" +
                "\n Активная системная красная волчанка" +
                "\n Воспалительная полиартропатия" +
                "\n Воспалительное заболевание кишечника" +
                "\n Нефротический синдром" +
                "\n Сахарный диабет I типа с нефропатией" +
                "\n Серповидноклеточная анемия" +
                "\n Наркомания с внутривенным введением наркотиков в настоящее время",
                "Заболевания", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Гетерозиготная мутация гена фактора V (мутация Лейден F5 G1691A)\n" +
                " Гетерозиготная мутация гена фактора II (протромбина) F2 G20210А",
                "Тромбофилия низкого риска", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checker()
        {
            if (checkBox1.Checked)
            {
                points = points + 4;
            }
            if (checkBox2.Checked)
            {
                points = points + 3;
            }
            if (checkBox3.Checked)
            {
                points = points + 3;
            }
            if (checkBox4.Checked)
            {
                points = points + 3;
            }
            if (checkBox5.Checked)
            {
                points = points + 1;
            }
            if (checkBox6.Checked)
            {
                points = points + 1;
            }
            if (checkBox7.Checked)
            {
                points = points + 1;
            }
            if (checkBox8.Checked)
            {
                points = points + 1;
            }
            if (checkBox9.Checked)
            {
                points = points + 2;
            }
            if (checkBox10.Checked)
            {
                points = points + 1;
            }
            if (checkBox11.Checked)
            {
                points = points + 1;
            }
            if (checkBox27.Checked)
            {
                points = points + 1;
            }
            if (checkBox12.Checked)
            {
                points = points + 1;
            }
            if (checkBox13.Checked)
            {
                points = points + 1;
            }
            if (checkBox14.Checked)
            {
                points = points + 1;
            }
            if (checkBox15.Checked)
            {
                points = points + 2;
            }
            if (checkBox16.Checked)
            {
                points = points + 1;
            }
            if (checkBox17.Checked)
            {
                points = points + 1;
            }
            if (checkBox18.Checked)
            {
                points = points + 1;
            }
            if (checkBox19.Checked)
            {
                points = points + 1;
            }
            if (checkBox20.Checked)
            {
                points = points + 1;
            }
            if (checkBox21.Checked)
            {
                points = points + 1;
            }
            if (checkBox22.Checked)
            {
                points = points + 3;
            }
            if (checkBox23.Checked)
            {
                points = points + 3;
            }
            if (checkBox24.Checked)
            {
                points = points + 4;
            }
            if (checkBox25.Checked)
            {
                points = points + 1;
            }
            if (checkBox26.Checked)
            {
                points = points + 1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checker();
            MessageBox.Show("Количество баллов: " + points.ToString(), "Подсчёт выполнен");
            points = 0;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}