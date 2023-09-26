using System.Windows.Forms;

namespace pr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string h, w;
            w = Convert.ToString(SystemInformation.VirtualScreen.Width);
            h = Convert.ToString(SystemInformation.VirtualScreen.Height);
            txtSizeWorkTable.Text = ('(' + w + "," + h + ')');
            txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            txtSolution.Text = resolution.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            Size s = SystemInformation.PrimaryMonitorSize;
            this.Location = new Point(s.Width - s.Width, s.Height - s.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            Size s = SystemInformation.PrimaryMonitorSize;
            this.Location = new Point(s.Width - this.Width, s.Height - s.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }
            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
        }

        private void btnBottomLeght_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            Size s = SystemInformation.PrimaryMonitorSize;
            this.Location = new Point(s.Width - s.Width, s.Height - this.Height);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (this.Width > 400)
            {
                this.Width = this.Width - 10;
                this.Height = this.Height - 10;
                txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (this.Width < 1229)
            {
                this.Width = this.Width + 10;
                this.Height = this.Height + 10;
                txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
            }
        }

        private void btnStandart_Click(object sender, EventArgs e)
        {
            this.Width = 1229;
            this.Height = 783;

            txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
        }

        private void btn839_Click(object sender, EventArgs e)
        {
            this.Width = 839;
            this.Height = 464;
            txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
        }

        private void btn939_Click(object sender, EventArgs e)
        {
            this.Width = 939;
            this.Height = 564;
            txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            txtSizeForm.Text = ('(' + this.Width + "," + this.Height + ')');
        }

        private void lblSolution_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSizeForm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}