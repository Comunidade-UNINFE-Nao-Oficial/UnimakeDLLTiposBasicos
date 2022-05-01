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
        public FormTestes() 
        {

            InitializeComponent();

            this.textBoxArqCert.Text = @"C:\Temp\CertificadoA1.pfx";
            CaminhoCertificadoDigital = this.textBoxArqCert.Text;

            this.textBoxSenhaCert.Text = "";
            SenhaCertificadoDigital = this.textBoxSenhaCert.Text;

        } 

        private void FormTestes_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Consulta Status da NFe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultaStatusNFe_Click(object sender, EventArgs e)
        {
            this.textBox_resultado.Text = "";

            try
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

                //MessageBox.Show(statusServico.Result.CStat + " " + statusServico.Result.XMotivo);
                this.textBox_resultado.Text = statusServico.Result.CStat + " " + statusServico.Result.XMotivo;

            }
            catch (Exception ex)
            {

                this.textBox_resultado.Text = ex.Message;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsultaSituacao_Click(object sender, EventArgs e)
        {
            this.textBox_resultado.Text = "";

            try
            {

                var xml = new ConsSitNFe
                {
                    Versao = "4.00",
                    TpAmb = TipoAmbiente.Homologacao,
                    ChNFe = "13220404818357000132550040000026161900128580"
                };

                var configuracao = new Configuracao
                {
                    TipoDFe = TipoDFe.NFe,
                    TipoEmissao = TipoEmissao.Normal,
                    CertificadoDigital = CertificadoSelecionado
                };

                var consultaProtocolo = new ConsultaProtocolo(xml, configuracao);

                consultaProtocolo.Executar();

                //MessageBox.Show(consultaProtocolo.Result.CStat + " " + consultaProtocolo.Result.XMotivo);
                this.textBox_resultado.Text = consultaProtocolo.Result.CStat + " " + consultaProtocolo.Result.XMotivo;

            }
            catch (Exception ex)
            {

                this.textBox_resultado.Text = ex.Message;
            }

        }

        #region Certificado Digital

        /// <summary>
        /// Caminho Completo do Certificado
        /// </summary>
        private static string CaminhoCertificadoDigital; //{ get; set; } = @"C:\Dropbox\MULTBEEF\MULTBEEF.pfx";

        /// <summary>
        /// Deixa escolher o arquivo pfx e atualiza CaminhoCertificadoDigital
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxArqCert_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.RestoreDirectory = true;
                    dlg.Filter = "Arquivos pfx|*.pfx";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        if (!string.IsNullOrEmpty(dlg.FileName))
                        {
                            this.textBoxArqCert.Text = dlg.FileName;
                            CaminhoCertificadoDigital = this.textBoxArqCert.Text;
                        }
                    }

                }

            }
        }

        /// <summary>
        /// Atualiza SenhaCertificadoDigital pelo textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSenhaCert_TextChanged(object sender, EventArgs e)
        {
            SenhaCertificadoDigital = this.textBoxSenhaCert.Text;
            CertificadoSelecionadoCampo = null;
        }

        /// <summary>
        /// Senha do Certificado
        /// </summary>
        private static string SenhaCertificadoDigital; //{ get; set; } = "ALGUMASENHA";

        /// <summary>
        /// Campo para o Certificado Selecionado
        /// </summary>
        private static X509Certificate2 CertificadoSelecionadoCampo;

        /// <summary>
        /// Campo para o Certificado Selecionado
        /// </summary>
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
