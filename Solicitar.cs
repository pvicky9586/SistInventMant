using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        public void limpiar()
        {
            lbnombre.Text = ""; // nombre
            label6.Text = ""; //descripcion
            label9.Text = ""; //cantidad disponible
            label11.Text = ""; // id

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbnombre.Text = dataGridView2.SelectedCells[1].Value.ToString();    //nombre
            label11.Text = dataGridView2.SelectedCells[0].Value.ToString();  // id
            label6.Text = dataGridView2.SelectedCells[4].Value.ToString(); //descripcion
            label9.Text = dataGridView2.SelectedCells[3].Value.ToString(); //cantidad

            //debo idicar la cantidad disponible y marcar stop

        }


        private void btnDar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox1.Text);
            int id = int.Parse(label11.Text); //laber oculto debajo de button
            int id_usuario = 1;
            MessageBox.Show("la cantidad es" + id);
            conectar.Open();
            try
            {
                string insertar = "INSERT INTO pedidos(id_almacen,cantidad,id_usuario) " +
                    "VALUES('" + id + "','" + cantidad + ",'" + id_usuario + "')";
                SqlCommand comando = new SqlCommand(insertar, conectar);
                comando.ExecuteNonQuery();
                if (conectar.State == ConnectionState.Open)
                {
                    MessageBox.Show("se ha registrado el despacho");
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            finally
            {
                conectar.Close();
            }
            // ACTUALIZA REGISTROS y limpia formulario
            llena_tabla();
            limpiar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
