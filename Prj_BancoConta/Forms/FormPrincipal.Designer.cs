namespace Prj_BancoConta
{
    partial class Form_GestãodeContas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            contaToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            pageSetupDialog1 = new PageSetupDialog();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            fecharContaToolStripMenuItem = new ToolStripMenuItem();
            PerfilCorrentistaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { contaToolStripMenuItem, operaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(672, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarContaToolStripMenuItem, fecharContaToolStripMenuItem, PerfilCorrentistaToolStripMenuItem });
            contaToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(83, 34);
            contaToolStripMenuItem.Text = "Conta";
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(127, 34);
            operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(186, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            criarContaToolStripMenuItem.Click += criarContaToolStripMenuItem_Click;
            // 
            // fecharContaToolStripMenuItem
            // 
            fecharContaToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fecharContaToolStripMenuItem.Name = "fecharContaToolStripMenuItem";
            fecharContaToolStripMenuItem.Size = new Size(186, 22);
            fecharContaToolStripMenuItem.Text = "Fechar Conta";
            fecharContaToolStripMenuItem.Click += fecharContaToolStripMenuItem_Click;
            // 
            // PerfilCorrentistaToolStripMenuItem
            // 
            PerfilCorrentistaToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PerfilCorrentistaToolStripMenuItem.Name = "PerfilCorrentistaToolStripMenuItem";
            PerfilCorrentistaToolStripMenuItem.Size = new Size(186, 22);
            PerfilCorrentistaToolStripMenuItem.Text = "Perfil Correntista";
            PerfilCorrentistaToolStripMenuItem.Click += PerfilCorrentistaToolStripMenuItem_Click;
            // 
            // Form_GestãodeContas
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 401);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "Form_GestãodeContas";
            Text = "Gestão de Contas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private PageSetupDialog pageSetupDialog1;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem fecharContaToolStripMenuItem;
        private ToolStripMenuItem PerfilCorrentistaToolStripMenuItem;
    }
}