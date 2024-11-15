namespace Practica__25_vsed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = 1;
            while (A <= 20)
            {
                listBox1.Items.Add(A);
                A++;
            }
        }
    }
}
