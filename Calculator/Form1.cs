using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String op;

        bool opClicked = false;

        double value1, value2;

        public Form1()
        {
            InitializeComponent();
        }

        private void num_clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (answer_box.Text == "0" || opClicked == true)
            {
                answer_box.Clear();
                opClicked = false;
            }

            answer_box.Text += b.Text;
        }

        private void op_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            value1 = Double.Parse(answer_box.Text);
            opClicked = true;
            op = b.Text; 
            answer_box.Text = "";
            answer_box.Text += b.Text;
        }

        private void equals_clicked(object sender, EventArgs e)
        {
            value2 = Double.Parse(answer_box.Text);

            answer_box.Text = "";

            switch (op)
            {
                case "+":
                    answer_box.Text = (value1 + value2).ToString();
                    break;
                
                case "-":
                    answer_box.Text = (value1 - value2).ToString();
                    break;
                
                case "X":
                    answer_box.Text = (value1 * value2).ToString();
                    break;
                
                case "/":
                    answer_box.Text = (value1 / value2).ToString();
                    break;
                
                default:
                    answer_box.Text = "0";
                    value1 = 0;
                    value2 = 0;
                    break;
            }
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            answer_box.Text = "0";
        }

        private void clear_screen_clicked(object sender, EventArgs e)
        {
            answer_box.Text = "0";
            value1 = 0;
            value2 = 0;
        }
    }
}
