using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TABLA_PRODUCTOS
{
    public partial class Form1 : Form
    {
        void cargartabla()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_listaproductos", varpublic.cadconex); 
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
            da.Dispose();
        }
        void rellenacombo() 
        { 
            SqlDataAdapter da = new SqlDataAdapter("Sp_listacategorias", varpublic.cadconex); 
            DataTable dt = new DataTable(); 
            da.Fill(dt); 
            cmbcategoria.DataSource = dt; 
            cmbcategoria.DisplayMember = "categoryname"; 
            cmbcategoria.ValueMember = "categoryid"; 
            da.Dispose(); 
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rellenacombo(); 
            cargartabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try 
            { 
                txtcodigo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value); 
                txtnomprod.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value); 
                cmbcategoria.SelectedValue = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value); 
                txtprecio.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value); 
                txtstock.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value); 
            } 
            catch 
            { 

            }
        }
    }
}
