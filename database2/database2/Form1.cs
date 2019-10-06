using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;

namespace database2
{
    public partial class Form1 : Form
    {
        OleDbConnection vcon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Github\CS\database2\database2\data_pass.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vcon.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vsql = string.Format("insert into user_pass values('{0}','{1}')", textBox1.Text, textBox2.Text);
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            vcom.ExecuteNonQuery();
            MessageBox.Show("Data stored successfully");
            vcom.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vsql = "select * from user_pass";
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds, "res");
            dataGridView1.DataSource = vds.Tables["res"];
            vda.Dispose();
            vcom.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string vsql = string.Format("select pass from user_pass where username = '{0}'", textBox3.Text);
            OleDbCommand vcom = new OleDbCommand(vsql, vcon);
            DataSet vds = new DataSet();
            OleDbDataAdapter vda = new OleDbDataAdapter(vcom);
            vda.Fill(vds,"res");
            dataGridView1.DataSource = vds.Tables["res"];
            try
            {
                label3.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                label3.Text = "kosong";
            }
            vda.Dispose();
            vcom.Dispose();
        }
    }
}
