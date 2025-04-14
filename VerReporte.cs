using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VerReporte : Form
    {
        public VerReporte()
        {
            InitializeComponent();
        }

        private void VerReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetAlmacen.ExistAlmacen' Puede moverla o quitarla según sea necesario.
            this.existAlmacenTableAdapter.Fill(this.dBDataSetAlmacen.ExistAlmacen);

            this.reportViewer1.RefreshReport();
        }
    }
}
