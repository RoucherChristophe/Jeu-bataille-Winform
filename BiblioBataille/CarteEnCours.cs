using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioCartes;

namespace BiblioBataille
{
    // création de la classe 'CarteEnCours' pour faire le pont entre 'BiblioBataille' et 'BiblioCarte'
    public class CarteEnCours
    {
        // création d'une variable de type 'Carte'
        private Carte _carte;

        // constructeur que l'on oblige à envoyer un type 'Carte' lors de la construction
        public CarteEnCours(Carte carte)
        {
            // on affecte la variable à l'instance de la carte passée en cours
            _carte = carte;
        }

        // création d'une propriété public qui retourne le nom de la carte
        public string Nom
        {
            get { return _carte.Nom; }
        }
    }
}
