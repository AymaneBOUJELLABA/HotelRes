using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Reservation
    {
        private int id { get; set; }
        private double prixtotal { get; set; }
        private DateTime dateReservation { get; set; }
        private int duree { get; set; }
        public Reservation(int id, double prixtotal, DateTime dateReservation, int duree)
        {
            this.id = id;
            this.prixtotal = prixtotal;
            this.dateReservation = dateReservation;
            this.duree = duree;
        }
        public Reservation(double prixtotal, DateTime dateReservation, int duree)
        {
            this.prixtotal = prixtotal;
            this.dateReservation = dateReservation;
            this.duree = duree;
        }
        public Reservation()
        {
        }
    }
}
