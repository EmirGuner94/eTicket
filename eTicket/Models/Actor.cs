using eTicket.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProfilePictureURL { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Bio { get; set; }

        //relation
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
