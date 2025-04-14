namespace WindowsFormsApp1
{
    partial class VerInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerInventario));
            this.existAlmacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetInvAlmacen = new WindowsFormsApp1.DBDataSetInvAlmacen();
            this.despachosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetInvDespachoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetInvDespacho = new WindowsFormsApp1.DBDataSetInvDespacho();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.existAlmacenTableAdapter = new WindowsFormsApp1.DBDataSetInvAlmacenTableAdapters.ExistAlmacenTableAdapter();
            this.despachosTableAdapter = new WindowsFormsApp1.DBDataSetInvDespachoTableAdapters.despachosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.existAlmacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetInvAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetInvDespachoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetInvDespacho)).BeginInit();
            this.SuspendLayout();
            // 
            // existAlmacenBindingSource
            // 
            this.existAlmacenBindingSource.DataMember = "ExistAlmacen";
            this.existAlmacenBindingSource.DataSource = this.dBDataSetInvAlmacen;
            // 
            // dBDataSetInvAlmacen
            // 
            this.dBDataSetInvAlmacen.DataSetName = "DBDataSetInvAlmacen";
            this.dBDataSetInvAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // despachosBindingSource
            // 
            this.despachosBindingSource.DataMember = "despachos";
            this.despachosBindingSource.DataSource = this.dBDataSetInvDespachoBindingSource;
            // 
            // dBDataSetInvDespachoBindingSource
            // 
            this.dBDataSetInvDespachoBindingSource.DataSource = this.dBDataSetInvDespacho;
            this.dBDataSetInvDespachoBindingSource.Position = 0;
            // 
            // dBDataSetInvDespacho
            // 
            this.dBDataSetInvDespacho.DataSetName = "DBDataSetInvDespacho";
            this.dBDataSetInvDespacho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DBDataSetInvAlmacen";
            reportDataSource1.Value = this.existAlmacenBindingSource;
            reportDataSource2.Name = "DBDataSetInvDespacho";
            reportDataSource2.Value = this.despachosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.ReportInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // existAlmacenTableAdapter
            // 
            this.existAlmacenTableAdapter.ClearBeforeFill = true;
            // 
            // despachosTableAdapter
            // 
            this.despachosTableAdapter.ClearBeforeFill = true;
            // 
            // VerInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.VerInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.existAlmacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetInvAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.despachosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetInvDespachoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetInvDespacho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DBDataSetInvAlmacen dBDataSetInvAlmacen;
        private System.Windows.Forms.BindingSource existAlmacenBindingSource;
        private DBDataSetInvAlmacenTableAdapters.ExistAlmacenTableAdapter existAlmacenTableAdapter;
        private System.Windows.Forms.BindingSource dBDataSetInvDespachoBindingSource;
        private DBDataSetInvDespacho dBDataSetInvDespacho;
        private System.Windows.Forms.BindingSource despachosBindingSource;
        private DBDataSetInvDespachoTableAdapters.despachosTableAdapter despachosTableAdapter;
    }
}