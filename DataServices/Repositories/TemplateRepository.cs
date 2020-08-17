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
    public class TemplateRepository : RepositoryBase<TEMPLATE>, ITemplateRepository
    {
        public TEMPLATE GetItemById(Int32 id)
        {
            IQueryable<TEMPLATE> query = Db.TEMPLATE;
            query = query.Where(p => p.TEMP_CD_ID == id);
            return query.FirstOrDefault();
        }

        public TEMPLATE GetItemByCode(String code, Int32? idAss)
        {
            IQueryable<TEMPLATE> query = Db.TEMPLATE;
            query = query.Where(p => p.TEMP_SG_SIGLA == code);
            query = query.Where(p => p.COND_CD_ID == idAss);
            return query.FirstOrDefault();
        }

        public TEMPLATE GetItemByCode(String code)
        {
            IQueryable<TEMPLATE> query = Db.TEMPLATE;
            query = query.Where(p => p.TEMP_SG_SIGLA == code);
            return query.FirstOrDefault();
        }

        public List<TEMPLATE> GetAllItensAdm(Int32? idAss)
        {
            IQueryable<TEMPLATE> query = Db.TEMPLATE;
            query = query.Where(p => p.COND_CD_ID == idAss);
            return query.ToList();
        }

        public List<TEMPLATE> GetAllItens(Int32? idAss)
        {
            IQueryable<TEMPLATE> query = Db.TEMPLATE.Where(p => p.TEMP_IN_ATIVO == 1);
            query = query.Where(p => p.COND_CD_ID == idAss);
            return query.ToList();
        }
    }
}
 