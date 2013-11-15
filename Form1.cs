using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            textBox23.Text = "0";
            textBox24.Text = "0";
            textBox25.Text = "0";
            textBox26.Text = "0";
            textBox27.Text = "0";
            textBox28.Text = "0";
            textBox29.Text = "0";
            textBox30.Text = "0";
            textBox31.Text = "0";
            textBox32.Text = "0";

            label36.Text = "";
            label37.Text = "";
            label38.Text = "";

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label36.Text = textBox1.Text;  

            int sum1 = int.Parse(textBox1.Text);

            int day1 = int.Parse(textBox2.Text);
            int day2 = int.Parse(textBox3.Text);
            int day3 = int.Parse(textBox4.Text);
            int day4 = int.Parse(textBox5.Text);
            int day5 = int.Parse(textBox6.Text);
            int day6 = int.Parse(textBox7.Text);
            int day7 = int.Parse(textBox8.Text);
            int day8 = int.Parse(textBox9.Text);
            int day9 = int.Parse(textBox10.Text);
            int day10 = int.Parse(textBox11.Text);
            int day11 = int.Parse(textBox12.Text);
            int day12 = int.Parse(textBox13.Text);
            int day13 = int.Parse(textBox14.Text);
            int day14 = int.Parse(textBox15.Text);
            int day15 = int.Parse(textBox16.Text);
            int day16 = int.Parse(textBox17.Text);
            int day17 = int.Parse(textBox18.Text);
            int day18 = int.Parse(textBox19.Text);
            int day19 = int.Parse(textBox20.Text);
            int day20 = int.Parse(textBox21.Text);
            int day21 = int.Parse(textBox22.Text);
            int day22 = int.Parse(textBox23.Text);
            int day23 = int.Parse(textBox24.Text);
            int day24 = int.Parse(textBox25.Text);
            int day25 = int.Parse(textBox26.Text);
            int day26 = int.Parse(textBox27.Text);
            int day27 = int.Parse(textBox28.Text);
            int day28 = int.Parse(textBox29.Text);
            int day29 = int.Parse(textBox30.Text);
            int day30 = int.Parse(textBox31.Text);
            int day31 = int.Parse(textBox32.Text);

            int sum2 = 0;

            sum2 = day1 +  day3 + day4 + day5 + day6 + day7 + day8 + day9 + day10 + day11 + day12 + day13 + day14 + day15 + day16 + day17 + day18
                   + day19 + day20 + day21 + day22 + day23 + day24 + day25 + day26 + day27 + day28 + day29 + day30 + day31;

            int sum3 = 0;

            sum3 = sum1 - sum2;

            this.label37.Text = sum2.ToString();
            this.label38.Text = sum3.ToString();
        }



    }
}
