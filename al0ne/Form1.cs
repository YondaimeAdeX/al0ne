using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace al0ne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> sayilar = new List<int>();
        List<string> isimler = new List<string>();
        List<bool> durumlar = new List<bool>();
        List<Kisiler> ogrenciler = new List<Kisiler>();
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayilar.Add(int.Parse(textBox1.Text));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isimler.Add(textBox2.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                durumlar.Add(true);
                
            }
            else
            {
                durumlar.Add(false);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kisiler og = new Kisiler();
            og.adi = textBox3.Text;
            og.sinifi = textBox4.Text;
            og.TCno = textBox6.Text;
            og.no = int.Parse(textBox5.Text);
            ogrenciler.Add(og);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in sayilar)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in isimler)
            {
                listBox2.Items.Add(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            foreach (var item in durumlar)
            {
                listBox3.Items.Add(item);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            foreach (var item in ogrenciler)
            {
                listBox4.Items.Add(item.adi+" "+item.sinifi+" "+item.TCno+" "+item.no);
            }
        }
    }
}
