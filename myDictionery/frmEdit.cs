using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myDictionery
{
    public partial class frmEdit : Form
    {
        mianForm formMain;
        public frmEdit()
        {
            InitializeComponent();
        }
        public frmEdit(mianForm minaform)
        {
            InitializeComponent();
            formMain = minaform;
            txtFarsi.Text = formMain.form1TxtPersian;
            txtEnglish.Text = formMain.form1TxtEnglish;
            txtFarsi.Focus();
            txtFarsi.SelectAll();
           
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApplay_Click(object sender, EventArgs e)
        {
            if(txtFarsi.Text.Length <= 0)
            {
                MessageBox.Show("معادل فارسی را کامل کنید");
                return;
            }
            allMetods allM = new allMetods();
            allM.upDate(txtEnglish.Text, txtFarsi.Text, formMain.connection, "TblDic");
            this.Close();

        }
    }
}
