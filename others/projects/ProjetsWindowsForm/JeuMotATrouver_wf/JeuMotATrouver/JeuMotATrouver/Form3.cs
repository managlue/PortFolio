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
    //===============================================================================
    // - - - - - - - - - - - TIC TAC TOE - - - - - - - - - - - - - - - - - - - - - -
    //===============================================================================

    public partial class FormTtt : Form
    {
        Boolean enCour = false;
        Boolean ordi = false;
        Boolean tourJ = true;
        Boolean marqueurX = true;
        Boolean partieBloquee = false;

        int scoreJ1 = 0;
        int scoreJ2 = 0;

        int bHg = 0; int bHm = 0; int bHd = 0;
        int bMg = 0; int bMm = 0; int bMd = 0;
        int bBg = 0; int bBm = 0; int bBd = 0;

        int c1 = 0; int c2 = 0; int c3 = 0;
        int l1 = 0; int l2 = 0; int l3 = 0;
        int d1 = 0; int d2 = 0;

        int[] cases;

        public FormTtt() { InitializeComponent(); }

        //===============================================================================
        // - - - - - - - - - - - GERER LES JOUEURS - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        private void initialisation()
        {
            l1 = bHg + bHm + bHd;
            l2 = bMg + bMm + bMd;
            l3 = bBg + bBm + bBd;

            c1 = bHg + bMg + bBg;
            c2 = bHm + bMm + bBm;
            c3 = bHd + bMd + bBd;

            d1 = bHg + bMm + bBd;
            d2 = bBg + bMm + bHd;
        }

        private void bDeuxiemeJ_Click(object sender, EventArgs e) {
            if (!partieBloquee) {
                // ajouter un joueur
                if (!ordi) {
                    if (marqueurX) {
                        bDeuxiemeJ.Text = "Enlever joueur";
                        bJ2.Text = "Joueur 2 : O";
                        ordi = true;
                    }
                    else {
                        bDeuxiemeJ.Text = "Enlever joueur";
                        bJ2.Text = "Joueur 2 : X";
                        ordi = true;
                    }
                }
                // remettre l'ordi
                else {
                    if (marqueurX) {
                        bDeuxiemeJ.Text = "Deuxième joueur";
                        bJ2.Text = "Ordi : O";
                        ordi = false;
                    }
                    else {
                        bDeuxiemeJ.Text = "Deuxième joueur";
                        bJ2.Text = "Ordi : X";
                        ordi = false;
                    }
                }
            }
        }

        // décider si le joueur prend la croie ou le rond
        private void bJ1_Click(object sender, EventArgs e) {
            if (!partieBloquee) {
                if (!enCour) {
                    if (marqueurX) {
                        bJ1.Text = "Joueur 1 : X";
                        if (!ordi) bJ2.Text = "Ordi : O";
                        else bJ2.Text = "Joueur 2 : O";
                        marqueurX = false;
                    }
                    else {
                        bJ1.Text = "Joueur 1 : O";
                        if (!ordi) bJ2.Text = "Ordi : X";
                        else bJ2.Text = "Joueur 2 : X";
                        marqueurX = true;
                    }
                }
            }
        }

        //===============================================================================
        // - - - - - - - - - - - BOUTONS CASES - - - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        private void bHG_Click(object sender, EventArgs e) {
            if (bHg == 0) {
                clicCase(bHG);
                bHg++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        private void bHM_Click(object sender, EventArgs e) {
            if (bHm == 0) {
                clicCase(bHM);
                bHm++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        private void bHD_Click(object sender, EventArgs e) {
            if (bHd == 0) {
                clicCase(bHD); 
                bHd++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        private void bMG_Click(object sender, EventArgs e) {
            if (bMg == 0) {
                clicCase(bMG);
                bMg++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        private void bMM_Click(object sender, EventArgs e) {
            if (bMm == 0) {
                clicCase(bMM);
                bMm++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        private void bMD_Click(object sender, EventArgs e) {
            if (bMd == 0) {
                clicCase(bMD);
                bMd++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        private void bBG_Click(object sender, EventArgs e) {
            if (bBg == 0) {
                clicCase(bBG);
                bBg++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        private void bBM_Click(object sender, EventArgs e) {
            if (bBm == 0) {
                clicCase(bBM);
                bBm++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        private void bBD_Click(object sender, EventArgs e) {
            if (bBd == 0) {
                clicCase(bBD);
                bBd++;
                partieBloquee = true;
                calculV();
                // l'ordi fait son tour
                if (ordi) calculOrdi();
                calculV();
            }
        }

        // la fonction qui change le contenue du bouton
        void clicCase(Button b) {

            // le joueur 1 fait son tour
            if (tourJ) {
                if (marqueurX) b.Text = "X";
                else b.Text = "O";
                tourJ = false;
            }
            // le joueur 2 fait son tour
            else if (!ordi) {
                if (!marqueurX) b.Text = "X";
                else b.Text = "O";
                tourJ = true;
            }
            calcul();
        }

        //===============================================================================
        // - - - - - - - - - - - CALCULS - - - - - - - - - - - - - - - - - - - - - - - -
        //===============================================================================

        void calcul()
        {
            l1 = bHg + bHm + bHd;
            l2 = bMg + bMm + bMd;
            l3 = bBg + bBm + bBd;

            c1 = bHg + bMg + bBg;
            c2 = bHm + bMm + bBm;
            c3 = bHd + bMd + bBd;

            d1 = bHg + bMm + bBd;
            d2 = bBg + bMm + bHd;
        }

        void calculOrdi() {

            System.Threading.Thread.Sleep(25);

            if (l1 == 2) {
                if (bHg == 0) bHg++;
                else if (bHm == 0) bHm++;
                else bHd++;
            }
            else if (l2 == 2) {
                if (bMg == 0) bMg++;
                else if (bMm == 0) bMm++;
                else bMd++;
            }
            else if (l3 == 2) {
                if (bBg == 0) bBg++;
                else if (bBm == 0) bBm++;
                else bBd++;
            }
            else if (c1 == 2) {
                if (bHg == 0) bHg++;
                else if (bMg == 0) bMg++;
                else bBg++;
            }
            else if (c2 == 2) {
                if (bHm == 0) bHm++;
                else if (bMm == 0) bMm++;
                else bBm++;
            }
            else if (c3 == 2) {
                if (bHd == 0) bHd++;
                else if (bHd == 0) bHd++;
                else bHd++;
            }
            else if (d1 == 2) {
                if (bHg == 0) bHg++;
                else if (bMm == 0) bMm++;
                else bBd++;
            }
            else if (d2 == 2) {
                if (bBg == 0) bBg++;
                else if (bMm == 0) bMm++;
                else bHd++;
            }
            else {
                int g = 0;
                while (g == 0) {
                    var rand = new Random();
                    int i = rand.Next(9);

                    switch (i) {
                        case 0: 
                            if (bHg == 0) {
                                if (!marqueurX) bHG.Text = "X";
                                else bHG.Text = "O";
                                tourJ = true;
                                bHg++;
                                g++;
                            } break;
                        case 1:
                            if (bHm == 0) {
                                if (!marqueurX) bHM.Text = "X";
                                else bHM.Text = "O";
                                tourJ = true;
                                bHm++;
                                g++;
                                } break;
                        case 2:
                            if (bHd == 0) {
                                if (!marqueurX) bHD.Text = "X";
                                else bHD.Text = "O";
                                tourJ = true;
                                bHd++;
                                g++;
                                } break;
                        case 3:
                            if (bMg == 0) {
                                if (!marqueurX) bMG.Text = "X";
                                else bMG.Text = "O";
                                tourJ = true;
                                bMg++;
                                g++;
                        } break;
                        case 4: 
                            if (bMm == 0) {
                                if (!marqueurX) bMM.Text = "X";
                                else bMM.Text = "O";
                                tourJ = true;
                                bMm++;
                                g++;
                            } break;
                        case 5:
                            if (bMd == 0) {
                                if (!marqueurX) bMD.Text = "X";
                                else bMD.Text = "O";
                                tourJ = true;
                                bMd++;
                                g++;
                            } break;
                        case 6: 
                            if (bBg == 0) {
                                if (!marqueurX) bBG.Text = "X";
                                else bBG.Text = "O";
                                tourJ = true;
                                bBg++;
                                g++;
                            } break;
                        case 7: 
                            if (bBm == 0) {
                                if (!marqueurX) bBM.Text = "X";
                                else bBM.Text = "O";
                                tourJ = true;
                                bBm++;
                                g++;
                            } break;
                        case 8: 
                            if (bBd == 0) {
                                if (!marqueurX) bBD.Text = "X";
                                else bHD.Text = "O";
                                tourJ = true;
                                bBd++;
                                g++;
                            } break;
                    }
                }
            } calcul();
        }

        void calculV()
        {
            if (l1==3 || l2 == 3 || l3 == 3 || c1 == 3 || c2 == 3 || c3 == 3 || d1 == 3 || d2 == 3) {
                if (tourJ) lblScoreJ1.Text = scoreJ1.ToString();
                else lblScoreJ2.Text = scoreJ2.ToString();
            }
        }
    }
}
