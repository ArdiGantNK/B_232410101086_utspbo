using utspbo.View;

namespace utspbo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          HalamanTUgas halamanTUgas = new HalamanTUgas();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }
    }
}
