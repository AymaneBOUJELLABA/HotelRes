using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Type
    {
        private int id { get; set; }
        private String classe { get; set; }
        private int nbrlits { get; set; }
        public Type(string classe, int nbrlits)
        {
            this.classe = classe;
            this.nbrlits = nbrlits;
        }
        public Type(int id, string classe, int nbrlits)
        {
            this.id = id;
            this.classe = classe;
            this.nbrlits = nbrlits;
        }
        public Type()
        {
        }
    }
}
