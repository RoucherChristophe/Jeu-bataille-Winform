﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioCartes;

namespace BiblioBataille
{
    // création d'un 'enum' pour connaître l'état du jeu
    public enum EtatsJeu
    {
        AttenteNouvellePartie,
        Normal,
        Bataille,
        Termine

    }

    public enum TypesJoueur
    {
        Joueur,
        Ordi
    }


    public class Jeubataille
    {
        // création de variables privées
        private EnginDeCartes _engin;
        private List<Carte> _cartesJoueur;
        private List<Carte> _cartesOrdi;
        private List<Carte> _cartesBatailleJoueur;
        private List<Carte> _cartesBatailleOrdi;
        private EtatsJeu _etatJeu;
        private Carte _carteEnCoursJoueur;
        private Carte _carteEnCoursOrdi;
        private TypesJoueur _gagnantDernierTour;
        private int _valeurCarteBataille = 0;
        private TypesJoueur _dernierAvecDesCartes;

        // constructeur
        public Jeubataille()
        {
            // au départ '_etatJeu' est en 'AttenteNouvellePartie'
            _etatJeu = EtatsJeu.AttenteNouvellePartie;
        }

        // propriétés de l'enum 'EtatsJeu'
        public EtatsJeu EtatJeu
        {
            get { return _etatJeu; }
        }
         
        // propriétés pour demander à la librairie quel est la carte en cour de jeu
        // on modifie pour communiquer avec 'CarteEnCours'
        public CarteEnCours CarteEnCourJoueur
        {
            get { return new CarteEnCours(_carteEnCoursJoueur); }
        }

        public CarteEnCours CarteEnCourOrdi
        {
            get { return new CarteEnCours(_carteEnCoursOrdi); }
        }

        public int NombreCartesJoueur
        {
            get { return _cartesJoueur.Count; }
        }

        public int NombreCartesOrdi
        {
            get { return _cartesOrdi.Count; }
        }

        public int NombreCartesBatailleJoueur
        {
            get { return _cartesBatailleJoueur.Count; }
        }

        public int NombreCartesBatailleOrdi
        {
            get { return _cartesBatailleOrdi.Count; }
        }

        public int ValeurCarteBataille
        {
            get { return _valeurCarteBataille; }
        }

        public TypesJoueur GagnantDernierTour
        {
            get { return _gagnantDernierTour; }
        }


        // lancer une nouvelle partie
        public void NouvellePartie()
        {
            // instanciation
            _engin = new EnginDeCartes();
            List<List<Carte>> deuxPaquets = _engin.RetourneDeuxPaquets();
            _cartesJoueur = deuxPaquets[0];
            _cartesOrdi = deuxPaquets[1]; 
            _etatJeu = EtatsJeu.Normal;
            _cartesBatailleJoueur = new List<Carte>();
            _cartesBatailleOrdi = new List<Carte>();
        }

