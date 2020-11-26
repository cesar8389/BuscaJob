using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BuscaJob.DAO
{
    class FormataDados
    {
        public string RetiraPontos(String entrada) {
            string saida;
            string pontos = @"(?i)[,.-/]";
            string substitui = "";
            Regex rgx = new Regex(pontos);
            saida = rgx.Replace(entrada, substitui);
            return saida;
        }

    }
}
