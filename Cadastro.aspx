﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="RamboErp.Cadastro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
  
    <title>Cadastrar nova pessoa</title>

</head>

<body>
  <div class="container">  
  <form id="contact" action="" method="post" runat="server">
    <h3>Formulario de Cadastro!</h3>
    <h4>Preencha os Campos abaixos conforme solicitado!</h4>
    <fieldset>
    <asp:HiddenField ID="codigo" runat="server" ></asp:HiddenField>
    </fieldset>
    <fieldset>
        <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="nome" runat="server"></asp:TextBox>
    </fieldset>
     Tipo: 
<asp:DropDownList ID="ddLType" runat="server" >
<asp:ListItem Value="fisica">Fisica</asp:ListItem>
<asp:ListItem Value="juridica">Juridica</asp:ListItem>
</asp:DropDownList>
    <fieldset>
        <asp:Label ID="Label2" runat="server" Text="Endereço"></asp:Label>
        <asp:TextBox ID="endereco" runat="server"></asp:TextBox>
    </fieldset>
    <fieldset>
        <asp:Label ID="Label3" runat="server" Text="Cidade"></asp:Label>
        <asp:TextBox ID="cidade" runat="server"></asp:TextBox>
    </fieldset>
    <fieldset>
        <asp:Label ID="Label4" runat="server" Text="Cep"></asp:Label>
        <asp:TextBox ID="cep" runat="server"></asp:TextBox>
    </fieldset>
    <fieldset>
        <asp:Label ID="Label5" runat="server" Text="Estado"></asp:Label>
        <asp:TextBox ID="estado" runat="server"></asp:TextBox>
    </fieldset>
       <fieldset>
        <asp:Label ID="Label6" runat="server" Text="Data Nascimento"></asp:Label>
        <asp:TextBox ID="dataNascimento" runat="server"></asp:TextBox>
    </fieldset>
       <fieldset>
        <asp:Label ID="Label7" runat="server" Text="Cpf ou Cnpj"></asp:Label>
        <asp:TextBox ID="cpf_cnpj" runat="server"></asp:TextBox>
    </fieldset>
    <fieldset>
  
  <asp:Button ID="Button1" runat="server" Text="Cadastrar" onclick="enviar_Click" />
    </fieldset>
  </form>
</div>
<a href="Index.aspx">Voltar</a>
      <style>
          @import url(https://fonts.googleapis.com/css?family=Roboto:400,300,600,400italic);
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  -webkit-font-smoothing: antialiased;
  -moz-font-smoothing: antialiased;
  -o-font-smoothing: antialiased;
  font-smoothing: antialiased;
  text-rendering: optimizeLegibility;
}

body {
  font-family: "Roboto", Helvetica, Arial, sans-serif;
  font-weight: 100;
  font-size: 12px;
  line-height: 30px;
  color: #777;
  background:  #76b852;
}

.container {
  max-width: 400px;
  width: 100%;
  margin: 0 auto;
  position: relative;
}

#Button1
{
     cursor: pointer;
  width: 100%;
  border: none;
  background: #4CAF50;
  color: #FFF;
  margin: 0 0 5px;
  padding: 10px;
  font-size: 15px;
}

#contact input[type="text"],
#contact input[type="email"],
#contact input[type="tel"],
#contact input[type="url"],
#contact textarea,
#contact button[type="submit"] {
  font: 400 12px/16px "Roboto", Helvetica, Arial, sans-serif;
}

#contact {
  background: #F9F9F9;
  padding: 25px;
  margin: 150px 0;
  box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
}

#contact h3 {
  display: block;
  font-size: 30px;
  font-weight: 300;
  margin-bottom: 10px;
}

#contact h4 {
  margin: 5px 0 15px;
  display: block;
  font-size: 13px;
  font-weight: 400;
}

fieldset {
  border: medium none !important;
  margin: 0 0 10px;
  min-width: 100%;
  padding: 0;
  width: 100%;
}

#contact input[type="text"],
#contact input[type="email"],
#contact input[type="tel"],
#contact input[type="url"],
#contact textarea {
  width: 100%;
  border: 1px solid #ccc;
  background: #FFF;
  margin: 0 0 5px;
  padding: 10px;
}

#contact input[type="text"]:hover,
#contact input[type="email"]:hover,
#contact input[type="tel"]:hover,
#contact input[type="url"]:hover,
#contact textarea:hover {
  -webkit-transition: border-color 0.3s ease-in-out;
  -moz-transition: border-color 0.3s ease-in-out;
  transition: border-color 0.3s ease-in-out;
  border: 1px solid #aaa;
}

#contact textarea {
  height: 100px;
  max-width: 100%;
  resize: none;
}

#contact button[type="submit"] {
  cursor: pointer;
  width: 100%;
  border: none;
  background: #4CAF50;
  color: #FFF;
  margin: 0 0 5px;
  padding: 10px;
  font-size: 15px;
}

#contact button[type="submit"]:hover {
  background: #43A047;
  -webkit-transition: background 0.3s ease-in-out;
  -moz-transition: background 0.3s ease-in-out;
  transition: background-color 0.3s ease-in-out;
}

#contact button[type="submit"]:active {
  box-shadow: inset 0 1px 3px rgba(0, 0, 0, 0.5);
}

.copyright {
  text-align: center;
}

#contact input:focus,
#contact textarea:focus {
  outline: 0;
  border: 1px solid #aaa;
}

::-webkit-input-placeholder {
  color: #888;
}

:-moz-placeholder {
  color: #888;
}

::-moz-placeholder {
  color: #888;
}

:-ms-input-placeholder {
  color: #888;
}
      </style>
</body>
</html>