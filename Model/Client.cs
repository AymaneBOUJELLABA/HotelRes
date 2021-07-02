using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model
{
    public class Client
    {
        private int id { get; set; }
        private String nom { get; set; }
        private String prenom { get; set; }
        private String cin { get; set; }
        private DateTime dateNaissance { get; set; }
        private char sexe { get; set; }
        private String nationalite { get; set; }

        public Client()
        {
        }

        public Client(int id, string nom, string prenom, string cin, DateTime dateNaissance, char sexe, string nationalite)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.dateNaissance = dateNaissance;
            this.sexe = sexe;
            this.nationalite = nationalite;
        }

        public Client(string nom, string prenom, string cin, DateTime dateNaissance, char sexe, string nationalite)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.cin = cin;
            this.dateNaissance = dateNaissance;
            this.sexe = sexe;
            this.nationalite = nationalite;
        }
    }
}
