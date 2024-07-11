using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlgoritmo.Funcoes
{
    internal class CodigoToNomeMapper
    {
        private Dictionary<string, string> codigoParaNome;

        public CodigoToNomeMapper()
        {
            // Inicializa o dicionário com os códigos e nomes correspondentes
            codigoParaNome = new Dictionary<string, string>
            {
                { "54850", "Hospital de Vila Franca de Xira, P.P.P." }
                //adicionar mais no futuro
            };
        }

        public string CodigoToNome(string codigo)
        {
            if (codigoParaNome.TryGetValue(codigo, out string nome))
            {
                return nome;
            }
            else
            {
                return "Código desconhecido";
            }
        }
    }
}
