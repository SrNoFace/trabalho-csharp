using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RamboErp.dao;

namespace RamboErp
{
    public partial class ListarPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void listar_Click(object sender, EventArgs e)
        {
            PessoaDao pessoaDao = new PessoaDao();
            string dados = pessoaDao.buscaDados();
            Response.Write(dados);
        }
    }
}