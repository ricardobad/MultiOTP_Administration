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
            // Crear una instancia de la clase TaskService
            

                try { using (TaskService taskService = new TaskService())
                {
                    // Crear una nueva tarea
                    TaskDefinition taskDefinition = taskService.NewTask();

                    // Establecer el nombre de la tarea
                    taskDefinition.RegistrationInfo.Description = "Sincronizar usuarios de LDAP cada 12 horas";

                    // Establecer la acción para ejecutar el archivo por lotes
                    string batFilePath = @"C:\\multiotp\\sync.bat"; // Ruta completa del archivo .bat
                    taskDefinition.Actions.Add(new ExecAction(batFilePath, null, null));

                    // Establecer la programación para ejecutar la tarea cada 12 horas
                    Trigger trigger = new DailyTrigger { DaysInterval = 1, StartBoundary = DateTime.Now, RandomDelay = TimeSpan.FromHours(1) };
                    trigger.Repetition.Duration = TimeSpan.FromHours(12);
                    taskDefinition.Triggers.Add(trigger);

                    // Registrar la tarea en el programador de tareas de Windows
                    taskService.RootFolder.RegisterTaskDefinition("Sincronizar_usuarios_LDAP", taskDefinition);

                    DAL.sMsjAviso = "Tarea creada correctamente, por favor verifique el programador de tareas";
                    // Console.WriteLine("Tarea programada creada correctamente.");
                    //  Console.ReadLine();
                }
            
                        
                        }
                catch (Exception ex) {
                DAL.sMsjAviso = ex.Message;
            
            }
            

        }
  
    }
}
