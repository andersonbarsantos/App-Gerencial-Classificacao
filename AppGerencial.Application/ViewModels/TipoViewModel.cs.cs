using AppGerencial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppGerencial.Application.ViewModels
{
    public class TipoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome preenchimento Obrigatorio")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Campo Descrição deve ser preenchido")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public string Dt_inclusao { get; set; }
        public string Usuario { get; set; }

        public EntityTipo ConvertTo()
        {
            return new EntityTipo(Id, Tipo, Descricao, Dt_inclusao, Usuario);
        }

    }

 }
