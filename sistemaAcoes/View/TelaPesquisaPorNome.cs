using sistemaAcoes.Controller;
using sistemaAcoes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaAcoes.View
{
    public partial class TelaPesquisaPorNome : Form
    {
        public TelaPesquisaPorNome()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Ativos.NomeAtivo = tbx_NomeAtivo.Text;
            dataGridViewAtivos.DataSource = ControllerAtivo.VisualizarNomeAtivo();
            dataGridViewAtivos.Columns[0].Visible = false;
            dataGridViewAtivos.Columns[1].Visible = false;
            dataGridViewAtivos.Columns[2].Visible = false;
            dataGridViewAtivos.Columns[3].Visible = false;
            dataGridViewAtivos.Columns[4].Visible = false;
            dataGridViewAtivos.Columns[5].Visible = false;

            dataGridViewAtivos.Columns[6].HeaderCell.Value = "Código";
            dataGridViewAtivos.Columns[7].HeaderCell.Value = "Tipo Ativo";
            dataGridViewAtivos.Columns[8].HeaderCell.Value = "Ativo";
            dataGridViewAtivos.Columns[9].HeaderCell.Value = "Data Compra";
            dataGridViewAtivos.Columns[10].HeaderCell.Value = "Qtd";
            dataGridViewAtivos.Columns[11].HeaderCell.Value = "Preço";
            dataGridViewAtivos.Columns[12].HeaderCell.Value = "Custos";
        }
    }
}
