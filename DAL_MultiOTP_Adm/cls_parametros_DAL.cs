using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_MultiOTP_Adm
{
    public class cls_parametros_DAL
    {
        #region Globales

        private string _sCN_User, _sCN_Group, _sAttributGroup, _sPortNum, _sDomain, _sIPDomain, _sBaseDN,
            _sDomainUser, _sPassword, _sFilter, _sSecret, _sSync, _sProtoc, _sFilePath, _sMsjErr, _sConfigPath, _sMsjAviso;


        private byte _bTimeout, _bTimeTransact;

        private char _cPrefixPIN, _cLDAP_Pass, _cLDAP_Type, _cSSL_Enable, _cLDAP_Support;



        #endregion


        #region Publicas

        public string sCN_User { get => _sCN_User; set => _sCN_User = value; }
        public string sCN_Group { get => _sCN_Group; set => _sCN_Group = value; }
        public string sAttributGroup { get => _sAttributGroup; set => _sAttributGroup = value; }
        public string sPortNum { get => _sPortNum; set => _sPortNum = value; }
        public string sDomain { get => _sDomain; set => _sDomain = value; }
        public string sIPDomain { get => _sIPDomain; set => _sIPDomain = value; }
        public string sBaseDN { get => _sBaseDN; set => _sBaseDN = value; }
        public string sDomainUser { get => _sDomainUser; set => _sDomainUser = value; }
        public string sPassword { get => _sPassword; set => _sPassword = value; }
        public string sFilter { get => _sFilter; set => _sFilter = value; }
        public string sSecret { get => _sSecret; set => _sSecret = value; }
        public string sSync { get => _sSync; set => _sSync = value; }
        public byte bTimeout { get => _bTimeout; set => _bTimeout = value; }
        public byte bTimeTransact { get => _bTimeTransact; set => _bTimeTransact = value; }
        public char cPrefixPIN { get => _cPrefixPIN; set => _cPrefixPIN = value; }
        public char cLDAP_Pass { get => _cLDAP_Pass; set => _cLDAP_Pass = value; }
        public char cLDAP_Type { get => _cLDAP_Type; set => _cLDAP_Type = value; }
        public char cSSL_Enable { get => _cSSL_Enable; set => _cSSL_Enable = value; }
        public char cLDAP_Support { get => _cLDAP_Support; set => _cLDAP_Support = value; }
        public string sProtoc { get => _sProtoc; set => _sProtoc = value; }
        public string sFilePath { get => _sFilePath; set => _sFilePath = value; }
        public string sMsjErr { get => _sMsjErr; set => _sMsjErr = value; }
        public string sConfigPath { get => _sConfigPath; set => _sConfigPath = value; }
        public string sMsjAviso { get => _sMsjAviso; set => _sMsjAviso = value; }

        #endregion

    }
}
