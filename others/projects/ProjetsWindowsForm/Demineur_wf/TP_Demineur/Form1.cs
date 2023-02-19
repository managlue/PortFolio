using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Demineur
{
    public partial class FormPrincipale : Form
    {
        public FormPrincipale() { InitializeComponent(); }

        int nbTentatives, nbTmax;
        bool partieFini, victoire, parametres;

        int tailleDesCasesEnPourcent;

        string m, message;

        private void initialisation()
        {
            generGrille(); // genere la grille de boutons

            nbTentatives = 0;
            nbTmax = 25;
            tailleDesCasesEnPourcent = 10;

            partieFini = false;
            victoire = true;
            parametres = false;
        }

        private void FormPrincipale_Load(object sender, EventArgs e) { initialisation(); }

        //================================================================================
        // - - - - - - - - - - - CLICS SUR LES BOUTONS- - - - - - - - - - - - - - - - - -
        //================================================================================

        private void btnParametres_Click(object sender, EventArgs e)
        {
            if (parametres) // cache les parametres et affiche le jeu
            {
                parametres = false;
                btnParametres.Text = "Paramètres";
                tlpGrille.Visible = true;
                
            }
            else // cache le jeu et affiche les parametres
            {
                parametres = true;
                btnParametres.Text = "Retour en jeu"; 
                tlpGrille.Visible = false;
            }
        }
        private void btnRecommencer_Click(object sender, EventArgs e) 
        { 
            if (rejouer()) btnRecommencer.Text = "Yolo";
        }
        private void btnGrille_Click(object sender, EventArgs e) 
        {
            // change CE bouton et pas un autre
            clic();
        }



        //================================================================================
        // - - - - - - - - - - - FONCTIONS PRINCIPALES- - - - - - - - - - - - - - - - - -
        //================================================================================

        void generGrille() // genere dans chaque case un bouton
        {
            for (int colonne = 0; colonne < tlpGrille.ColumnCount - 1; colonne++)
                for (int ligne = 0; ligne < tlpGrille.RowCount - 1; ligne++)
                {
                    Button btnGrille = new Button();
                    btnGrille.Click += new EventHandler(btnGrille_Click);

                    btnGrille.Dock = DockStyle.Fill;
                    btnGrille.AutoSize = true;

                    tlpGrille.Controls.Add(btnGrille, colonne, ligne);
                }
        }

        void clic() 
        {
            nbTentatives++;
            partieFini = nbTentatives == nbTmax || victoire == false;
            if (partieFini) rejouer();
            else checkLesCasesAdjacentes();
        }

        void checkLesCasesAdjacentes() { }

        //===============================================================================
        // - - - - - - - - - - - POPUP - - - - - - - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        private Boolean rejouer()
        {
            // crée un message
            if (partieFini) {
                if (!victoire) m = "Fellicitation, vous avez gagné en " + nbTentatives + " essais.";
                else m = "Domage, vous avez perdu.";
                message = m + "\nVoulez-vous rejouer ?";
            } else message = "Etes-vous sûr ?\nSi vous validez, ce sera considéré comme un abandon";

            // créé la fenetre et les types de boutons
            string caption = "nouvelle partie ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // affiche la fenetre
            result = MessageBox.Show(message, caption, buttons);

            // ferme le jeu si le joueur valide
            if (result == System.Windows.Forms.DialogResult.No) return false;
            else return true;
        }

        //================================================================================
        // - - - - - - - - - - - AUTRES FONCTIONS - - - - - - - - - - - - - - - - - - - -
        //================================================================================

        private void shake()
        {
            this.Left += 2; System.Threading.Thread.Sleep(40);
            this.Left -= 4; System.Threading.Thread.Sleep(40);
            this.Left += 4; System.Threading.Thread.Sleep(40);
            this.Left -= 4; System.Threading.Thread.Sleep(40);
            this.Left += 2; System.Threading.Thread.Sleep(40);
        }


    }
}
