using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Solicitar : Form
    {
        protected SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-0624BL6;Initial Catalog=inventarioDB;Integrated Security=True");
        private SqlCommand cmd;
        public string consulta;
        public Solicitar()
        {
            InitializeComponent();
            llena_tabla();
        }

        private void Solicitar_Load(object sender, EventArgs e)
        {
            llena_tabla();
        }
        public void llena_tabla()
        {
            string consulta = "select * from almacen";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "NOMBRE";
            dataGridView2.Columns[2].HeaderText = "CODIGO";
            dataGridView2.Columns[3].HeaderText = "CANTIDAD";
            dataGridView2.Columns[4].HeaderText = "DETALLES";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // lbnombre.Text = dataGridView2.SelectedCells[1].Value.ToString();
           // label6.Text = dataGridView2.SelectedCells[5].Value.ToString();
            //label8.Text = dataGridView2.SelectedCells[3].Value.ToString();

            //debo idicar la cantidad disponible y marcar stop

            //txtCodigo.Text = dataGridView2.SelectedCells[2].Value.ToString();

        }

        private void btnDar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox1.Text);
           string codigo = label8.Text;
            MessageBox.Show("la cantidad es" + cantidad);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
