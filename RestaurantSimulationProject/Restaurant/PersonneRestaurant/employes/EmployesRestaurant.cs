using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.PersonneRestaurant.employes
{

    public class EmployesRestaurant : IPersonne
    {
        private static int id;
        protected ZoneTravail zoneDeTravail;
        protected Horaire horaireDeTravail;
        protected StatusDuTravail statutDuTravail;

        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int idPersonne 
        { 
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public EmployesRestaurant() { }
        public EmployesRestaurant(ZoneTravail zone, Horaire horaire)
        {
            zoneDeTravail = zone;
            horaireDeTravail = horaire;
            statutDuTravail = StatusDuTravail.NotWork;
        }
        public void autoId()
        {
            throw new NotImplementedException();
            this.idPersonne += 1;
        }
        public void creerPersonne(string name, string surname)
        {
            throw new NotImplementedException();
            this.name = name;
            this.surname = surname;
            this.autoId();
        }
    }
}
