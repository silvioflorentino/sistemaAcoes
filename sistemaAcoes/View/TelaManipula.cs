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
    public partial class TelaManipula : Form
    {
        public TelaManipula()
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
            tbx_Qtd.Text = Ativos.QtdAtivo.ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            if (tbx_CodigoAcao.Text == "")
            {
                MessageBox.Show("Digite o Código do Ativo");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar as informações do ativo: " + tbx_Ativo.Text + " ? ",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {

                    Ativos.DataCompraAtivo = dateTimePickerCompra.Value;
                    Ativos.QtdAtivo = Convert.ToInt16(tbx_Qtd.Text);
                    Ativos.TipoAtivo = tbx_TipoAtivo.Text;
                    Ativos.NomeAtivo = tbx_Ativo.Text;
                    Ativos.PrecoAtivo = Convert.ToDecimal(tbx_Preco.Text);

                    ControllerAtivo controllerAtivo = new ControllerAtivo();
                    controllerAtivo.AlterarAtivo();
                }
                else
                {
                    dateTimePickerCompra.Value = DateTime.Now;
                    tbx_Qtd.Text = "";
                    tbx_TipoAtivo.Text = "";
                    tbx_Ativo.Text = "";
                    tbx_Preco.Text = "";
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (tbx_CodigoAcao.Text == "")
            {
                MessageBox.Show("Digite o Código do Ativo");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja Excluir as informações do ativo: " + tbx_Ativo.Text + " ? ",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Ativos.CodigoAtivo = Convert.ToInt16(tbx_CodigoAcao.Text);


                    ControllerAtivo controllerAtivo = new ControllerAtivo();
                    controllerAtivo.DeletarAtivo();
                }
                else
                {
                    dateTimePickerCompra.Value = DateTime.Now;
                    tbx_Qtd.Text = "";
                    tbx_TipoAtivo.Text = "";
                    tbx_Ativo.Text = "";
                    tbx_Preco.Text = "";
                }
            }
        }
    }
}
