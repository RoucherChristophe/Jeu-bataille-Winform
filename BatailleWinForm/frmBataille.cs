using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioBataille;

namespace BatailleWinForm
{
    public partial class frmBataille : Form
    {

        Jeubataille _jeuBataille = new Jeubataille();

        public frmBataille()
        {
            InitializeComponent();
        }

        private void NuvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _jeuBataille.NouvellePartie();
            btnJouer.Enabled = true;

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            _jeuBataille.JouerUnTour();
            MiseAJourEcran();
        }

        private void MiseAJourEcran()
        {
            lblCarteEnCourJoueur.Text = _jeuBataille.CarteEnCourJoueur.Nom;
            lblCarteEnCourOrdi.Text = _jeuBataille.CarteEnCourOrdi.Nom;
        }

        private void frmBataille_Load(object sender, EventArgs e)
        {

        }


    }
}