        public void JouerUnTour()
        {
            if (_etatJeu !=EtatsJeu.Normal && _etatJeu !=EtatsJeu.Bataille)
            {
                return;
            }
            
            if (_etatJeu ==EtatsJeu.Normal)
            {

                if (_cartesJoueur.Count == 0)
                {
                    _etatJeu = EtatsJeu.Termine;
                    _gagnantDernierTour = TypesJoueur.Ordi;
                    return; // pour sortir de la méthode 'JouerUnTour()'
                }
                if (_cartesOrdi.Count == 0)
                {
                    _etatJeu = EtatsJeu.Termine;
                    _gagnantDernierTour = TypesJoueur.Joueur;
                    return; // pour sortir de la méthode 'JouerUnTour()'
                }

                _engin.JouerCarte(_cartesJoueur, ref _carteEnCoursJoueur);
                _engin.JouerCarte(_cartesOrdi, ref _carteEnCoursOrdi);

                if (_carteEnCoursJoueur.Valeur == _carteEnCoursOrdi.Valeur)
                {
                    _etatJeu = EtatsJeu.Bataille;
                    _valeurCarteBataille = _carteEnCoursJoueur.Valeur;
                }
                else if (_carteEnCoursJoueur.Valeur > _carteEnCoursOrdi.Valeur)
                {
                    _engin.PlacerCarteSousPaquet(ref _carteEnCoursOrdi, _cartesJoueur);
                    _engin.PlacerCarteSousPaquet(ref _carteEnCoursJoueur, _cartesJoueur);
                    _gagnantDernierTour = TypesJoueur.Joueur;
                }                				
                else
                {
                    _engin.PlacerCarteSousPaquet(ref _carteEnCoursJoueur, _cartesOrdi);
                    _engin.PlacerCarteSousPaquet(ref _carteEnCoursOrdi, _cartesOrdi);
                    _gagnantDernierTour = TypesJoueur.Ordi;
                }
            }

            else if (_etatJeu == EtatsJeu.Bataille)
            {

                if (_cartesJoueur.Count == 0 && _cartesOrdi.Count == 0)
                {
                    if (_dernierAvecDesCartes == TypesJoueur.Joueur)
                    {
                        _engin.DeplacerPaquetDessous(_cartesBatailleJoueur, _cartesJoueur);
                        _engin.DeplacerPaquetDessous(_cartesBatailleOrdi, _cartesJoueur);
                    }
                    else
                    {
                        _engin.DeplacerPaquetDessous(_cartesBatailleJoueur, _cartesOrdi);
                        _engin.DeplacerPaquetDessous(_cartesBatailleOrdi, _cartesOrdi);    
                    }
                }

                else if (_cartesJoueur.Count > 0 && _cartesOrdi.Count > 0)
                {
                    _engin.DeplacerCarteDessusDessus(_cartesJoueur, _cartesBatailleJoueur);
                    _engin.DeplacerCarteDessusDessus(_cartesOrdi, _cartesBatailleOrdi);
                }

                else if (_cartesJoueur.Count == 0)
                {
                    _engin.DeplacerCarteDessusDessus(_cartesOrdi, _cartesBatailleJoueur);
                    _engin.DeplacerCarteDessusDessus(_cartesOrdi, _cartesBatailleOrdi);
                    _dernierAvecDesCartes = TypesJoueur.Ordi;
                }
                else 
                   
                if (_cartesOrdi.Count == 0)
                {
                    _engin.DeplacerCarteDessusDessus(_cartesJoueur, _cartesBatailleOrdi);
                    _engin.DeplacerCarteDessusDessus(_cartesJoueur, _cartesBatailleJoueur);
                    _dernierAvecDesCartes = TypesJoueur.Joueur;
                }

                _carteEnCoursJoueur = _cartesBatailleJoueur[0];
                _carteEnCoursOrdi = _cartesBatailleOrdi[0];

                if (_carteEnCoursJoueur.Valeur == _valeurCarteBataille)
                {
                    _engin.DeplacerPaquetDessous(_cartesBatailleJoueur, _cartesJoueur);
                    _engin.DeplacerPaquetDessous(_cartesBatailleOrdi, _cartesJoueur);
                    _engin.PlacerCarteSousPaquet(ref _carteEnCoursJoueur, _cartesJoueur);
                    _engin.PlacerCarteSousPaquet(ref _carteEnCoursOrdi, _cartesJoueur);
                    _etatJeu = EtatsJeu.Normal;
                    _valeurCarteBataille = 0;
                }
                else if (_carteEnCoursOrdi.Valeur == _valeurCarteBataille)
                {
                    _engin.DeplacerPaquetDessous(_cartesBatailleJoueur, _cartesOrdi);
                    _engin.DeplacerPaquetDessous(_cartesBatailleOrdi, _cartesOrdi);
                    _engin.PlacerCarteSousPaquet(ref _carteEnCoursJoueur, _cartesOrdi);
                    _engin.PlacerCarteSousPaquet(ref _carteEnCoursOrdi, _cartesOrdi);
                    _etatJeu = EtatsJeu.Normal;
                    _valeurCarteBataille = 0;
                }

            }


        }

         
    }
}
