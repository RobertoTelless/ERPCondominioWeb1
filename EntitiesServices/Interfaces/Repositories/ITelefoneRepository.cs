using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;

namespace ModelServices.Interfaces.Repositories
{
    public interface ITelefoneRepository : IRepositoryBase<TELEFONE>
    {
        List<TELEFONE> GetAllItens();
        TELEFONE GetByNome(String nome);
        List<TELEFONE> ExecuteFilter(Int32? ramo, String nome, String bairro, String contato);
        TELEFONE GetItemByID(Int32 id);
    }
}
