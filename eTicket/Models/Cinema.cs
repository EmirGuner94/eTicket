using eTicket.Data.Base;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        //relations
        public List<Movie> Movies { get; set; }
    }
}
