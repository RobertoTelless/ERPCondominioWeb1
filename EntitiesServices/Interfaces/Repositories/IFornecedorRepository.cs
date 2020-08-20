using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IFornecedorRepository : IRepositoryBase<FORNECEDOR>
    {
        List<FORNECEDOR> GetAllItens();
        List<FORNECEDOR> GetFornecedorDashboard();
        FORNECEDOR GetByNome(String nome);
        FORNECEDOR GetByCNPJ(String cnpj);
        List<FORNECEDOR> ExecuteFilter(String nome, Int32? catId, String email);
        FORNECEDOR GetItemByID(Int32 id);
        //List<FORNECEDOR> GetAllPortaria();
    }
}
