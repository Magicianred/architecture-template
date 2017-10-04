using ArchitectureTemplate.Business.DataEntities;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArchitectureTemplate.Mvc.Models
{
    public class MenuModel
    {
        [DisplayName(@"Identifier")]
        public int Id { get; set; }

        [DisplayName(@"Name")]
        [Required(ErrorMessage = @"Field Required")]
        [StringLength(50, ErrorMessage = @"Field must be 100 characters or less")]
        public string Nome { get; set; }

        [DisplayName(@"Profile")]
        public int PerfilId { get; set; }

        public IEnumerable<Menu> MenuList { get; set; }

        public IEnumerable<PerfilPorMenu> PerfilPorMenuList { get; set; }

        public IDictionary<int, string> PerfilDictionary { get; set; }

        public double Scroll { get; set; }
    }
}
