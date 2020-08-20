using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<PRODUTO>
    {
        List<PRODUTO> GetAllItens();
        List<PRODUTO> GetAllItensFull();
        PRODUTO GetByNome(String nome);
        List<PRODUTO> ExecuteFilter(String nome, Int32? TipoId);
        PRODUTO GetItemByID(Int32 id);
    }
}
