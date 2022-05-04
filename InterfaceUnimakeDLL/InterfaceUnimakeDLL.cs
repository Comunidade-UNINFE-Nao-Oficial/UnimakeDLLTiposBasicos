using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Unimake.Business.DFe.Xml.NFe;
using Unimake.Security.Platform;
using Unimake.Business.DFe.Servicos;
using Unimake.Business.DFe.Servicos.NFe;

namespace InterfaceUnimakeDLL
{
    public class InterfaceUnimakeDLL
    {

        #region Certifidado Digital

        private string nomeArquivoCertificado;
        /// <summary>
        /// Nome do Arquivo do Certificado Digital
        /// </summary>
        public string NomeArquivoCertificado
        {
            get
            {
                return nomeArquivoCertificado;
            }

            set
            {
                nomeArquivoCertificado = value;
            }
        }

        private string senhaArquivoCertificado;
        /// <summary>
        /// Senha do Arquivo do Certificado Digital
        /// </summary>
        public string SenhaArquivoCertificado
        {
            get
            {
                return senhaArquivoCertificado;
            }

            set
            {
                senhaArquivoCertificado = value;
            }
        }

        /// <summary>
        /// Certificado para assinatura digital
        /// </summary>
        private X509Certificate2 certificado;

        public void CarregaCertificado()
        {
            try
            {

                if (this.nomeArquivoCertificado == null)
                {
                    throw new Exception("Nome Completo do Arquivo do Certificado Digital não carregado.");
                }

                if (this.senhaArquivoCertificado == null)
                {
                    throw new Exception("Senha do Certificado Digital não carregada.");
                }

                if (certificado == null)
                {
                    certificado = new CertificadoDigital().CarregarCertificadoDigitalA1(this.nomeArquivoCertificado, this.senhaArquivoCertificado);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string DadosDoCertificado()
        {
            RetornoComArquivo retornoComArquivo = new RetornoComArquivo();

            try
            {
                if (this.certificado == null)
                {
                    throw new Exception("Certificado Digital não carregado.");
                }

                DateTime hoje = DateTime.Now;
                TimeSpan dif = this.certificado.NotAfter.Subtract(hoje);
                string mensagemRestante;

                if (dif.Days > 0)
                {
                    mensagemRestante = "Faltam " + dif.Days + " dias para vencer o certificado.";
                }
                else
                {
                    mensagemRestante = "Certificado vencido a " + (dif.Days) * -1 + " dias.";
                }
                retornoComArquivo.Retorno =
                    "[Requerente]\r\n" + this.certificado.Subject + "\r\n" +
                    "[Validade] " + this.certificado.NotBefore + " à " + this.certificado.NotAfter + " " +
                    mensagemRestante + "\r\n" +
                    "[Impressão Digital] " + this.certificado.Thumbprint + "\r\n" +
                    "[Certificadora] " + this.certificado.Issuer; // " {" + this.x509Cert.ToString() + "}";

            }
            catch (Exception ex)
            {
                //retornoComArquivo.Retorno = ex.Message;
                throw new Exception(ex.Message);
            }

            return retornoComArquivo.Retorno;
        }

        #endregion

    }
}
