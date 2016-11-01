using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGICA_DE_NEGOCIOS;

namespace instaladorServidor
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsSeguridad HWK = new clsSeguridad();
            txtServerIp.Text = HWK.GetServerName();
            int vVer = HWK.VerificaInstalacion();
            txtHWK.ReadOnly = true;
            if (vVer == 0)
            {
                btnSolicitar.Enabled = false;


                MessageBox.Show("El Servidor ya se encuentra registrado, debe verificar Licencia",
                                "Error",
                                 MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1);

                clsCodificacion Seg = new clsCodificacion();




                Seg = null;

            }
            HWK = null;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            clsCodificacion Seg = new clsCodificacion();
            string vEmpresa = txtEmpresa.Text;
           
            if (vEmpresa.Length>10)
            {
                if (Seg.ComprobarFormatoEmail(txtMail.Text))
                {
                    txtMail.ForeColor = Color.Black;
                    clsSeguridad HWK = new clsSeguridad();
                    txtHWK.Text = HWK.CrearInstalacion(HWK.getCadenaHWK(vEmpresa,txtMail.Text));
                   
                    //txtDecifrado.Text = Seg.descifrar(txtHWK.Text);
                    HWK = null;
                }
                else
                {
                    MessageBox.Show("Formato de Correo invalido",
                                    "Direccion invalida",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1);
                                    txtMail.ForeColor = Color.Red;
                }
            }
            else
            {
             
                MessageBox.Show("El nombre de la empresa debe ser mas largo.",
                                    "Error Solcitud",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1);

            }
            Seg = null;
           
        }

        private void txtHWK_Click(object sender, EventArgs e)
        {
            txtHWK.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construccion");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
