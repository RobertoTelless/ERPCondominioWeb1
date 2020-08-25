using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using ModelServices.Interfaces.Repositories;
using EntitiesServices.Work_Classes;
using System.Data.Entity;

namespace DataServices.Repositories
{
    public class FuncionarioAnexoRepository : RepositoryBase<FUNCIONARIO_ANEXO>, IFuncionarioAnexoRepository
    {
        public List<FUNCIONARIO_ANEXO> GetAllItens()
        {
            return Db.FUNCIONARIO_ANEXO.ToList();
        }

        public FUNCIONARIO_ANEXO GetItemById(Int32 id)
        {
            IQueryable<FUNCIONARIO_ANEXO> query = Db.FUNCIONARIO_ANEXO.Where(p => p.FUAN_CD_ID == id);
            return query.FirstOrDefault();
        }
    }
}
 