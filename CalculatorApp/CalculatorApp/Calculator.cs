using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Calculator : Form
    {

        public delegate void CalculateEventHandler(Hitung htng);
        public event CalculateEventHandler OnResult;

        private Hitung htng;

        public Calculator(string title) : this()
        {
            this.Text = title;
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            htng = new Hitung();

            htng.NilaiA = Convert.ToInt32(txtNilaiA.Text);
            htng.NilaiB = Convert.ToInt32(txtNilaiB.Text);
            htng.Operasi = cmbOperasi.Text;

            OnResult(htng); 
            txtNilaiA.Clear();
            txtNilaiB.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
