﻿using AzdımLan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Vize
{
    public partial class frmOkulEkle : Form
    {
        public frmOkulEkle()
        {
            InitializeComponent();
        }


        private void btnOkulEkle_Click(object sender, EventArgs e) 
        {
            try
            {
           
           
       
                tbOkulAd.Clear();      
                MessageBox.Show("Okul Eklendi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Okul Eklenemedi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmOkulEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUyeIslemler uyeIslemlerForm = (frmUyeIslemler)Application.OpenForms["frmUyeIslemler"];
            uyeIslemlerForm.cbUyeOkul.DataSource = null;
            uyeIslemlerForm.cbUyeOkul.Items.Clear();
            uyeIslemlerForm.cbOkullarDoldur();
        }
    }
}
