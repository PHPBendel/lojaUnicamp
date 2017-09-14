using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja
{
    public class Usuario
    {
       private string nome, cpf, email, telefone, celular, logradouro, numero, bairro, estado, cidade, senha, dicaSenha, cep;
        

        public string Cep
        {
            get { return cep; }
            set
            { cep = value; }
        }

        public String DicaSenha
        {
            get { return dicaSenha; }
            set
            { dicaSenha = value; }
        }


        public String Senha
        {
            get { return senha; }
            set
            { senha = value; }
        }


        public String Cidade
        {
            get { return cidade; }
            set
            { cidade = value; }
        }

        public String Estado
        {
            get { return estado; }
            set
            { estado = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set
            { bairro = value; }
        }

        public String Numero
        {
            get { return numero; }
            set
            { numero = value; }
        }

        public String Logradouro
        {
            get { return logradouro; }
            set
            { logradouro = value; }
        }

        public String Celular
        {
            get { return celular; }
            set
            { celular = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set
            { telefone = value; }
        }

        public String Cpf
        {
            get { return cpf; }
            set
            { cpf = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Email
        {
            get { return email; }
            set
            { email = value; }
        }


    }


}