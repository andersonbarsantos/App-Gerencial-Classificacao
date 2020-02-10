﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppGerencial.Domain.Entities
{
    public class EntityResponsavel
    {
        public EntityResponsavel(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        int Id { get; set; }
        string Nome { get; set; }
        string Descricao { get; set; }
    }
}
