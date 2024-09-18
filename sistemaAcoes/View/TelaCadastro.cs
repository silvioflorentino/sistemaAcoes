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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Ativos.DataCompraAtivo = dateTimePickerCompra.Value;
            Ativos.QtdAtivo = (int) num_Qtd.Value;
            Ativos.TipoAtivo = cbx_Tipo.Text;
            Ativos.NomeAtivo = tbx_Ativo.Text;
            Ativos.PrecoAtivo = Convert.ToDecimal(tbx_Preco.Text);
            Ativos.CustoAtivo = Convert.ToDecimal(tbx_Custo.Text);

            ControllerAtivo controllerAtivo = new ControllerAtivo();
            controllerAtivo.CadastrarAtivo();
        }
    }
}
