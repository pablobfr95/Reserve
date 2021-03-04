using Reserve.Aplicacao.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserve.Aplicacao.Interface
{
    public interface ICovidAppServico
    {
        IList<ContratoRetornoPaisesCovid> Listar10PaisesComMaisCasosAtivos(string linkConsulta);
    }
}
