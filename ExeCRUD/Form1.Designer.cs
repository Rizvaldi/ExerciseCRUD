
namespace ExeCRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crudDataSet = new ExeCRUD.crudDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTableAdapter = new ExeCRUD.crudDataSetTableAdapters.dataTableAdapter();
            this.cRDataSet = new ExeCRUD.CRDataSet();
            this.cRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namaTableAdapter = new ExeCRUD.CRDataSetTableAdapters.NamaTableAdapter();
            this.jenisKelaminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jenis_KelaminTableAdapter = new ExeCRUD.CRDataSetTableAdapters.Jenis_KelaminTableAdapter();
            this.cRDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisKelaminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.cRDataSetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(182, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "data";
            this.dataBindingSource.DataSource = this.crudDataSet;
            // 
            // crudDataSet
            // 
            this.crudDataSet.DataSetName = "crudDataSet";
            this.crudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(333, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Lihat Data";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(564, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(564, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(261, 135);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(155, 22);
            this.txtAlamat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(99, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // txtJk
            // 
            this.txtJk.Location = new System.Drawing.Point(261, 86);
            this.txtJk.Name = "txtJk";
            this.txtJk.Size = new System.Drawing.Size(100, 22);
            this.txtJk.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(99, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(261, 32);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(155, 22);
            this.txtNama.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(99, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // cRDataSet
            // 
            this.cRDataSet.DataSetName = "CRDataSet";
            this.cRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRDataSetBindingSource
            // 
            this.cRDataSetBindingSource.DataSource = this.cRDataSet;
            this.cRDataSetBindingSource.Position = 0;
            // 
            // namaBindingSource
            // 
            this.namaBindingSource.DataMember = "Nama";
            this.namaBindingSource.DataSource = this.cRDataSetBindingSource;
            // 
            // namaTableAdapter
            // 
            this.namaTableAdapter.ClearBeforeFill = true;
            // 
            // jenisKelaminBindingSource
            // 
            this.jenisKelaminBindingSource.DataMember = "Jenis_Kelamin";
            this.jenisKelaminBindingSource.DataSource = this.cRDataSetBindingSource;
            // 
            // jenis_KelaminTableAdapter
            // 
            this.jenis_KelaminTableAdapter.ClearBeforeFill = true;
            // 
            // cRDataSetBindingSource1
            // 
            this.cRDataSetBindingSource1.DataSource = this.cRDataSet;
            this.cRDataSetBindingSource1.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExeCRUD.Properties.Resources.brady_bellini__hpk_92Crhs_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtJk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisKelaminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private crudDataSet crudDataSet;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private crudDataSetTableAdapters.dataTableAdapter dataTableAdapter;
        private CRDataSet cRDataSet;
        private System.Windows.Forms.BindingSource cRDataSetBindingSource;
        private System.Windows.Forms.BindingSource namaBindingSource;
        private CRDataSetTableAdapters.NamaTableAdapter namaTableAdapter;
        private System.Windows.Forms.BindingSource jenisKelaminBindingSource;
        private CRDataSetTableAdapters.Jenis_KelaminTableAdapter jenis_KelaminTableAdapter;
        private System.Windows.Forms.BindingSource cRDataSetBindingSource1;
    }
}

