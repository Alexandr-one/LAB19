using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB19
{
    public partial class Form1 : Form, Interface
    {
        Form1 rhomb;
        Form1 triangle;
        Form1 figure;
        Dialog dialog;
        public int X
        {
            get { return dialog.X; }
            set { X = dialog.X; }
        }
        public int Y
        {
            get { return dialog.Y; }
            set { Y = dialog.Y; }
        }
        public Form1()
        {
            InitializeComponent();
            dialog = new Dialog();
            dialog.Update += (sender, args) => { textBox1.Text = X.ToString(); textBox2.Text = Y.ToString(); };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Paint();
        }
        public void Paint()
        {
            if(figure != null)
            {
                Graphics g = pictureBox1.CreateGraphics();

                SolidBrush r = new SolidBrush(Color.Yellow);
                SolidBrush t = new SolidBrush(Color.Orange);
                g.Clear(Color.White);
                if(figure == rhomb)
                {                    g.FillPolygon(r, new Point[]      // корпус (трапеция)
                      {
                        new Point(0,Y/2),new Point(X/2,Y),
                        new Point(X/2,Y),new Point(X,Y/2),
                        new Point(X,Y/2),new Point(X/2,0),
                        new Point(X/2,0),new Point(0,Y/2)
                      }
                    );
                }
                else if(figure == triangle)
                {
                    g.FillPolygon(t, new Point[]      // корпус (трапеция)
                      {
                        new Point(X,Y),new Point(0,Y),
                        new Point(0,Y),new Point(X,0),
                        new Point(X,0),new Point(X,Y)
                      }
                    );
                }
            }
            else
            {
                MessageBox.Show("Выберите фигуру.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rhomb = new Form1();
            figure = rhomb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            triangle = new Form1();
            figure = triangle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dialog.Show();
        }
    }
}
