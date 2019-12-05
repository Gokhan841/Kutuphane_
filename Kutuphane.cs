using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] turler = { "ask", "pisikolojik", "aksiyon", "dram", "anı", "felsefe", "sanat" };
        string[] kitapad = new string[10];
        string[] yazarad = new string[10];
        int i;
        int a;
        void temizle()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = "";
           
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox4.Items.AddRange(turler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ErrorProvider provider = new ErrorProvider();
            if (textBox1.Text == "")
            {
                provider.SetError(textBox1, "BU ALAN BOŞ BIRAKILAMAZ");
            }
            if (textBox2.Text == "")
            {
                provider.SetError(textBox2, "BU ALAN BOŞ GEÇİLEMEZ");
            }
            listBox1.Items.Add(textBox1.Text+ " /  " + textBox2.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
            textBox2.Focus();
            temizle();
            MessageBox.Show("Kaydınız Eklenmiştir");
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek isteiğiniz kaydı seçiniz");
            }
            listBox1.Items.Remove(listBox1.SelectedItem); 
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen düzenlemek isteiğiniz kaydı seçiniz");
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz alanları yenileyiniz");
                a = listBox1.SelectedIndex;
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Bilgiler Henüz Düzenlenmedi");
            }
            else
            {
                listBox1.Items.Insert(a, textBox1.Text + " / " + textBox2.Text);
                temizle();
                MessageBox.Show("Kaydınız Güncellenmiştir");
            }

        }
    }
}
//https://www.kodlamamerkezi.com/c-net/csharp-listbox-kontrolu-kullanimi/
