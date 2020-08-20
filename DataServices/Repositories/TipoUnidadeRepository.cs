using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using ModelServices.Interfaces.Repositories;
using EntitiesServices.Work_Classes;

namespace DataServices.Repositories
{
    public class TipoUnidadeRepository : RepositoryBase<TIPO_UNIDADE>, ITipoUnidadeRepository
    {
        public List<TIPO_UNIDADE> GetAllItens()
        {
            IQueryable<TIPO_UNIDADE> query = Db.TIPO_UNIDADE;
            return query.ToList();
        }

        public TIPO_UNIDADE GetItemById(Int32 id)
        {
            IQueryable<TIPO_UNIDADE> query = Db.TIPO_UNIDADE;
            query = query.Where(p => p.TIUN_CD_ID == id);
            return query.FirstOrDefault();
        }
    }
}
 