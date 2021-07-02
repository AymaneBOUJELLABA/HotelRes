using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Chambre
    {
        private int id { get; set; }
        private Type type { get; set; }
        private String prenom { get; set; }
        public Chambre(Type type, string prenom)
        {
            this.type = type;
            this.prenom = prenom;
        }
        public Chambre(int id, Type type, string prenom)
        {
            this.id = id;
            this.type = type;
            this.prenom = prenom;
        }
        public Chambre()
        {
        }
    }
}
