using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteConexaoBanco
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }
        Form tela_atual = new Form();
        
        private void Abrir_janela (Form janela_filha)
        {

            tela_atual = janela_filha;
            janela_filha.TopLevel = false;
            janela_filha.FormBorderStyle = FormBorderStyle.None;
            janela_filha.Dock = DockStyle.Fill;
            Painel_tela_principal.Controls.Add(janela_filha);
            janela_filha.Show();
        }
        private void Btn_cliente_Click(object sender, EventArgs e)
        {
            Abrir_janela(new Tela_Cliente());
            
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            Abrir_janela(new Tela_produto());
        }
    }
}
