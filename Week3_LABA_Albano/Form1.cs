namespace Week3_LABA_Albano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void But_Start(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            FlatStyle st = FlatStyle.Flat;
            btn.FlatStyle = st;
            btn.Visible = false;
            pictureBox1.Visible = false;
            Introduction.Visible = true;
            Ab_School.Visible = false;
            choices.Visible = false;
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Introduction.Visible = false;
            Ab_School.Visible = true;
            choices.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            Introduction.Visible = false;
            Ab_School.Visible = false;
            choices.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Next1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Introduction.Visible = false;
            Ab_School.Visible = false;
            choices.Visible = false;
        }

        private void Ab_School_Enter(object sender, EventArgs e)
        {

        }

        private void Next1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Introduction.Visible = false;
            Ab_School.Visible = false;
            choices.Visible = false;
        }

        private void radioButton138_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton136_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
