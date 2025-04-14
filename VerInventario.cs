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
    public partial class VerInventario : Form
    {
        public VerInventario()
        {
            InitializeComponent();
        }

        private void VerInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetInvDespacho.despachos' Puede moverla o quitarla según sea necesario.
            this.despachosTableAdapter.Fill(this.dBDataSetInvDespacho.despachos);
            // TODO: esta línea de código carga datos en la tabla 'dBDataSetInvAlmacen.ExistAlmacen' Puede moverla o quitarla según sea necesario.
            this.existAlmacenTableAdapter.Fill(this.dBDataSetInvAlmacen.ExistAlmacen);

            this.reportViewer1.RefreshReport();
        }
    }
}
