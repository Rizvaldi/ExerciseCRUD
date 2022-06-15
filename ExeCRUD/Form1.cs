using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExeCRUD
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRDataSet.Jenis_Kelamin' table. You can move, or remove it, as needed.
            this.jenis_KelaminTableAdapter.Fill(this.cRDataSet.Jenis_Kelamin);
            // TODO: This line of code loads data into the 'cRDataSet.Nama' table. You can move, or remove it, as needed.
            this.namaTableAdapter.Fill(this.cRDataSet.Nama);

            // TODO: This line of code loads data into the 'crudDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.crudDataSet.data);

        }

  

        private void button1_Click(object sender, EventArgs e)
        {
           
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 look = new Form2();
            look.Show();
            this.Hide();
        }
    }
}
