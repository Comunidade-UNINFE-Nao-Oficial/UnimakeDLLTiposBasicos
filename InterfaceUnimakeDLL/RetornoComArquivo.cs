using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUnimakeDLL
{
    public class RetornoComArquivo
    {
        private string _retorno = "";

        private string _arquivo = "";

        /// <summary>
        /// Retorno
        /// </summary>
        public string Retorno
        {
            get
            {
                return _retorno;
            }

            set
            {
                _retorno = value;
            }
        }

        /// <summary>
        /// Arquivo
        /// </summary>
        public string Arquivo
        {
            get
            {
                return _arquivo;
            }

            set
            {
                _arquivo = value;
            }
        }

    }
}
