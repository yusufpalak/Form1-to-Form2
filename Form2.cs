using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1toForm2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string ad { get; set; }
        public string soyad { get; set; }
        public string dogumyeri { get; set; }
        public string dogumtarihi { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblAd.Text = ad;
            lblSoyad.Text = soyad;
            lblSehir.Text = dogumyeri;
            lblDogumTarihi.Text = dogumtarihi;
        }
    }
}
