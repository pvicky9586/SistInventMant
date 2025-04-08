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

    public partial class Registro : Form
    {
        protected SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-0624BL6;Initial Catalog=inventarioDB;Integrated Security=True");
        public Registro()
        {
            InitializeComponent();
         
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            string consulta = "select * from almacen";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            int tipo = 0;
            int cantidad = int.Parse(txtcantidad.Text);
            string descripcion = txtdescripcion.Text;
            string tipoSelect = cmbtipo.SelectedItem.ToString();
            if (tipoSelect == "Producto")
            {
                tipo = 1;
            }
            if (tipoSelect == "Herramienta")
            {
                tipo = 2;
            }
            //creando codigo...
            string AbvNomb = nombre.Substring(0, 3); //traer los 1eros 3 caract
            string Nomb = AbvNomb.ToUpper(); //pasa A MAYUSCULA           
            string CodCreado = Nomb + "-" + tipo;

            //MessageBox.Show(nombre + " es de tipo " + tipo + ", Codigo: " + CodCreado + " cantidad: " + cantidad + " Descripcion: " + descripcion);
           
            //--------conectar e insertar--------------

            conectar.Open();
            try
            {
                //primero consulto
                string sql = "select * from [inventarioDB].[dbo].[almacen] where codigo = '" + CodCreado + "'";
                SqlCommand cmd = new SqlCommand(sql, conectar);
                if (cmd.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Registro Existe");
                }
                else
                {
                    string insertar = "INSERT INTO almacen(nombre,tipo,codigo,cantidadT,descripcion) VALUES('" + nombre + "'," + tipo + ",'" + CodCreado + "'," + cantidad + ",'" + descripcion + "')";
                    SqlCommand comando = new SqlCommand(insertar, conectar);
                    comando.ExecuteNonQuery();
                    if (conectar.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Registro guardado Exitosamente");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conectar.Close();
            }
            // ACTUALIZA REGISTROS
            string consulta = "select * from almacen";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;




        }


    }
}