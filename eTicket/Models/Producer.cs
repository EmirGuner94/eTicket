using eTicket.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer : IEntityBase
    {
        public int Id { get; set; }
        [Required]
        public string ProfilePictureURL { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Bio { get; set; }

        //relations
        public List<Movie> Movies { get; set; }
    }
}
