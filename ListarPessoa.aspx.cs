using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RamboErp.dao;
using System.Web.UI.HtmlControls;

namespace RamboErp
{
    public partial class ListarPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["acao"] = "inserir";

             string url=  HttpContext.Current.Request.Url.AbsoluteUri;
             if (url.Contains("?delete&id="))
             {
                 Int32 posicao = url.IndexOf("=");
                 string valor = url.Substring(posicao + 1);
                 PessoaDao pessoaDao = new PessoaDao();
                 pessoaDao.excluir(valor);
                 Response.Write("<script>alert('Exclusão realizada com sucesso!');</script>");

             }
            geraTabela();
        }

        private void geraTabela()
        {
            HtmlTable tabela = new HtmlTable();
            HtmlTableRow linha;
            HtmlTableCell coluna;
            PessoaDao pessoaDao = new PessoaDao();
            int numero = pessoaDao.buscarPessoas().Count;

            for (int i = 0; i < numero; i++)
            {
                linha = new HtmlTableRow();
               
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getId());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getName());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getTypePerson());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getAddress());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getCity());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getCep());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getState());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getCnpj_cpf());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = Convert.ToString(pessoaDao.buscarPessoas()[i].getDateOfBirth());
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = "<a href='Cadastro.aspx?id="+Convert.ToString(pessoaDao.buscarPessoas()[i].getId())+"'>Alterar</a>";
                    linha.Cells.Add(coluna);
                    coluna = new HtmlTableCell();
                    coluna.InnerHtml = "<a href='ListarPessoa.aspx?delete&id=" + Convert.ToString(pessoaDao.buscarPessoas()[i].getId()) + "'>Excluir</a>";
                    linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);

            }
            Controls.Add(tabela);
        }
    }
}