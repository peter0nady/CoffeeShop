using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int btnUP(string text)
        {
            int x = int.Parse(text);
            x++;
            return x; 
        }
        public int btnDown(string text)
        {
            int x=int.Parse(text);
            x--;
            return x;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if(checkBox1.Checked==true)
            {
                double number = double.Parse(textBox2.Text);
                double price = double.Parse(textBox3.Text);
                sum += number * price;
                richTextBox1.Text += checkBox1.Text + "  " + number + "    " + number * price + "  L.E " +"\r\n";
            }

            if (checkBox2.Checked == true)
            {
                double number = double.Parse(textBox4.Text);
                double price = double.Parse(textBox5.Text);
                sum += number * price;
                richTextBox1.Text += checkBox2.Text + "  " + number + "    " + number * price + "  L.E" +"\r\n";
            }
            if (checkBox3.Checked == true)
            {
                double number = double.Parse(textBox6.Text);
                double price = double.Parse(textBox7.Text);
                sum += number * price;
                richTextBox1.Text += checkBox3.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox4.Checked == true)
            {
                double number = double.Parse(textBox8.Text);
                double price = double.Parse(textBox9.Text);
                sum += number * price;
                richTextBox1.Text += checkBox4.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox5.Checked == true)
            {
                double number = double.Parse(textBox10.Text);
                double price = double.Parse(textBox11.Text);
                sum += number * price;
                richTextBox1.Text += checkBox5.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox6.Checked == true)
            {
                double number = double.Parse(textBox12.Text);
                double price = double.Parse(textBox13.Text);
                sum += number * price;
                richTextBox1.Text += checkBox6.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            

            }
            if (checkBox7.Checked == true)
            {
                double number = double.Parse(textBox14.Text);
                double price = double.Parse(textBox15.Text);
                sum += number * price;
                richTextBox1.Text += checkBox7.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox8.Checked == true)
            {
                double number = double.Parse(textBox16.Text);
                double price = double.Parse(textBox17.Text);
                sum += number * price;
                richTextBox1.Text += checkBox8.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox9.Checked == true)
            {
                double number = double.Parse(textBox18.Text);
                double price = double.Parse(textBox19.Text);
                sum += number * price;
                richTextBox1.Text += checkBox9.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox10.Checked == true)
            {
                double number = double.Parse(textBox20.Text);
                double price = double.Parse(textBox21.Text);
                sum += number * price;
                richTextBox1.Text += checkBox10.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox11.Checked == true)
            {
                double number = double.Parse(textBox22.Text);
                double price = double.Parse(textBox23.Text);
                sum += number * price;
                richTextBox1.Text += checkBox11.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox12.Checked == true)
            {
                double number = double.Parse(textBox25.Text);
                double price = double.Parse(textBox24.Text);
                sum += number * price;
                richTextBox1.Text += checkBox12.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox13.Checked == true)
            {
                double number = double.Parse(textBox27.Text);
                double price = double.Parse(textBox26.Text);
                sum += number * price;
                richTextBox1.Text += checkBox13.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox14.Checked == true)
            {
                double number = double.Parse(textBox29.Text);
                double price = double.Parse(textBox28.Text);
                sum += number * price;
                richTextBox1.Text += checkBox14.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox15.Checked == true)
            {
                double number = double.Parse(textBox31.Text);
                double price = double.Parse(textBox30.Text);
                sum += number * price;
                richTextBox1.Text += checkBox15.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox16.Checked == true)
            {
                double number = double.Parse(textBox33.Text);
                double price = double.Parse(textBox32.Text);
                sum += number * price;
                richTextBox1.Text += checkBox16.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox17.Checked == true)
            {
                double number = double.Parse(textBox35.Text);
                double price = double.Parse(textBox34.Text);
                sum += number * price;
                richTextBox1.Text += checkBox17.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox18.Checked == true)
            {
                double number = double.Parse(textBox37.Text);
                double price = double.Parse(textBox36.Text);
                sum += number * price;
                richTextBox1.Text += checkBox18.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox19.Checked == true)
            {
                double number = double.Parse(textBox39.Text);
                double price = double.Parse(textBox38.Text);
                sum += number * price;
                richTextBox1.Text += checkBox19.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox20.Checked == true)
            {
                double number = double.Parse(textBox41.Text);
                double price = double.Parse(textBox40.Text);
                sum += number * price;
                richTextBox1.Text += checkBox20.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox21.Checked == true)
            {
                double number = double.Parse(textBox43.Text);
                double price = double.Parse(textBox42.Text);
                sum += number * price;
                richTextBox1.Text += checkBox21.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }
            if (checkBox22.Checked == true)
            {
                double number = double.Parse(textBox45.Text);
                double price = double.Parse(textBox44.Text);
                sum += number * price;
                richTextBox1.Text += checkBox22.Text + "  " + number + "    " + number * price + "  L.E" + "\r\n";
            
            }

            richTextBox1.Text += " the Total is :   " + sum+ " L.E \r\n";
            richTextBox1.Text += "Table's Number " + textBox1.Text;
            button1.Enabled = false;
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Click To Create Order ");
            toolTip1.SetToolTip(btnsave, "Click To Save Your Order ");
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox4.Text = "0";
            textBox6.Text = "0";
            textBox8.Text = "0";
            textBox10.Text = "0";
            textBox12.Text = "0";
            textBox14.Text = "0";
            textBox16.Text = "0";
            textBox18.Text = "0";
            textBox20.Text = "0";
            textBox22.Text = "0";
            textBox25.Text = "0";
            textBox27.Text = "0";
            textBox29.Text = "0";
            textBox31.Text = "0";
            textBox33.Text = "0";
            textBox35.Text = "0";
            textBox37.Text = "0";
            textBox39.Text = "0";
            textBox41.Text = "0";
            textBox43.Text = "0";
            textBox45.Text = "0";

            richTextBox1.Text = null;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          int y= btnUP(textBox2.Text);
          textBox2.Text = y.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox2.Text);
            textBox2.Text = y.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox4.Text);
            textBox4.Text = y.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox4.Text);
            textBox4.Text = y.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox6.Text);
            textBox6.Text = y.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox6.Text);
            textBox6.Text = y.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox8.Text);
            textBox8.Text = y.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox8.Text);
            textBox8.Text = y.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int y = btnDown(textBox10.Text);
            textBox10.Text = y.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox10.Text);
            textBox10.Text = y.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox12.Text);
            textBox12.Text = y.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox12.Text);
            textBox12.Text = y.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox14.Text);
            textBox14.Text = y.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox14.Text);
            textBox14.Text = y.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox16.Text);
            textBox16.Text = y.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox16.Text);
            textBox16.Text = y.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox18.Text);
            textBox18.Text = y.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox18.Text);
            textBox18.Text = y.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox20.Text);
            textBox20.Text = y.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox20.Text);
            textBox20.Text = y.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox22.Text);
            textBox22.Text = y.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox22.Text);
            textBox22.Text = y.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox45.Text);
            textBox45.Text = y.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox45.Text);
            textBox45.Text = y.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox43.Text);
            textBox43.Text = y.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox43.Text);
            textBox43.Text = y.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox41.Text);
            textBox41.Text = y.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox41.Text);
            textBox41.Text = y.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox39.Text);
            textBox39.Text = y.ToString();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox39.Text);
            textBox39.Text = y.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox37.Text);
            textBox37.Text = y.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox37.Text);
            textBox37.Text = y.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox35.Text);
            textBox35.Text = y.ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox35.Text);
            textBox35.Text = y.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox33.Text);
            textBox33.Text = y.ToString();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox33.Text);
            textBox33.Text = y.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox31.Text);
            textBox31.Text = y.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox29.Text);
            textBox29.Text = y.ToString();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox29.Text);
            textBox29.Text = y.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox27.Text);
            textBox27.Text = y.ToString();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox27.Text);
            textBox27.Text = y.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox25.Text);
            textBox25.Text = y.ToString();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox25.Text);
            textBox25.Text = y.ToString();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox31.Text);
            textBox31.Text = y.ToString();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            int y = btnUP(textBox1.Text);
            textBox1.Text = y.ToString();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            int y = btnDown(textBox1.Text);
            textBox1.Text = y.ToString();
        }

       
        private void btnsave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files | *.txt; *.Text";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("\r\n"+richTextBox1.Text);
                sw.WriteLine("___________________________________");
                sw.Close();
                fs.Close();
            }
        }

        private void hotDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void coldDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

       
    }
}
