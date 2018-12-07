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
            picCarteEnCoursJoueur.Image = _jeuBataille.CarteEnCourJoueur.Image;
            picCarteEnCoursOrdi.Image = _jeuBataille.CarteEnCourOrdi.Image;
        }

        private void frmBataille_Load(object sender, EventArgs e)
        {

        }


    }
}
