using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ModelServices.Interfaces.Repositories;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Data.Entity;
using System.Data;
using Twilio.Rest.Autopilot.V1.Assistant.Task;

namespace ModelServices.EntitiesServices
{
    public class UnidadeService : ServiceBase<UNIDADE>, IUnidadeService
    {
        private readonly IUnidadeRepository _baseRepository;
        private readonly ILogRepository _logRepository;
        private readonly ITipoUnidadeRepository _catRepository;
        protected Erp_CondominioEntities Db = new Erp_CondominioEntities();

        public UnidadeService(IUnidadeRepository baseRepository, ILogRepository logRepository, ITipoUnidadeRepository catRepository) : base(baseRepository)
        {
            _baseRepository = baseRepository;
            _logRepository = logRepository;
            _catRepository = catRepository;
        }

        public UNIDADE GetItemById(Int32 id)
        {
            UNIDADE item = _baseRepository.GetItemById(id);
            return item;
        }

        public List<UNIDADE> GetAllItens(Int32? idAss)
        {
            return _baseRepository.GetAllItens(idAss.Value);
        }

        public List<TIPO_UNIDADE> GetAllTipos()
        {
            return _catRepository.GetAllItens();
        }

        //public List<NOTIFICACAO> ExecuteFilter(Int32? idCat, String titulo, DateTime? data, String texto, Int32? idAss)
        //{
        //    return _baseRepository.ExecuteFilter(idCat, titulo, data, texto, idAss);

        //}

        public Int32 Create(UNIDADE item, LOG log)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _logRepository.Add(log);
                    _baseRepository.Add(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 Create(UNIDADE item)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _baseRepository.Add(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }


        public Int32 Edit(UNIDADE item, LOG log)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    item.USUARIO = null;
                    UNIDADE obj = _baseRepository.GetById(item.UNID_CD_ID);
                    _baseRepository.Detach(obj);
                    _logRepository.Add(log);
                    _baseRepository.Update(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 Edit(UNIDADE item)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    item.USUARIO = null;
                    item.CONDOMINIO = null;
                    item.TIPO_UNIDADE = null;
                    UNIDADE obj = _baseRepository.GetById(item.UNID_CD_ID);
                    _baseRepository.Detach(obj);
                    _baseRepository.Update(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public Int32 Delete(UNIDADE item, LOG log)
        {
            using (DbContextTransaction transaction = Db.Database.BeginTransaction(IsolationLevel.ReadCommitted))
            {
                try
                {
                    _logRepository.Add(log);
                    _baseRepository.Remove(item);
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
    }
}
