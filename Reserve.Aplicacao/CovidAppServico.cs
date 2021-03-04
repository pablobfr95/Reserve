using Reserve.Aplicacao.Contratos;
using Reserve.Aplicacao.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserve.Aplicacao
{
    public class CovidAppServico : ICovidAppServico
    {
        
        public IList<ContratoRetornoPaisesCovid> Listar10PaisesComMaisCasosAtivos(string linkConsulta)
        {
            throw new NotImplementedException();
        }
    }
}
