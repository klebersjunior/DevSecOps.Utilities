using System;
using System.Text;

namespace DevSecOps.Utilities.Infra.Util
{
    public static class Conversor
    {
        //convert string para base64
        static public string EncodeToBase64(this string texto)
        {
            try
            {
                byte[] textoAsBytes = Encoding.ASCII.GetBytes(texto);
                string resultado = System.Convert.ToBase64String(textoAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //converte de base64 para texto
        static public string DecodeFrom64(this string dados)
        {
            try
            {
                byte[] dadosAsBytes = System.Convert.FromBase64String(dados);
                string resultado = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

