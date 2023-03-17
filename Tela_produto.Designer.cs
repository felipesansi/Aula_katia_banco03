namespace TesteConexaoBanco
{
    partial class Tela_produto
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
            this.text_codigo_prod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_nome_prod = new System.Windows.Forms.TextBox();
            this.text_descricao_prod = new System.Windows.Forms.TextBox();
            this.text_valor_prod = new System.Windows.Forms.TextBox();
            this.Cbx_descricao_prod = new System.Windows.Forms.ComboBox();
            this.Btn_excluir_prod = new System.Windows.Forms.Button();
            this.btn_cadastrar_prod = new System.Windows.Forms.Button();
            this.btn_atualizar_prod = new System.Windows.Forms.Button();
            this.Dgv_dados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // text_codigo_prod
            // 
            this.text_codigo_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_codigo_prod.Location = new System.Drawing.Point(79, 35);
            this.text_codigo_prod.Name = "text_codigo_prod";
            this.text_codigo_prod.Size = new System.Drawing.Size(94, 26);
            this.text_codigo_prod.TabIndex = 9;
            this.text_codigo_prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_codigo_prod_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descricao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Categoria:";
            // 
            // text_nome_prod
            // 
            this.text_nome_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome_prod.Location = new System.Drawing.Point(79, 93);
            this.text_nome_prod.Name = "text_nome_prod";
            this.text_nome_prod.Size = new System.Drawing.Size(225, 26);
            this.text_nome_prod.TabIndex = 14;
            // 
            // text_descricao_prod
            // 
            this.text_descricao_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_descricao_prod.Location = new System.Drawing.Point(95, 158);
            this.text_descricao_prod.Name = "text_descricao_prod";
            this.text_descricao_prod.Size = new System.Drawing.Size(209, 26);
            this.text_descricao_prod.TabIndex = 15;
            // 
            // text_valor_prod
            // 
            this.text_valor_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_valor_prod.Location = new System.Drawing.Point(79, 289);
            this.text_valor_prod.Name = "text_valor_prod";
            this.text_valor_prod.Size = new System.Drawing.Size(225, 26);
            this.text_valor_prod.TabIndex = 16;
            // 
            // Cbx_descricao_prod
            // 
            this.Cbx_descricao_prod.FormattingEnabled = true;
            this.Cbx_descricao_prod.Location = new System.Drawing.Point(95, 229);
            this.Cbx_descricao_prod.Name = "Cbx_descricao_prod";
            this.Cbx_descricao_prod.Size = new System.Drawing.Size(209, 21);
            this.Cbx_descricao_prod.TabIndex = 17;
            // 
            // Btn_excluir_prod
            // 
            this.Btn_excluir_prod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_excluir_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_excluir_prod.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_excluir_prod.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_excluir_prod.Location = new System.Drawing.Point(187, 351);
            this.Btn_excluir_prod.Name = "Btn_excluir_prod";
            this.Btn_excluir_prod.Size = new System.Drawing.Size(140, 39);
            this.Btn_excluir_prod.TabIndex = 19;
            this.Btn_excluir_prod.Text = "Excluir";
            this.Btn_excluir_prod.UseVisualStyleBackColor = false;
            this.Btn_excluir_prod.Click += new System.EventHandler(this.Btn_excluir_prod_Click);
            // 
            // btn_cadastrar_prod
            // 
            this.btn_cadastrar_prod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cadastrar_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar_prod.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar_prod.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cadastrar_prod.Location = new System.Drawing.Point(11, 351);
            this.btn_cadastrar_prod.Name = "btn_cadastrar_prod";
            this.btn_cadastrar_prod.Size = new System.Drawing.Size(140, 39);
            this.btn_cadastrar_prod.TabIndex = 18;
            this.btn_cadastrar_prod.Text = "Cadastrar";
            this.btn_cadastrar_prod.UseVisualStyleBackColor = false;
            this.btn_cadastrar_prod.Click += new System.EventHandler(this.btn_cadastrar_prod_Click);
            // 
            // btn_atualizar_prod
            // 
            this.btn_atualizar_prod.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_atualizar_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar_prod.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_prod.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_atualizar_prod.Location = new System.Drawing.Point(344, 351);
            this.btn_atualizar_prod.Name = "btn_atualizar_prod";
            this.btn_atualizar_prod.Size = new System.Drawing.Size(140, 39);
            this.btn_atualizar_prod.TabIndex = 20;
            this.btn_atualizar_prod.Text = "Atualizar";
            this.btn_atualizar_prod.UseVisualStyleBackColor = false;
            this.btn_atualizar_prod.Click += new System.EventHandler(this.btn_atualizar_prod_Click);
            // 
            // Dgv_dados
            // 
            this.Dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_dados.Location = new System.Drawing.Point(12, 413);
            this.Dgv_dados.Name = "Dgv_dados";
            this.Dgv_dados.Size = new System.Drawing.Size(741, 168);
            this.Dgv_dados.TabIndex = 21;
            // 
            // Tela_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 584);
            this.Controls.Add(this.Dgv_dados);
            this.Controls.Add(this.btn_atualizar_prod);
            this.Controls.Add(this.Btn_excluir_prod);
            this.Controls.Add(this.btn_cadastrar_prod);
            this.Controls.Add(this.Cbx_descricao_prod);
            this.Controls.Add(this.text_valor_prod);
            this.Controls.Add(this.text_descricao_prod);
            this.Controls.Add(this.text_nome_prod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_codigo_prod);
            this.Controls.Add(this.label4);
            this.Name = "Tela_produto";
            this.Text = "Tela_produto";
            this.Load += new System.EventHandler(this.Tela_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_codigo_prod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_nome_prod;
        private System.Windows.Forms.TextBox text_descricao_prod;
        private System.Windows.Forms.TextBox text_valor_prod;
        private System.Windows.Forms.ComboBox Cbx_descricao_prod;
        private System.Windows.Forms.Button Btn_excluir_prod;
        private System.Windows.Forms.Button btn_cadastrar_prod;
        private System.Windows.Forms.Button btn_atualizar_prod;
        private System.Windows.Forms.DataGridView Dgv_dados;
    }
}