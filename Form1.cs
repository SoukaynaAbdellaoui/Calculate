using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        char op;
        double memo;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
           form1.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains(",")== false){
                label1.Text += ",";

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Text+= "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double resultat = 0;
            string[] operation = label1.Text.Split(op);
            switch (op)
            {
                case '+':
                    resultat = double.Parse(operation[0]) + double.Parse(operation[1]);
                    break;
                case '-':
                    resultat = double.Parse(operation[0]) - double.Parse(operation[1]);
                    break;
                case '*':
                    resultat = double.Parse(operation[0]) * double.Parse(operation[1]);
                    break;
                case '/':
                    resultat = double.Parse(operation[0]) / double.Parse(operation[1]);
                    break;
                default:
                    break;
            }
            label1.Text = resultat.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
            op = '+';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "1";
            else
                label1.Text += "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memo = (double.Parse(label1.Text)) * (-1);
            label1.Text = memo.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "2";
            else
                label1.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "3";
            else
                label1.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "4";
            else
                label1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "5";
            else
                label1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "6";
            else
                label1.Text += "6";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "7";
            else
                label1.Text += "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "8";
            else
                label1.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = "9";
            else
                label1.Text += "9";

        }

        private void label1_Click_1(object sender, EventArgs e) => this.Width = panel1_Paint.width;

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text += "*";
            op = '*';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "-";
            op = '-';
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text += "/";
            op = '/';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int longueure = label1.Text.Length - 1;
            string texte = label1.Text;
            label1.Text = " ";
            for (int i = 0; i < longueure; i++)
                label1.Text += texte[i];

        }

        private void button20_Click(object sender, EventArgs e)
        {
            memo = 1/(double.Parse(label1.Text)) ;
            label1.Text = memo.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            memo = Math.Pow((double.Parse(label1.Text)),2);
            label1.Text = memo.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            memo = Math.Sqrt((double.Parse(label1.Text)));
            label1.Text = memo.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
