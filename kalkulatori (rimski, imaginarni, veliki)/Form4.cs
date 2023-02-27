using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatori__rimski__imaginarni__veliki_
{
    public partial class FormVeliki : Form
    {
        public FormVeliki()
        {
            InitializeComponent();
        }

        static List<int>[] IstiNapred(List<int> A, List<int> B)
        {
            int n = A.Count;
            int m = B.Count;
            int diff = Math.Abs(n - m);

            if (n < m)
            {
                for (var i = 0; i < diff; i++)
                {
                    A.Insert(0, 0);
                }
            }
            else
            {
                for (var i = 0; i < diff; i++)
                {
                    B.Insert(0, 0);
                }
            }

            return new[] { A, B };
        }

        static List<int>[] IstiNazad(List<int> A,
                                           List<int> B)
        {
            int n = A.Count;
            int m = B.Count;
            int diff = Math.Abs(n - m);

            if (n < m)
            {
                for (var i = 0; i < diff; i++)
                {
                    A.Add(0);
                }
            }
            else
            {
                for (var i = 0; i < diff; i++)
                {
                    B.Add(0);
                }
            }

            return new[] { A, B };
        }

        static string Zbir(string s1, string s2)
        {

            int i;

            List<int> Celi1 = new List<int>();
            List<int> Celi2 = new List<int>();
            List<int> Deci1 = new List<int>();
            List<int> Deci2 = new List<int>();

            for (i = s1.Length - 1; i > -1; i--)
            {
                if (s1[i] == '.')
                {
                    break;
                }
                Deci1.Add(s1[i] - '0');
            }

            i--;
            for (; i > -1; i--)
            {
                Celi1.Add(s1[i] - '0');
            }

            for (i = s2.Length - 1; i > -1; i--)
            {
                if (s2[i] == '.')
                {
                    break;
                }
                Deci2.Add(s2[i] - '0');
            }

            i--;
            for (; i > -1; i--)
            {
                Celi2.Add(s2[i] - '0');
            }

            List<int>[] rez1 = IstiNapred(Deci1, Deci2);
            List<int>[] rez2 = IstiNazad(Celi1, Celi2);
            Deci1 = rez1[0];
            Deci2 = rez1[1];
            Celi1 = rez2[0];
            Celi2 = rez2[1];

            int n = Deci1.Count;
            int m = Deci2.Count;
            i = 0;
            int ostatak = 0;

            while (i < n && i < m)
            {
                int sum = Deci1[i] + Deci2[i] + ostatak;

                Deci1[i] = sum % 10;
                ostatak = (sum >= 10) ? 1 : 0;
                i++;
            }

            int N = Celi1.Count;
            int M = Celi2.Count;
            i = 0;

            while (i < N && i < M)
            {
                int sum = Celi1[i] + Celi2[i] + ostatak;
                Celi1[i] = sum % 10;
                ostatak = (sum >= 10) ? 1 : 0;
                i++;
            }

            if (ostatak != 0)
                Celi1.Add(ostatak);

            Celi1.Reverse();
            Deci1.Reverse();

            string celi = string.Join(string.Empty, Celi1);
            string decimalni = string.Join(string.Empty, Deci1);
            return celi + '.' + decimalni;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxRezultat.Text = Zbir(textBoxPrvi.Text, textBoxDrugi.Text);
        }
    }
}
