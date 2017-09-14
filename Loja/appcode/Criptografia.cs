using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;


/// <summary>
/// Summary description for Criptografia
/// </summary>
public static class Criptografia
{
	
		//
		// TODO: Add constructor logic here
		//
        public static string Codificar(string entrada)
        {
            TripleDESCryptoServiceProvider tripledescryptoserviceprovider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5cryptoserviceprovider = new MD5CryptoServiceProvider();

            try
            {
                if (entrada.Trim() != "")
                {
                    string myKey = "lavemonegaocheiodepaixao";  //Aqui vc inclui uma chave qualquer para servir de base para cifrar, que deve ser a mesma no método Decodificar
                    tripledescryptoserviceprovider.Key = md5cryptoserviceprovider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(myKey));
                    tripledescryptoserviceprovider.Mode = CipherMode.ECB;
                    ICryptoTransform desdencrypt = tripledescryptoserviceprovider.CreateEncryptor();
                    ASCIIEncoding MyASCIIEncoding = new ASCIIEncoding();
                    byte[] buff = Encoding.ASCII.GetBytes(entrada);

                    return Convert.ToBase64String(desdencrypt.TransformFinalBlock(buff, 0, buff.Length));
                }
                else
                {
                    return "";
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                tripledescryptoserviceprovider = null;
                md5cryptoserviceprovider = null;
            }

        }

        public static string Decodificar(string entrada)
        {
            TripleDESCryptoServiceProvider tripledescryptoserviceprovider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5cryptoserviceprovider = new MD5CryptoServiceProvider();

            try
            {
                if (entrada.Trim() != "")
                {
                    string myKey = "1111111111111111";  //Aqui vc inclui uma chave qualquer para servir de base para cifrar, que deve ser a mesma no método Codificar
                    tripledescryptoserviceprovider.Key = md5cryptoserviceprovider.ComputeHash(ASCIIEncoding.ASCII.GetBytes(myKey));
                    tripledescryptoserviceprovider.Mode = CipherMode.ECB;
                    ICryptoTransform desdencrypt = tripledescryptoserviceprovider.CreateDecryptor();
                    byte[] buff = Convert.FromBase64String(entrada);

                    return ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length));
                }
                else
                {
                    return "";
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                tripledescryptoserviceprovider = null;
                md5cryptoserviceprovider = null;
            }

        }


	}
