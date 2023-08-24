namespace GuiaPratico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] nomeCaminho = Directory.GetFiles(@"C:\Users\Automação\Documents\way");

            foreach (string img in nomeCaminho)
            {
                string[] barra = img.Split('\\');
                string[] select = barra[5].Split(',');

                if (comboBox2.Text == select[0])
                {
                    pictureBox2.ImageLocation = @"C:\Users\Automação\Documents\way" + comboBox2.Text + ".jpg";
                    pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Text = string.Empty;
            if (comboBox1.Text == "SGE")
            {
                comboBox2.Items.Add("INTRODUÇÃO");
                comboBox2.Items.Add("CADASTRO PRODUTO");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");

            }
            else if (comboBox1.Text == "JAMSAC")
            {
                comboBox2.Items.Add("INTRODUÇÃO");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");
                comboBox2.Items.Add("");

            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}