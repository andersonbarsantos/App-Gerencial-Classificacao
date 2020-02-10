using System;
using System.Collections.Generic;
using System.Text;

namespace AppGerencial.Domain.Entities
{
    public class EntityRegra
    {
        public int IdRegra { get; set; }
        public string Ativo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DtInicioVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }
        public EntitySistema Sistema { get; set; }
        public EntityResponsavel Responsavel { get; set; }
        public EntitySituacao Situacao { get; set; }
        public EntityTipo Tipo { get; set; }
        public EntityRetorno Retorno { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }
    }
}
