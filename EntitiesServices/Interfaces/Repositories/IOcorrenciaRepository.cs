using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IOcorrenciaRepository : IRepositoryBase<OCORRENCIA>
    {
        List<OCORRENCIA> GetAllItens();
        List<OCORRENCIA> GetOcorrenciaUnidade(Int32 id);
        //List<FUNCIONARIO> ExecuteFilter(Int32? categoria, String cpf, String email, Int32? unidadeId);
        OCORRENCIA GetItemByID(Int32 id);
        List<OCORRENCIA> GetByUnidade(Int32 id);
    }
}
