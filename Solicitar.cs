using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Solicitar : Form
    {
        protected SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-0624BL6;Initial Catalog=inventarioDB;Integrated Security=True");

        public Solicitar()
        {
            InitializeComponent();
        }

        private void Solicitar_Load(object sender, EventArgs e)
        {
           string consulta = "select nombre, cantidadT, descripcion from almacen";
           SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar);
           DataTable dt = new DataTable();
           adaptador.Fill(dt);
           dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbnombre.Text = dataGridView2.SelectedCells[0].Value.ToString();
            int cantidad = int.Parse(textBox1.Text);



        }

        private void btnDar_Click(object sender, EventArgs e)
        {

        }
    }
}
