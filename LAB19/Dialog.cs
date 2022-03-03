using System;
using System.Windows.Forms;

namespace LAB19
{
    public partial class Dialog : Form
    {
        public int X;
        public int Y;
        public Dialog()
        {
            InitializeComponent();
        }

        public event EventHandler Update;
        private void button1_Click(object sender, EventArgs e)
        {
            X = Convert.ToInt32(textBox1.Text);
            Y = Convert.ToInt32(textBox2.Text);
            Update.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
