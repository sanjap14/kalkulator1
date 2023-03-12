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
        class Kompleksni
        {
            public double imaginarniDeo, realniDeo, realniDeoStari;
        }
        Kompleksni broj = new Kompleksni();

        public FormKompleksni()
        {
            InitializeComponent();
        }
        private void FormKompleksni_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormKompleksni_Load(object sender, EventArgs e)
        {

        }

        public string text;
        
        private void textBoxKompleksni_KeyUp_1(object sender, KeyEventArgs e)
        {           
            if (e.KeyCode == Keys.I)
            {
                RegexRealniImaginarni(textBoxKompleksni.Text);
                textBoxKompleksni.Text += ')';                
                CursorNaKraj();
                textBoxKomp.Text = broj.realniDeo.ToString() + "  " + broj.imaginarniDeo.ToString() + "i";      
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
            else if (e.KeyCode == Keys.Divide && (textBoxKompleksni.Text.EndsWith("i)/")))
            {
                textBoxKompleksni.Text = "/(";
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
                    broj.realniDeo += Convert.ToInt16(matchRealni.Value);
                    broj.realniDeoStari += Convert.ToInt16(matchRealni.Value);
                }
                else if (text.StartsWith("-("))
                {
                    broj.realniDeo -= Convert.ToInt16(matchRealni.Value);
                    broj.realniDeoStari += Convert.ToInt16(matchRealni.Value);
                }
                else if (text.StartsWith("*("))
                {
                    broj.realniDeo = broj.realniDeo * Convert.ToInt16(matchRealni.Value) - broj.imaginarniDeo * Convert.ToInt16(matchImaginarni.Value); 
                }
                else if(text.StartsWith("/("))
                {
                    if (Convert.ToInt16(matchRealni.Value) == 0 && Convert.ToInt16(matchImaginarni.Value) == 0)
                    {
                        textBoxKomp.Text = "nedefinisano";
                    }
                    else
                    {
                        broj.realniDeo = (broj.realniDeo * Convert.ToInt16(matchRealni.Value) + broj.imaginarniDeo * Convert.ToInt16(matchImaginarni.Value)) / (Math.Pow(Convert.ToInt16(matchRealni.Value), 2) + Math.Pow(Convert.ToInt16(matchImaginarni.Value), 2));
                    }  
                }
            }
            catch (System.FormatException) { }

            //imaginarni
            try
            {
                if (text.StartsWith("+(") || text.StartsWith("("))
                {
                    broj.imaginarniDeo += Convert.ToInt16(matchImaginarni.Value);
                }
                else if (text.StartsWith("-("))
                {
                    broj.imaginarniDeo -= Convert.ToInt16(matchImaginarni.Value);
                }
                else if (text.StartsWith("*("))
                {
                    broj.imaginarniDeo = broj.realniDeoStari * Convert.ToInt16(matchImaginarni.Value) + broj.imaginarniDeo * Convert.ToInt16(matchRealni.Value);    
                }
                else if(text.StartsWith("/("))
                {
                    if (Convert.ToInt16(matchRealni.Value) != 0 && Convert.ToInt16(matchImaginarni.Value) != 0)
                    {
                        broj.imaginarniDeo = (broj.imaginarniDeo * Convert.ToInt16(matchRealni.Value) - broj.realniDeoStari * Convert.ToInt16(matchImaginarni.Value)) / (Math.Pow(Convert.ToInt16(matchRealni.Value), 2) + Math.Pow(Convert.ToInt16(matchImaginarni.Value), 2));
                    }
                }
            }
            catch (System.FormatException)
            {
                if (text.EndsWith("-i"))
                {
                    broj.imaginarniDeo -= 1;
                }
                else
                {
                    broj.imaginarniDeo += 1;
                }
            }
            broj.realniDeoStari = broj.realniDeo;
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

    }
}