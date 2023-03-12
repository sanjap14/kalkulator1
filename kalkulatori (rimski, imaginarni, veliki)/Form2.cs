using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kalkulatori__rimski__imaginarni__veliki_
{
    public partial class FormRimski : Form
    {
        public FormRimski()
        {
            InitializeComponent();
        }

        public int RimskiUString(string s)
        {
            int zbir = 0;
            Dictionary<char, int> recnikRimski = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
                char trenutniRimski = s[i];
                recnikRimski.TryGetValue(trenutniRimski, out int broj);
                if (i + 1 < s.Length && recnikRimski[s[i + 1]] > recnikRimski[trenutniRimski])
                {
                    zbir -= broj;
                }
                else
                {
                    zbir += broj;
                }
            }
            return zbir;
        }
        public string IntURimski(int num)
        {
            var result = string.Empty;
            var map = new Dictionary<string, int>
            {
                {"M", 1000 },
                {"CM", 900},
                {"D", 500},
                {"CD", 400},
                {"C", 100},
                {"XC", 90},
                {"L", 50},
                {"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1}
            };
            foreach (var pair in map)
            {
                result += string.Join(string.Empty, Enumerable.Repeat(pair.Key, num / pair.Value));
                num %= pair.Value;
            }
            return result;
        }
        private bool ProveriRimskiRegex(string str)
        {
            string strRegex = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            if (Regex.IsMatch(str, strRegex))
                return (true);
            else
                return (false);
        }

        string[] niz = new string[20];
        int brojac = 0;

        private void buttonI_Click(object sender, EventArgs e)
        {
            textBoxRimski.Text += "I";
        }
        private void buttonV_Click(object sender, EventArgs e)
        {
            textBoxRimski.Text += "V";
        }
        private void buttonX_Click(object sender, EventArgs e)
        {
            textBoxRimski.Text += "X";
        }
        private void buttonL_Click(object sender, EventArgs e)
        {
            textBoxRimski.Text += "L";
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxRimski.Text += "C";
        }
        private void buttonD_Click(object sender, EventArgs e)
        {
            textBoxRimski.Text += "D";
        }
        private void buttonM_Click(object sender, EventArgs e)
        {
            textBoxRimski.Text += "M";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            StaviUNiz("+");
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            StaviUNiz("-");
        }
        private void buttonPuta_Click(object sender, EventArgs e)
        {
            StaviUNiz("*");
        }
        private void buttonKroz_Click(object sender, EventArgs e)
        {
            StaviUNiz("/");
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ResetujKalkulator();
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            StaviUNizEnter();
            IzracunajNiz(niz);
        }

        private void StaviUNiz(string operacija)
        {
            string poms;
            string text = textBoxRimski.Text;
            text = text.Remove(0, 1);
            if (ProveriRimskiRegex(text) == true)
            {
                poms = (RimskiUString(text)).ToString();
                niz[brojac] = poms; brojac++; ;
                niz[brojac] = operacija; brojac++;
                textBoxRimski.Text = operacija;
            }
            else
            {
                textBoxrezultat.Text ="BROJ NE POSTOJI";
            }
        }
        private void StaviUNizEnter()
        {
            string poms;
            string text = textBoxRimski.Text;
            text = text.Remove(0, 1);
            if (ProveriRimskiRegex(text) == true)
            {
                poms = (RimskiUString(text)).ToString();
                niz[brojac] = poms; brojac++;
                poms = ""; brojac = 0;
                textBoxRimski.Text = " ";
            }
            else
            {
                textBoxrezultat.Text = "BROJ NE POSTOJI";
            }
        }
        private void IzracunajNiz(string[] niz)
        {
            try
            {
                string izraz = string.Join(string.Empty, niz);
                DataTable dt = new DataTable();
                var rezultat = dt.Compute(izraz, "").ToString();
                double rezultatD = Convert.ToDouble(rezultat);
                if (rezultatD < 0)
                {
                    textBoxrezultat.Text = "BROJ JE MANJI OD NULE";
                }
                else
                {
                    textBoxrezultat.Text = rezultat;
                }
                Math.Round(Convert.ToDouble(rezultat));
                ResetujKalkulator();
                textBoxRimski.Text += IntURimski(Convert.ToInt16(rezultatD));
            }
            catch(Exception ex)
            {
                if (ex is FormatException || ex is SyntaxErrorException)
                textBoxRimski.Text = " ";
            }
        }
        private void ResetujKalkulator()
        {
            Array.Clear(niz, 0, niz.Length); brojac = 0;
            textBoxRimski.Text = " ";
        }
    }
}