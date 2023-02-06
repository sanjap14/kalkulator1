using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kalkulatori__rimski__imaginarni__veliki_
{
    public partial class FormKompleksni : Form
    {

        public FormKompleksni()
        {
            InitializeComponent();
            //text = textBoxKompleksni.Text;
        }
        private void FormKompleksni_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormKompleksni_Load(object sender, EventArgs e)
        {

        }



        private void textBoxKompleksni_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                RegexRealniImaginarni(textBoxKompleksni.Text);
                textBoxKompleksni.Text += ')';
                CursorNaKraj();
                MessageBox.Show(realniDeo.ToString() + "\n" + imaginarniDeo.ToString());
            }
            if (e.KeyCode == Keys.OemMinus && (textBoxKompleksni.Text.EndsWith("i)-")))
            {
                textBoxKompleksni.Text = "-(";
                CursorNaKraj();
            }
            else if (e.KeyCode == Keys.Oemplus && (textBoxKompleksni.Text.EndsWith("i)+")))
            {
                textBoxKompleksni.Text = "+(";
                CursorNaKraj();
            }
            else if (e.KeyCode == Keys.Multiply && (textBoxKompleksni.Text.EndsWith("i)*")))
            {
                textBoxKompleksni.Text = "*(";
                CursorNaKraj();
            }
        }

        private void RegexRealniImaginarni(string text)
        {
            string patternRealni = @"(?<=\()(.*)(?=(\+|\-))";
            string patternImaginarni = @"[+-]?\d+(?=i)";
            Match matchRealni = Regex.Match(text, patternRealni);
            Match matchImaginarni = Regex.Match(text, patternImaginarni);
            //realni
            try
            {
                if (text.StartsWith("+(") || text.StartsWith("("))
                {
                    realniDeo += Convert.ToInt16(matchRealni.Value);
                    realniDeoStari += Convert.ToInt16(matchRealni.Value);
                }
                else if (text.StartsWith("-("))
                {
                    realniDeo -= Convert.ToInt16(matchRealni.Value);
                    realniDeoStari += Convert.ToInt16(matchRealni.Value);
                }
                else if (text.StartsWith("*("))
                {
                    realniDeo = realniDeo * Convert.ToInt16(matchRealni.Value) - imaginarniDeo * Convert.ToInt16(matchImaginarni.Value);
                }
            }
            catch (System.FormatException) 
            {
                realniDeo = 0;
            }

            //imaginarni
            try
            {
                if (text.StartsWith("+(") || text.StartsWith("("))
                {
                    imaginarniDeo += Convert.ToInt16(matchImaginarni.Value);
                }
                else if (text.StartsWith("-("))
                {
                    imaginarniDeo -= Convert.ToInt16(matchImaginarni.Value);
                }
                else if (text.StartsWith("*("))
                {
                    imaginarniDeo = realniDeoStari * Convert.ToInt16(matchImaginarni.Value) + imaginarniDeo * Convert.ToInt16(matchRealni.Value);
                }
            }
            catch (System.FormatException)
            {
                if (text.EndsWith("-i") && text.StartsWith("-("))
                {
                    imaginarniDeo += 1;
                }
                else if (text.EndsWith("-i") && text.StartsWith("+("))
                {
                    imaginarniDeo -= 1;
                }
                else if (text.EndsWith("+i") && text.StartsWith("-("))
                {
                    imaginarniDeo -= 1;
                }
                else if (text.EndsWith("+i") && text.StartsWith("+("))  //ovde napisi i slucajeve bez plusa +i=i
                {
                    imaginarniDeo += 1;
                }
                else if (text.EndsWith("-i"))
                {
                    imaginarniDeo -= 1;
                }
                else if (text.EndsWith("+i"))
                {
                    imaginarniDeo += 1;
                }
            }
            realniDeoStari = realniDeo;
        }

        private void CursorNaKraj()
        {
            textBoxKompleksni.SelectionStart = textBoxKompleksni.Text.Length;
            textBoxKompleksni.SelectionLength = 0;
        }

        int brojacKlikova = 0;
        private void textBoxKompleksni_MouseClick(object sender, MouseEventArgs e)
        {
            if (brojacKlikova == 0)
            {
                textBoxKompleksni.Text += '(';
                CursorNaKraj();
                brojacKlikova++;
            }
        }

        private void textBoxKompleksni_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

        }
        public int imaginarniDeo, realniDeo, realniDeoStari;
    }
}