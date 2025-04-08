using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registro FormRegistro = new Registro();
            //this.Close();
            FormRegistro.Show();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            Solicitar FormSolicitar = new Solicitar();
            //this.Close();
            FormSolicitar.Show();
        }
    }
}
