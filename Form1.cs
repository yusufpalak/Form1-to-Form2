﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.ad = textBoxAd.Text;
            frm.soyad = textBoxSoyad.Text;
            frm.dogumyeri = comboBoxSehirler.Text;
            frm.dogumtarihi = dateTimePicker1.Text;
            frm.ShowDialog();
        }
    }
}
