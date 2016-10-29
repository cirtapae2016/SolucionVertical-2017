using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;




namespace LOGICA_DE_NEGOCIOS
{
    public class clsSeguridad
    {
        private string _SerialHDPuro;
        private string _IPMaquina;
        public clsSeguridad()
        {
            WqlObjectQuery wqlQuery = new WqlObjectQuery("SELECT * FROM Win32_DiskDrive");
            ManagementObjectSearcher informaciondisco = new ManagementObjectSearcher(wqlQuery);
            foreach (ManagementObject infodisco in informaciondisco.Get())
            {
                if (infodisco["SerialNumber"] != null)
                    _SerialHDPuro = infodisco["SerialNumber"].ToString();
            }

            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    _IPMaquina = ip.ToString();
                }
            }
        }
        public string SerialHD
        {
            get { return _SerialHDPuro; }
        }
        public string getCadenaHWK(string vEmpresa, string vEmail)
        {
            string _CadenaSinCifrar;
            clsSeguridad HWK = new clsSeguridad();
            _CadenaSinCifrar = ("##" + GetMACAddress()  +"##" + HWK.IPMaquina + "##"
                + vEmpresa + "##" + HWK.SerialHD + "##" + vEmail + "##");
            return _CadenaSinCifrar;
        }
        public string IPMaquina
        {
            get { return _IPMaquina; }
        }
        public static string GetMACAddress()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration where IPEnabled=true");
            IEnumerable<ManagementObject> objects = searcher.Get().Cast<ManagementObject>();
            string mac = (from o in objects orderby o["IPConnectionMetric"] select o["MACAddress"].ToString()).FirstOrDefault();
            return mac;
        }
        private string KeyPath = "Software\\HPFVertical";
        private string ValueName = "Hardware Key";
        private string ValueName1 = "AUTHT";
        public int VerificaInstalacion()
        {
           
            RegistryKey key;
            key = Registry.CurrentUser.OpenSubKey(KeyPath, true);
            if (key == null)
                {
                   return 1;
                }
            else
                {
                return 0;
            }
            key.Close();
            key = null;
         
        }
        public string CrearInstalacion(string vClaveServer)
        {
            string vHWK = vClaveServer;
            clsCodificacion Seg = new clsCodificacion();
            DateTime Hoy = DateTime.Now;
            DateTime Expiracion = Hoy.AddDays(36);
            string muestra1 = Seg.cifrar(Expiracion.ToString("dd-MM-yyyy"));
            vHWK = vHWK + Expiracion.ToString("dd-MM-yyyy") + "##";
            vHWK = Seg.cifrar(vHWK);
            //string KeyPath = "Software\\HPFVertical";
            //string ValueName = "Hardware Key";
            //string ValueName1 = "AUTHT";
            RegistryKey key;
            key = Registry.CurrentUser.OpenSubKey(KeyPath, true);
            if (key != null)

            {
                vHWK = Seg.cifrar("Producto ya instalado, Debe validar instalación");


                //key.SetValue(ValueName, "Lo modifique");
            }
            else
            {
                key = Registry.CurrentUser.CreateSubKey(KeyPath);
                key.SetValue(ValueName, vHWK);
                key.SetValue(ValueName1, muestra1);
                key.Close();

                // comunicarse con el WebServer y grabaar datos d cliente en la web

            }

            key = null;
            return vHWK;
        }

        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("");
            Con.Open();

            DataSet DS = new DataSet();

            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;
        }
    }
}
