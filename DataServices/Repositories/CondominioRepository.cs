using System;
using System.Collections.Generic;
using EntitiesServices.Model;  
using ModelServices.Interfaces.Repositories;
using System.Linq;
using System.Data.Entity;
using CrossCutting;

namespace DataServices.Repositories
{
    public class CondominioRepository : RepositoryBase<CONDOMINIO>, ICondominioRepository
    {
        public CONDOMINIO GetItemByID(Int32 id)
        {
            IQueryable<CONDOMINIO> query = Db.CONDOMINIO;
            query = query.Where(p => p.COND_CD_ID == id);
            return query.FirstOrDefault();
        }

        public List<CONDOMINIO> GetAllItens()
        {
            IQueryable<CONDOMINIO> query = Db.CONDOMINIO.Where(p => p.COND_IN_ATIVO == 1);
            return query.ToList();
        }

        public CONDOMINIO GetByNome(String nome)
        {
            IQueryable<CONDOMINIO> query = Db.CONDOMINIO;
            query = query.Where(p => p.COND_NM_CONDOMINIO == nome);
            return query.FirstOrDefault();
        }

    }
}
