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
    public partial class TelaPesquisaPorCodigo : Form
    {
        public TelaPesquisaPorCodigo()
        {
            InitializeComponent();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Ativos.CodigoAtivo = Convert.ToInt32(tbx_CodigoAcao.Text);
            ControllerAtivo controllerAtivo = new ControllerAtivo();
            controllerAtivo.VisualializarCodigoAtivo();

            tbx_TipoAtivo.Text = Ativos.TipoAtivo;
            tbx_Ativo.Text = Ativos.NomeAtivo;
            dateTimePickerCompra.Text = Ativos.DataCompraAtivo.ToString();
            tbx_Preco.Text = Ativos.PrecoAtivo.ToString();
            tbx_Qtd.Text =Ativos.QtdAtivo.ToString();
        }
    }
}
