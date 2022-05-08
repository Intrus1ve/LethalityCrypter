using AzdımLan;
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
    public partial class frmUyeDuzenle : Form
    {
        public frmUyeDuzenle()
        {
            InitializeComponent();
        }


        Kutuphane_VizeEntities1 model2 = new Kutuphane_VizeEntities1();

        public string okulGelenAd { get; set; }

        public void cbOkullarDoldur2()
        {
       
        }
        private void btnUyeGuncelle_Click(object sender, EventArgs e)  
        {
            try
            {
                int uyeNo = Convert.ToInt32(lblUyeNo.Text); 
      
               
         
                MessageBox.Show("Üye kaydı başarıyla güncellendi.",
                ""
                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();   //İşlem bittiginde form ekranını kapadık.
            }
            catch (Exception)
            {
                MessageBox.Show("Üye kaydı güncellenirken hata oluştu. Bilgileri kontol ediniz",
                 ""
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmUyeDuzenle_Load(object sender, EventArgs e)
        {
            cbOkullarDoldur2();
        }

        private void frmUyeDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUyeIslemler uyeIslemlerForm = (frmUyeIslemler)Application.OpenForms["frmUyeIslemler"];
            uyeIslemlerForm.uyeleriGöster();
        }
    }
}
