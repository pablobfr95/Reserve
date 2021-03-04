using Reserve.Dominio.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reserve.Dominio.Interface
{
    public interface ICovidServico
    {
        Task<CovidDTO> ListarTodosPaises(string linkConsulta);

        Task<IList<Countries>> ListarPaisesComMaisCasosAtivos(string linkConsulta);
    }
}
