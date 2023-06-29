using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_MultiOTP_Adm;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace BLL_MultiOTP_Adm
{
    public class cls_parametros_BLL
    {
        #region Globales
        cls_parametros_DAL dal_obj = new cls_parametros_DAL();
        #endregion
        public void InsertaDatos(ref cls_parametros_DAL DAL_Objects) {

            try
            {
                string[] lines = File.ReadAllLines(DAL_Objects.sFilePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("default-request-prefix-pin="))
                    {
                        lines[i] = "default-request-prefix-pin=" + DAL_Objects.cPrefixPIN;
                        continue;
                    }
                    if (lines[i].StartsWith("default-request-ldap-pwd="))
                    {
                        lines[i] = "default-request-ldap-pwd=" + DAL_Objects.cLDAP_Pass;
                        continue;
                    }
                    if (lines[i].StartsWith("ldap-server-type="))
                    {
                        lines[i] = "ldap-server-type=" + DAL_Objects.cLDAP_Type;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-cn-identifier="))
                    {
                        lines[i] = "ldap-cn-identifier=" + DAL_Objects.sCN_User;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-group-cn-identifier="))
                    {
                        lines[i] = "ldap-group-cn-identifier=" + DAL_Objects.sCN_Group;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-group-attribute="))
                    {
                        lines[i] = "ldap-group-attribute=" + DAL_Objects.sAttributGroup;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-ssl="))
                    {
                        lines[i] = "ldap-ssl=" + DAL_Objects.cSSL_Enable;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-port="))
                    {
                        lines[i] = "ldap-port=" + DAL_Objects.sPortNum;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-domain-controllers="))
                    {
                        lines[i] = "ldap-domain-controllers=" + DAL_Objects.sDomain+","+DAL_Objects.sProtoc+DAL_Objects.sIPDomain+":"+DAL_Objects.sPortNum;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-base-dn=DC="))
                    {
                        lines[i] = "ldap-base-dn=DC=" + DAL_Objects.sBaseDN;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-bind-dn=CN="))
                    {
                        lines[i] = "ldap-bind-dn=CN=" + DAL_Objects.sDomainUser;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-server-password="))
                    {
                        lines[i] = "ldap-server-password=" + DAL_Objects.sPassword;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-in-group="))
                    {
                        lines[i] = "ldap-in-group=" + DAL_Objects.sFilter;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-network-timeout="))
                    {
                        lines[i] = "ldap-network-timeout=" + DAL_Objects.bTimeout;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-time-limit="))
                    {
                        lines[i] = "ldap-time-limit=" + DAL_Objects.bTimeTransact;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap-activated="))
                    {
                        lines[i] = "ldap-activated=" + DAL_Objects.cLDAP_Support;
                        continue;
                    }

                    if (lines[i].StartsWith("server-secret="))
                    {
                        lines[i] = "server-secret=" + DAL_Objects.sSecret;
                        continue;
                    }
                  
                }
                File.WriteAllLines(DAL_Objects.sFilePath, lines);
            }

            catch(Exception ex)
            {

               DAL_Objects.sMsjErr = "Error al actualizar el archivo: " + ex.Message + " \n verifique permisos y valores ingresados";


            }

            DAL_Objects.sMsjErr = "exito al guardar, revise la aplicacion Web";
         



        }


        public void sincronizarAD(ref cls_parametros_DAL DAL_OBJ) {
            string rutaRaiz;
            // Iniciar el proceso CMD
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = false;
            psi.UseShellExecute = false;

            Process proceso = new Process();
            proceso.StartInfo = psi;
            proceso.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data); // Mostrar la salida en tiempo real

            proceso.Start();

            // Ejecutar el comando "cd C:\multiotp"
            rutaRaiz = Path.GetDirectoryName(DAL_OBJ.sFilePath);

            proceso.StandardInput.WriteLine("cd ");
            proceso.StandardInput.WriteLine("echo Comando ejecutado: cd "+rutaRaiz);
            proceso.StandardInput.WriteLine("echo.");

            // Ejecutar el comando "multiotp.exe"
            proceso.StandardInput.WriteLine("multiotp.exe");
            proceso.StandardInput.WriteLine("echo Comando ejecutado: multiotp.exe");
            proceso.StandardInput.WriteLine("echo.");

            // Salir del CMD
            proceso.StandardInput.WriteLine("exit");

            proceso.BeginOutputReadLine(); // Iniciar la lectura de la salida en tiempo real
           

            Console.ReadLine();
        }
  
    }
}
