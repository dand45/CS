using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DTBS1
{
    public partial class Form1 : Form
    {
        string koneksi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:/Github/CS/DTBS1/Database1.mdb";

        public Form1()
        {
            InitializeComponent();
        }    

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "select* from LAPTOP";
            OleDbConnection con = new OleDbConnection(koneksi);
            con.Open();
            OleDbDataAdapter da = new OleDbCommand(sql,con);
            DataSet ds = new DataSet();
            da.Fill(ds, "LAPTOP");
            con.Close();
            dgvLAPTOP.DataSource = ds.Tables["LAPTOP"].DefaultView;
        }
    }
}
