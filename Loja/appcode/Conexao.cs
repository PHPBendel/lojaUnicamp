using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Conexao
/// </summary>
public static class Conexao
{
	
    public static SqlConnection connection()
    {
        try
        {
            //Instância o sqlconnection com a string de conexão.
            string strConexao = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection sqlconnection = new SqlConnection(strConexao);


            //Verifica se a conexão esta fechada.
            if (sqlconnection.State == ConnectionState.Closed)
            {
                //Abre a conexão.
                sqlconnection.Open();
            }

            //Retorna o sqlconnection.
            return sqlconnection;
        }
        catch (SqlException ex)
        {
            throw ex;
        }

    }

}