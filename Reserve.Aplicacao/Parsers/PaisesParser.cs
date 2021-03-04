using Reserve.Aplicacao.Contratos;
using Reserve.Dominio.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserve.Aplicacao.Parsers
{
    public static class PaisesParser
    {
        public static ContratoRetornoPaisesCovid Converter(Countries pais, int posicao)
        {
            return new ContratoRetornoPaisesCovid
            {
                Nome = pais.Country,
                Posicao = posicao,
                TotalAtivos = pais.TotalAtivos
            };
        }

        public static IList<ContratoRetornoPaisesCovid> Converter(IList<Countries> paises)
        {
            var listaPaises = new List<ContratoRetornoPaisesCovid>();
            for (int i = 0; i < paises.Count; i++)
            {
                listaPaises.Add(Converter(paises[i], i + 1));
            }
            return listaPaises;
        }
    }
}
