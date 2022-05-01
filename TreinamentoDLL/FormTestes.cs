using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unimake.Business.DFe.Xml.NFe;
using Unimake.Security.Platform;
using Unimake.Business.DFe.Servicos;
using Unimake.Business.DFe.Servicos.NFe;

namespace TreinamentoDLL
{
    public partial class FormTestes : Form
    {
        public FormTestes() => InitializeComponent();

        private void FormTestes_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultaStatusNFe_Click(object sender, EventArgs e)
        {

            var xml = new ConsStatServ
            {

                Versao = "4.00",
                CUF = UFBrasil.AM,
                TpAmb = TipoAmbiente.Homologacao
            };

            var configuracao = new Configuracao
            {
                TipoDFe = TipoDFe.NFe,
                TipoEmissao = TipoEmissao.Normal,
                CertificadoDigital = CertificadoSelecionado
            };

            var statusServico = new StatusServico(xml, configuracao);

            statusServico.Executar();

            MessageBox.Show(statusServico.Result.CStat + " " + statusServico.Result.XMotivo);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultaSituacao_Click(object sender, EventArgs e)
        {

        }

        #region Certificado Digital

        /// <summary>
        /// Caminho Completo do Certificado
        /// </summary>
        private static string CaminhoCertificadoDigital { get; set; } = @"C:\Dropbox\AGROPAM\AGROPAM 2022.pfx";
        
        /// <summary>
        /// Senha do Certificado
        /// </summary>
        private static string SenhaCertificadoDigital { get; set; } = "senhaadescobrir";

        /// <summary>
        /// Campo para o Certificado Selecionado
        /// </summary>
        private static X509Certificate2 CertificadoSelecionadoCampo;

        public static X509Certificate2 CertificadoSelecionado 
        {
            get 
            {
                if (CertificadoSelecionadoCampo == null) 
                {
                    CertificadoSelecionadoCampo = new CertificadoDigital().CarregarCertificadoDigitalA1(CaminhoCertificadoDigital, SenhaCertificadoDigital);
                }

                return CertificadoSelecionadoCampo;
            }

            private set => throw new Exception("Não é possível atribuir um certificado digital ! Somente resgate o valor da propriedade que o certificado é definido automaticamente.");
        }


        #endregion

    }
}
