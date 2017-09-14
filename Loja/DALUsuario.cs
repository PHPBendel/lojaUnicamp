using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Loja
{
    public class DALUsuario
    {
        
        public void inserirUsuario(Usuario usu)
        {
            string query = "";
            query = "select count(*) from usuario where cnpj_cpf=@cpf";
            SqlCommand comm = new SqlCommand(query, Conexao.connection());
            comm.Parameters.AddWithValue("@cpf", usu.Cpf);
            int nroUsuarios = Convert.ToInt32(comm.ExecuteScalar());

            if (nroUsuarios > 0)
                throw new Exception("CPF já cadastrado");

            query = "select count(*) from usuario where email=@email";
            comm = new SqlCommand(query, Conexao.connection());
            comm.Parameters.AddWithValue("@email", usu.Email);
            nroUsuarios = Convert.ToInt32(comm.ExecuteScalar());
            if (nroUsuarios > 0)
                throw new Exception("E-mail já cadastrado");

            

            query = "";
            query = "insert into usuario(nome,cnpj_cpf, email, tipo_usuario, senha) values(@nome, @cnpj_cpf, @email, @tipo_usuario, @senha)";
            comm = new SqlCommand(query, Conexao.connection());
            comm.Parameters.AddWithValue("@nome", usu.Nome);
            comm.Parameters.AddWithValue("@cnpj_cpf", usu.Cpf);
            comm.Parameters.AddWithValue("@email", usu.Email);
            comm.Parameters.AddWithValue("@tipo_usuario", '1');
            comm.Parameters.AddWithValue("@senha", usu.Senha);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir no banco de usuario");
            }


            query = "select id from usuario where email=@email";
            comm = new SqlCommand(query, Conexao.connection());
            comm.Parameters.AddWithValue("@email", usu.Email);

            int idLido = 0;

            SqlDataReader dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read())
            {
                idLido = Convert.ToInt32(dr[0]);
            }


            query = "";
            query = "insert into usuario_endereco(fk_id_usuario, estado, cidade, cep, rua) values(@fk_id_usuario, @estado, @cidade, @cep, @rua)";
            comm = new SqlCommand(query, Conexao.connection());
            comm.Parameters.AddWithValue("@fk_id_usuario", idLido);
            comm.Parameters.AddWithValue("@estado", usu.Estado);
            comm.Parameters.AddWithValue("@cidade", usu.Cidade);
            comm.Parameters.AddWithValue("@cep", usu.Cep);
            comm.Parameters.AddWithValue("@rua", usu.Logradouro);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir no banco de usuario");
            }



            query = "";
            query = "insert into usuario_telefone(fk_id_usuario,telefone) values(@fk_id_usuario, @telefone)";
            comm = new SqlCommand(query, Conexao.connection());
            comm.Parameters.AddWithValue("@fk_id_usuario", idLido);
            comm.Parameters.AddWithValue("@telefone", usu.Telefone);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao inserir no banco de usuario");
            }

            if (usu.Celular != "" && usu.Celular != usu.Telefone)
            {                
                query = "insert into usuario_telefone(fk_id_usuario,telefone) values(@fk_id_usuario, @telefone)";
                comm = new SqlCommand(query, Conexao.connection());
                comm.Parameters.AddWithValue("@fk_id_usuario", idLido);
                comm.Parameters.AddWithValue("@telefone", usu.Celular);

                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("Erro ao inserir no banco de usuario");
                }
            }

           
        }

        
    }


}