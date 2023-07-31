using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_MultiOTP_Adm;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Microsoft.Win32.TaskScheduler;

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
                    if (lines[i].StartsWith("default_request_prefix_pin="))
                    {
                        lines[i] = "default_request_prefix_pin=" + DAL_Objects.cPrefixPIN;
                        continue;
                    }
                    if (lines[i].StartsWith("default_request_ldap_pwd="))
                    {
                        lines[i] = "default_request_ldap_pwd=" + DAL_Objects.cLDAP_Pass;
                        continue;
                    }
                    if (lines[i].StartsWith("ldap_server_type="))
                    {
                        lines[i] = "ldap_server_type=" + DAL_Objects.cLDAP_Type;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_cn_identifier="))
                    {
                        lines[i] = "ldap_cn_identifier=" + DAL_Objects.sCN_User;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_group_cn_identifier="))
                    {
                        lines[i] = "ldap_group_cn_identifier=" + DAL_Objects.sCN_Group;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_group_attribute="))
                    {
                        lines[i] = "ldap_group_attribute=" + DAL_Objects.sAttributGroup;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_ssl="))
                    {
                        lines[i] = "ldap_ssl=" + DAL_Objects.cSSL_Enable;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_port="))
                    {
                        lines[i] = "ldap_port=" + DAL_Objects.sPortNum;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_domain_controllers="))
                    {//
                        lines[i] = "ldap_domain_controllers=" + DAL_Objects.sDomain+","+DAL_Objects.sProtoc+DAL_Objects.sIPDomain+":"+DAL_Objects.sPortNum;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_base_dn="))
                    {
                        lines[i] = "ldap_base_dn=" + DAL_Objects.sBaseDN;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_bind_dn="))
                    {
                        lines[i] = "ldap_bind_dn=" + DAL_Objects.sDomainUser;
                        continue;
                    }
               
                  

                    if (lines[i].StartsWith("ldap_in_group="))
                    {
                        lines[i] = "ldap_in_group=" + DAL_Objects.sFilter;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_network_timeout="))
                    {
                        lines[i] = "ldap_network_timeout=" + DAL_Objects.bTimeout;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_time_limit="))
                    {
                        lines[i] = "ldap_time_limit=" + DAL_Objects.bTimeTransact;
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_activated="))
                    {
                        lines[i] = "ldap_activated=" + DAL_Objects.cLDAP_Support;
                        continue;
                    }
                   

                }
                File.WriteAllLines(DAL_Objects.sFilePath, lines);
                DAL_Objects.sMsjErr = "exito al guardar, Sincronice el directorio de LDAP";
            }

            catch(Exception ex)
            {

               DAL_Objects.sMsjErr = "Error al actualizar el archivo: " + ex.Message + " \n verifique permisos y valores ingresados";
                return;

            }
            //serverpassword
            try
            {

                Process cmdProcess = new Process();

                // Configura las propiedades del proceso
                cmdProcess.StartInfo.FileName = "cmd.exe";
                cmdProcess.StartInfo.RedirectStandardInput = true;
                cmdProcess.StartInfo.RedirectStandardOutput = true;
                cmdProcess.StartInfo.CreateNoWindow = true;
                cmdProcess.StartInfo.UseShellExecute = false;

                // Inicia el proceso
                cmdProcess.Start();

                // Envía el comando al símbolo del sistema
                cmdProcess.StandardInput.WriteLine("start \"ServerPAss\"  \"C:\\multiotp\\multiotp.exe\" -config ldap-server-password=" + DAL_Objects.sPassword);
                cmdProcess.StandardInput.Flush();
                cmdProcess.StandardInput.Close();

                // Espera a que finalice el proceso
                cmdProcess.WaitForExit();

                // Lee la salida del símbolo del sistema
                string output = cmdProcess.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
                DAL_Objects.sMsjErr = "exito al guardar, Sincronice el directorio de LDAP";
            }
            catch (Exception ex)
            {

                DAL_Objects.sMsjErr = ex.Message;
                return;
            }

            //serversecret
            try
            {

                Process cmdProcess = new Process();

                // Configura las propiedades del proceso
                cmdProcess.StartInfo.FileName = "cmd.exe";
                cmdProcess.StartInfo.RedirectStandardInput = true;
                cmdProcess.StartInfo.RedirectStandardOutput = true;
                cmdProcess.StartInfo.CreateNoWindow = true;
                cmdProcess.StartInfo.UseShellExecute = false;

                // Inicia el proceso
                cmdProcess.Start();

                // Envía el comando al símbolo del sistema
                cmdProcess.StandardInput.WriteLine("start \"SecretPhrase\"  \"C:\\multiotp\\multiotp.exe\" -config server-secret=" + DAL_Objects.sSecret);
                cmdProcess.StandardInput.Flush();
                cmdProcess.StandardInput.Close();

                // Espera a que finalice el proceso
                cmdProcess.WaitForExit();

                // Lee la salida del símbolo del sistema
                string output = cmdProcess.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
                DAL_Objects.sMsjErr = "exito al guardar, Sincronice el directorio de LDAP";
            }
            catch (Exception ex)
            {

                DAL_Objects.sMsjErr = ex.Message;
            }
        }

        public void sincronizarAD(ref cls_parametros_DAL DAL_OBJ) {
           
            try {
              
                Process cmdProcess = new Process();

                // Configura las propiedades del proceso
                cmdProcess.StartInfo.FileName = "cmd.exe";
                cmdProcess.StartInfo.RedirectStandardInput = true;
                cmdProcess.StartInfo.RedirectStandardOutput = true;
                cmdProcess.StartInfo.CreateNoWindow = true;
                cmdProcess.StartInfo.UseShellExecute = false;

                // Inicia el proceso
                cmdProcess.Start();

                // Envía el comando al símbolo del sistema
                cmdProcess.StandardInput.WriteLine("start \"Syncronizacion\"  \"C:\\multiotp\\multiotp.exe\" -debug -display-log -ldap-users-sync");
                cmdProcess.StandardInput.Flush();
                cmdProcess.StandardInput.Close();

                // Espera a que finalice el proceso
                cmdProcess.WaitForExit();

                // Lee la salida del símbolo del sistema
                string output = cmdProcess.StandardOutput.ReadToEnd();
                Console.WriteLine(output);
                DAL_OBJ.sMsjErr = "";
            }
            catch (Exception ex) {

                DAL_OBJ.sMsjErr = ex.Message;
            }

           
        }

        public void mostrarLog(ref cls_parametros_DAL DAL) {
            try
            {
                // Abre el archivo de texto 
                Process.Start("C:\\multiotp\\log\\multiotp.log");

            }
            catch (Exception ex)
            {
                DAL.sMsjErr= "Favor verifique que exista la carpeta Log en su sistema y ya haya realizado la" +
                    "configuracion de LDAP" + ex.Message;
            }
        

    }

        public void crearTarea(ref cls_parametros_DAL DAL) {

            try {
                string batFilePath = @"C:\\multiotp\\sync.bat"; // Ruta y nombre de archivo .bat a crear

                // Crear el archivo .bat
                using (StreamWriter sw = File.CreateText(batFilePath))
                {
                    sw.WriteLine("@echo off");
                    sw.WriteLine("start \"Syncronizacion\"  \"C:\\multiotp\\multiotp.exe\" -debug -display-log -ldap-users-sync");
                }
                using (TaskService taskService = new TaskService())
                {
                    // Crear una nueva tarea
                    TaskDefinition taskDefinition = taskService.NewTask();

                    // Establecer el nombre de la tarea
                    taskDefinition.RegistrationInfo.Description = "Sincronizar usuarios de LDAP cada 12 horas";

                    // Establecer la acción para ejecutar el archivo por lotes
                    batFilePath = @"C:\\multiotp\\sync.bat"; // Ruta completa del archivo .bat
                    taskDefinition.Actions.Add(new ExecAction(batFilePath, null, null));

                    // Establecer la programación para ejecutar la tarea cada 12 horas
                    Trigger trigger = new DailyTrigger { DaysInterval = 1, StartBoundary = DateTime.Now, RandomDelay = TimeSpan.FromHours(1) };
                    trigger.Repetition.Duration = TimeSpan.FromHours(12);
                    taskDefinition.Triggers.Add(trigger);

                    // Registrar la tarea en el programador de tareas de Windows
                    taskService.RootFolder.RegisterTaskDefinition("Sincronizar_usuarios_LDAP", taskDefinition);

                    DAL.sMsjAviso = "Tarea creada correctamente, por favor verifique el programador de tareas";
                   
                }
            
                        
                        }
                catch (Exception ex) {
                DAL.sMsjAviso = ex.Message;
            
            }
            

        }

        public void cargarConfigActual(ref cls_parametros_DAL DAL) {

            string[] lines = File.ReadAllLines(DAL.sFilePath);
            string[] valores;



            try
            {
                for (int i = 0; i < lines.Length; i++) {
                   
                    if (lines[i].StartsWith("default_request_prefix_pin="))
                    {

                        valores = lines[i].Split('=');
                        DAL.cPrefixPIN = Convert.ToChar(valores[1]);
                        continue;
                    }

                    if (lines[i].StartsWith("default_request_ldap_pwd="))
                    {
                        valores = lines[i].Split('=');
                        DAL.cLDAP_Pass = Convert.ToChar(valores[1]);
                        continue;
                    }
                    if (lines[i].StartsWith("ldap_server_type="))
                    {
                        valores = lines[i].Split('=');
                        DAL.cLDAP_Type = Convert.ToChar(valores[1]);
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_cn_identifier="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sCN_User = Convert.ToString(valores[1]);
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_group_cn_identifier="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sCN_Group = valores[1].ToString();
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_group_attribute="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sAttributGroup = valores[1].ToString();
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_ssl="))
                    {
                        valores = lines[i].Split('=');
                        DAL.cSSL_Enable = Convert.ToChar(valores[1]);
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_port="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sPortNum = valores[1].ToString();
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_domain_controllers="))
                    {
                        //valores es todo la linea separadas por =
                        valores = lines[i].Split('=');
                        if (valores[1] == string.Empty)
                        {
                            continue;
                        }
                        else
                        {
                            //Domain vale todo lo de la derecha del =
                            DAL.sDomain = valores[1].ToString();
                            //valores ahora vale todo lo que es domain
                            valores = DAL.sDomain.Split(',');
                            //Domain ahora vale lo que es a la izquierda de la , DOmain LISTO
                            DAL.sDomain = valores[0].ToString();
                            //Protocolo vale todo lo de la derecha de la ,
                            DAL.sProtoc = valores[1].ToString();
                            //valores vale todo lo dividido de protocolo
                            valores = DAL.sProtoc.Split('/');
                            //protocolo ahora vale lo de la izquierda del primer /
                            DAL.sProtoc = valores[0].ToString();
                            DAL.sProtoc = DAL.sProtoc + "//";
                            //IP vale todo lo de la derecha del /
                            DAL.sIPDomain = valores[2].ToString();
                            //valores ahora vale todo lo d IP
                            valores = DAL.sIPDomain.Split(':');
                            //IP ahora vale lo de izq de IP
                            DAL.sIPDomain = valores[0].ToString();
                            continue;
                        }
                        
                    }

                    if (lines[i].StartsWith("ldap_base_dn="))
                    {
                        valores = null;
                        valores = lines[i].Split('=');
                        for (int j = 0; j < valores.Length; j++)
                        {
                            if (j !=0 )
                                DAL.sBaseDN  += valores[j]+ "=";
                        }

                        //elimina el = del final
                        DAL.sBaseDN = DAL.sBaseDN.TrimEnd('=');
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_bind_dn="))
                    {
                        valores = null;
                        valores = lines[i].Split('=');
                        for (int j = 0; j < valores.Length; j++)
                        {
                            if (j != 0)
                                DAL.sDomainUser += valores[j] + "=";
                        }

                        //elimina el = del final
                        DAL.sDomainUser = DAL.sDomainUser.TrimEnd('=');
                        continue;
                    }
                    //Archivo nuevo, clave en texto plano
                    if (lines[i].StartsWith("ldap_server_password:="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sPassword = valores[1].ToString();
                        continue;
                    }

                    //si ya existe, clave texto plano
                   
                    if (lines[i].StartsWith("ldap_server_password="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sPassword = valores[1].ToString();
                        continue;
                    }
                    if (lines[i].StartsWith("ldap_in_group="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sFilter = valores[1].ToString();
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_network_timeout="))
                    {
                        valores = lines[i].Split('=');
                        DAL.bTimeout = Convert.ToByte(valores[1]);
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_time_limit="))
                    {
                        valores = lines[i].Split('=');
                        DAL.bTimeTransact = Convert.ToByte(valores[1]);
                        continue;
                    }

                    if (lines[i].StartsWith("ldap_activated="))
                    {
                        valores = lines[i].Split('=');
                        DAL.cLDAP_Support = Convert.ToChar(valores[1]);
                        continue;
                    }

                    //archivo nuevo, txt plano
                    if (lines[i].StartsWith("server_secret:="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sSecret = valores[1].ToString();
                        continue;
                    }
                    //archivo ya existe, txt plano
                    if (lines[i].StartsWith("server_secret="))
                    {
                        valores = lines[i].Split('=');
                        DAL.sSecret = valores[1].ToString();
                        continue;
                    }


                }


                DAL.sMsjErr = "Configuracion cargada correctamente";

            }

            catch (Exception ex) {

                DAL.sMsjErr = "No se pudo cargar la configuracion "+ ex.Message;
            }
            

        }
  
    }
}
