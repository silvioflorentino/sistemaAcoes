namespace sistemaAcoes.View
{
    partial class TelaPesquisaPorNome
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
            btn_Pesquisar = new Button();
            tbx_NomeAtivo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewAtivos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            tipoAtivo = new DataGridViewTextBoxColumn();
            nomeAtivo = new DataGridViewTextBoxColumn();
            dataCompra = new DataGridViewTextBoxColumn();
            qtdAtivo = new DataGridViewTextBoxColumn();
            precoAtivo = new DataGridViewTextBoxColumn();
            custoAtivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtivos).BeginInit();
            SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pesquisar.Location = new Point(138, 144);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(407, 31);
            btn_Pesquisar.TabIndex = 9;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // tbx_NomeAtivo
            // 
            tbx_NomeAtivo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_NomeAtivo.Location = new Point(258, 93);
            tbx_NomeAtivo.Name = "tbx_NomeAtivo";
            tbx_NomeAtivo.Size = new Size(348, 33);
            tbx_NomeAtivo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 99);
            label2.Name = "label2";
            label2.Size = new Size(173, 21);
            label2.TabIndex = 6;
            label2.Text = "Digite o nome do Ativo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(327, 47);
            label1.TabIndex = 5;
            label1.Text = "Pesquisa por Ativo";
            // 
            // dataGridViewAtivos
            // 
            dataGridViewAtivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtivos.Columns.AddRange(new DataGridViewColumn[] { codigo, tipoAtivo, nomeAtivo, dataCompra, qtdAtivo, precoAtivo, custoAtivo });
            dataGridViewAtivos.Location = new Point(21, 192);
            dataGridViewAtivos.Name = "dataGridViewAtivos";
            dataGridViewAtivos.RowHeadersVisible = false;
            dataGridViewAtivos.Size = new Size(703, 193);
            dataGridViewAtivos.TabIndex = 10;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            // 
            // tipoAtivo
            // 
            tipoAtivo.HeaderText = "Tipo Ativo";
            tipoAtivo.Name = "tipoAtivo";
            // 
            // nomeAtivo
            // 
            nomeAtivo.HeaderText = "Ativo";
            nomeAtivo.Name = "nomeAtivo";
            // 
            // dataCompra
            // 
            dataCompra.HeaderText = "Data da Compra";
            dataCompra.Name = "dataCompra";
            dataCompra.Width = 99;
            // 
            // qtdAtivo
            // 
            qtdAtivo.HeaderText = "QTD";
            qtdAtivo.Name = "qtdAtivo";
            // 
            // precoAtivo
            // 
            precoAtivo.HeaderText = "Preço";
            precoAtivo.Name = "precoAtivo";
            // 
            // custoAtivo
            // 
            custoAtivo.HeaderText = "Custo";
            custoAtivo.Name = "custoAtivo";
            // 
            // TelaPesquisaPorNome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(748, 439);
            Controls.Add(dataGridViewAtivos);
            Controls.Add(btn_Pesquisar);
            Controls.Add(tbx_NomeAtivo);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaPesquisaPorNome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtivos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Pesquisar;
        private TextBox tbx_NomeAtivo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAtivos;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn tipoAtivo;
        private DataGridViewTextBoxColumn nomeAtivo;
        private DataGridViewTextBoxColumn dataCompra;
        private DataGridViewTextBoxColumn qtdAtivo;
        private DataGridViewTextBoxColumn precoAtivo;
        private DataGridViewTextBoxColumn custoAtivo;
    }
}