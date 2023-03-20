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
    public partial class Tela_produto : Form
    {
        public Tela_produto()
        {
            InitializeComponent();
        }
        Conexao conexao = new Conexao();
        private void CarregarCategoria()
        {
            Cbx_descricao_prod.DataSource = null;
            Cbx_descricao_prod.DataSource = conexao.retorno_tabela("select * from tb_categoria");
            Cbx_descricao_prod.DisplayMember = "cat_descricao";
            Cbx_descricao_prod.ValueMember = "cat_id";

            
        }
        private void Carregar_tabela()
        {
            Dgv_dados.DataSource = null;
            DataTable dados = conexao.retorno_tabela("select * from tb_produto");
           
            if (dados.Rows[0]["prod_codigo"].ToString() != "")
            {
                Dgv_dados.DataSource = dados;
            }
            else
            {
                MessageBox.Show("Não existe produtos cadastrados","Mensagem de erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void Tela_produto_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            Carregar_tabela();
        }

        private void btn_atualizar_prod_Click(object sender, EventArgs e)
        {
            string atualizar = "update tb_produto set prod_nome ='" + text_nome_prod.Text + "' , prod_decricao= '" + text_descricao_prod.Text + "',prod_categoria =" + Cbx_descricao_prod.SelectedValue + ",prod_valor=" + text_valor_prod.Text;

            if (conexao.Executar_sql(atualizar))
            {
                MessageBox.Show("Dados do produto " + text_codigo_prod.Text + " atualizado com sucesso!", "Mesagem de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar...", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_excluir_prod_Click(object sender, EventArgs e)
        {

            string sql = "delete from tb_produto where prod_codigo= "+text_codigo_prod.Text+ ";";
            if (text_codigo_prod.Text != "")
            {
              DialogResult =  MessageBox.Show("Deseja reamente excluir este produto?","Pergunta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
                if ( DialogResult==DialogResult.Yes)
                {
                    if (conexao.Executar_sql(sql))
                    {
                        MessageBox.Show("Os dados foram excluido com sucesso!", "Mensagem de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Carregar_tabela();
                    }

                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Erro ao excluir os dados informados", "Mensagem de erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cadastrar_prod_Click(object sender, EventArgs e)
        {
            string sql = "insert into tb_produto(prod_nome, prod_decricao, prod_categoria, prod_valor) values('"+text_nome_prod.Text+"','"+text_descricao_prod.Text
                +"','"+Cbx_descricao_prod.SelectedValue+"','"+text_valor_prod.Text+ "')";
            if (text_codigo_prod.Text == "")
            {
                if (conexao.Executar_sql(sql))
                {
                    MessageBox.Show("Os dados foram cadastrados com sucesso!", "Mensagem de sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Carregar_tabela();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar os dados informados", "Mensagem de erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
    }
}
