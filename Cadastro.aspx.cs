using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RamboErp.Entidades;
using RamboErp.dao;

namespace RamboErp
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enviar_Click(object sender, EventArgs e)
        {
           
            String nomePessoa = nome.Text;
            String dataPessoa = dataNascimento.Text;
            String enderecoPessoa = endereco.Text;
            String cidadePessoa = cidade.Text;
            String estadoPessoa = estado.Text;
            String cepPessoa = cep.Text;
            String cnpj_cpfPessoa = cpf_cnpj.Text;

            try
            {
                Pessoa pessoa = new Pessoa(nomePessoa, 'F', enderecoPessoa, cidadePessoa, cepPessoa, estadoPessoa, cnpj_cpfPessoa, dataPessoa);
                PessoaDao pessoaDao = new PessoaDao();
                pessoaDao.inserir(pessoa);
                Response.Write("<script>alert('Cadastrou');</script>");
            }catch(Exception ex)
            {
                Response.Write("<script>alert('Houve um erro:);</script>");
            }
    }
            
    }
}