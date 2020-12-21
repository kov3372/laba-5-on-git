using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2_laba_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string arr = textBox1.Text;
            string[] c = arr.Split(' ');

            

            Circle circ = new Circle(int.Parse(c[0]), int.Parse(c[1]), 80, this);
            circ.MoveRight(int.Parse(c[2]));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string arr = textBox2.Text;
            string[] c = arr.Split(' ');

            Square sq = new Square(int.Parse(c[0]), int.Parse(c[1]), 80, this);
            sq.MoveRight(int.Parse(c[2]));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string arr = textBox3.Text;
           
           
                string[] c = arr.Split(' ');
                Rhomb romb = new Rhomb(int.Parse(c[0]), int.Parse(c[1]), int.Parse(c[2]), int.Parse(c[3]), this);
                romb.MoveRight(int.Parse(c[4]));
                  
        }

       
    }
}
