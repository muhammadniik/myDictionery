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

    public partial class mianForm : Form
    {
        public string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Asus\Desktop\Dictionery _project\myDictionery\myDictionery\dicDatabase.mdf;Integrated Security=True";
        allMetods allmetod = new allMetods();
        CurrencyManager cr;
        public string form1TxtEnglish;
        public string form1TxtPersian;

        DataSet dataS = new DataSet();

        public mianForm()
        {
            InitializeComponent();
        }

        private void mianForm_Load(object sender, EventArgs e)
        {
            setDatagridViwe();
            dataGridView1_CellClick(null, null);

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr = (CurrencyManager)this.BindingContext[dataS, "T1"];
            cr.Position = dataGridView1.CurrentCell.RowIndex;

            txtFarsi.DataBindings.Clear();
            txtFarsi.DataBindings.Add("Text", dataS, "T1.Persan");

        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1_CellClick(null, null);
        }

        private void txtEnglish_KeyUp(object sender, KeyEventArgs e)
        {

            setDatagridViwe();

        }


        private void setDatagridViwe()
        {
            dataS.Clear();
            allmetod.fillGrid(connection, "TblDic", dataS, "T1", txtEnglish.Text, "EnglishWord");
            //dataGridView1.Columns[0].DataGridView.DataBindings.Add("DataSource", dataS, "T1.EnglishWord");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("DataSource", dataS, "T1");
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[0].Width = dataGridView1.Width;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Height = 30;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedCells.Count > 0)
            {
                GetTexts();
                frmEdit _frmEdit = new frmEdit(this);

               
               _frmEdit.ShowDialog();
                setDatagridViwe();



            }

        }

        public void GetTexts()
        {

            form1TxtEnglish = dataGridView1.SelectedCells[0].Value.ToString();
            form1TxtPersian = txtFarsi.Text;
        }
    }
}
