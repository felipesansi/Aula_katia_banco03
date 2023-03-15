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
    public partial class Tela_Cliente : Form
    {
        public Tela_Cliente()
        {
            InitializeComponent();
        }
         Conexao Conexao = new Conexao();
        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if (text_id.Text =="")
            {
                string Sql = "INSERT INTO tb_cliente (cli_nome, cli_cpf, cli_celular) VALUES ('" + text_nome.Text + "', '" + mask_CPF.Text + "', '" + mask_celular.Text + "')";
                if (Conexao.Executar_sql(Sql))
                {
                    MessageBox.Show("Cadastro feito com sucesso!","Mensagem de Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar...", "Mensagem de erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                string atualizar = "UPDATE tb_cliente SET cli_nome = '"+text_nome.Text+"',cli_cpf ='"+mask_CPF.Text+"',cli_celular ='"+mask_celular.Text +"' where cli_id = " +text_id.Text+";";
                if (Conexao.Executar_sql(atualizar))
                {
                    MessageBox.Show("Dados do cliente "+text_nome.Text+" atualizado com sucesso!","Mesagem de sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar...","Mensagem de erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void text_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sql = "select from * tb_cliente where cli_id =" + text_id.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dados = Conexao.retorno_tabela(sql);
                text_nome.Text = dados.Rows[0]["cli_nome"].ToString();
                mask_CPF.Text = dados.Rows[0]["cli_cpf"].ToString();
                mask_celular.Text = dados.Rows[0]["cli_celular"].ToString();
            }
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            string deletar = "delete from tb_cliente where cli_id =" + text_id.Text + ";";
            if (text_id.Text !="")
            {
                if (Conexao.Executar_sql(deletar))
                {
                    MessageBox.Show("Os dados do cliente "+ text_id.Text+" apgado com sucesso!","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao deletar dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("O ID não foi informado!","Mensagem de erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
    }
}
