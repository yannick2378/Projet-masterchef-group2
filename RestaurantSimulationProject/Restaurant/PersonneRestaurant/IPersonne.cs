using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public enum ZoneTravail
    {
        Kitchen,
        DiningRoom
    }
    public enum Horaire
    {
        ServiceDuMatin,
        ServiceDuSoir
    }
    public enum StatusDuTravail
    {
        NotWork,
        WorkRunning,
        WorkFinished
    }
    public interface IPersonne
    {
        string name { get; set; }
        string surname { get; set; }
        int idPersonne { get; set; }
        // methode de l'interface
        void creerPersonne(string name, string surname);
        void autoId();
    }
}
