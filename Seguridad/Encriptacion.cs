using System;
using System.Security.Cryptography;
using System.Text;

namespace Seguridad
{
    public class Encriptacion
    {
        public string Encrypt(string cadena)
        {
            string hash = "SistemaPuntoVenta";
            byte[] data = UTF8Encoding.UTF8.GetBytes(cadena);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform cryptoTransform = tripleDES.CreateEncryptor();
            byte[] result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

        public String Decrypt(string cadenaEncriptada)
        {
            string hash = "SistemaPuntoVenta";
            byte[] data = Convert.FromBase64String(cadenaEncriptada);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform cryptoTransform = tripleDES.CreateDecryptor();
            byte[] result = cryptoTransform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}
