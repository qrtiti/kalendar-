public partial class Form1 : Form
    {                       
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = null;
            comboBox1.Text = null;
            pictureBox1.Image = null ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           int index = comboBox1.SelectedIndex;
            switch (index)
            {
                case 0:
                    label2.Text = "Год крысы!";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\qrtiti\\Desktop\\63e8daf16593.jpg");
                    break;

                case 1:
                    label2.Text = "Год коровы!";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\qrtiti\\Desktop\\fd.jpg");
                    break;

                case 2:
                    label2.Text = "Год тигра!";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\qrtiti\\Desktop\\df.jpg");
                    break;

                case 3:
                    label2.Text = "Год зайца!";
                    pictureBox1.Image = Image.FromFile("C:\\Users\\qrtiti\\Desktop\\fdd.jpg");
                    break;

                case 4:
                    label2.Text = "Год дракона!";
                    break;

                case 5:
                    label2.Text = "Год змеи!";
                    break;

                case 6:
                    label2.Text = "Год лошади";
                    break;

                case 7:
                    label2.Text = "Год овцы!";
                    break;

                case 8:
                    label2.Text = "Год обезьяны!";
                    break;

                case 9:
                    label2.Text = "Год курицы!";
                    break;

                case 10:
                    label2.Text = "Год собаки!";
                    break;

                case 11:
                    label2.Text = "Год свиньи!";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Зачем ты нажал/a...");
        }
    }
}
