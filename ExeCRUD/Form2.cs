using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRDataSet.Alamat' table. You can move, or remove it, as needed.
            this.alamatTableAdapter.Fill(this.cRDataSet.Alamat);
            // TODO: This line of code loads data into the 'cRDataSet.Jenis_Kelamin' table. You can move, or remove it, as needed.
            this.jenis_KelaminTableAdapter.Fill(this.cRDataSet.Jenis_Kelamin);
            // TODO: This line of code loads data into the 'cRDataSet.Nama' table. You can move, or remove it, as needed.
            this.namaTableAdapter.Fill(this.cRDataSet.Nama);
            // TODO: This line of code loads data into the 'crudDataSet.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.crudDataSet.data);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }
    }
}
