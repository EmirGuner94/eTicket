using System.Collections.Generic;

namespace eTicket.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        //relation
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
