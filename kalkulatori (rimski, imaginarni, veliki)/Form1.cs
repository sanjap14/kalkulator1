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
    public partial class Form1 : Form
    {
        FormRimski formRimski = new FormRimski();
        FormKompleksni formKompleksni = new FormKompleksni();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formRimski.ShowDialog();
        }

        private void buttonKompleksni_Click(object sender, EventArgs e)
        {
            formKompleksni.ShowDialog();
        }
    }
}
