﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesServices.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Erp_CondominioEntities : DbContext
    {
        public Erp_CondominioEntities()
            : base("name=Erp_CondominioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AGENDA> AGENDA { get; set; }
        public virtual DbSet<AMBIENTE> AMBIENTE { get; set; }
        public virtual DbSet<AMBIENTE_CHAVE> AMBIENTE_CHAVE { get; set; }
        public virtual DbSet<AMBIENTE_CUSTO> AMBIENTE_CUSTO { get; set; }
        public virtual DbSet<AMBIENTE_IMAGEM> AMBIENTE_IMAGEM { get; set; }
        public virtual DbSet<ASSEMBLEIA_PRESENCIAL> ASSEMBLEIA_PRESENCIAL { get; set; }
        public virtual DbSet<ASSEMBLEIA_VIRTUAL> ASSEMBLEIA_VIRTUAL { get; set; }
        public virtual DbSet<AUTORIZACAO_ACESSO> AUTORIZACAO_ACESSO { get; set; }
        public virtual DbSet<BANCO> BANCO { get; set; }
        public virtual DbSet<CARGO> CARGO { get; set; }
        public virtual DbSet<CATEGORIA_AGENDA> CATEGORIA_AGENDA { get; set; }
        public virtual DbSet<CATEGORIA_FORNECEDOR> CATEGORIA_FORNECEDOR { get; set; }
        public virtual DbSet<CATEGORIA_NOTIFICACAO> CATEGORIA_NOTIFICACAO { get; set; }
        public virtual DbSet<CATEGORIA_OCORRENCIA> CATEGORIA_OCORRENCIA { get; set; }
        public virtual DbSet<CATEGORIA_PRODUTO> CATEGORIA_PRODUTO { get; set; }
        public virtual DbSet<CENTRO_CUSTO> CENTRO_CUSTO { get; set; }
        public virtual DbSet<CONDOMINIO> CONDOMINIO { get; set; }
        public virtual DbSet<CONFIGURACAO> CONFIGURACAO { get; set; }
        public virtual DbSet<CONTA_BANCO> CONTA_BANCO { get; set; }
        public virtual DbSet<CONTA_BANCO_CONTATO> CONTA_BANCO_CONTATO { get; set; }
        public virtual DbSet<CONTA_BANCO_LANCAMENTO> CONTA_BANCO_LANCAMENTO { get; set; }
        public virtual DbSet<CONTA_PAGAR> CONTA_PAGAR { get; set; }
        public virtual DbSet<CONTA_PAGAR_ANEXO> CONTA_PAGAR_ANEXO { get; set; }
        public virtual DbSet<CONTA_PAGAR_PARCELA> CONTA_PAGAR_PARCELA { get; set; }
        public virtual DbSet<CONTA_PAGAR_TAG> CONTA_PAGAR_TAG { get; set; }
        public virtual DbSet<CONTA_RECEBER> CONTA_RECEBER { get; set; }
        public virtual DbSet<CONTA_RECEBER_ANEXO> CONTA_RECEBER_ANEXO { get; set; }
        public virtual DbSet<CONTA_RECEBER_PARCELA> CONTA_RECEBER_PARCELA { get; set; }
        public virtual DbSet<CONTA_RECEBER_TAG> CONTA_RECEBER_TAG { get; set; }
        public virtual DbSet<CONTRATO> CONTRATO { get; set; }
        public virtual DbSet<CONTRATO_ANEXO> CONTRATO_ANEXO { get; set; }
        public virtual DbSet<CONTROLE_VEICULO> CONTROLE_VEICULO { get; set; }
        public virtual DbSet<CONVIDADO> CONVIDADO { get; set; }
        public virtual DbSet<CORPO_DIRETIVO> CORPO_DIRETIVO { get; set; }
        public virtual DbSet<DEPENDENTE> DEPENDENTE { get; set; }
        public virtual DbSet<DOCUMENTO> DOCUMENTO { get; set; }
        public virtual DbSet<DOCUMENTO_METADADO> DOCUMENTO_METADADO { get; set; }
        public virtual DbSet<ENCOMENDA> ENCOMENDA { get; set; }
        public virtual DbSet<ENCOMENDA_ANEXO> ENCOMENDA_ANEXO { get; set; }
        public virtual DbSet<ENTRADA_SAIDA> ENTRADA_SAIDA { get; set; }
        public virtual DbSet<EQUIPAMENTO> EQUIPAMENTO { get; set; }
        public virtual DbSet<ESCALA_TRABALHO> ESCALA_TRABALHO { get; set; }
        public virtual DbSet<ESCOLARIDADE> ESCOLARIDADE { get; set; }
        public virtual DbSet<ESTADO_CIVIL> ESTADO_CIVIL { get; set; }
        public virtual DbSet<FAVORECIDO> FAVORECIDO { get; set; }
        public virtual DbSet<FINALIDADE_RESERVA> FINALIDADE_RESERVA { get; set; }
        public virtual DbSet<FORMA_ENTREGA> FORMA_ENTREGA { get; set; }
        public virtual DbSet<FORMA_PAGAMENTO> FORMA_PAGAMENTO { get; set; }
        public virtual DbSet<FORNECEDOR> FORNECEDOR { get; set; }
        public virtual DbSet<FUNCAO_CORPO_DIRETIVO> FUNCAO_CORPO_DIRETIVO { get; set; }
        public virtual DbSet<FUNCIONALIDADE> FUNCIONALIDADE { get; set; }
        public virtual DbSet<FUNCIONARIO> FUNCIONARIO { get; set; }
        public virtual DbSet<FUNCIONARIO_ATIVO> FUNCIONARIO_ATIVO { get; set; }
        public virtual DbSet<GRAU_PARENTESCO> GRAU_PARENTESCO { get; set; }
        public virtual DbSet<GRUPO> GRUPO { get; set; }
        public virtual DbSet<LISTA_CONVIDADO> LISTA_CONVIDADO { get; set; }
        public virtual DbSet<LISTA_NEGRA> LISTA_NEGRA { get; set; }
        public virtual DbSet<LOG> LOG { get; set; }
        public virtual DbSet<METADADO> METADADO { get; set; }
        public virtual DbSet<MORADOR> MORADOR { get; set; }
        public virtual DbSet<MOTIVO_DESLIGAMENTO> MOTIVO_DESLIGAMENTO { get; set; }
        public virtual DbSet<MOVIMENTO> MOVIMENTO { get; set; }
        public virtual DbSet<MOVIMENTO_ESTOQUE> MOVIMENTO_ESTOQUE { get; set; }
        public virtual DbSet<MULTA> MULTA { get; set; }
        public virtual DbSet<NOTICIA> NOTICIA { get; set; }
        public virtual DbSet<NOTICIA_AVALIACAO> NOTICIA_AVALIACAO { get; set; }
        public virtual DbSet<NOTICIA_COMENTARIO> NOTICIA_COMENTARIO { get; set; }
        public virtual DbSet<NOTICIA_TAG> NOTICIA_TAG { get; set; }
        public virtual DbSet<NOTIFICACAO> NOTIFICACAO { get; set; }
        public virtual DbSet<NOTIFICACAO_ANEXO> NOTIFICACAO_ANEXO { get; set; }
        public virtual DbSet<OCORRENCIA> OCORRENCIA { get; set; }
        public virtual DbSet<OCORRENCIA_ANEXO> OCORRENCIA_ANEXO { get; set; }
        public virtual DbSet<OCORRENCIA_COMENTARIO> OCORRENCIA_COMENTARIO { get; set; }
        public virtual DbSet<OPERACAO> OPERACAO { get; set; }
        public virtual DbSet<PEDIDO_COMPRA> PEDIDO_COMPRA { get; set; }
        public virtual DbSet<PERFIL> PERFIL { get; set; }
        public virtual DbSet<PERFIL_FUNCIONALIDADE> PERFIL_FUNCIONALIDADE { get; set; }
        public virtual DbSet<PERIODICIDADE> PERIODICIDADE { get; set; }
        public virtual DbSet<PLANO_CONTA> PLANO_CONTA { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<PRODUTO_ANEXO> PRODUTO_ANEXO { get; set; }
        public virtual DbSet<PROPRIETARIO> PROPRIETARIO { get; set; }
        public virtual DbSet<RAMO_ATIVIDADE> RAMO_ATIVIDADE { get; set; }
        public virtual DbSet<RESERVA> RESERVA { get; set; }
        public virtual DbSet<SEXO> SEXO { get; set; }
        public virtual DbSet<SOLICITACAO_MUDANCA> SOLICITACAO_MUDANCA { get; set; }
        public virtual DbSet<SOLICITACAO_MUDANCA_ANEXO> SOLICITACAO_MUDANCA_ANEXO { get; set; }
        public virtual DbSet<SOLICITACAO_MUDANCA_COMENTARIO> SOLICITACAO_MUDANCA_COMENTARIO { get; set; }
        public virtual DbSet<SOLICITACAO_MUDANCA_MOVIMENTO> SOLICITACAO_MUDANCA_MOVIMENTO { get; set; }
        public virtual DbSet<TAXA_CONDOMINIO> TAXA_CONDOMINIO { get; set; }
        public virtual DbSet<TELEFONE> TELEFONE { get; set; }
        public virtual DbSet<TELEFONE_EMERGENCIA> TELEFONE_EMERGENCIA { get; set; }
        public virtual DbSet<TEMPLATE> TEMPLATE { get; set; }
        public virtual DbSet<TIPO_AMBIENTE> TIPO_AMBIENTE { get; set; }
        public virtual DbSet<TIPO_CONTA> TIPO_CONTA { get; set; }
        public virtual DbSet<TIPO_CONTRATO> TIPO_CONTRATO { get; set; }
        public virtual DbSet<TIPO_DADO> TIPO_DADO { get; set; }
        public virtual DbSet<TIPO_DOCUMENTO> TIPO_DOCUMENTO { get; set; }
        public virtual DbSet<TIPO_ENCOMENDA> TIPO_ENCOMENDA { get; set; }
        public virtual DbSet<TIPO_EQUIPAMENTO> TIPO_EQUIPAMENTO { get; set; }
        public virtual DbSet<TIPO_FAVORECIDO> TIPO_FAVORECIDO { get; set; }
        public virtual DbSet<TIPO_MOVIMENTO> TIPO_MOVIMENTO { get; set; }
        public virtual DbSet<TIPO_PESSOA> TIPO_PESSOA { get; set; }
        public virtual DbSet<TIPO_PLANO_CONTA> TIPO_PLANO_CONTA { get; set; }
        public virtual DbSet<TIPO_PRODUTO> TIPO_PRODUTO { get; set; }
        public virtual DbSet<TIPO_SALARIO> TIPO_SALARIO { get; set; }
        public virtual DbSet<TIPO_TAG> TIPO_TAG { get; set; }
        public virtual DbSet<TIPO_TAXA> TIPO_TAXA { get; set; }
        public virtual DbSet<TIPO_UNIDADE> TIPO_UNIDADE { get; set; }
        public virtual DbSet<TIPO_VEICULO> TIPO_VEICULO { get; set; }
        public virtual DbSet<TORRE> TORRE { get; set; }
        public virtual DbSet<UF> UF { get; set; }
        public virtual DbSet<UNIDADE> UNIDADE { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<USUARIO_ANEXO> USUARIO_ANEXO { get; set; }
        public virtual DbSet<USUARIO_CONTROLE_ENTRADA> USUARIO_CONTROLE_ENTRADA { get; set; }
        public virtual DbSet<VAGA> VAGA { get; set; }
        public virtual DbSet<VAGA_UNIDADE> VAGA_UNIDADE { get; set; }
        public virtual DbSet<VALOR_REFERENCIA> VALOR_REFERENCIA { get; set; }
        public virtual DbSet<VEICULO> VEICULO { get; set; }
        public virtual DbSet<VEICULO_ANEXO> VEICULO_ANEXO { get; set; }
        public virtual DbSet<VINCULO_EMPREGATICIO> VINCULO_EMPREGATICIO { get; set; }
        public virtual DbSet<TAREFA> TAREFA { get; set; }
        public virtual DbSet<TAREFA_ACOMPANHAMENTO> TAREFA_ACOMPANHAMENTO { get; set; }
        public virtual DbSet<TAREFA_ANEXO> TAREFA_ANEXO { get; set; }
        public virtual DbSet<TAREFA_NOTIFICACAO> TAREFA_NOTIFICACAO { get; set; }
        public virtual DbSet<TIPO_TAREFA> TIPO_TAREFA { get; set; }
        public virtual DbSet<FUNCIONARIO_ANEXO> FUNCIONARIO_ANEXO { get; set; }
    }
}
