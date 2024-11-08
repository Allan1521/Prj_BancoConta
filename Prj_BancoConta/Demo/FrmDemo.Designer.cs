namespace Prj_BancoConta.Demo
{
    partial class FrmDemo
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
            txtNumFormatado = new TextBox();
            txtNumBruto = new TextBox();
            btnFormatar = new Button();
            lblNumBruto = new Label();
            lblNumFormatado = new Label();
            label1 = new Label();
            txtNumFormatado2 = new TextBox();
            SuspendLayout();
            // 
            // txtNumFormatado
            // 
            txtNumFormatado.Location = new Point(68, 181);
            txtNumFormatado.Name = "txtNumFormatado";
            txtNumFormatado.Size = new Size(244, 23);
            txtNumFormatado.TabIndex = 0;
            // 
            // txtNumBruto
            // 
            txtNumBruto.Location = new Point(68, 88);
            txtNumBruto.Name = "txtNumBruto";
            txtNumBruto.Size = new Size(244, 23);
            txtNumBruto.TabIndex = 1;
            // 
            // btnFormatar
            // 
            btnFormatar.Location = new Point(380, 405);
            btnFormatar.Name = "btnFormatar";
            btnFormatar.Size = new Size(75, 23);
            btnFormatar.TabIndex = 2;
            btnFormatar.Text = "Formatar";
            btnFormatar.UseVisualStyleBackColor = true;
            btnFormatar.Click += btnFormata_Click;
            // 
            // lblNumBruto
            // 
            lblNumBruto.AutoSize = true;
            lblNumBruto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumBruto.Location = new Point(68, 60);
            lblNumBruto.Name = "lblNumBruto";
            lblNumBruto.Size = new Size(142, 25);
            lblNumBruto.TabIndex = 3;
            lblNumBruto.Text = "Número Bruto";
            lblNumBruto.Click += lblNumBruto_Click;
            // 
            // lblNumFormatado
            // 
            lblNumFormatado.AutoSize = true;
            lblNumFormatado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumFormatado.Location = new Point(68, 153);
            lblNumFormatado.Name = "lblNumFormatado";
            lblNumFormatado.Size = new Size(189, 25);
            lblNumFormatado.TabIndex = 4;
            lblNumFormatado.Text = "Número Formatado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 238);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 5;
            label1.Text = "Número Formatado";
            // 
            // txtNumFormatado2
            // 
            txtNumFormatado2.Location = new Point(68, 275);
            txtNumFormatado2.Name = "txtNumFormatado2";
            txtNumFormatado2.Size = new Size(244, 23);
            txtNumFormatado2.TabIndex = 6;
            // 
            // FrmDemo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 450);
            Controls.Add(txtNumFormatado2);
            Controls.Add(label1);
            Controls.Add(lblNumFormatado);
            Controls.Add(lblNumBruto);
            Controls.Add(btnFormatar);
            Controls.Add(txtNumBruto);
            Controls.Add(txtNumFormatado);
            Name = "FrmDemo";
            Text = "FrmDemo";
            Load += FrmDemo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumFormatado;
        private TextBox txtNumBruto;
        private Button btnFormatar;
        private Label lblNumBruto;
        private Label lblNumFormatado;
        private Label label1;
        private TextBox txtNumFormatado2;
    }
}