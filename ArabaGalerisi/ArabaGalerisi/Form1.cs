using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaGalerisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Galeri galeri = new Galeri();

        private void EkranTemizle()
        {
            txtMarka.Text = txtModel.Text = txtRenk.Text = "";
            txtMarka.Focus();
        }
        private void BtnEkle_Click(object sender, EventArgs e)  
        {
            try
            {
                Araba araba = new Araba();
                araba.Marka = txtMarka.Text;
                araba.Model = Convert.ToInt16(txtModel.Text);
                araba.Renk = txtRenk.Text;
                galeri.ArabaEkle(araba);
                EkranTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            txtArabalar.Text = galeri.ArabalariListele();
            dgwArabalar.DataSource = galeri.ArabaListesiVer();
        }
    }
}
