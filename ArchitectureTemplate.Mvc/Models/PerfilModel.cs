using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArchitectureTemplate.Mvc.Models
{
    public class PerfilModel
    {
        [Key]
        [DisplayName(@"Code")]
        public int Id { get; set; }

        [DisplayName(@"Role")]
        [Required(ErrorMessage = @"Field Required")]
        [StringLength(50, ErrorMessage = @"O campo deve ter no m�ximo 50 caracters")]
        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public string Solicitante { get; set; }

        [DisplayName(@"Date of Create")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }

        //public IEnumerable<Usuario> Usuario { get; set; }

        public IDictionary<int, string> AbrangenciaDictionary { get; set; }

        public IDictionary<int, string> AreaDictionary { get; set; }
    }
}
