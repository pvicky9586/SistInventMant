namespace WindowsFormsApp1
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetAlmacen = new WindowsFormsApp1.DataSetAlmacen();
            this.dataSetAlmacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDBDataSet = new WindowsFormsApp1.inventarioDBDataSet();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter = new WindowsFormsApp1.inventarioDBDataSetTableAdapters.pedidosTableAdapter();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTableAdapter = new WindowsFormsApp1.DataSetAlmacenTableAdapters.almacenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAlmacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.almacenBindingSource1;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.pedidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetAlmacen
            // 
            this.dataSetAlmacen.DataSetName = "DataSetAlmacen";
            this.dataSetAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAlmacenBindingSource
            // 
            this.dataSetAlmacenBindingSource.DataSource = this.dataSetAlmacen;
            this.dataSetAlmacenBindingSource.Position = 0;
            // 
            // inventarioDBDataSet
            // 
            this.inventarioDBDataSet.DataSetName = "inventarioDBDataSet";
            this.inventarioDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "pedidos";
            this.pedidosBindingSource.DataSource = this.inventarioDBDataSet;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "almacen";
            this.almacenBindingSource.DataSource = this.dataSetAlmacen;
            // 
            // almacenBindingSource1
            // 
            this.almacenBindingSource1.DataMember = "almacen";
            this.almacenBindingSource1.DataSource = this.dataSetAlmacen;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAlmacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetAlmacen dataSetAlmacen;
        private System.Windows.Forms.BindingSource dataSetAlmacenBindingSource;
        private inventarioDBDataSet inventarioDBDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private inventarioDBDataSetTableAdapters.pedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private System.Windows.Forms.BindingSource almacenBindingSource1;
        private DataSetAlmacenTableAdapters.almacenTableAdapter almacenTableAdapter;
    }
}