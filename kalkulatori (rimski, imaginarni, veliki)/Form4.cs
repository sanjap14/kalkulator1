using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using Singulink.Numerics;

namespace kalkulatori__rimski__imaginarni__veliki_
{
    public partial class FormVeliki : Form
    {
        public FormVeliki()
        {
            InitializeComponent();
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Veliki a = new Veliki();
            textBoxRezultat.Text = a.Zbir(textBoxPrvi.Text, textBoxDrugi.Text);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Veliki a = new Veliki();
            textBoxRezultat.Text = a.Razlika(textBoxPrvi.Text, textBoxDrugi.Text);
        }

        private void textBoxRezultat_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veliki a = new Veliki();
            textBoxRezultat.Text = a.Proizvod(textBoxPrvi.Text, textBoxDrugi.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veliki a = new Veliki();
            textBoxRezultat.Text = a.Kolicnik(textBoxPrvi.Text, textBoxDrugi.Text);
        }

        private void FormVeliki_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    class Veliki
    {
        private BigDecimal a, b;
        public Veliki()
        {

        }
        public Veliki(string a1, string b1)
        {
            a = BigDecimal.Parse(a1);
            b = BigDecimal.Parse(b1);

        }
        public string Zbir(string a1, string b1)
        {
            a = BigDecimal.Parse(a1);
            b = BigDecimal.Parse(b1);
            return (Convert.ToString(a + b));
        }
        public string Razlika(string a1, string b1)
        {
            a = BigDecimal.Parse(a1);
            b = BigDecimal.Parse(b1);
            return (Convert.ToString(a - b));
        }
        public string Proizvod(string a1, string b1)
        {
            a = BigDecimal.Parse(a1);
            b = BigDecimal.Parse(b1);
            return (Convert.ToString(a * b));
        }
        public string Kolicnik(string a1, string b1)
        {
            a = BigDecimal.Parse(a1);
            b = BigDecimal.Parse(b1);
            return (Convert.ToString(a / b));
        }
    }
}