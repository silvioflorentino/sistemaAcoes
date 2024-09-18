namespace sistemaAcoes.View
{
    partial class TelaHome
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
            menuStrip1 = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            porCódigoToolStripMenuItem = new ToolStripMenuItem();
            porAçõesToolStripMenuItem = new ToolStripMenuItem();
            manipulaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem, cadastrarToolStripMenuItem, pesquisarToolStripMenuItem, manipulaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(725, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(49, 25);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(89, 25);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porCódigoToolStripMenuItem, porAçõesToolStripMenuItem });
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(88, 25);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // porCódigoToolStripMenuItem
            // 
            porCódigoToolStripMenuItem.Name = "porCódigoToolStripMenuItem";
            porCódigoToolStripMenuItem.Size = new Size(157, 26);
            porCódigoToolStripMenuItem.Text = "Por Código";
            // 
            // porAçõesToolStripMenuItem
            // 
            porAçõesToolStripMenuItem.Name = "porAçõesToolStripMenuItem";
            porAçõesToolStripMenuItem.Size = new Size(157, 26);
            porAçõesToolStripMenuItem.Text = "Por Ações";
            // 
            // manipulaToolStripMenuItem
            // 
            manipulaToolStripMenuItem.Name = "manipulaToolStripMenuItem";
            manipulaToolStripMenuItem.Size = new Size(93, 25);
            manipulaToolStripMenuItem.Text = "Manipular";
            manipulaToolStripMenuItem.Click += manipulaToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stock_trading_6525084_1280;
            pictureBox1.Location = new Point(12, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(701, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TelaHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(725, 433);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "TelaHome";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem porCódigoToolStripMenuItem;
        private ToolStripMenuItem porAçõesToolStripMenuItem;
        private ToolStripMenuItem manipulaToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}