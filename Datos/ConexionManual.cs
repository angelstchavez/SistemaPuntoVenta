using Seguridad;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace Datos
{
    public partial class ConexionManual : Form
    {
        public ConexionManual()
        {
            InitializeComponent();
        }

        int idTabla;
        private AES aes = new AES();

        public void SaveToXml(Object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();

        }

        string dbcnString;

        public void ReadFromXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtConexionString.Text = (aes.Decrypt(dbcnString, Desencryptacion.appPwdUnique, int.Parse("256")));
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComprobarConexion()
        {
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = txtConexionString.Text;
                SqlCommand command = new SqlCommand("select * from Salon", conexion);
                conexion.Open();
                idTabla = Convert.ToInt32(command.ExecuteScalar());
                conexion.Close();
                SaveToXml(aes.Encrypt(txtConexionString.Text, Desencryptacion.appPwdUnique, int.Parse("256")));
                MessageBox.Show("Conexión realizada exitosamente.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception) { conexion.Close(); MessageBox.Show("Conexión fallida.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ConexionManual_Load(object sender, EventArgs e)
        {
            ReadFromXML();
        }

        private void btnGenerarCadena_Click(object sender, EventArgs e)
        {
            ComprobarConexion();
        }
    }
}
