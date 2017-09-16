﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEventosCore.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o código do usuário")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o nome do usuário")]
        [MaxLength(60, ErrorMessage = "O nome deve conter no máxino 60 caracters")]
        [MinLength(5, ErrorMessage = "O nome deve conter no mínimo 5 caracters")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o nome do usuário")]
        [MaxLength(30, ErrorMessage = "O nome deve conter no máxino 60 caracters")]
        [MinLength(5, ErrorMessage = "O nome deve conter no mínimo 5 caracters")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Informe a data de início")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Informe a data do término")]
        public DateTime DataFim { get; set; }

        [Required(ErrorMessage = "Informe a hora do inicio")]
        public string HoraInicio { get; set; }

        [Required(ErrorMessage = "Informe a hora do termino")]
        public string HoraFim { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para o evento")]
        [MaxLength(500, ErrorMessage = "A descrição deve conter no máxino 500 caracters")]
        [MinLength(100, ErrorMessage = "A descrição deve conter no mínimo 100 caracters")]
        public string Descricao { get; set; }

        public bool Cancelado { get; set; }

        public DateTime DataDeCadastro { get; set; } = DateTime.Now;
    }
}
