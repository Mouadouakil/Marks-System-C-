using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class eleve:model
    {

        int code;
        string nom, prenom;
        int niveau;
        string code_fil;

        public int Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public string Code_fil { get => code_fil; set => code_fil = value; }
    }
}
