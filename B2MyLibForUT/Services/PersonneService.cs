using B2MyLibForUT.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2MyLibForUT.Services {
    public class PersonneService {
        private List<Personne> _lesPersonnes;
        public void CreatePersonne() {
            // do some job
            Personne p = new Personne();
            Console.WriteLine("Nom de la personne");
            p.FirstName = Console.ReadLine();
        }

        public List<Personne> getAllPersonnes() {
            return _lesPersonnes;
        }

        public string CreerMessage() {
            var result = "";
            foreach(Personne p in getAllPersonnes()) {
                result+= "Nom:" + p.LastName + ", Prenom:" + p.FirstName + "\n";
            }
            return result;
        }

        public string CreerMessagePourUnePersonne(Personne p) {
            return "Nom:" + p.LastName + ", Prenom:" + p.FirstName + "\n"; 
        }
    }
}
