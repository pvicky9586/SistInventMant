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
    public partial class ViewReporAlmacen : Form
    {
        public ViewReporAlmacen()
        {
            InitializeComponent();
        }

        private void ViewReporAlmacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetAlmacen.almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.dataSetAlmacen.almacen);

            this.reportViewer1.RefreshReport();
        }
    }
}
