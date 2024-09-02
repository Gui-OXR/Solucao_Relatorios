using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatórios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void listagemMerceariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulários.FrmVisualizaListaFrutas objVisualiza = new Formulários.FrmVisualizaListaFrutas();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();
        }
    }
}
