using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormApp
{
    public partial class Form1 : Form
    {
        private object txtNilaiA;
        private object txtNilaiB;

        public Form1()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            LstHasil.Items.Clear();
            LstHasil.Items.Add("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            LstHasil.Items.Add(string.Format("Hasil Penguranagan {0} - {1} = {2}", a, b, Pengurangan(a, b)));
            LstHasil.Items.Add(string.Format("Hasil Perkalian  {0} * {1} = {2}", a, b, Perkalian(a, b)));
            LstHasil.Items.Add(string.Format("Hasil Penambahan {0} / {1} = {2}", a, b, Pembagian(a, b)));
        }
    }
}
