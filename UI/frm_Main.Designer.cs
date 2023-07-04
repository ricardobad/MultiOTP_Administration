
namespace UI
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.gpB_Menu = new System.Windows.Forms.GroupBox();
            this.btn_Tarea = new System.Windows.Forms.Button();
            this.gpB_Elegir_Arch = new System.Windows.Forms.GroupBox();
            this.btn_Elegir_Archivo = new System.Windows.Forms.Button();
            this.lbl_File = new System.Windows.Forms.Label();
            this.cmb_Protocolo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gp_TipoAD = new System.Windows.Forms.GroupBox();
            this.lbl_tipo_AD = new System.Windows.Forms.Label();
            this.rb_Active_DIrectoy = new System.Windows.Forms.RadioButton();
            this.rb_OPEN_LDAP = new System.Windows.Forms.RadioButton();
            this.gpB_TimeoutServer = new System.Windows.Forms.GroupBox();
            this.lbl_Tiempo_Transact = new System.Windows.Forms.Label();
            this.nUD_Transact = new System.Windows.Forms.NumericUpDown();
            this.gpB_LDAPSupp = new System.Windows.Forms.GroupBox();
            this.lbl_LDAP_Support = new System.Windows.Forms.Label();
            this.rb_LDAP_Support_SI = new System.Windows.Forms.RadioButton();
            this.rb_LDAP_Support_NO = new System.Windows.Forms.RadioButton();
            this.gpB_Timeout = new System.Windows.Forms.GroupBox();
            this.lbl_Timeout_LDAP = new System.Windows.Forms.Label();
            this.nUD_Timeout_LDAP = new System.Windows.Forms.NumericUpDown();
            this.gp_SSL = new System.Windows.Forms.GroupBox();
            this.lbl_SSL = new System.Windows.Forms.Label();
            this.rb_SSL_SI = new System.Windows.Forms.RadioButton();
            this.rb_SSL_NO = new System.Windows.Forms.RadioButton();
            this.gpB_PIN_Pass = new System.Windows.Forms.GroupBox();
            this.lbl_PIN_PASS = new System.Windows.Forms.Label();
            this.rb_Pass_PIN_SI = new System.Windows.Forms.RadioButton();
            this.rb_Pass_PIN_NO = new System.Windows.Forms.RadioButton();
            this.gpB_Prefijo = new System.Windows.Forms.GroupBox();
            this.lbl_Prefijo_PIN = new System.Windows.Forms.Label();
            this.rb_Prefijo_SI = new System.Windows.Forms.RadioButton();
            this.rb_Prefijo_NO = new System.Windows.Forms.RadioButton();
            this.pB_Sync = new System.Windows.Forms.PictureBox();
            this.btn_Sincronizar = new System.Windows.Forms.Button();
            this.btn_Aplicar = new System.Windows.Forms.Button();
            this.txt_Secreto = new System.Windows.Forms.TextBox();
            this.lbl_Clave_Secret = new System.Windows.Forms.Label();
            this.txt_Filtro_Grupo = new System.Windows.Forms.TextBox();
            this.lbl_Filtro_Grupo = new System.Windows.Forms.Label();
            this.txt_Contrasena = new System.Windows.Forms.TextBox();
            this.lbl_Pass_Dominio = new System.Windows.Forms.Label();
            this.txt_Dir_Admin_Dominio = new System.Windows.Forms.TextBox();
            this.lbl_Dir_Adm_Dominio = new System.Windows.Forms.Label();
            this.txt_Dir_Base_DN = new System.Windows.Forms.TextBox();
            this.lbl_Dir_Base_DN = new System.Windows.Forms.Label();
            this.txt_IP_Dominio = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Dominio = new System.Windows.Forms.TextBox();
            this.lbl_NombreAD = new System.Windows.Forms.Label();
            this.txt_PuertoLDAP = new System.Windows.Forms.TextBox();
            this.lbl_Puerto_LDAP = new System.Windows.Forms.Label();
            this.txt_Atributo_Grupo = new System.Windows.Forms.TextBox();
            this.lbl_Atributo_Grupo = new System.Windows.Forms.Label();
            this.txt_IdentificadorGrupo = new System.Windows.Forms.TextBox();
            this.lbl_IdentificadorGrupo = new System.Windows.Forms.Label();
            this.txt_CuentaCN = new System.Windows.Forms.TextBox();
            this.lbl_Identificador = new System.Windows.Forms.Label();
            this.tT_Message = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cargarConfig = new System.Windows.Forms.Button();
            this.gpB_Sincronizacion = new System.Windows.Forms.GroupBox();
            this.pB_Pass = new System.Windows.Forms.PictureBox();
            this.pb_Task = new System.Windows.Forms.PictureBox();
            this.gpB_Datos = new System.Windows.Forms.GroupBox();
            this.pb_Apply = new System.Windows.Forms.PictureBox();
            this.pb_Load = new System.Windows.Forms.PictureBox();
            this.gpB_Menu.SuspendLayout();
            this.gpB_Elegir_Arch.SuspendLayout();
            this.gp_TipoAD.SuspendLayout();
            this.gpB_TimeoutServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Transact)).BeginInit();
            this.gpB_LDAPSupp.SuspendLayout();
            this.gpB_Timeout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Timeout_LDAP)).BeginInit();
            this.gp_SSL.SuspendLayout();
            this.gpB_PIN_Pass.SuspendLayout();
            this.gpB_Prefijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Sync)).BeginInit();
            this.gpB_Sincronizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Task)).BeginInit();
            this.gpB_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Apply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // gpB_Menu
            // 
            this.gpB_Menu.Controls.Add(this.gpB_Datos);
            this.gpB_Menu.Controls.Add(this.pB_Pass);
            this.gpB_Menu.Controls.Add(this.gpB_Sincronizacion);
            this.gpB_Menu.Controls.Add(this.gpB_Elegir_Arch);
            this.gpB_Menu.Controls.Add(this.cmb_Protocolo);
            this.gpB_Menu.Controls.Add(this.label2);
            this.gpB_Menu.Controls.Add(this.gp_TipoAD);
            this.gpB_Menu.Controls.Add(this.gpB_TimeoutServer);
            this.gpB_Menu.Controls.Add(this.gpB_LDAPSupp);
            this.gpB_Menu.Controls.Add(this.gpB_Timeout);
            this.gpB_Menu.Controls.Add(this.gp_SSL);
            this.gpB_Menu.Controls.Add(this.gpB_PIN_Pass);
            this.gpB_Menu.Controls.Add(this.gpB_Prefijo);
            this.gpB_Menu.Controls.Add(this.txt_Secreto);
            this.gpB_Menu.Controls.Add(this.lbl_Clave_Secret);
            this.gpB_Menu.Controls.Add(this.txt_Filtro_Grupo);
            this.gpB_Menu.Controls.Add(this.lbl_Filtro_Grupo);
            this.gpB_Menu.Controls.Add(this.txt_Contrasena);
            this.gpB_Menu.Controls.Add(this.lbl_Pass_Dominio);
            this.gpB_Menu.Controls.Add(this.txt_Dir_Admin_Dominio);
            this.gpB_Menu.Controls.Add(this.lbl_Dir_Adm_Dominio);
            this.gpB_Menu.Controls.Add(this.txt_Dir_Base_DN);
            this.gpB_Menu.Controls.Add(this.lbl_Dir_Base_DN);
            this.gpB_Menu.Controls.Add(this.txt_IP_Dominio);
            this.gpB_Menu.Controls.Add(this.txt_Nombre_Dominio);
            this.gpB_Menu.Controls.Add(this.lbl_NombreAD);
            this.gpB_Menu.Controls.Add(this.txt_PuertoLDAP);
            this.gpB_Menu.Controls.Add(this.lbl_Puerto_LDAP);
            this.gpB_Menu.Controls.Add(this.txt_Atributo_Grupo);
            this.gpB_Menu.Controls.Add(this.lbl_Atributo_Grupo);
            this.gpB_Menu.Controls.Add(this.txt_IdentificadorGrupo);
            this.gpB_Menu.Controls.Add(this.lbl_IdentificadorGrupo);
            this.gpB_Menu.Controls.Add(this.txt_CuentaCN);
            this.gpB_Menu.Controls.Add(this.lbl_Identificador);
            this.gpB_Menu.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpB_Menu.Location = new System.Drawing.Point(24, 21);
            this.gpB_Menu.Name = "gpB_Menu";
            this.gpB_Menu.Size = new System.Drawing.Size(1027, 599);
            this.gpB_Menu.TabIndex = 0;
            this.gpB_Menu.TabStop = false;
            this.gpB_Menu.Text = "Parametros Active Directory";
            // 
            // btn_Tarea
            // 
            this.btn_Tarea.Location = new System.Drawing.Point(274, 28);
            this.btn_Tarea.Name = "btn_Tarea";
            this.btn_Tarea.Size = new System.Drawing.Size(148, 56);
            this.btn_Tarea.TabIndex = 57;
            this.btn_Tarea.Text = "Crear tarea Sincronizacion";
            this.btn_Tarea.UseVisualStyleBackColor = true;
            this.btn_Tarea.Click += new System.EventHandler(this.btn_Tarea_Click);
            // 
            // gpB_Elegir_Arch
            // 
            this.gpB_Elegir_Arch.Controls.Add(this.btn_Elegir_Archivo);
            this.gpB_Elegir_Arch.Controls.Add(this.lbl_File);
            this.gpB_Elegir_Arch.Location = new System.Drawing.Point(469, 12);
            this.gpB_Elegir_Arch.Name = "gpB_Elegir_Arch";
            this.gpB_Elegir_Arch.Size = new System.Drawing.Size(441, 78);
            this.gpB_Elegir_Arch.TabIndex = 56;
            this.gpB_Elegir_Arch.TabStop = false;
            this.gpB_Elegir_Arch.Text = "Elegir Archivo";
            // 
            // btn_Elegir_Archivo
            // 
            this.btn_Elegir_Archivo.Location = new System.Drawing.Point(225, 25);
            this.btn_Elegir_Archivo.Name = "btn_Elegir_Archivo";
            this.btn_Elegir_Archivo.Size = new System.Drawing.Size(197, 40);
            this.btn_Elegir_Archivo.TabIndex = 55;
            this.btn_Elegir_Archivo.Text = "Elegir arch...";
            this.btn_Elegir_Archivo.UseVisualStyleBackColor = true;
            this.btn_Elegir_Archivo.Click += new System.EventHandler(this.btn_Elegir_Archivo_Click);
            // 
            // lbl_File
            // 
            this.lbl_File.AutoSize = true;
            this.lbl_File.Location = new System.Drawing.Point(6, 35);
            this.lbl_File.Name = "lbl_File";
            this.lbl_File.Size = new System.Drawing.Size(191, 21);
            this.lbl_File.TabIndex = 54;
            this.lbl_File.Text = "Archivo Config MULTIOTP";
            // 
            // cmb_Protocolo
            // 
            this.cmb_Protocolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Protocolo.FormattingEnabled = true;
            this.cmb_Protocolo.Items.AddRange(new object[] {
            "ldap://",
            "ldaps://"});
            this.cmb_Protocolo.Location = new System.Drawing.Point(516, 265);
            this.cmb_Protocolo.Name = "cmb_Protocolo";
            this.cmb_Protocolo.Size = new System.Drawing.Size(89, 29);
            this.cmb_Protocolo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "IP Dominio =";
            // 
            // gp_TipoAD
            // 
            this.gp_TipoAD.Controls.Add(this.lbl_tipo_AD);
            this.gp_TipoAD.Controls.Add(this.rb_Active_DIrectoy);
            this.gp_TipoAD.Controls.Add(this.rb_OPEN_LDAP);
            this.gp_TipoAD.Location = new System.Drawing.Point(25, 25);
            this.gp_TipoAD.Name = "gp_TipoAD";
            this.gp_TipoAD.Size = new System.Drawing.Size(423, 58);
            this.gp_TipoAD.TabIndex = 49;
            this.gp_TipoAD.TabStop = false;
            this.gp_TipoAD.Text = "Tipo de Dominio";
            this.gp_TipoAD.MouseHover += new System.EventHandler(this.gp_TipoAD_MouseHover);
            // 
            // lbl_tipo_AD
            // 
            this.lbl_tipo_AD.AutoSize = true;
            this.lbl_tipo_AD.Location = new System.Drawing.Point(22, 22);
            this.lbl_tipo_AD.Name = "lbl_tipo_AD";
            this.lbl_tipo_AD.Size = new System.Drawing.Size(82, 21);
            this.lbl_tipo_AD.TabIndex = 6;
            this.lbl_tipo_AD.Text = "Tipo LDAP";
            // 
            // rb_Active_DIrectoy
            // 
            this.rb_Active_DIrectoy.AutoSize = true;
            this.rb_Active_DIrectoy.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Active_DIrectoy.Location = new System.Drawing.Point(119, 20);
            this.rb_Active_DIrectoy.Name = "rb_Active_DIrectoy";
            this.rb_Active_DIrectoy.Size = new System.Drawing.Size(146, 25);
            this.rb_Active_DIrectoy.TabIndex = 7;
            this.rb_Active_DIrectoy.TabStop = true;
            this.rb_Active_DIrectoy.Text = "Active Directory";
            this.rb_Active_DIrectoy.UseVisualStyleBackColor = true;
            // 
            // rb_OPEN_LDAP
            // 
            this.rb_OPEN_LDAP.AutoSize = true;
            this.rb_OPEN_LDAP.Location = new System.Drawing.Point(279, 20);
            this.rb_OPEN_LDAP.Name = "rb_OPEN_LDAP";
            this.rb_OPEN_LDAP.Size = new System.Drawing.Size(118, 25);
            this.rb_OPEN_LDAP.TabIndex = 8;
            this.rb_OPEN_LDAP.TabStop = true;
            this.rb_OPEN_LDAP.Text = "OPEN LDAP";
            this.rb_OPEN_LDAP.UseVisualStyleBackColor = true;
            // 
            // gpB_TimeoutServer
            // 
            this.gpB_TimeoutServer.Controls.Add(this.lbl_Tiempo_Transact);
            this.gpB_TimeoutServer.Controls.Add(this.nUD_Transact);
            this.gpB_TimeoutServer.Location = new System.Drawing.Point(28, 386);
            this.gpB_TimeoutServer.Name = "gpB_TimeoutServer";
            this.gpB_TimeoutServer.Size = new System.Drawing.Size(234, 65);
            this.gpB_TimeoutServer.TabIndex = 48;
            this.gpB_TimeoutServer.TabStop = false;
            this.gpB_TimeoutServer.Text = "Timeout Server Auth";
            this.gpB_TimeoutServer.MouseHover += new System.EventHandler(this.gpB_TimeoutServer_MouseHover);
            // 
            // lbl_Tiempo_Transact
            // 
            this.lbl_Tiempo_Transact.AutoSize = true;
            this.lbl_Tiempo_Transact.Location = new System.Drawing.Point(-3, 28);
            this.lbl_Tiempo_Transact.Name = "lbl_Tiempo_Transact";
            this.lbl_Tiempo_Transact.Size = new System.Drawing.Size(171, 21);
            this.lbl_Tiempo_Transact.TabIndex = 41;
            this.lbl_Tiempo_Transact.Text = "Limite Tiempo Transact";
            // 
            // nUD_Transact
            // 
            this.nUD_Transact.Location = new System.Drawing.Point(178, 23);
            this.nUD_Transact.Name = "nUD_Transact";
            this.nUD_Transact.Size = new System.Drawing.Size(56, 28);
            this.nUD_Transact.TabIndex = 42;
            this.nUD_Transact.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // gpB_LDAPSupp
            // 
            this.gpB_LDAPSupp.Controls.Add(this.lbl_LDAP_Support);
            this.gpB_LDAPSupp.Controls.Add(this.rb_LDAP_Support_SI);
            this.gpB_LDAPSupp.Controls.Add(this.rb_LDAP_Support_NO);
            this.gpB_LDAPSupp.Location = new System.Drawing.Point(24, 240);
            this.gpB_LDAPSupp.Name = "gpB_LDAPSupp";
            this.gpB_LDAPSupp.Size = new System.Drawing.Size(237, 57);
            this.gpB_LDAPSupp.TabIndex = 47;
            this.gpB_LDAPSupp.TabStop = false;
            this.gpB_LDAPSupp.Text = "Conexion AD/LDAP";
            this.gpB_LDAPSupp.MouseHover += new System.EventHandler(this.gpB_LDAPSupp_MouseHover);
            // 
            // lbl_LDAP_Support
            // 
            this.lbl_LDAP_Support.AutoSize = true;
            this.lbl_LDAP_Support.Location = new System.Drawing.Point(0, 22);
            this.lbl_LDAP_Support.Name = "lbl_LDAP_Support";
            this.lbl_LDAP_Support.Size = new System.Drawing.Size(107, 21);
            this.lbl_LDAP_Support.TabIndex = 33;
            this.lbl_LDAP_Support.Text = "Soporte LDAP";
            // 
            // rb_LDAP_Support_SI
            // 
            this.rb_LDAP_Support_SI.AutoSize = true;
            this.rb_LDAP_Support_SI.Location = new System.Drawing.Point(118, 18);
            this.rb_LDAP_Support_SI.Name = "rb_LDAP_Support_SI";
            this.rb_LDAP_Support_SI.Size = new System.Drawing.Size(48, 25);
            this.rb_LDAP_Support_SI.TabIndex = 34;
            this.rb_LDAP_Support_SI.TabStop = true;
            this.rb_LDAP_Support_SI.Text = "SI";
            this.rb_LDAP_Support_SI.UseVisualStyleBackColor = true;
            // 
            // rb_LDAP_Support_NO
            // 
            this.rb_LDAP_Support_NO.AutoSize = true;
            this.rb_LDAP_Support_NO.Location = new System.Drawing.Point(174, 18);
            this.rb_LDAP_Support_NO.Name = "rb_LDAP_Support_NO";
            this.rb_LDAP_Support_NO.Size = new System.Drawing.Size(59, 25);
            this.rb_LDAP_Support_NO.TabIndex = 35;
            this.rb_LDAP_Support_NO.TabStop = true;
            this.rb_LDAP_Support_NO.Text = "NO";
            this.rb_LDAP_Support_NO.UseVisualStyleBackColor = true;
            // 
            // gpB_Timeout
            // 
            this.gpB_Timeout.Controls.Add(this.lbl_Timeout_LDAP);
            this.gpB_Timeout.Controls.Add(this.nUD_Timeout_LDAP);
            this.gpB_Timeout.Location = new System.Drawing.Point(28, 312);
            this.gpB_Timeout.Name = "gpB_Timeout";
            this.gpB_Timeout.Size = new System.Drawing.Size(233, 52);
            this.gpB_Timeout.TabIndex = 46;
            this.gpB_Timeout.TabStop = false;
            this.gpB_Timeout.Text = "Timeout hacia LDAP";
            this.gpB_Timeout.MouseHover += new System.EventHandler(this.gpB_Timeout_MouseHover);
            // 
            // lbl_Timeout_LDAP
            // 
            this.lbl_Timeout_LDAP.AutoSize = true;
            this.lbl_Timeout_LDAP.Location = new System.Drawing.Point(7, 22);
            this.lbl_Timeout_LDAP.Name = "lbl_Timeout_LDAP";
            this.lbl_Timeout_LDAP.Size = new System.Drawing.Size(109, 21);
            this.lbl_Timeout_LDAP.TabIndex = 31;
            this.lbl_Timeout_LDAP.Text = "Timeout LDAP";
            // 
            // nUD_Timeout_LDAP
            // 
            this.nUD_Timeout_LDAP.Location = new System.Drawing.Point(149, 16);
            this.nUD_Timeout_LDAP.Name = "nUD_Timeout_LDAP";
            this.nUD_Timeout_LDAP.Size = new System.Drawing.Size(56, 28);
            this.nUD_Timeout_LDAP.TabIndex = 32;
            this.nUD_Timeout_LDAP.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // gp_SSL
            // 
            this.gp_SSL.Controls.Add(this.lbl_SSL);
            this.gp_SSL.Controls.Add(this.rb_SSL_SI);
            this.gp_SSL.Controls.Add(this.rb_SSL_NO);
            this.gp_SSL.Location = new System.Drawing.Point(25, 100);
            this.gp_SSL.Name = "gp_SSL";
            this.gp_SSL.Size = new System.Drawing.Size(237, 57);
            this.gp_SSL.TabIndex = 45;
            this.gp_SSL.TabStop = false;
            this.gp_SSL.Text = "Conexion SSL";
            this.gp_SSL.MouseHover += new System.EventHandler(this.gp_SSL_MouseHover);
            // 
            // lbl_SSL
            // 
            this.lbl_SSL.AutoSize = true;
            this.lbl_SSL.Location = new System.Drawing.Point(4, 22);
            this.lbl_SSL.Name = "lbl_SSL";
            this.lbl_SSL.Size = new System.Drawing.Size(72, 21);
            this.lbl_SSL.TabIndex = 15;
            this.lbl_SSL.Text = "Usar SSL";
            // 
            // rb_SSL_SI
            // 
            this.rb_SSL_SI.AutoSize = true;
            this.rb_SSL_SI.Location = new System.Drawing.Point(101, 18);
            this.rb_SSL_SI.Name = "rb_SSL_SI";
            this.rb_SSL_SI.Size = new System.Drawing.Size(48, 25);
            this.rb_SSL_SI.TabIndex = 16;
            this.rb_SSL_SI.TabStop = true;
            this.rb_SSL_SI.Text = "SI";
            this.rb_SSL_SI.UseVisualStyleBackColor = true;
            // 
            // rb_SSL_NO
            // 
            this.rb_SSL_NO.AutoSize = true;
            this.rb_SSL_NO.Location = new System.Drawing.Point(163, 18);
            this.rb_SSL_NO.Name = "rb_SSL_NO";
            this.rb_SSL_NO.Size = new System.Drawing.Size(59, 25);
            this.rb_SSL_NO.TabIndex = 17;
            this.rb_SSL_NO.TabStop = true;
            this.rb_SSL_NO.Text = "NO";
            this.rb_SSL_NO.UseVisualStyleBackColor = true;
            // 
            // gpB_PIN_Pass
            // 
            this.gpB_PIN_Pass.Controls.Add(this.lbl_PIN_PASS);
            this.gpB_PIN_Pass.Controls.Add(this.rb_Pass_PIN_SI);
            this.gpB_PIN_Pass.Controls.Add(this.rb_Pass_PIN_NO);
            this.gpB_PIN_Pass.Location = new System.Drawing.Point(25, 168);
            this.gpB_PIN_Pass.Name = "gpB_PIN_Pass";
            this.gpB_PIN_Pass.Size = new System.Drawing.Size(236, 53);
            this.gpB_PIN_Pass.TabIndex = 44;
            this.gpB_PIN_Pass.TabStop = false;
            this.gpB_PIN_Pass.Text = "Pin o Password";
            this.gpB_PIN_Pass.MouseHover += new System.EventHandler(this.gpB_PIN_Pass_MouseHover);
            // 
            // lbl_PIN_PASS
            // 
            this.lbl_PIN_PASS.AutoSize = true;
            this.lbl_PIN_PASS.Location = new System.Drawing.Point(6, 23);
            this.lbl_PIN_PASS.Name = "lbl_PIN_PASS";
            this.lbl_PIN_PASS.Size = new System.Drawing.Size(90, 21);
            this.lbl_PIN_PASS.TabIndex = 3;
            this.lbl_PIN_PASS.Text = "Escribir PIN";
            // 
            // rb_Pass_PIN_SI
            // 
            this.rb_Pass_PIN_SI.AutoSize = true;
            this.rb_Pass_PIN_SI.Location = new System.Drawing.Point(103, 19);
            this.rb_Pass_PIN_SI.Name = "rb_Pass_PIN_SI";
            this.rb_Pass_PIN_SI.Size = new System.Drawing.Size(48, 25);
            this.rb_Pass_PIN_SI.TabIndex = 4;
            this.rb_Pass_PIN_SI.TabStop = true;
            this.rb_Pass_PIN_SI.Text = "SI";
            this.rb_Pass_PIN_SI.UseVisualStyleBackColor = true;
            // 
            // rb_Pass_PIN_NO
            // 
            this.rb_Pass_PIN_NO.AutoSize = true;
            this.rb_Pass_PIN_NO.Location = new System.Drawing.Point(165, 19);
            this.rb_Pass_PIN_NO.Name = "rb_Pass_PIN_NO";
            this.rb_Pass_PIN_NO.Size = new System.Drawing.Size(59, 25);
            this.rb_Pass_PIN_NO.TabIndex = 5;
            this.rb_Pass_PIN_NO.TabStop = true;
            this.rb_Pass_PIN_NO.Text = "NO";
            this.rb_Pass_PIN_NO.UseVisualStyleBackColor = true;
            // 
            // gpB_Prefijo
            // 
            this.gpB_Prefijo.Controls.Add(this.lbl_Prefijo_PIN);
            this.gpB_Prefijo.Controls.Add(this.rb_Prefijo_SI);
            this.gpB_Prefijo.Controls.Add(this.rb_Prefijo_NO);
            this.gpB_Prefijo.Location = new System.Drawing.Point(29, 477);
            this.gpB_Prefijo.Name = "gpB_Prefijo";
            this.gpB_Prefijo.Size = new System.Drawing.Size(232, 57);
            this.gpB_Prefijo.TabIndex = 43;
            this.gpB_Prefijo.TabStop = false;
            this.gpB_Prefijo.Text = "Prefijo";
            this.gpB_Prefijo.MouseHover += new System.EventHandler(this.gpB_Prefijo_MouseHover);
            // 
            // lbl_Prefijo_PIN
            // 
            this.lbl_Prefijo_PIN.AutoSize = true;
            this.lbl_Prefijo_PIN.Location = new System.Drawing.Point(3, 27);
            this.lbl_Prefijo_PIN.Name = "lbl_Prefijo_PIN";
            this.lbl_Prefijo_PIN.Size = new System.Drawing.Size(81, 21);
            this.lbl_Prefijo_PIN.TabIndex = 0;
            this.lbl_Prefijo_PIN.Text = "Prefijo Pin";
            // 
            // rb_Prefijo_SI
            // 
            this.rb_Prefijo_SI.AutoSize = true;
            this.rb_Prefijo_SI.Location = new System.Drawing.Point(99, 23);
            this.rb_Prefijo_SI.Name = "rb_Prefijo_SI";
            this.rb_Prefijo_SI.Size = new System.Drawing.Size(48, 25);
            this.rb_Prefijo_SI.TabIndex = 1;
            this.rb_Prefijo_SI.TabStop = true;
            this.rb_Prefijo_SI.Text = "SI";
            this.rb_Prefijo_SI.UseVisualStyleBackColor = true;
            // 
            // rb_Prefijo_NO
            // 
            this.rb_Prefijo_NO.AutoSize = true;
            this.rb_Prefijo_NO.Location = new System.Drawing.Point(159, 23);
            this.rb_Prefijo_NO.Name = "rb_Prefijo_NO";
            this.rb_Prefijo_NO.Size = new System.Drawing.Size(59, 25);
            this.rb_Prefijo_NO.TabIndex = 2;
            this.rb_Prefijo_NO.TabStop = true;
            this.rb_Prefijo_NO.Text = "NO";
            this.rb_Prefijo_NO.UseVisualStyleBackColor = true;
            // 
            // pB_Sync
            // 
            this.pB_Sync.Image = ((System.Drawing.Image)(resources.GetObject("pB_Sync.Image")));
            this.pB_Sync.InitialImage = ((System.Drawing.Image)(resources.GetObject("pB_Sync.InitialImage")));
            this.pB_Sync.Location = new System.Drawing.Point(12, 28);
            this.pB_Sync.Name = "pB_Sync";
            this.pB_Sync.Size = new System.Drawing.Size(55, 56);
            this.pB_Sync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Sync.TabIndex = 40;
            this.pB_Sync.TabStop = false;
            // 
            // btn_Sincronizar
            // 
            this.btn_Sincronizar.Location = new System.Drawing.Point(73, 28);
            this.btn_Sincronizar.Name = "btn_Sincronizar";
            this.btn_Sincronizar.Size = new System.Drawing.Size(117, 56);
            this.btn_Sincronizar.TabIndex = 39;
            this.btn_Sincronizar.Text = "Sincronizar Usuarios Dominio";
            this.btn_Sincronizar.UseVisualStyleBackColor = true;
            this.btn_Sincronizar.Click += new System.EventHandler(this.btn_Sincronizar_Click);
            this.btn_Sincronizar.MouseHover += new System.EventHandler(this.btn_Sincronizar_MouseHover);
            // 
            // btn_Aplicar
            // 
            this.btn_Aplicar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Aplicar.Location = new System.Drawing.Point(84, 28);
            this.btn_Aplicar.Name = "btn_Aplicar";
            this.btn_Aplicar.Size = new System.Drawing.Size(148, 56);
            this.btn_Aplicar.TabIndex = 38;
            this.btn_Aplicar.Text = "Aplicar Cambios";
            this.btn_Aplicar.UseVisualStyleBackColor = false;
            this.btn_Aplicar.Click += new System.EventHandler(this.btn_Aplicar_Click);
            this.btn_Aplicar.MouseHover += new System.EventHandler(this.btn_Aplicar_MouseHover);
            // 
            // txt_Secreto
            // 
            this.txt_Secreto.Location = new System.Drawing.Point(516, 451);
            this.txt_Secreto.Name = "txt_Secreto";
            this.txt_Secreto.Size = new System.Drawing.Size(232, 28);
            this.txt_Secreto.TabIndex = 37;
            this.txt_Secreto.Text = "secretClient";
            this.txt_Secreto.Leave += new System.EventHandler(this.txt_Secreto_Leave);
            // 
            // lbl_Clave_Secret
            // 
            this.lbl_Clave_Secret.AutoSize = true;
            this.lbl_Clave_Secret.Location = new System.Drawing.Point(316, 455);
            this.lbl_Clave_Secret.Name = "lbl_Clave_Secret";
            this.lbl_Clave_Secret.Size = new System.Drawing.Size(177, 21);
            this.lbl_Clave_Secret.TabIndex = 36;
            this.lbl_Clave_Secret.Text = "Clave Secreta Clientes =";
            // 
            // txt_Filtro_Grupo
            // 
            this.txt_Filtro_Grupo.Location = new System.Drawing.Point(516, 409);
            this.txt_Filtro_Grupo.Name = "txt_Filtro_Grupo";
            this.txt_Filtro_Grupo.Size = new System.Drawing.Size(232, 28);
            this.txt_Filtro_Grupo.TabIndex = 30;
            this.txt_Filtro_Grupo.Text = "GrupoMFA";
            // 
            // lbl_Filtro_Grupo
            // 
            this.lbl_Filtro_Grupo.AutoSize = true;
            this.lbl_Filtro_Grupo.Location = new System.Drawing.Point(316, 413);
            this.lbl_Filtro_Grupo.Name = "lbl_Filtro_Grupo";
            this.lbl_Filtro_Grupo.Size = new System.Drawing.Size(134, 21);
            this.lbl_Filtro_Grupo.TabIndex = 29;
            this.lbl_Filtro_Grupo.Text = "Filtro Grupo AD =";
            // 
            // txt_Contrasena
            // 
            this.txt_Contrasena.Location = new System.Drawing.Point(516, 372);
            this.txt_Contrasena.Name = "txt_Contrasena";
            this.txt_Contrasena.PasswordChar = '*';
            this.txt_Contrasena.Size = new System.Drawing.Size(190, 28);
            this.txt_Contrasena.TabIndex = 28;
            this.txt_Contrasena.Text = "DOMAINPASS";
            this.txt_Contrasena.Leave += new System.EventHandler(this.txt_Contrasena_Leave);
            // 
            // lbl_Pass_Dominio
            // 
            this.lbl_Pass_Dominio.AutoSize = true;
            this.lbl_Pass_Dominio.Location = new System.Drawing.Point(316, 376);
            this.lbl_Pass_Dominio.Name = "lbl_Pass_Dominio";
            this.lbl_Pass_Dominio.Size = new System.Drawing.Size(168, 21);
            this.lbl_Pass_Dominio.TabIndex = 27;
            this.lbl_Pass_Dominio.Text = "Contrasena Dominio =";
            // 
            // txt_Dir_Admin_Dominio
            // 
            this.txt_Dir_Admin_Dominio.Location = new System.Drawing.Point(516, 338);
            this.txt_Dir_Admin_Dominio.Name = "txt_Dir_Admin_Dominio";
            this.txt_Dir_Admin_Dominio.Size = new System.Drawing.Size(232, 28);
            this.txt_Dir_Admin_Dominio.TabIndex = 26;
            this.txt_Dir_Admin_Dominio.Text = "CN=Soporte,CN=Users,DC=midominio,DC=co,DC=com";
            this.txt_Dir_Admin_Dominio.Leave += new System.EventHandler(this.txt_Dir_Admin_Dominio_Leave);
            // 
            // lbl_Dir_Adm_Dominio
            // 
            this.lbl_Dir_Adm_Dominio.AutoSize = true;
            this.lbl_Dir_Adm_Dominio.Location = new System.Drawing.Point(316, 338);
            this.lbl_Dir_Adm_Dominio.Name = "lbl_Dir_Adm_Dominio";
            this.lbl_Dir_Adm_Dominio.Size = new System.Drawing.Size(166, 21);
            this.lbl_Dir_Adm_Dominio.TabIndex = 25;
            this.lbl_Dir_Adm_Dominio.Text = "Cuenta Admin LDAP =";
            this.lbl_Dir_Adm_Dominio.MouseHover += new System.EventHandler(this.lbl_Dir_Adm_Dominio_MouseHover);
            // 
            // txt_Dir_Base_DN
            // 
            this.txt_Dir_Base_DN.Location = new System.Drawing.Point(516, 297);
            this.txt_Dir_Base_DN.Name = "txt_Dir_Base_DN";
            this.txt_Dir_Base_DN.Size = new System.Drawing.Size(232, 28);
            this.txt_Dir_Base_DN.TabIndex = 24;
            this.txt_Dir_Base_DN.Text = "DC=midominio,DC=co,DC=com";
            this.txt_Dir_Base_DN.Leave += new System.EventHandler(this.txt_Dir_Base_DN_Leave);
            // 
            // lbl_Dir_Base_DN
            // 
            this.lbl_Dir_Base_DN.AutoSize = true;
            this.lbl_Dir_Base_DN.Location = new System.Drawing.Point(316, 301);
            this.lbl_Dir_Base_DN.Name = "lbl_Dir_Base_DN";
            this.lbl_Dir_Base_DN.Size = new System.Drawing.Size(153, 21);
            this.lbl_Dir_Base_DN.TabIndex = 23;
            this.lbl_Dir_Base_DN.Text = "Direccion Base DN =";
            // 
            // txt_IP_Dominio
            // 
            this.txt_IP_Dominio.Location = new System.Drawing.Point(611, 265);
            this.txt_IP_Dominio.MaxLength = 33;
            this.txt_IP_Dominio.Name = "txt_IP_Dominio";
            this.txt_IP_Dominio.Size = new System.Drawing.Size(137, 28);
            this.txt_IP_Dominio.TabIndex = 22;
            this.txt_IP_Dominio.Text = "192.168.100.14";
            this.txt_IP_Dominio.Leave += new System.EventHandler(this.txt_IP_Dominio_Leave);
            // 
            // txt_Nombre_Dominio
            // 
            this.txt_Nombre_Dominio.Location = new System.Drawing.Point(516, 236);
            this.txt_Nombre_Dominio.Name = "txt_Nombre_Dominio";
            this.txt_Nombre_Dominio.Size = new System.Drawing.Size(232, 28);
            this.txt_Nombre_Dominio.TabIndex = 21;
            this.txt_Nombre_Dominio.Text = "midominio.co.com";
            this.txt_Nombre_Dominio.Leave += new System.EventHandler(this.txt_Nombre_Dominio_Leave);
            // 
            // lbl_NombreAD
            // 
            this.lbl_NombreAD.AutoSize = true;
            this.lbl_NombreAD.Location = new System.Drawing.Point(316, 240);
            this.lbl_NombreAD.Name = "lbl_NombreAD";
            this.lbl_NombreAD.Size = new System.Drawing.Size(147, 21);
            this.lbl_NombreAD.TabIndex = 20;
            this.lbl_NombreAD.Text = "Nombre Dominio =";
            // 
            // txt_PuertoLDAP
            // 
            this.txt_PuertoLDAP.Location = new System.Drawing.Point(516, 205);
            this.txt_PuertoLDAP.MaxLength = 4;
            this.txt_PuertoLDAP.Name = "txt_PuertoLDAP";
            this.txt_PuertoLDAP.Size = new System.Drawing.Size(232, 28);
            this.txt_PuertoLDAP.TabIndex = 19;
            this.txt_PuertoLDAP.Text = "389";
            this.txt_PuertoLDAP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PuertoLDAP_KeyPress);
            this.txt_PuertoLDAP.Leave += new System.EventHandler(this.txt_PuertoLDAP_Leave);
            // 
            // lbl_Puerto_LDAP
            // 
            this.lbl_Puerto_LDAP.AutoSize = true;
            this.lbl_Puerto_LDAP.Location = new System.Drawing.Point(316, 209);
            this.lbl_Puerto_LDAP.Name = "lbl_Puerto_LDAP";
            this.lbl_Puerto_LDAP.Size = new System.Drawing.Size(113, 21);
            this.lbl_Puerto_LDAP.TabIndex = 18;
            this.lbl_Puerto_LDAP.Text = "Puerto LDAP =";
            this.lbl_Puerto_LDAP.MouseHover += new System.EventHandler(this.lbl_Puerto_LDAP_MouseHover);
            // 
            // txt_Atributo_Grupo
            // 
            this.txt_Atributo_Grupo.Location = new System.Drawing.Point(516, 164);
            this.txt_Atributo_Grupo.Name = "txt_Atributo_Grupo";
            this.txt_Atributo_Grupo.Size = new System.Drawing.Size(232, 28);
            this.txt_Atributo_Grupo.TabIndex = 14;
            this.txt_Atributo_Grupo.Text = "memberof";
            this.txt_Atributo_Grupo.Leave += new System.EventHandler(this.txt_Atributo_Grupo_Leave);
            // 
            // lbl_Atributo_Grupo
            // 
            this.lbl_Atributo_Grupo.AutoSize = true;
            this.lbl_Atributo_Grupo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Atributo_Grupo.Location = new System.Drawing.Point(316, 168);
            this.lbl_Atributo_Grupo.Name = "lbl_Atributo_Grupo";
            this.lbl_Atributo_Grupo.Size = new System.Drawing.Size(130, 21);
            this.lbl_Atributo_Grupo.TabIndex = 13;
            this.lbl_Atributo_Grupo.Text = "Atributo Grupo =";
            // 
            // txt_IdentificadorGrupo
            // 
            this.txt_IdentificadorGrupo.Location = new System.Drawing.Point(516, 128);
            this.txt_IdentificadorGrupo.Name = "txt_IdentificadorGrupo";
            this.txt_IdentificadorGrupo.Size = new System.Drawing.Size(232, 28);
            this.txt_IdentificadorGrupo.TabIndex = 12;
            this.txt_IdentificadorGrupo.Text = "sAMAccountName";
            this.txt_IdentificadorGrupo.Leave += new System.EventHandler(this.txt_IdentificadorGrupo_Leave);
            // 
            // lbl_IdentificadorGrupo
            // 
            this.lbl_IdentificadorGrupo.AutoSize = true;
            this.lbl_IdentificadorGrupo.Location = new System.Drawing.Point(316, 131);
            this.lbl_IdentificadorGrupo.Name = "lbl_IdentificadorGrupo";
            this.lbl_IdentificadorGrupo.Size = new System.Drawing.Size(186, 21);
            this.lbl_IdentificadorGrupo.TabIndex = 11;
            this.lbl_IdentificadorGrupo.Text = "Identificador Grupo CN =";
            // 
            // txt_CuentaCN
            // 
            this.txt_CuentaCN.Location = new System.Drawing.Point(516, 96);
            this.txt_CuentaCN.Name = "txt_CuentaCN";
            this.txt_CuentaCN.Size = new System.Drawing.Size(232, 28);
            this.txt_CuentaCN.TabIndex = 10;
            this.txt_CuentaCN.Text = "sAMAccountName";
            this.txt_CuentaCN.Leave += new System.EventHandler(this.txt_CuentaCN_Leave);
            // 
            // lbl_Identificador
            // 
            this.lbl_Identificador.AutoSize = true;
            this.lbl_Identificador.Location = new System.Drawing.Point(316, 100);
            this.lbl_Identificador.Name = "lbl_Identificador";
            this.lbl_Identificador.Size = new System.Drawing.Size(191, 21);
            this.lbl_Identificador.TabIndex = 9;
            this.lbl_Identificador.Text = "Identificador Cuenta CN =";
            // 
            // btn_cargarConfig
            // 
            this.btn_cargarConfig.BackColor = System.Drawing.Color.Salmon;
            this.btn_cargarConfig.Location = new System.Drawing.Point(84, 120);
            this.btn_cargarConfig.Name = "btn_cargarConfig";
            this.btn_cargarConfig.Size = new System.Drawing.Size(148, 53);
            this.btn_cargarConfig.TabIndex = 58;
            this.btn_cargarConfig.Text = "Cargar Conf Actual";
            this.btn_cargarConfig.UseVisualStyleBackColor = false;
            this.btn_cargarConfig.Click += new System.EventHandler(this.btn_cargarConfig_Click);
            // 
            // gpB_Sincronizacion
            // 
            this.gpB_Sincronizacion.Controls.Add(this.pb_Task);
            this.gpB_Sincronizacion.Controls.Add(this.btn_Sincronizar);
            this.gpB_Sincronizacion.Controls.Add(this.pB_Sync);
            this.gpB_Sincronizacion.Controls.Add(this.btn_Tarea);
            this.gpB_Sincronizacion.Location = new System.Drawing.Point(320, 483);
            this.gpB_Sincronizacion.Name = "gpB_Sincronizacion";
            this.gpB_Sincronizacion.Size = new System.Drawing.Size(428, 99);
            this.gpB_Sincronizacion.TabIndex = 59;
            this.gpB_Sincronizacion.TabStop = false;
            this.gpB_Sincronizacion.Text = "Sincronizacion";
            // 
            // pB_Pass
            // 
            this.pB_Pass.Image = ((System.Drawing.Image)(resources.GetObject("pB_Pass.Image")));
            this.pB_Pass.Location = new System.Drawing.Point(719, 371);
            this.pB_Pass.Name = "pB_Pass";
            this.pB_Pass.Size = new System.Drawing.Size(29, 27);
            this.pB_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Pass.TabIndex = 60;
            this.pB_Pass.TabStop = false;
            this.pB_Pass.MouseLeave += new System.EventHandler(this.pB_Pass_MouseLeave);
            this.pB_Pass.MouseHover += new System.EventHandler(this.pB_Pass_MouseHover);
            // 
            // pb_Task
            // 
            this.pb_Task.Image = ((System.Drawing.Image)(resources.GetObject("pb_Task.Image")));
            this.pb_Task.Location = new System.Drawing.Point(224, 26);
            this.pb_Task.Name = "pb_Task";
            this.pb_Task.Size = new System.Drawing.Size(44, 56);
            this.pb_Task.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Task.TabIndex = 58;
            this.pb_Task.TabStop = false;
            // 
            // gpB_Datos
            // 
            this.gpB_Datos.Controls.Add(this.pb_Load);
            this.gpB_Datos.Controls.Add(this.pb_Apply);
            this.gpB_Datos.Controls.Add(this.btn_Aplicar);
            this.gpB_Datos.Controls.Add(this.btn_cargarConfig);
            this.gpB_Datos.Location = new System.Drawing.Point(774, 409);
            this.gpB_Datos.Name = "gpB_Datos";
            this.gpB_Datos.Size = new System.Drawing.Size(238, 183);
            this.gpB_Datos.TabIndex = 61;
            this.gpB_Datos.TabStop = false;
            this.gpB_Datos.Text = "Datos";
            // 
            // pb_Apply
            // 
            this.pb_Apply.Image = ((System.Drawing.Image)(resources.GetObject("pb_Apply.Image")));
            this.pb_Apply.Location = new System.Drawing.Point(19, 28);
            this.pb_Apply.Name = "pb_Apply";
            this.pb_Apply.Size = new System.Drawing.Size(47, 56);
            this.pb_Apply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Apply.TabIndex = 59;
            this.pb_Apply.TabStop = false;
            // 
            // pb_Load
            // 
            this.pb_Load.Image = ((System.Drawing.Image)(resources.GetObject("pb_Load.Image")));
            this.pb_Load.Location = new System.Drawing.Point(19, 120);
            this.pb_Load.Name = "pb_Load";
            this.pb_Load.Size = new System.Drawing.Size(47, 53);
            this.pb_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Load.TabIndex = 62;
            this.pb_Load.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1063, 632);
            this.Controls.Add(this.gpB_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de MultiOTP";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.gpB_Menu.ResumeLayout(false);
            this.gpB_Menu.PerformLayout();
            this.gpB_Elegir_Arch.ResumeLayout(false);
            this.gpB_Elegir_Arch.PerformLayout();
            this.gp_TipoAD.ResumeLayout(false);
            this.gp_TipoAD.PerformLayout();
            this.gpB_TimeoutServer.ResumeLayout(false);
            this.gpB_TimeoutServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Transact)).EndInit();
            this.gpB_LDAPSupp.ResumeLayout(false);
            this.gpB_LDAPSupp.PerformLayout();
            this.gpB_Timeout.ResumeLayout(false);
            this.gpB_Timeout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Timeout_LDAP)).EndInit();
            this.gp_SSL.ResumeLayout(false);
            this.gp_SSL.PerformLayout();
            this.gpB_PIN_Pass.ResumeLayout(false);
            this.gpB_PIN_Pass.PerformLayout();
            this.gpB_Prefijo.ResumeLayout(false);
            this.gpB_Prefijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Sync)).EndInit();
            this.gpB_Sincronizacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Task)).EndInit();
            this.gpB_Datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Apply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpB_Menu;
        private System.Windows.Forms.RadioButton rb_Prefijo_SI;
        private System.Windows.Forms.Label lbl_Prefijo_PIN;
        private System.Windows.Forms.RadioButton rb_OPEN_LDAP;
        private System.Windows.Forms.RadioButton rb_Active_DIrectoy;
        private System.Windows.Forms.Label lbl_tipo_AD;
        private System.Windows.Forms.RadioButton rb_Pass_PIN_NO;
        private System.Windows.Forms.RadioButton rb_Pass_PIN_SI;
        private System.Windows.Forms.Label lbl_PIN_PASS;
        private System.Windows.Forms.RadioButton rb_Prefijo_NO;
        private System.Windows.Forms.TextBox txt_CuentaCN;
        private System.Windows.Forms.Label lbl_Identificador;
        private System.Windows.Forms.TextBox txt_IdentificadorGrupo;
        private System.Windows.Forms.Label lbl_IdentificadorGrupo;
        private System.Windows.Forms.RadioButton rb_SSL_NO;
        private System.Windows.Forms.RadioButton rb_SSL_SI;
        private System.Windows.Forms.Label lbl_SSL;
        private System.Windows.Forms.TextBox txt_Atributo_Grupo;
        private System.Windows.Forms.Label lbl_Atributo_Grupo;
        private System.Windows.Forms.TextBox txt_PuertoLDAP;
        private System.Windows.Forms.Label lbl_Puerto_LDAP;
        private System.Windows.Forms.TextBox txt_Dir_Admin_Dominio;
        private System.Windows.Forms.Label lbl_Dir_Adm_Dominio;
        private System.Windows.Forms.TextBox txt_Dir_Base_DN;
        private System.Windows.Forms.Label lbl_Dir_Base_DN;
        private System.Windows.Forms.TextBox txt_IP_Dominio;
        private System.Windows.Forms.TextBox txt_Nombre_Dominio;
        private System.Windows.Forms.Label lbl_NombreAD;
        private System.Windows.Forms.TextBox txt_Filtro_Grupo;
        private System.Windows.Forms.Label lbl_Filtro_Grupo;
        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.Label lbl_Pass_Dominio;
        private System.Windows.Forms.PictureBox pB_Sync;
        private System.Windows.Forms.Button btn_Sincronizar;
        private System.Windows.Forms.Button btn_Aplicar;
        private System.Windows.Forms.TextBox txt_Secreto;
        private System.Windows.Forms.Label lbl_Clave_Secret;
        private System.Windows.Forms.RadioButton rb_LDAP_Support_NO;
        private System.Windows.Forms.RadioButton rb_LDAP_Support_SI;
        private System.Windows.Forms.Label lbl_LDAP_Support;
        private System.Windows.Forms.NumericUpDown nUD_Timeout_LDAP;
        private System.Windows.Forms.Label lbl_Timeout_LDAP;
        private System.Windows.Forms.NumericUpDown nUD_Transact;
        private System.Windows.Forms.Label lbl_Tiempo_Transact;
        private System.Windows.Forms.GroupBox gpB_Prefijo;
        private System.Windows.Forms.GroupBox gpB_PIN_Pass;
        private System.Windows.Forms.GroupBox gp_TipoAD;
        private System.Windows.Forms.GroupBox gpB_TimeoutServer;
        private System.Windows.Forms.GroupBox gpB_LDAPSupp;
        private System.Windows.Forms.GroupBox gpB_Timeout;
        private System.Windows.Forms.GroupBox gp_SSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Protocolo;
        private System.Windows.Forms.ToolTip tT_Message;
        private System.Windows.Forms.Button btn_Elegir_Archivo;
        private System.Windows.Forms.Label lbl_File;
        private System.Windows.Forms.GroupBox gpB_Elegir_Arch;
        private System.Windows.Forms.Button btn_Tarea;
        private System.Windows.Forms.Button btn_cargarConfig;
        private System.Windows.Forms.GroupBox gpB_Sincronizacion;
        private System.Windows.Forms.PictureBox pB_Pass;
        private System.Windows.Forms.GroupBox gpB_Datos;
        private System.Windows.Forms.PictureBox pb_Load;
        private System.Windows.Forms.PictureBox pb_Apply;
        private System.Windows.Forms.PictureBox pb_Task;
    }
}