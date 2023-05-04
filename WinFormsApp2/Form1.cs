namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"it's {DateTime.Now}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}