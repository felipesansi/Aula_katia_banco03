namespace TesteConexaoBanco
{
    partial class Tela_Principal
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
            this.Btn_cliente = new System.Windows.Forms.Button();
            this.btn_produto = new System.Windows.Forms.Button();
            this.btn_fornecedor = new System.Windows.Forms.Button();
            this.Painel_menu = new System.Windows.Forms.Panel();
            this.Painel_tela_principal = new System.Windows.Forms.Panel();
            this.Painel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_cliente
            // 
            this.Btn_cliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cliente.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cliente.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_cliente.Location = new System.Drawing.Point(12, 47);
            this.Btn_cliente.Name = "Btn_cliente";
            this.Btn_cliente.Size = new System.Drawing.Size(152, 49);
            this.Btn_cliente.TabIndex = 0;
            this.Btn_cliente.Text = "Cliente";
            this.Btn_cliente.UseVisualStyleBackColor = false;
            this.Btn_cliente.Click += new System.EventHandler(this.Btn_cliente_Click);
            // 
            // btn_produto
            // 
            this.btn_produto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_produto.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produto.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_produto.Location = new System.Drawing.Point(12, 203);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(152, 49);
            this.btn_produto.TabIndex = 1;
            this.btn_produto.Text = "Produto";
            this.btn_produto.UseVisualStyleBackColor = false;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // btn_fornecedor
            // 
            this.btn_fornecedor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fornecedor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fornecedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_fornecedor.Location = new System.Drawing.Point(12, 332);
            this.btn_fornecedor.Name = "btn_fornecedor";
            this.btn_fornecedor.Size = new System.Drawing.Size(152, 49);
            this.btn_fornecedor.TabIndex = 2;
            this.btn_fornecedor.Text = "Fornecdor";
            this.btn_fornecedor.UseVisualStyleBackColor = false;
            // 
            // Painel_menu
            // 
            this.Painel_menu.Controls.Add(this.Btn_cliente);
            this.Painel_menu.Controls.Add(this.btn_fornecedor);
            this.Painel_menu.Controls.Add(this.btn_produto);
            this.Painel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Painel_menu.Location = new System.Drawing.Point(0, 0);
            this.Painel_menu.Name = "Painel_menu";
            this.Painel_menu.Size = new System.Drawing.Size(180, 544);
            this.Painel_menu.TabIndex = 3;
            // 
            // Painel_tela_principal
            // 
            this.Painel_tela_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_tela_principal.Location = new System.Drawing.Point(180, 0);
            this.Painel_tela_principal.Name = "Painel_tela_principal";
            this.Painel_tela_principal.Size = new System.Drawing.Size(805, 544);
            this.Painel_tela_principal.TabIndex = 4;
            // 
            // Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 544);
            this.Controls.Add(this.Painel_tela_principal);
            this.Controls.Add(this.Painel_menu);
            this.Name = "Tela_Principal";
            this.Text = "Tela_Principal";
            this.Painel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_cliente;
        private System.Windows.Forms.Button btn_produto;
        private System.Windows.Forms.Button btn_fornecedor;
        private System.Windows.Forms.Panel Painel_menu;
        private System.Windows.Forms.Panel Painel_tela_principal;
    }
}