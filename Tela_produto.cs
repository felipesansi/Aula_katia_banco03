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
            Cbx_descricao_prod.DataSource = conexao.retorno_tabela("selet * from tb_categoria");
            Cbx_descricao_prod.DisplayMember = "cat_descricao";
            Cbx_descricao_prod.ValueMember = "cat_id";

            
        }
        private void Carregar_tabela()
        {
            Dgv_dados.DataSource = null;
            DataTable dados = conexao.retorno_tabela("select * from tb_categoria");
            Dgv_dados.DataSource= dados;
        }
        private void Tela_produto_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            Carregar_tabela();
        }

        private void btn_atualizar_prod_Click(object sender, EventArgs e)
        {
            string sql = "update tb_produto setprod_nome='" + text_nome_prod.Text + "',prod_descricao ='" + text_descricao_prod.Text + "',prod_categoria=" + Cbx_descricao_prod.SelectedValue + ",prod_valor =" + text_valor_prod.Text+"where prod_codigo ="+text_codigo_prod.Text;
            if (conexao.Executar_sql(sql))
            {
                MessageBox.Show("Atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar");
            }
        }

        private void Btn_excluir_prod_Click(object sender, EventArgs e)
        {
            string sql = "insert into tb_produto values (null,'"+text_nome_prod.Text+ "', '"+text_descricao_prod.Text+"''"+Cbx_descricao_prod.SelectedValue+","+text_valor_prod.Text+ ")";
        }

        private void btn_cadastrar_prod_Click(object sender, EventArgs e)
        {

        }
    }
}
