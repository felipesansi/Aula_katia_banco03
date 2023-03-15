namespace TesteConexaoBanco
{
    partial class Tela_Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.mask_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // text_nome
            // 
            this.text_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome.Location = new System.Drawing.Point(57, 99);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(178, 26);
            this.text_nome.TabIndex = 1;
            // 
            // mask_CPF
            // 
            this.mask_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_CPF.Location = new System.Drawing.Point(66, 242);
            this.mask_CPF.Mask = "000,000,000-00";
            this.mask_CPF.Name = "mask_CPF";
            this.mask_CPF.Size = new System.Drawing.Size(178, 26);
            this.mask_CPF.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // text_id
            // 
            this.text_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_id.Location = new System.Drawing.Point(46, 35);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(169, 26);
            this.text_id.TabIndex = 7;
            this.text_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone:";
            // 
            // mask_celular
            // 
            this.mask_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_celular.Location = new System.Drawing.Point(78, 174);
            this.mask_celular.Mask = "(00)00000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(157, 26);
            this.mask_celular.TabIndex = 8;
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salvar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_salvar.Location = new System.Drawing.Point(15, 307);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(140, 41);
            this.Btn_salvar.TabIndex = 10;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = false;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_excluir.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_excluir.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_excluir.Location = new System.Drawing.Point(160, 307);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(140, 41);
            this.Btn_excluir.TabIndex = 11;
            this.Btn_excluir.Text = "Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = false;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Tela_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mask_celular);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mask_CPF);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Name = "Tela_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.MaskedTextBox mask_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mask_celular;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_excluir;
    }
}