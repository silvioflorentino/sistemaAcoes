namespace sistemaAcoes.View
{
    partial class TelaManipula
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
            tbx_CodigoAcao = new TextBox();
            groupBox1 = new GroupBox();
            tbx_Qtd = new TextBox();
            tbx_Preco = new TextBox();
            dateTimePickerCompra = new DateTimePicker();
            tbx_Ativo = new TextBox();
            tbx_TipoAtivo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Alterar = new Button();
            btn_Excluir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Pesquisar.Location = new Point(328, 92);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new Size(94, 41);
            btn_Pesquisar.TabIndex = 9;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += btn_Pesquisar_Click;
            // 
            // tbx_CodigoAcao
            // 
            tbx_CodigoAcao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbx_CodigoAcao.Location = new Point(220, 96);
            tbx_CodigoAcao.Name = "tbx_CodigoAcao";
            tbx_CodigoAcao.Size = new Size(102, 33);
            tbx_CodigoAcao.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_Qtd);
            groupBox1.Controls.Add(tbx_Preco);
            groupBox1.Controls.Add(dateTimePickerCompra);
            groupBox1.Controls.Add(tbx_Ativo);
            groupBox1.Controls.Add(tbx_TipoAtivo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(74, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 216);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // tbx_Qtd
            // 
            tbx_Qtd.Font = new Font("Segoe UI", 12F);
            tbx_Qtd.Location = new Point(224, 161);
            tbx_Qtd.Name = "tbx_Qtd";
            tbx_Qtd.Size = new Size(79, 29);
            tbx_Qtd.TabIndex = 9;
            // 
            // tbx_Preco
            // 
            tbx_Preco.Font = new Font("Segoe UI", 12F);
            tbx_Preco.Location = new Point(70, 161);
            tbx_Preco.Name = "tbx_Preco";
            tbx_Preco.Size = new Size(100, 29);
            tbx_Preco.TabIndex = 8;
            // 
            // dateTimePickerCompra
            // 
            dateTimePickerCompra.Format = DateTimePickerFormat.Short;
            dateTimePickerCompra.Location = new Point(126, 116);
            dateTimePickerCompra.Name = "dateTimePickerCompra";
            dateTimePickerCompra.Size = new Size(98, 27);
            dateTimePickerCompra.TabIndex = 7;
            // 
            // tbx_Ativo
            // 
            tbx_Ativo.Location = new Point(83, 71);
            tbx_Ativo.Name = "tbx_Ativo";
            tbx_Ativo.Size = new Size(220, 27);
            tbx_Ativo.TabIndex = 6;
            // 
            // tbx_TipoAtivo
            // 
            tbx_TipoAtivo.Location = new Point(83, 31);
            tbx_TipoAtivo.Name = "tbx_TipoAtivo";
            tbx_TipoAtivo.Size = new Size(220, 27);
            tbx_TipoAtivo.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(179, 166);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 4;
            label7.Text = "QTD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(15, 161);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 3;
            label6.Text = "Preço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(15, 116);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 2;
            label5.Text = "Data Compra:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(15, 73);
            label8.Name = "label8";
            label8.Size = new Size(49, 21);
            label8.TabIndex = 1;
            label8.Text = "Ativo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(15, 29);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 0;
            label3.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 96);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 6;
            label2.Text = "Digite o Código da Ação:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(435, 47);
            label1.TabIndex = 5;
            label1.Text = "Gerenciamento de Ativos";
            // 
            // btn_Alterar
            // 
            btn_Alterar.Location = new Point(74, 375);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(101, 48);
            btn_Alterar.TabIndex = 10;
            btn_Alterar.Text = "Alterar";
            btn_Alterar.UseVisualStyleBackColor = true;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Location = new Point(298, 375);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(112, 48);
            btn_Excluir.TabIndex = 11;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // TelaManipula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(475, 450);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Alterar);
            Controls.Add(btn_Pesquisar);
            Controls.Add(tbx_CodigoAcao);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaManipula";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Pesquisar;
        private TextBox tbx_CodigoAcao;
        private GroupBox groupBox1;
        private TextBox tbx_Qtd;
        private TextBox tbx_Preco;
        private DateTimePicker dateTimePickerCompra;
        private TextBox tbx_Ativo;
        private TextBox tbx_TipoAtivo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Alterar;
        private Button btn_Excluir;
    }
}