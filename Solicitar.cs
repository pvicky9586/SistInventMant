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
    public partial class Despachar : Form
    {
        protected SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-0624BL6;Initial Catalog=inventarioDB;Integrated Security=True");
   
        public Despachar()
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
                string consulta = "select * from ExistAlmacen";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView2.DataSource = dt;  
            dataGridView2.Columns[0].HeaderText = "NOMBRE";
            dataGridView2.Columns[1].HeaderText = "CODIGO";
            dataGridView2.Columns[2].HeaderText = "CANTIDAD";
            dataGridView2.Columns[3].HeaderText = "DETALLES";
            dataGridView2.Columns[4].Visible = false; //id
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbnombre.Text = dataGridView2.SelectedCells[0].Value.ToString();    //nombre
            label6.Text = dataGridView2.SelectedCells[3].Value.ToString(); //descripcion
            label9.Text = dataGridView2.SelectedCells[2].Value.ToString(); //cantidad
            label3.Text = dataGridView2.SelectedCells[1].Value.ToString();  // codigo

            //debo idicar la cantidad disponible y marcar stop

        }


        private void btnDar_Click(object sender, EventArgs e)
        {
          
            try
            {  
                int cantidad = int.Parse(textBox1.Text);
                string codigo = label3.Text; //label oculto debajo de button
                int cantDisp = int.Parse(label9.Text);
                int cantRest = cantDisp - cantidad;
                DateTime DT = DateTime.Today;
                string fecha = DT.ToString();
                // MessageBox.Show(cantidad);
                conectar.Open();
                string insertar = "INSERT INTO despachos(codigo,cantidad,fecha) " +
                    "VALUES('" + codigo + "','" + cantidad + "','" + fecha + "')";
                SqlCommand comando = new SqlCommand(insertar, conectar);
                comando.ExecuteNonQuery();

                string updat = "UPDATE ExistAlmacen SET cantidadT='" + cantRest + "'" +
                  " WHERE codigo='" + codigo + "'";
                SqlCommand cmd = new SqlCommand(updat, conectar);
                cmd.ExecuteNonQuery();
                label7.Text = "Despacho procesado...";
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string consulta = "select * from ExistAlmacen where codigo = '" + textBox3.Text+ "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].HeaderText = "NOMBRE";
            dataGridView2.Columns[1].HeaderText = "CODIGO";
            dataGridView2.Columns[2].HeaderText = "CANTIDAD";
            dataGridView2.Columns[3].HeaderText = "DETALLES";
            dataGridView2.Columns[4].Visible = false; //id

        }


        public void limpiar()
        {
            lbnombre.Text = "nada seleccionado"; // nombre
            label6.Text = ""; //descripcion
            label9.Text = ""; //cantidad disponible
            label11.Text = ""; // id
            textBox1.Text = ""; // cantidad a solicitar
            textBox3.Text = ""; //buscar
            label3.Text = "";  // codigo


        }

        private void button3_Click(object sender, EventArgs e)
        {
            llena_tabla();
            limpiar();
        }
    }
}
