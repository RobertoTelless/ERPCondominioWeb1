using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IFuncionarioRepository : IRepositoryBase<FUNCIONARIO>
    {
        List<FUNCIONARIO> GetAllItens();
        FUNCIONARIO GetByNome(String nome);
        FUNCIONARIO GetByCPF(String cpf);
        //List<FUNCIONARIO> ExecuteFilter(String nome, String cpf, String email, Int32? unidadeId);
        FUNCIONARIO GetItemByID(Int32 id);
        List<FUNCIONARIO> GetAllPortaria();
    }
}
