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
    public partial class FrmHasil : Form
    {
        private IList<Hitung> listOfHitung = new List<Hitung>();

        public FrmHasil()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwHasil.View = View.Details;
            lvwHasil.FullRowSelect = true;
            lvwHasil.GridLines = true;

            lvwHasil.Columns.Add("", 10, HorizontalAlignment.Left);
            lvwHasil.Columns.Add("", 300, HorizontalAlignment.Left);
        }

        public int Penjumlahan(int a, int b)
        {
            return a + b;
        }
        public int Pengurangan(int a, int b)
        {
            return a - b;
        }
        public int Perkalian(int a, int b)
        {
            return a * b;
        }
        public int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void Calculator_OnResult(Hitung htng)
        {
            listOfHitung.Add(htng);

            ListViewItem item = new ListViewItem();

            if(htng.Operasi=="Penjumlahan")
            {
                item.SubItems.Add("Hasil Penjumlahan "+ htng.NilaiA.ToString() + " + "+ htng.NilaiB.ToString() + " = "+ Penjumlahan(htng.NilaiA, htng.NilaiB).ToString());
            }
            if (htng.Operasi == "Pengurangan")
            {
                item.SubItems.Add("Hasil Pengurangan " + htng.NilaiA.ToString() + " - " + htng.NilaiB.ToString() + " = " + Pengurangan(htng.NilaiA, htng.NilaiB).ToString());
            }
            if (htng.Operasi == "Perkalian")
            {
                item.SubItems.Add("Hasil Perkalian " + htng.NilaiA.ToString() + " x " + htng.NilaiB.ToString() + " = " + Perkalian(htng.NilaiA, htng.NilaiB).ToString());
            }
            if (htng.Operasi == "Pembagian")
            {
                item.SubItems.Add("Hasil Pembagian " + htng.NilaiA.ToString() + " / " + htng.NilaiB.ToString() + " = " + Pembagian(htng.NilaiA, htng.NilaiB).ToString());
            }
            lvwHasil.Items.Add(item);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator("Calculator");
            calculator.OnResult += Calculator_OnResult;
            calculator.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
