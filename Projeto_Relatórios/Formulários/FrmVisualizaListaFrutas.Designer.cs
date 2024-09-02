
namespace Projeto_Relatórios.Formulários
{
    partial class FrmVisualizaListaFrutas
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
            this.db230288DataSet = new Projeto_Relatórios.db230288DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.frutasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frutasTableAdapter = new Projeto_Relatórios.db230288DataSetTableAdapters.FrutasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db230288DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frutasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // db230288DataSet
            // 
            this.db230288DataSet.DataSetName = "db230288DataSet";
            this.db230288DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Frutas";
            reportDataSource1.Value = this.frutasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Relatórios.Relatórios.RelatorioFrutas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // frutasBindingSource
            // 
            this.frutasBindingSource.DataMember = "Frutas";
            this.frutasBindingSource.DataSource = this.db230288DataSet;
            // 
            // frutasTableAdapter
            // 
            this.frutasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVisualizaListaFrutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmVisualizaListaFrutas";
            this.Text = "FrmVisualizaListaFrutas";
            this.Load += new System.EventHandler(this.FrmVisualizaListaFrutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db230288DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frutasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private db230288DataSet db230288DataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource frutasBindingSource;
        private db230288DataSetTableAdapters.FrutasTableAdapter frutasTableAdapter;
    }
}