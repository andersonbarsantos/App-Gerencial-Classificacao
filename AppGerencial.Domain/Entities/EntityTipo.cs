using System;
using System.Collections.Generic;
using System.Text;

namespace AppGerencial.Domain.Entities
{
    public class EntityTipo
    {
        private EntityTipo entityTipo;

        public EntityTipo(EntityTipo entityTipo)
        {
            this.entityTipo = entityTipo;
        }

        public EntityTipo(int id)
        {
            Id = id;
        }

        public EntityTipo(int id, string tipo, string descricao)
        {
            Id = id;
            Tipo = tipo;
            Descricao = descricao;
        }

        public EntityTipo(int id, string tipo, string descricao, string dt_inclusao, string usuario) : this(id, tipo, descricao)
        {
            Dt_inclusao = dt_inclusao;
            this.usuario = usuario;
        }

        public  int Id { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Dt_inclusao { get; set; }
        public string usuario { get; set; }

    }
}
