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
        string url =  HttpContext.Current.Request.Url.AbsoluteUri;
        
        protected void Page_Load(object sender, EventArgs e)
        {

         if (url.Contains("?id=") && Session["acao"] != "atualizar")
         {
             Int32 posicao = url.IndexOf("=");
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
             char tipo = pessoa.getTypePerson();

             if (tipo == 'J')
             {
                 ddLType.Items.FindByText("Juridica").Selected = true;
             }

             Session["acao"] = "atualizar";

         }
         
         
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

            char tipoPessoa;

            if (ddLType.SelectedValue == "fisica")
            {
                tipoPessoa = 'F';
            }else 
            {
             tipoPessoa = 'J';
            }


            try
            {
                Pessoa pessoa = new Pessoa(nomePessoa, tipoPessoa, enderecoPessoa, cidadePessoa, cepPessoa, estadoPessoa, cnpj_cpfPessoa, dataPessoa);
                PessoaDao pessoaDao = new PessoaDao();

                String data = pessoa.getDateOfBirth().Substring(0, 10);
                string ano = data.Substring(6, 4);
                string mes = data.Substring(3, 2);
                string dia = data.Substring(0, 2);
              
                pessoa.setDateOfBirth(ano + "-" + mes + "-" + dia);

                
                if (Session["acao"] != "atualizar")
                {

                    Session["acao"] = "atualizar";
                    pessoaDao.inserir(pessoa);
                    Response.Write("<script>alert('O cadastro foi realizo com sucesso...');</script>");
              
                }
                else
                {
                    Session["acao"] = "inserir";
                    
                    int codigoPessoa = Convert.ToInt32(codigo.Value);
                    pessoa.setId(codigoPessoa);
                    pessoaDao.alterar(pessoa);
                    Response.Write("<script>alert('A alteração foi realizada com sucesso...');</script>");
                
                }

                   Response.Write("<script>window.location.href='ListarPessoa.aspx'</script>");
                   Session.Abandon();
            
            }catch(Exception ex)
            {
                Response.Write(ex);
            }
    }

        
            
    }
}