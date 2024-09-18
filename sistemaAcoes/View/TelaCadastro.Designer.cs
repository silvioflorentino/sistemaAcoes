namespace sistemaAcoes.View
{
    partial class TelaCadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbx_Tipo = new ComboBox();
            tbx_Ativo = new TextBox();
            dateTimePickerCompra = new DateTimePicker();
            num_Qtd = new NumericUpDown();
            tbx_Preco = new TextBox();
            tbx_Custo = new TextBox();
            lbl_ValorTotal = new Label();
            btn_Cancelar = new Button();
            btn_Salvar = new Button();
            ((System.ComponentModel.ISupportInitialize)num_Qtd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 45);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Transação";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(64, 67);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 1;
            label2.Text = "Tipo de ativo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(64, 135);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 2;
            label3.Text = "Ativo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(64, 218);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 3;
            label4.Text = "Data da compra";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(264, 218);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 4;
            label5.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(64, 287);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 5;
            label6.Text = "Preço em R$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(245, 287);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 6;
            label7.Text = "Outros Custos";
            // 
            // cbx_Tipo
            // 
            cbx_Tipo.Font = new Font("Microsoft Sans Serif", 12F);
            cbx_Tipo.FormattingEnabled = true;
            cbx_Tipo.Items.AddRange(new object[] { "Açõe", "Fundos de investimentos", "FIIS", "Criptomoedas", "Stock", "Reit", "BDRS", "ETFS", "ETFS Internacionais", "Tesouro Direto", "Renda Fixa", "Outros" });
            cbx_Tipo.Location = new Point(68, 95);
            cbx_Tipo.Name = "cbx_Tipo";
            cbx_Tipo.Size = new Size(307, 28);
            cbx_Tipo.TabIndex = 7;
            // 
            // tbx_Ativo
            // 
            tbx_Ativo.Font = new Font("Microsoft Sans Serif", 12F);
            tbx_Ativo.Location = new Point(68, 163);
            tbx_Ativo.Name = "tbx_Ativo";
            tbx_Ativo.Size = new Size(307, 26);
            tbx_Ativo.TabIndex = 8;
            // 
            // dateTimePickerCompra
            // 
            dateTimePickerCompra.Font = new Font("Microsoft Sans Serif", 12F);
            dateTimePickerCompra.Location = new Point(68, 246);
            dateTimePickerCompra.Name = "dateTimePickerCompra";
            dateTimePickerCompra.Size = new Size(145, 26);
            dateTimePickerCompra.TabIndex = 9;
            // 
            // num_Qtd
            // 
            num_Qtd.Font = new Font("Microsoft Sans Serif", 12F);
            num_Qtd.Location = new Point(284, 246);
            num_Qtd.Name = "num_Qtd";
            num_Qtd.Size = new Size(53, 26);
            num_Qtd.TabIndex = 10;
            // 
            // tbx_Preco
            // 
            tbx_Preco.Font = new Font("Microsoft Sans Serif", 12F);
            tbx_Preco.Location = new Point(68, 315);
            tbx_Preco.Name = "tbx_Preco";
            tbx_Preco.Size = new Size(100, 26);
            tbx_Preco.TabIndex = 11;
            // 
            // tbx_Custo
            // 
            tbx_Custo.Font = new Font("Microsoft Sans Serif", 12F);
            tbx_Custo.Location = new Point(264, 315);
            tbx_Custo.Name = "tbx_Custo";
            tbx_Custo.Size = new Size(100, 26);
            tbx_Custo.TabIndex = 12;
            tbx_Custo.Text = "0,00";
            // 
            // lbl_ValorTotal
            // 
            lbl_ValorTotal.BackColor = SystemColors.AppWorkspace;
            lbl_ValorTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ValorTotal.Location = new Point(68, 365);
            lbl_ValorTotal.Name = "lbl_ValorTotal";
            lbl_ValorTotal.Size = new Size(307, 35);
            lbl_ValorTotal.TabIndex = 13;
            lbl_ValorTotal.Text = "Valor total: R$ - ";
            lbl_ValorTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = SystemColors.ActiveCaptionText;
            btn_Cancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Cancelar.ForeColor = SystemColors.Control;
            btn_Cancelar.Location = new Point(73, 421);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(125, 54);
            btn_Cancelar.TabIndex = 14;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = SystemColors.ActiveCaptionText;
            btn_Salvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_Salvar.ForeColor = SystemColors.Control;
            btn_Salvar.Location = new Point(245, 421);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(130, 54);
            btn_Salvar.TabIndex = 15;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(445, 508);
            Controls.Add(btn_Salvar);
            Controls.Add(btn_Cancelar);
            Controls.Add(lbl_ValorTotal);
            Controls.Add(tbx_Custo);
            Controls.Add(tbx_Preco);
            Controls.Add(num_Qtd);
            Controls.Add(dateTimePickerCompra);
            Controls.Add(tbx_Ativo);
            Controls.Add(cbx_Tipo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaCadastro";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            ((System.ComponentModel.ISupportInitialize)num_Qtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbx_Tipo;
        private TextBox tbx_Ativo;
        private DateTimePicker dateTimePickerCompra;
        private NumericUpDown num_Qtd;
        private TextBox tbx_Preco;
        private TextBox tbx_Custo;
        private Label lbl_ValorTotal;
        private Button btn_Cancelar;
        private Button btn_Salvar;
    }
}