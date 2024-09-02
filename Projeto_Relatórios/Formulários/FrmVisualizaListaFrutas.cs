using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatórios.Formulários
{
    public partial class FrmVisualizaListaFrutas : Form
    {
        public FrmVisualizaListaFrutas()
        {
            InitializeComponent();
        }

        private void FrmVisualizaListaFrutas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db230288DataSet.Frutas'. Você pode movê-la ou removê-la conforme necessário.
            this.frutasTableAdapter.Fill(this.db230288DataSet.Frutas);
            // TODO: esta linha de código carrega dados na tabela 'db230288DataSet.Frutas'. Você pode movê-la ou removê-la conforme necessário.
            this.frutasTableAdapter.Fill(this.db230288DataSet.Frutas);

            this.reportViewer1.RefreshReport();
        }
    }
}
