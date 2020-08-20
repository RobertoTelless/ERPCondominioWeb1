using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using EntitiesServices.Work_Classes;
using ApplicationServices.Interfaces;
using ModelServices.Interfaces.EntitiesServices;
using CrossCutting;
using System.Text.RegularExpressions;

namespace ApplicationServices.Services
{
    public class CondominioAppService : AppServiceBase<CONDOMINIO>, ICondominioAppService
    {
        private readonly ICondominioService _baseService;

        public CondominioAppService(ICondominioService baseService): base(baseService)
        {
            _baseService = baseService;
        }

        public List<CONDOMINIO> GetAllItens()
        {
            List<CONDOMINIO> lista = _baseService.GetAllItens();
            return lista;
        }

        public CONDOMINIO GetItemById(Int32 id)
        {
            CONDOMINIO item = _baseService.GetItemById(id);
            return item;
        }

        public CONDOMINIO GetItemByNome(String nome)
        {
            CONDOMINIO item = _baseService.GetItemByNome(nome);
            return item;
        }

        public Int32 ValidateCreate(CONDOMINIO item, USUARIO usuario, Int32? idAss)
        {
            try
            {
                // Verifica existencia prévia

                // Completa objeto
                item.COND_IN_ATIVO = 1;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    COND_CD_ID = idAss,
                    LOG_NM_OPERACAO = "AddCOND",
                    LOG_IN_ATIVO = 1,
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CONDOMINIO>(item),
                    LOG_TX_REGISTRO_ANTES = null
                };

                // Persiste
                Int32 volta = _baseService.Create(item);
                return volta;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateEdit(CONDOMINIO item, CONDOMINIO itemAntes, USUARIO usuario, Int32? idAss)
        {
            try
            {
                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    COND_CD_ID = idAss,
                    LOG_NM_OPERACAO = "EditCOND",
                    LOG_IN_ATIVO = 1,
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CONDOMINIO>(item),
                    LOG_TX_REGISTRO_ANTES = Serialization.SerializeJSON<CONDOMINIO>(itemAntes)
                };

                // Persiste
                return _baseService.Edit(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateEdit(CONDOMINIO item, CONDOMINIO itemAntes)
        {
            try
            {

                // Persiste
                return _baseService.Edit(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateDelete(CONDOMINIO item, USUARIO usuario, Int32? idAss)
        {
            try
            {
                // Verifica integridade referencial

                // Acerta campos
                item.COND_IN_ATIVO = 0;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    COND_CD_ID = idAss,
                    LOG_IN_ATIVO = 1,
                    LOG_NM_OPERACAO = "DelCOND",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CONDOMINIO>(item)
                };

                // Persiste
                return _baseService.Edit(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Int32 ValidateReativar(CONDOMINIO item, USUARIO usuario, Int32? idAss)
        {
            try
            {
                // Verifica integridade referencial

                // Acerta campos
                item.COND_IN_ATIVO = 1;

                // Monta Log
                LOG log = new LOG
                {
                    LOG_DT_DATA = DateTime.Now,
                    USUA_CD_ID = usuario.USUA_CD_ID,
                    COND_CD_ID = idAss,
                    LOG_IN_ATIVO = 1,
                    LOG_NM_OPERACAO = "ReatCOND",
                    LOG_TX_REGISTRO = Serialization.SerializeJSON<CONDOMINIO>(item)
                };

                // Persiste
                return _baseService.Edit(item);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
