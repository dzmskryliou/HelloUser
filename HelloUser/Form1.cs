namespace HelloUser
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloWorld helloWorld = new HelloWorld();
            string username = textBox1.Text;
            string message = helloWorld.HelloMessage(username);
            MessageBox.Show(message, "Hello User");
        }
    }
}
