using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuMotATrouver
{
    public partial class FormPrincipale : Form
    {
        int nbParties = 1, nbVictoires = 0;
        int nbTmax = 5, nbTentatives = 0;
        int GO = 1, gameOver = 15;
        int R, G, B;
        int X, Y, Z;

        String[] tabMots;

        Boolean partieFini = false;
        Boolean nbTchangeur = false;
        Boolean gagne = false;
        Boolean param = false;
        Boolean darkMode = false;


        public FormPrincipale() { InitializeComponent(); }

        private void initialisation()
        {
            // creation du tableau des mots
            tabMots = new String[] {
                // liste des mots
                "CAROTTE","RENARD","POKEMON","ABRACADABRA","ABERRANT",
                "EXHAUSTIF","EPINARD","COURAGE","TOILETTE","MAGNETOSCOPE",
                "DEGUSTATION","COURGETTE","ASPIRATEUR","PYJAMA","BOUTEILLE",
                "APERITIF","CHAUSSURE","AGRAFEUSE","CONFITURE","DRAGON",
                "GROSEILLE","ASCENSEUR","ARGENT","DETOURNEMENT","HABITAT",
                "CONTINENT","CIRCUIT","CACTUS","ETAGERE","CRIMINALITE" };

            // initialise le compteur de tentatives
            LBLnombreEssaisRestant2.Text = (nbTmax - nbTentatives).ToString();

            // initialise la trackbar des tentatives
            trackBar1.Value = nbTmax;
            lblNbEssais2.Text = nbTmax.ToString();

            // initialise les trackbars RGB
            tbR.Value = 125; lblR.Text = (tbR.Value - 125).ToString(); X = tbR.Value;
            tbG.Value = 125; lblG.Text = (tbG.Value - 125).ToString(); Y = tbG.Value;
            tbB.Value = 125; lblB.Text = (tbB.Value - 125).ToString(); Z = tbB.Value;
        }

        private void Form1_Load(object sender, EventArgs e) { initialisation(); }

        //===============================================================================
        // - - - - - - - - - - - BOUTONS - - - - - - - - - - - - - - - - - - - - - - - - 
        //===============================================================================

        private void Btester_Click(object sender, EventArgs e)
        {
            if (!partieFini && TBproposition.Text != "")
            {
                nbTchangeur = true;
                // si l'utilisateur trouve le mot
                if (TBproposition.Text.ToUpper() == LBLmotATrouver2.Text)
                {
                    globalTest();
                    if (GO > 0) GO = 0;

                    nbVictoires++;
                    LBlistProposFaites.Items.Clear();
                    LBLmotATrouver.Text = "Félicitation, vous avez gagné";
                    partieFini = true;
                    gagne = true;
                }
                // si l'utilisateur ne trouve pas le mot
                else
                {
                    // si il lui reste des tentatives
                    if (nbTentatives < nbTmax - 1)
                    {
                        LBlistProposFaites.Items.Add(TBproposition.Text);
                        globalTest();
                        shake();
                    }
                    // si il ne lui en reste pas
                    else
                    {
                        globalTest();

                        LBlistProposFaites.Items.Clear();
                        LBLmotATrouver.Text = "Dommage, c'est perdu";
                        partieFini = true;
                        gagne = false;

                        /* lance un écran de game over
                        if (GO < gameOver) GO++;
                        else endGame(); */
                    }
                }
            }
            else if (TBproposition.Text == "tictactoe") tictactoe();
            else if (TBproposition.Text == "chifoumi") chifoumi();
            else {
                MessageBox.Show("message");
                shake();
            }
        }

        private void Brejouer_Click(object sender, EventArgs e)
        {
            if ( !param && ( partieFini || vousEtesSur() ) )
            {
                TBproposition.Text = "";
                partieFini = false;

                nbTchangeur = false;
                nbTmax = trackBar1.Value;
                LBLnombreEssaisRestant2.Text = (nbTmax - nbTentatives).ToString();
                lblNbEssais2.Text = trackBar1.Value.ToString();

                // creer un objet instance de la classe PartiesResultats
                PartiesResultats p = new PartiesResultats(LBLmotATrouver2.Text, nbTentatives, gagne);

                // l'ajoute a l'index des parties (juste le numéro)
                // les valeurs de resultat seront retrouvé grâce à ça
                CBhistorique.Items.Add("Partie " + nbParties);
                nbParties++;

                // lance la methode pour mélanger un mot de la liste au hazard
                Random r = new Random();
                int i = r.Next(tabMots.Length);
                LBLmotATrouver2.Text = tabMots[i];
                LBLmotATrouver.Text = melangeur(tabMots[i]);

                nbTentatives = 0;
                LBLnombreEssaisRestant2.Text = (nbTmax - nbTentatives).ToString();
            } else shake();
        }

        private void Bquitter_Click(object sender, EventArgs e) { scoreQuitter(); }

        //===============================================================================
        // - - - - - - - - - - - INDEX DES PARTIES - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        private void CBhistorique_SelectedIndexChanged(object sender, EventArgs e)
        {
            // prend la case n° w de l'index
            int w = CBhistorique.SelectedIndex;

            //  et l'utilise pour chercher la partie arrivant en position w de la list des parties
            LBLhistoriqueMotATrouver2.Text = PartiesResultats.tabParties[w].getMot();
            LBLhistoriqueNombreEssais2.Text = PartiesResultats.tabParties[w].getNbTenta().ToString();
            if (PartiesResultats.tabParties[w].getGagne() == true) LBLhistoriqueResultat2.Text = "gagné";
            else LBLhistoriqueResultat2.Text = "perdu";
        }

        //===============================================================================
        // - - - - - - - - - - - AUTRES METHODES - - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        private String melangeur(string mot)
        {
            // créer un mot vide pour le remplir avec les lettres du mot a mélanger
            String mot2 = "";

            // mélange les lettres
            var rand = new Random();
            for (int i = 0; i < mot.Length; i++)
                mot2 = mot2.Insert(rand.Next(0, mot2.Length), mot[i].ToString());

            return mot2;
        }

        private void globalTest()
        {
            nbTentatives++;
            LBLnombreEssaisRestant2.Text = (nbTmax - nbTentatives).ToString();
            TBproposition.Text = "";
        }

        private void shake()
        {
                this.Left += 2; System.Threading.Thread.Sleep(40);
                this.Left -= 4; System.Threading.Thread.Sleep(40);
                this.Left += 4; System.Threading.Thread.Sleep(40);
                this.Left -= 4; System.Threading.Thread.Sleep(40);
                this.Left += 2; System.Threading.Thread.Sleep(40);
        }

        //===============================================================================
        // - - - - - - - - - - - POPUP - - - - - - - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        private Boolean vousEtesSur()
        {
            // crée un message
            string message = "Etes-vous sûr ?\nSi vous validez, ce sera considéré comme un abandon.";

            // créé la fenetre et les types de boutons
            string caption = "Vous êtes sûr ?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // affiche la fenetre
            result = MessageBox.Show(message, caption, buttons);

            // ferme le jeu si le joueur valide
            if (result == System.Windows.Forms.DialogResult.No) return false;
            else
            {
                if (GO < gameOver) GO++;
                else endGame();
                return true;
            }
                
        }

        private void scoreQuitter()
        {
            // crée un message (presque) personalisé
            String messageNormale = "Vous avez gagné " + nbVictoires + " parties sur " + nbParties + " \nVoulez-vous vraiment quitter ?";
            String messageVictoire = "Félicitations";
            string message;
            if (nbVictoires > nbParties / 2) message = messageVictoire + ". " + messageNormale + ".";
            else message = messageNormale;

            // créé la fenetre et les types de boutons
            string caption = "Score";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // affiche la fenetre
            result = MessageBox.Show(message, caption, buttons);

            // ferme le jeu si le joueur valide
            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        //===============================================================================
        // - - - - - - - - - - - ECRAN GAME-OVER - - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        // rien pour l'instant car je ne sais pas comment faire

        // si le joueur enchaine 5 défaite (par exemple)
        // l'écrant se teinte progressivement en noir alors qu'un
        // TableLayoutPanelGrowStyle GAME OVER rouge apparaît
        // (progressivement lui aussi)

        // je voulais mettre un timer très rapide qui augmente les
        // opacités du voile noir et du GAME OVER à chaque fois qu'il
        // fait un tour complet.

        // ce fera dans une autre form

        private void endGame()
        {
            Form formGameOver = new FormGameOver();
            formGameOver.Show();
        }

        //===============================================================================
        // - - - - - - - - - - - MINI JEUX - - - - - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        private void tictactoe()
        {
            Form formTtt = new FormTtt();
            formTtt.Show();
        }

        private void chifoumi()
        {
            Form formPfs = new FormPfs();
            formPfs.Show();
        }

        //===============================================================================
        // - - - - - - - - CHANGER LE NOMBRE DE TENTATIVES MAXIMUM - - - - - - - - - - -
        //===============================================================================

        private void trackBar1_Scroll(object sender, EventArgs e) {
            if (!nbTchangeur)
            {
                    nbTmax = trackBar1.Value;
                    LBLnombreEssaisRestant2.Text = (nbTmax - nbTentatives).ToString();
                    lblNbEssais2.Text = trackBar1.Value.ToString();
            }
        }

        //===============================================================================
        // - - - - - - - - - - - PARAMETRAGE - - - - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        //========== cacher ou montrer les parametres =========================

        private void bParametres_Click_1(object sender, EventArgs e)
        {
            if (!param)
            {
                groupBox1.Text = "Police et Taille";
                groupBox2.Text = "Couleurs RGB";
                param = true;

                // cache les trucs dans la box "Proposition"
                TBproposition.Visible = false;
                Btester.Visible = false;

                // cache les trucs dans la box "Essais"
                LBLnombreEssaisRestant.Visible = false;
                LBLnombreEssaisRestant2.Visible = false;
                LBlistProposFaites.Visible = false;

                // montre les trucs dans la box "Police et Taille"
                rbCSms.Visible = true;
                rbSymbol.Visible = true;
                rbMC.Visible = true;
                rbMSS.Visible = true;
                nudTaillePolice.Visible = true;

                // montre les trucs dans la box "Couleurs RGB"
                tbR.Visible = true; lblR.Visible = true;
                tbG.Visible = true; lblG.Visible = true;
                tbB.Visible = true; lblB.Visible = true;
                rbOverAll.Visible = true;
                rbFond.Visible = true;
                rbBoites.Visible = true;
                rbTextes.Visible = true;
                rbBoutons.Visible = true;
                
            } 
            else
            {
                groupBox1.Text = "Proposition";
                groupBox2.Text = "Essais";
                param = false;

                // cache les trucs dans la box "Proposition"
                TBproposition.Visible = true;
                Btester.Visible = true;

                // montre les trucs dans la box "Essais"
                LBLnombreEssaisRestant.Visible = true;
                LBLnombreEssaisRestant2.Visible = true;
                LBlistProposFaites.Visible = true;

                // montre les trucs dans la box "Police et Taille"
                rbCSms.Visible = false;
                rbSymbol.Visible = false;
                rbMC.Visible = false;
                rbMSS.Visible = false;
                nudTaillePolice.Visible = false;

                // cache les trucs dans la box "Couleurs RGB"
                tbR.Visible = false; lblR.Visible = false;
                tbG.Visible = false; lblG.Visible = false;
                tbB.Visible = false; lblB.Visible = false;
                rbOverAll.Visible = false;
                rbFond.Visible = false;
                rbBoites.Visible = false;
                rbTextes.Visible = false;
                rbBoutons.Visible = false;
            }
        }

        //========== changer la police d'ecriture =========================

        private void rbMSS_CheckedChanged(object sender, EventArgs e)
        {
            // les groupBoxes
            groupBox1.Font = lblModelMSS.Font;
            groupBox2.Font = lblModelMSS.Font;
            groupBox3.Font = lblModelMSS.Font;

            // les boutons
            bParametres.Font = lblModelMSS.Font;
            Brejouer.Font = lblModelMSS.Font;
            Bquitter.Font = lblModelMSS.Font;
            BdarkLight.Font = lblModelMSS.Font;

            // les labels
            label4.Font = lblModelMSS.Font;
            lblNbTentaModif.Font = lblModelMSS.Font;
            lblNbEssais.Font = lblModelMSS.Font;
            lblNbEssais2.Font = lblModelMSS.Font;

            // garder les exemple en forme
            rbMC.Font = lblModelMC.Font;
            rbCSms.Font = lblModelCSms.Font;
            rbSymbol.Font = lblModelSymbol.Font;
        }

        private void rbMC_CheckedChanged(object sender, EventArgs e)
        {
            // les groupBoxes
            groupBox1.Font = lblModelMC.Font;
            groupBox2.Font = lblModelMC.Font;
            groupBox3.Font = lblModelMC.Font;

            // les boutons
            bParametres.Font = lblModelMC.Font;
            Brejouer.Font = lblModelMC.Font;
            Bquitter.Font = lblModelMC.Font;
            BdarkLight.Font = lblModelMC.Font;

            // les labels
            label4.Font = lblModelMC.Font;
            lblNbTentaModif.Font = lblModelMC.Font;
            lblNbEssais.Font = lblModelMC.Font;
            lblNbEssais2.Font = lblModelMC.Font;

            // garder les exemple en forme
            rbMSS.Font = lblModelMSS.Font;
            rbCSms.Font = lblModelCSms.Font;
            rbSymbol.Font = lblModelSymbol.Font;
        }

        private void rbCSms_CheckedChanged(object sender, EventArgs e)
        {
            // les groupBoxes
            groupBox1.Font = lblModelCSms.Font;
            groupBox2.Font = lblModelCSms.Font;
            groupBox3.Font = lblModelCSms.Font;

            // les boutons
            bParametres.Font = lblModelCSms.Font;
            Brejouer.Font = lblModelCSms.Font;
            Bquitter.Font = lblModelCSms.Font;
            BdarkLight.Font = lblModelCSms.Font;

            // les labels
            label4.Font = lblModelCSms.Font;
            lblNbTentaModif.Font = lblModelCSms.Font;
            lblNbEssais.Font = lblModelCSms.Font;
            lblNbEssais2.Font = lblModelCSms.Font;

            // garder les exemple en forme
            rbMC.Font = lblModelMC.Font;
            rbMSS.Font = lblModelMSS.Font;
            rbSymbol.Font = lblModelSymbol.Font;
        }

        private void rbSymbol_CheckedChanged(object sender, EventArgs e)
        {
            // les groupBoxes
            groupBox1.Font = lblModelSymbol.Font;
            groupBox2.Font = lblModelSymbol.Font;
            groupBox3.Font = lblModelSymbol.Font;

            // les boutons
            bParametres.Font = lblModelSymbol.Font;
            Brejouer.Font = lblModelSymbol.Font;
            Bquitter.Font = lblModelSymbol.Font;
            BdarkLight.Font = lblModelSymbol.Font;

            // les labels
            label4.Font = lblModelSymbol.Font;
            lblNbTentaModif.Font = lblModelSymbol.Font;
            lblNbEssais.Font = lblModelSymbol.Font;
            lblNbEssais2.Font = lblModelSymbol.Font;

            // garder les exemple en forme
            rbMSS.Font = lblModelMSS.Font;
            rbCSms.Font = lblModelCSms.Font;
            rbMC.Font = lblModelMC.Font;
        }

        // changer les couleurs en fonction des radioboutons
        private void rbOverAll_CheckedChanged(object sender, EventArgs e)
        {
            tbR.Value = 125;    lblR.Text = (tbR.Value - 125).ToString();
            tbG.Value = 125;    lblG.Text = (tbG.Value - 125).ToString();
            tbB.Value = 125;    lblB.Text = (tbB.Value - 125).ToString();
        }
        private void rbFond_CheckedChanged(object sender, EventArgs e)
        {
            tbR.Value = this.BackColor.R;   lblR.Text = tbR.Value.ToString();
            tbG.Value = this.BackColor.G;   lblG.Text = tbG.Value.ToString();
            tbB.Value = this.BackColor.B;   lblB.Text = tbB.Value.ToString();
        }

        private void rbBoites_CheckedChanged(object sender, EventArgs e)
        {
            tbR.Value = TBproposition.BackColor.R; lblR.Text = tbR.Value.ToString();
            tbG.Value = TBproposition.BackColor.G; lblG.Text = tbG.Value.ToString();
            tbB.Value = TBproposition.BackColor.B; lblB.Text = tbB.Value.ToString();
        }

        private void rbTextes_CheckedChanged(object sender, EventArgs e)
        {
            tbR.Value = lblNbEssais.ForeColor.R; lblR.Text = tbR.Value.ToString();
            tbG.Value = lblNbEssais.ForeColor.G; lblG.Text = tbG.Value.ToString();
            tbB.Value = lblNbEssais.ForeColor.B; lblB.Text = tbB.Value.ToString();
        }
        private void rbBoutons_CheckedChanged(object sender, EventArgs e)
        {
            tbR.Value = Btester.BackColor.R; lblR.Text = tbR.Value.ToString();
            tbG.Value = Btester.BackColor.G; lblG.Text = tbG.Value.ToString();
            tbB.Value = Btester.BackColor.B; lblB.Text = tbB.Value.ToString();
        }

        // changer les couleurs grace aux trackbars
        private void tbR_Scroll(object sender, EventArgs e)
        {
            lblR.Text = tbR.Value.ToString();
            if (rbOverAll.Checked)
            {
                X = tbR.Value;  Y = tbG.Value;  Z = tbB.Value;
                lblR.Text = (tbR.Value - 125).ToString();
                this.BackColor = Color.FromArgb(R, G, B);
                // les textBoxes
                TBproposition.BackColor = Color.FromArgb(R, G, B);      TBproposition.ForeColor = Color.FromArgb(R, G, B);
                LBlistProposFaites.BackColor = Color.FromArgb(R, G, B); LBlistProposFaites.ForeColor = Color.FromArgb(R, G, B);
                // la comboBox
                CBhistorique.BackColor = Color.FromArgb(R, G, B);   CBhistorique.ForeColor = Color.FromArgb(R, G, B);
                // les boutons
                Btester.ForeColor = Color.FromArgb(R, G, B);        Btester.BackColor = Color.FromArgb(R, G, B);
                Brejouer.ForeColor = Color.FromArgb(R, G, B);       Brejouer.BackColor = Color.FromArgb(R, G, B);
                Bquitter.ForeColor = Color.FromArgb(R, G, B);       Bquitter.BackColor = Color.FromArgb(R, G, B);
                BdarkLight.ForeColor = Color.FromArgb(R, G, B);     BdarkLight.BackColor = Color.FromArgb(R, G, B);
                bParametres.ForeColor = Color.FromArgb(R, G, B);    bParametres.BackColor = Color.FromArgb(R, G, B);
                // les labels
                label4.ForeColor = Color.FromArgb(R, G, B);
                LBLmotATrouver.ForeColor = Color.FromArgb(R, G, B);
                LBLnombreEssaisRestant.ForeColor = Color.FromArgb(R, G, B);
                LBLnombreEssaisRestant2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueResultat.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueResultat2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueNombreEssais.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueNombreEssais2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueMotATrouver.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueMotATrouver2.ForeColor = Color.FromArgb(R, G, B);
                lblNbTentaModif.ForeColor = Color.FromArgb(R, G, B);
                lblNbEssais.ForeColor = Color.FromArgb(R, G, B);
                lblNbEssais2.ForeColor = Color.FromArgb(R, G, B);
                // les groupBoxes
                groupBox1.ForeColor = Color.FromArgb(R, G, B);
                groupBox2.ForeColor = Color.FromArgb(R, G, B);
                groupBox3.ForeColor = Color.FromArgb(R, G, B);
            }
            if (rbFond.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblR.Text = R.ToString();
                this.BackColor = Color.FromArgb(R, G, B);
            }
            if (rbBoites.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblR.Text = R.ToString();
                // les textBoxes
                TBproposition.BackColor = Color.FromArgb(R, G, B);
                LBlistProposFaites.BackColor = Color.FromArgb(R, G, B); 
                // la comboBox
                CBhistorique.BackColor = Color.FromArgb(R, G, B);
            }
            if (rbTextes.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblR.Text = R.ToString();
                // les boutons
                Btester.ForeColor = Color.FromArgb(R, G, B);
                Brejouer.ForeColor = Color.FromArgb(R, G, B);
                Bquitter.ForeColor = Color.FromArgb(R, G, B);
                BdarkLight.ForeColor = Color.FromArgb(R, G, B);
                bParametres.ForeColor = Color.FromArgb(R, G, B);
                // les labels
                label4.ForeColor = Color.FromArgb(R, G, B);
                LBLmotATrouver.ForeColor = Color.FromArgb(R, G, B);
                LBLnombreEssaisRestant.ForeColor = Color.FromArgb(R, G, B);
                LBLnombreEssaisRestant2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueResultat.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueResultat2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueNombreEssais.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueNombreEssais2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueMotATrouver.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueMotATrouver2.ForeColor = Color.FromArgb(R, G, B);
                lblNbTentaModif.ForeColor = Color.FromArgb(R, G, B);
                lblNbEssais.ForeColor = Color.FromArgb(R, G, B);
                lblNbEssais2.ForeColor = Color.FromArgb(R, G, B);
                // les groupBoxes
                groupBox1.ForeColor = Color.FromArgb(R, G, B);
                groupBox2.ForeColor = Color.FromArgb(R, G, B);
                groupBox3.ForeColor = Color.FromArgb(R, G, B);
                // les textBoxes
                TBproposition.ForeColor = Color.FromArgb(R, G, B);
                LBlistProposFaites.ForeColor = Color.FromArgb(R, G, B);
                // la comboBox
                CBhistorique.ForeColor = Color.FromArgb(R, G, B);
            }
            if (rbBoutons.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblR.Text = R.ToString();
                // les boutons
                Btester.BackColor = Color.FromArgb(R, G, B);
                Brejouer.BackColor = Color.FromArgb(R, G, B);
                Bquitter.BackColor = Color.FromArgb(R, G, B);
                BdarkLight.BackColor = Color.FromArgb(R, G, B);
                bParametres.BackColor = Color.FromArgb(R, G, B);
            }
        }
        private void tbG_Scroll(object sender, EventArgs e)
        {
            lblR.Text = tbR.Value.ToString();
            if (rbOverAll.Checked)
            {
                // à finir
                lblR.Text = tbR.Value.ToString();
            }
            if (rbFond.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblG.Text = G.ToString();
                this.BackColor = Color.FromArgb(R, G, B);
            }
            if (rbBoites.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblG.Text = G.ToString();
                // les textBoxes
                TBproposition.BackColor = Color.FromArgb(R, G, B);
                LBlistProposFaites.BackColor = Color.FromArgb(R, G, B);
                // la comboBox
                CBhistorique.BackColor = Color.FromArgb(R, G, B);
            }
            if (rbTextes.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblG.Text = G.ToString();
                // les boutons
                Btester.ForeColor = Color.FromArgb(R, G, B);
                Brejouer.ForeColor = Color.FromArgb(R, G, B);
                Bquitter.ForeColor = Color.FromArgb(R, G, B);
                BdarkLight.ForeColor = Color.FromArgb(R, G, B);
                bParametres.ForeColor = Color.FromArgb(R, G, B);
                // les labels
                label4.ForeColor = Color.FromArgb(R, G, B);
                LBLmotATrouver.ForeColor = Color.FromArgb(R, G, B);
                LBLnombreEssaisRestant.ForeColor = Color.FromArgb(R, G, B);
                LBLnombreEssaisRestant2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueResultat.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueResultat2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueNombreEssais.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueNombreEssais2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueMotATrouver.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueMotATrouver2.ForeColor = Color.FromArgb(R, G, B);
                lblNbTentaModif.ForeColor = Color.FromArgb(R, G, B);
                lblNbEssais.ForeColor = Color.FromArgb(R, G, B);
                lblNbEssais2.ForeColor = Color.FromArgb(R, G, B);
                // les groupBoxes
                groupBox1.ForeColor = Color.FromArgb(R, G, B);
                groupBox2.ForeColor = Color.FromArgb(R, G, B);
                groupBox3.ForeColor = Color.FromArgb(R, G, B);
                // les textBoxes
                TBproposition.ForeColor = Color.FromArgb(R, G, B);
                LBlistProposFaites.ForeColor = Color.FromArgb(R, G, B);
                // la comboBox
                CBhistorique.ForeColor = Color.FromArgb(R, G, B);
            }
            if (rbBoutons.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblG.Text = G.ToString();
                // les boutons
                Btester.BackColor = Color.FromArgb(R, G, B);
                Brejouer.BackColor = Color.FromArgb(R, G, B);
                Bquitter.BackColor = Color.FromArgb(R, G, B);
                BdarkLight.BackColor = Color.FromArgb(R, G, B);
                bParametres.BackColor = Color.FromArgb(R, G, B);
            }
        }
        private void tbB_Scroll(object sender, EventArgs e)
        {
            lblR.Text = tbR.Value.ToString();
            if (rbOverAll.Checked)
            {
                // à finir
                lblR.Text = tbR.Value.ToString();
            }
            if (rbFond.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblB.Text = B.ToString();
                this.BackColor = Color.FromArgb(R, G, B);
            }
            if (rbBoites.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblB.Text = B.ToString();
                // les textBoxes
                TBproposition.BackColor = Color.FromArgb(R, G, B);
                LBlistProposFaites.BackColor = Color.FromArgb(R, G, B);
                // la comboBox
                CBhistorique.BackColor = Color.FromArgb(R, G, B);
            }
            if (rbTextes.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblB.Text = B.ToString();
                // les boutons
                Btester.ForeColor = Color.FromArgb(R, G, B);
                Brejouer.ForeColor = Color.FromArgb(R, G, B);
                Bquitter.ForeColor = Color.FromArgb(R, G, B);
                BdarkLight.ForeColor = Color.FromArgb(R, G, B);
                bParametres.ForeColor = Color.FromArgb(R, G, B);
                // les labels
                label4.ForeColor = Color.FromArgb(R, G, B);
                LBLmotATrouver.ForeColor = Color.FromArgb(R, G, B);
                LBLnombreEssaisRestant.ForeColor = Color.FromArgb(R, G, B);
                LBLnombreEssaisRestant2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueResultat.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueResultat2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueNombreEssais.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueNombreEssais2.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueMotATrouver.ForeColor = Color.FromArgb(R, G, B);
                LBLhistoriqueMotATrouver2.ForeColor = Color.FromArgb(R, G, B);
                lblNbTentaModif.ForeColor = Color.FromArgb(R, G, B);
                lblNbEssais.ForeColor = Color.FromArgb(R, G, B);
                lblNbEssais2.ForeColor = Color.FromArgb(R, G, B);
                // les groupBoxes
                groupBox1.ForeColor = Color.FromArgb(R, G, B);
                groupBox2.ForeColor = Color.FromArgb(R, G, B);
                groupBox3.ForeColor = Color.FromArgb(R, G, B);
                // les textBoxes
                TBproposition.ForeColor = Color.FromArgb(R, G, B);
                LBlistProposFaites.ForeColor = Color.FromArgb(R, G, B);
                // la comboBox
                CBhistorique.ForeColor = Color.FromArgb(R, G, B);
            }
            if (rbBoutons.Checked)
            {
                R = tbR.Value;
                G = tbG.Value;
                B = tbB.Value;
                lblB.Text = B.ToString();
                // les boutons
                Btester.BackColor = Color.FromArgb(R, G, B);
                Brejouer.BackColor = Color.FromArgb(R, G, B);
                Bquitter.BackColor = Color.FromArgb(R, G, B);
                BdarkLight.BackColor = Color.FromArgb(R, G, B);
                bParametres.BackColor = Color.FromArgb(R, G, B);
            }
        }

        //===============================================================================
        // - - - - - - - - - - - MODES SOMBRE / CLAIRE - - - - - - - - - - - - - - - - -
        //===============================================================================

        // j'ai fait le mode sombre/claire avant les parametres

        // je ne sais pas pourquoi mais les composants des parametres
        // suivent quand meme les regles du mode s/c alors que je
        // ne les ai pas integrés

        private void BdarkLight_Click(object sender, EventArgs e)
        {
            // mettre le dark mode
            if (!darkMode)
            {
                darkMode = true;
                BdarkLight.Text = "Mode clair";

                this.BackColor = Color.FromArgb(20, 20, 20);

                // les boutons
                Btester.BackColor = Color.FromArgb(10, 10, 10);     Btester.ForeColor = Color.WhiteSmoke;
                Brejouer.BackColor = Color.FromArgb(10, 10, 10);    Brejouer.ForeColor = Color.WhiteSmoke;
                Bquitter.BackColor = Color.FromArgb(10, 10, 10);    Bquitter.ForeColor = Color.WhiteSmoke;
                BdarkLight.BackColor = Color.FromArgb(10, 10, 10);  BdarkLight.ForeColor = Color.WhiteSmoke;
                bParametres.BackColor = Color.FromArgb(10, 10, 10); bParametres.ForeColor = Color.WhiteSmoke;

                // les labels
                label4.ForeColor = Color.WhiteSmoke;
                LBLmotATrouver.ForeColor = Color.WhiteSmoke;
                LBLnombreEssaisRestant.ForeColor = Color.WhiteSmoke;
                LBLnombreEssaisRestant2.ForeColor = Color.WhiteSmoke;
                LBLhistoriqueResultat.ForeColor = Color.WhiteSmoke;
                LBLhistoriqueResultat2.ForeColor = Color.WhiteSmoke;
                LBLhistoriqueNombreEssais.ForeColor = Color.WhiteSmoke;
                LBLhistoriqueNombreEssais2.ForeColor = Color.WhiteSmoke;
                LBLhistoriqueMotATrouver.ForeColor = Color.WhiteSmoke;
                LBLhistoriqueMotATrouver2.ForeColor = Color.WhiteSmoke;
                lblNbTentaModif.ForeColor = Color.WhiteSmoke;
                lblNbEssais.ForeColor = Color.WhiteSmoke;
                lblNbEssais2.ForeColor = Color.WhiteSmoke;
 
                // les groupBoxes
                groupBox1.ForeColor = Color.WhiteSmoke;
                groupBox2.ForeColor = Color.WhiteSmoke;
                groupBox3.ForeColor = Color.WhiteSmoke;

                // les textBoxes
                TBproposition.BackColor = Color.FromArgb(50, 50, 50);       TBproposition.ForeColor = Color.WhiteSmoke;
                LBlistProposFaites.BackColor = Color.FromArgb(50, 50, 50);  LBlistProposFaites.ForeColor = Color.WhiteSmoke;

                // la comboBox
                CBhistorique.BackColor = Color.FromArgb(50, 50, 50);    CBhistorique.ForeColor = Color.WhiteSmoke;
            }
            // mettre le light mode
            else
            {
                darkMode = false;
                BdarkLight.Text = "Mode sombre";

                this.BackColor = DefaultBackColor;

                // les boutons
                Btester.BackColor = Color.FromArgb(250, 250, 250);       Btester.ForeColor = DefaultForeColor;
                Brejouer.BackColor = Color.FromArgb(250, 250, 250);      Brejouer.ForeColor = DefaultForeColor;
                Bquitter.BackColor = Color.FromArgb(250, 250, 250);      Bquitter.ForeColor = DefaultForeColor;
                BdarkLight.BackColor = Color.FromArgb(250, 250, 250);    BdarkLight.ForeColor = DefaultForeColor;
                bParametres.BackColor = Color.FromArgb(250, 250, 250);   bParametres.ForeColor = DefaultForeColor;

                // les labels
                label4.ForeColor = DefaultForeColor;
                LBLmotATrouver.ForeColor = DefaultForeColor;
                LBLnombreEssaisRestant.ForeColor = DefaultForeColor;
                LBLnombreEssaisRestant2.ForeColor = DefaultForeColor;
                LBLhistoriqueResultat.ForeColor = DefaultForeColor;
                LBLhistoriqueResultat2.ForeColor = DefaultForeColor;
                LBLhistoriqueNombreEssais.ForeColor = DefaultForeColor;
                LBLhistoriqueNombreEssais2.ForeColor = DefaultForeColor;
                LBLhistoriqueMotATrouver.ForeColor = DefaultForeColor;
                LBLhistoriqueMotATrouver2.ForeColor = DefaultForeColor;
                lblNbTentaModif.ForeColor = DefaultForeColor;
                lblNbEssais.ForeColor = DefaultForeColor;
                lblNbEssais2.ForeColor = DefaultForeColor;

                // les groupBoxes
                groupBox1.ForeColor = DefaultForeColor;
                groupBox2.ForeColor = DefaultForeColor;
                groupBox3.ForeColor = DefaultForeColor;

                // les textBoxes
                TBproposition.BackColor = Color.FromArgb(250, 250, 250);       TBproposition.ForeColor = DefaultForeColor;
                LBlistProposFaites.BackColor = Color.FromArgb(250, 250, 250);  LBlistProposFaites.ForeColor = DefaultForeColor;

                // la comboBox
                CBhistorique.BackColor = Color.FromArgb(250, 250, 250);  CBhistorique.ForeColor = DefaultForeColor;
            }
        }
    }

    //===============================================================================
    // - - - - - - - - - - - AUTRES CLASSES  - - - - - - - - - - - - - - - - - - - -
    //===============================================================================

    public class PartiesResultats
    {
        String mot;
        int nbTenta;
        Boolean gagne;

        // tableau
        public static List<PartiesResultats> tabParties = new List<PartiesResultats>();

        // constructeur
        public PartiesResultats (String mot, int nbTenta, Boolean gagne) {
            this.mot = mot;
            this.nbTenta = nbTenta;
            this.gagne = gagne;
            tabParties.Add(this);
        }

        // methodes get
        public int getNbTenta() { return this.nbTenta; }
        public String getMot() { return this.mot; }
        public Boolean getGagne() { return this.gagne; }
    }
}