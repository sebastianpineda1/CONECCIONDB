using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConeccionDB
{

    public partial class DatosRegistro : Form
    {
    
        public DatosRegistro()
        {
            InitializeComponent();
        }

        //SqlConnection Conexion = new SqlConnection("server=B9-202-26882; database=DB_Biblioteca2023; integrated security=true");
        
        
            private void BtnMostrar_Click(object sender, EventArgs e)
            
            {
            // definimos las variables
            /*    Conexion.Open();
                int Cedu = int.Parse(TxtId.Text);
                string Nombre = TxtNom.Text;
                int Telefono = int.Parse(TxtTel.Text);
                string Direccion = TxtDir.Text;
                int Cod_tipo = int.Parse(TxtTip_Cod.Text);
                string Estado = TxtEst.Text;

            //Se realiza la consulta
                string Consulta = ("insert into tblusuario values (" +TxtId.Text+", '"+TxtNom.Text+"', "+TxtTel.Text+", '"+TxtDir.Text+"', "+TxtTip_Cod.Text+", '"+TxtEst.Text+"')");
                SqlCommand Comando = new SqlCommand(Consulta, Conexion);
                SqlDataReader R = Comando.ExecuteReader();
                MessageBox.Show("Registro agregado");
                Conexion.Close();
            */
            }
            
    }
}
