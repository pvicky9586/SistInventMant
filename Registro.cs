using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Windows.Forms.DialogResult;

namespace WindowsFormsApp1
{

    public partial class Registro : Form
    {
        protected SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-0624BL6;Initial Catalog=inventarioDB;Integrated Security=True");
        private SqlCommand cmd;
        public string consulta;
        public Registro()
        {
            InitializeComponent();
            llena_tabla();
        }

        private void Registro_Load(object sender, EventArgs e)
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
           textBox1.Text = dataGridView2.SelectedCells[1].Value.ToString(); //nombre
           textBox2.Text = dataGridView2.SelectedCells[2].Value.ToString(); //codigo
           textBox3.Text = dataGridView2.SelectedCells[3].Value.ToString(); //cantidad
           textBox4.Text = dataGridView2.SelectedCells[4].Value.ToString(); //descripcion
            label8.Text = dataGridView2.SelectedCells[0].Value.ToString();  // id
            //debo idicar la cantidad disponible y marcar stop
        }

        public void limpiar()
        {
            textBox1.Text=""; // nombre
            textBox2.Text=""; //codigo
            textBox3.Text = ""; //cantidad
            textBox4.Text = ""; // descripcion
            label8.Text = ""; //id oculto debajo de DataGridView

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string codigo = textBox2.Text;
            int cantidad = int.Parse(textBox3.Text);
            string descripcion = textBox4.Text;
            //--------conectar e insertar--------------
            conectar.Open();
            try
            {
                string insertar = "INSERT INTO almacen(nombre,codigo,cantidadT,descripcion) " +
                    "VALUES('" + nombre + "','" + codigo + "'," + cantidad + ",'"+descripcion+"')";
                SqlCommand comando = new SqlCommand(insertar, conectar);
                comando.ExecuteNonQuery();
                if (conectar.State == ConnectionState.Open)
                {
                    MessageBox.Show("Registro guardado con EXITO");
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

        //----ACTUALIZANDO ---

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string codigo = textBox2.Text;
            int cantidad = int.Parse(textBox3.Text);
            string descripcion = textBox4.Text;
            int id = int.Parse(label8.Text);
           
            //--------conectar e insertar--------------
            conectar.Open();
            try
            {

                string updat = "UPDATE almacen SET nombre='" + nombre + "', codigo='" + codigo + "',cantidadT='" + cantidad + "',descripcion='" + descripcion + "'" +
                    " WHERE id='" + id + "'";
                SqlCommand comando = new SqlCommand(updat, conectar);
                comando.ExecuteNonQuery();
                if (conectar.State == ConnectionState.Open)
                {
                    MessageBox.Show("REGISTRO ACTUALIZADO");
                }

            }
            catch (Exception eup)
            {
                MessageBox.Show(eup.Message);
            }
            finally
            {
                conectar.Close();
            }
            // ACTUALIZA REGISTROS y limpia formulario
            llena_tabla();
            limpiar();
        }



        //---------BORRAR -----------
        private void btnBorrar_Click(object sender, EventArgs e)
        {
           // string Confir;
            //MessageBox.Show("Seguro que desea Eliminar el registro", "DataGrid",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //--------conectar e insertar--------------
            conectar.Open();
            try
            {

                string delet = "DELETE FROM almacen WHERE id= '" + label8.Text + "'";
                SqlCommand comando = new SqlCommand(delet, conectar);
                comando.ExecuteNonQuery();
                if (conectar.State == ConnectionState.Open)
                {
                    MessageBox.Show("REGISTRO ELIMINADO");
                }

            }
            catch (Exception exdel)
            {
                MessageBox.Show(exdel.Message);
            }
            finally
            {
                conectar.Close();
            }
            // ACTUALIZA REGISTROS y limpia formulario
            llena_tabla();
            limpiar();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dataGridView2.Columns['id'].Visible = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int indice  = comboBox1.SelectedIndex;
            //lbCategoria.Text = indice.ToString();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings  ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {

        }
        private void buscar_Click(object sender, EventArgs e)
        {
            string consulta = "select * from almacen where codigo = '" + textBox3.Text + "'";
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
    }
}