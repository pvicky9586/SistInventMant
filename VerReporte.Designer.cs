﻿namespace WindowsFormsApp1
{
    partial class VerReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerReporte));
            this.existAlmacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetAlmacen = new WindowsFormsApp1.DBDataSetAlmacen();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.existAlmacenTableAdapter = new WindowsFormsApp1.DBDataSetAlmacenTableAdapters.ExistAlmacenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.existAlmacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // existAlmacenBindingSource
            // 
            this.existAlmacenBindingSource.DataMember = "ExistAlmacen";
            this.existAlmacenBindingSource.DataSource = this.dBDataSetAlmacen;
            // 
            // dBDataSetAlmacen
            // 
            this.dBDataSetAlmacen.DataSetName = "DBDataSetAlmacen";
            this.dBDataSetAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CDDataSetAlmacen";
            reportDataSource1.Value = this.existAlmacenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Reporte.rdlc";
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
            // VerReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerReporte";
            this.Text = "INSUMOS";
            this.Load += new System.EventHandler(this.VerReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.existAlmacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DBDataSetAlmacen dBDataSetAlmacen;
        private System.Windows.Forms.BindingSource existAlmacenBindingSource;
        private DBDataSetAlmacenTableAdapters.ExistAlmacenTableAdapter existAlmacenTableAdapter;
    }
}