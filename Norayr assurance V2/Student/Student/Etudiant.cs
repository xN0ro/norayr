using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Etudiant
    {

        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Cours { get; set; }
        public string Notes { get; set; }

        public Etudiant(string prenom, string nom, string cours, string notes)
        {
            Prenom = prenom;
            Nom = nom;
            Cours = cours;
            Notes = notes;
        }
    }
}
