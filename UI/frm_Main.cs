using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_MultiOTP_Adm;
using BLL_MultiOTP_Adm;

namespace UI
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }



        #region Globales
        cls_parametros_DAL DAL_Obj = new cls_parametros_DAL();
        cls_parametros_BLL BLL_Obj = new cls_parametros_BLL();

        #endregion

        #region Eventos

        private void frm_Main_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            inHabilitaOpciones();


        }


        private void btn_Sincronizar_Click(object sender, EventArgs e)
        {
            BLL_Obj.sincronizarAD(ref DAL_Obj);
            if (DAL_Obj.sMsjErr == string.Empty)
            {
                BLL_Obj.mostrarLog(ref DAL_Obj);
            }
            else {
                MessageBox.Show("Advertencia ","Error \n "+ DAL_Obj.sMsjErr);
            }

        }

        private void btn_Aplicar_Click(object sender, EventArgs e)
        {
            //carga de variable path a ruta de archivo
            DAL_Obj.sFilePath = btn_Elegir_Archivo.Text.Trim();
            capturaDatos(ref DAL_Obj);



            BLL_Obj.InsertaDatos(ref DAL_Obj);



            MessageBox.Show(DAL_Obj.sMsjErr);

        }

        private void btn_Elegir_Archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Establecer las propiedades del OpenFileDialog
            openFileDialog1.Title = "Seleccionar archivo de texto";
            openFileDialog1.Filter = "Archivo multiotp(*.ini)|*.ini";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Mostrar el diálogo de apertura de archivo
            DialogResult result = openFileDialog1.ShowDialog();

            // Procesar el archivo seleccionado
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                // Hacer algo con el filePath, como leer el contenido del archivo
                // o mostrar el nombre del archivo en un TextBox, etc.
                btn_Elegir_Archivo.Text = filePath;
                habilitaOpciones();
            }



        }

            #endregion

            #region Validaciones

            private void gpB_PIN_Pass_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Los usuarios deben escribir el pin en vez de la clave de LDAP", gpB_PIN_Pass);
            }


            private void gp_SSL_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Se usa para indicar si se usa certificado SSL en la conexion", gp_SSL);
            }

            private void gp_TipoAD_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Tipo de LDAP usado, Active Directory de Microsoft o OPENLDAP Linux", gp_TipoAD);
            }

            private void gpB_LDAPSupp_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Soporte en la configuracion LDAP del controlador de dominio, se sugiere activar", gpB_LDAPSupp);
            }

            private void gpB_Timeout_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Tiempo limite que el programa intenta validar las credenciales del LDAP", gpB_Timeout);
            }

            private void gpB_TimeoutServer_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Tiempo limite de conexion de la computadora cliente hacia este servidor de autenticacion", gpB_TimeoutServer);
            }

            private void gpB_Prefijo_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Los usuarios deben escribir su PIN numerico antes de la clave de dominio, \n" +
                    "un ejemplo seria 1234Password", gpB_Prefijo);
            }

            private void btn_Sincronizar_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Sincroniza los usuarios de LDAP contra el servidor de Autenticacion. \n Es Util si se crearon o eliminaron usuarios de LDAP", btn_Sincronizar);
            }

            private void btn_Aplicar_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("Aplica la configuracion definida en el sistema", btn_Aplicar);
            }

            private void btn_Mostrar_MouseHover(object sender, EventArgs e)
            {
                txt_Contrasena.PasswordChar = '\0';
            }

            private void lbl_Puerto_LDAP_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("389 Standard, 636 si selecciona SSL", lbl_Puerto_LDAP);
            }

            private void lbl_Dir_Adm_Dominio_MouseHover(object sender, EventArgs e)
            {
                tT_Message.Show("La cuenta CN no puede contener espacios", lbl_Dir_Adm_Dominio);
            }

            private void btn_Mostrar_MouseLeave(object sender, EventArgs e)
            {
                txt_Contrasena.PasswordChar = '*';
            }


            private void txt_CuentaCN_Leave(object sender, EventArgs e)
            {
                if (txt_CuentaCN.Text == string.Empty)
                {

                    txt_CuentaCN.Text = "sAMAccountName";
                }
            }

            private void txt_IdentificadorGrupo_Leave(object sender, EventArgs e)
            {
                if (txt_IdentificadorGrupo.Text == string.Empty)
                {

                    txt_IdentificadorGrupo.Text = "sAMAccountName";
                }

            }

            private void txt_Atributo_Grupo_Leave(object sender, EventArgs e)
            {
                if (txt_Atributo_Grupo.Text == string.Empty)
                {

                    txt_Atributo_Grupo.Text = "memberof";
                }

            }

            private void txt_PuertoLDAP_Leave(object sender, EventArgs e)
            {
                if (txt_PuertoLDAP.Text == string.Empty)
                {

                    txt_PuertoLDAP.Text = "389";
                }
            }

            private void txt_PuertoLDAP_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Ignorar el carácter ingresado
                }
            }



            private void txt_Nombre_Dominio_Leave(object sender, EventArgs e)
            {
                if (txt_Nombre_Dominio.Text == string.Empty)
                {

                    txt_Nombre_Dominio.Text = "midominio.co.com";
                }

            }

            private void txt_Dir_Base_DN_Leave(object sender, EventArgs e)
            {
                if (txt_Dir_Base_DN.Text == string.Empty)
                {

                    txt_Dir_Base_DN.Text = "DC=midominio,DC=co,DC=com";
                }

            }

            private void txt_Dir_Admin_Dominio_Leave(object sender, EventArgs e)
            {
                if (txt_Dir_Admin_Dominio.Text == string.Empty)
                {

                    txt_Dir_Admin_Dominio.Text = "CN=Soporte,CN=Users,DC=midominio,DC=co,DC=com";
                }

            }



            private void txt_Contrasena_Leave(object sender, EventArgs e)
            {
                if (txt_Contrasena.Text == string.Empty)
                {

                    txt_Contrasena.Text = "DOMAINPASSW";
                }
            }

            private void txt_Secreto_Leave(object sender, EventArgs e)
            {
                if (txt_Secreto.Text == string.Empty)
                {

                    txt_Secreto.Text = "secretClient";
                }
            }
        private void txt_IP_Dominio_Leave(object sender, EventArgs e)
        {
            if (txt_IP_Dominio.Text == string.Empty)
            {

                txt_IP_Dominio.Text = "192.168.100.14";
            }
        }



        #endregion

        #region Metodos

        private void inHabilitaOpciones() {

            //Deshabilita todos los campos hasta que se escoja el archivo
            gp_TipoAD.Enabled = false;
            gp_SSL.Enabled = false;
            gpB_PIN_Pass.Enabled = false;
            gpB_LDAPSupp.Enabled = false;
            gpB_Timeout.Enabled = false;
            gpB_TimeoutServer.Enabled = false;
            gpB_Prefijo.Enabled = false;
            txt_CuentaCN.Enabled = false;
            txt_IdentificadorGrupo.Enabled = false;
            txt_Atributo_Grupo.Enabled = false;
            txt_PuertoLDAP.Enabled = false;
            txt_Nombre_Dominio.Enabled = false;
            txt_IP_Dominio.Enabled = false;
            cmb_Protocolo.Enabled = false;
            txt_Dir_Base_DN.Enabled = false;
            txt_Dir_Admin_Dominio.Enabled = false;
            txt_Contrasena.Enabled = false;
            btn_Mostrar.Enabled = false;
            txt_Filtro_Grupo.Enabled = false;
            txt_Secreto.Enabled = false;
            btn_Sincronizar.Enabled = false;
            btn_Aplicar.Enabled = false;


        }

        private void habilitaOpciones()
        {

            //habilita todos los campos 
            gp_TipoAD.Enabled = !false;
            gp_SSL.Enabled = !false;
            gpB_PIN_Pass.Enabled = !false;
            gpB_LDAPSupp.Enabled = !false;
            gpB_Timeout.Enabled = !false;
            gpB_TimeoutServer.Enabled = !false;
            gpB_Prefijo.Enabled = !false;
            txt_CuentaCN.Enabled = !false;
            txt_IdentificadorGrupo.Enabled = !false;
            txt_Atributo_Grupo.Enabled = !false;
            txt_PuertoLDAP.Enabled = !false;
            txt_Nombre_Dominio.Enabled = !false;
            txt_IP_Dominio.Enabled = !false;
            cmb_Protocolo.Enabled = !false;
            txt_Dir_Base_DN.Enabled = !false;
            txt_Dir_Admin_Dominio.Enabled = !false;
            txt_Contrasena.Enabled = !false;
            btn_Mostrar.Enabled = !false;
            txt_Filtro_Grupo.Enabled = !false;
            txt_Secreto.Enabled = !false;
            btn_Sincronizar.Enabled = !false;
            btn_Aplicar.Enabled = !false;


        }

        private void capturaDatos(ref cls_parametros_DAL DAL_Object) {

            //Radio buttons
            //ldap
            if (rb_Active_DIrectoy.Checked == true)
            {

                DAL_Object.cLDAP_Type = '1';
            }
            else {
                DAL_Object.cLDAP_Type = '2';
            }

            //SSL
            if (rb_SSL_SI.Checked == true)
            {

                DAL_Object.cSSL_Enable = '1';
            }
            else
            {
                DAL_Object.cSSL_Enable = '0';
            }
            //PPIN o PASS
            if (rb_Pass_PIN_SI.Checked == true)
            {

                DAL_Object.cLDAP_Pass = '1';
            }
            else
            {
                DAL_Object.cLDAP_Pass = '0';
            }
            //ConexionLDAP
            if (rb_LDAP_Support_SI.Checked == true)
            {

                DAL_Object.cLDAP_Support = '1';
            }
            else
            {
                DAL_Obj.cLDAP_Support = '0';
            }
            //prefijo pin
            if (rb_Prefijo_SI.Checked == true)
            {

                DAL_Object.cPrefixPIN = '1';
            }
            else
            {
                DAL_Object.cPrefixPIN = '0';
            }
            //timeout LDAP
            DAL_Object.bTimeout= Convert.ToByte(nUD_Timeout_LDAP.Value);
            //timeout server auth
            DAL_Object.bTimeTransact = Convert.ToByte(nUD_Transact.Value);

            //txts
            DAL_Object.sCN_User = txt_CuentaCN.Text.Trim().ToString();
            DAL_Object.sCN_Group = txt_IdentificadorGrupo.Text.Trim().ToString();
            DAL_Object.sAttributGroup = txt_Atributo_Grupo.Text.Trim().ToString();
            DAL_Object.sPortNum = txt_PuertoLDAP.Text.Trim().ToString();
            DAL_Object.sDomain = txt_Nombre_Dominio.Text.Trim().ToString();
            DAL_Object.sProtoc = cmb_Protocolo.Text.ToString();
            DAL_Object.sIPDomain = txt_IP_Dominio.Text.Trim().ToString();
            DAL_Object.sBaseDN = txt_Dir_Base_DN.Text.Trim().ToString();
            DAL_Object.sDomainUser = txt_Dir_Admin_Dominio.Text.Trim().ToString();
            DAL_Object.sPassword = txt_Contrasena.Text.Trim().ToString();
            DAL_Object.sFilter = txt_Filtro_Grupo.Text.Trim().ToString();
            DAL_Object.sSecret = txt_Secreto.Text.Trim().ToString();

            //luego de la captura habilita aplicar
            btn_Aplicar.Enabled = true;

      

        }



        #endregion

        private void btn_Tarea_Click(object sender, EventArgs e)
        {
            BLL_Obj.crearTarea(ref DAL_Obj);
            MessageBox.Show(DAL_Obj.sMsjAviso);

        }
    } 
}
    

