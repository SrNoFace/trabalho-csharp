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

        private Boolean update = false;
        protected void Page_Load(object sender, EventArgs e)
        {
       
         string url=  HttpContext.Current.Request.Url.AbsoluteUri;
         if (url.Contains("?id="))
         {
             Int32 posicao = url.IndexOf("=");
             Int32 tamanho = url.Length;
             string valor = url.Substring(posicao + 1);

             PessoaDao pessoaDao = new PessoaDao();
             Pessoa pessoa = pessoaDao.buscaPessoaPorId(valor);

             codigo.Value = pessoa.getId().ToString();
             nome.Text = pessoa.getName();
             dataNascimento.Text = pessoa.getDateOfBirth();
             endereco.Text = pessoa.getAddress();
             cidade.Text = pessoa.getCity();
             estado.Text = pessoa.getState();
             cep.Text = pessoa.getCep();
             cpf_cnpj.Text = pessoa.getCnpj_cpf();
             update = true;

         }
         else
         {
             codigo.Value = "0";
         }
         
        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            
            int codigoPessoa = Convert.ToInt32(codigo.Value);
            String nomePessoa = nome.Text;
            String dataPessoa = dataNascimento.Text;
            String enderecoPessoa = endereco.Text;
            String cidadePessoa = cidade.Text;
            String estadoPessoa = estado.Text;
            String cepPessoa = cep.Text;
            String cnpj_cpfPessoa = cpf_cnpj.Text;
  
            try
            {
                
                Pessoa pessoa = new Pessoa(codigoPessoa,nomePessoa, 'F', enderecoPessoa, cidadePessoa, cepPessoa, estadoPessoa, cnpj_cpfPessoa, dataPessoa);
                PessoaDao pessoaDao = new PessoaDao();
                if (!update) pessoaDao.inserir(pessoa);
                else pessoaDao.alterar(pessoa);
                Response.Write("<script>alert('Blz');</script>");
            }catch(Exception ex)
            {
                Response.Write(ex);
            }
    }

        
            
    }
}