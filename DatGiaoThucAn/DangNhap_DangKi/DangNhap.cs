namespace DatGiaoThucAn
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DangKy form_signup = new DangKy();
            form_signup.StartPosition = FormStartPosition.CenterParent;
            form_signup.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(this.pass_textbox.UseSystemPasswordChar)
            {
                this.pass_textbox.UseSystemPasswordChar = false;
                this.show_btn.BackgroundImage = new Bitmap(".\\Resources\\eye_2.png");

            }
            else
            {
                this.pass_textbox.UseSystemPasswordChar = true;
                this.show_btn.BackgroundImage = new Bitmap(Application.StartupPath + "\\Resources\\eye.png");
            }

        }

        
    }
}