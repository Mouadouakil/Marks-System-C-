using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class note : model
    {
        int code_eleve;
        int code_matiere;
        float note;

        public int Code_eleve { get => code_eleve; set => code_eleve = value; }
        public int Code_matiere { get => code_matiere; set => code_matiere = value; }
        public float Note { get => note; set => note = value; }
    }
}
