
namespace JeuMotATrouver
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBproposition = new System.Windows.Forms.TextBox();
            this.Btester = new System.Windows.Forms.Button();
            this.rbCSms = new System.Windows.Forms.RadioButton();
            this.lblTt = new System.Windows.Forms.Label();
            this.nudTaillePolice = new System.Windows.Forms.NumericUpDown();
            this.rbSymbol = new System.Windows.Forms.RadioButton();
            this.rbMC = new System.Windows.Forms.RadioButton();
            this.rbMSS = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTextes = new System.Windows.Forms.RadioButton();
            this.rbBoutons = new System.Windows.Forms.RadioButton();
            this.rbBoites = new System.Windows.Forms.RadioButton();
            this.rbFond = new System.Windows.Forms.RadioButton();
            this.rbOverAll = new System.Windows.Forms.RadioButton();
            this.lblB = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.LBLnombreEssaisRestant2 = new System.Windows.Forms.Label();
            this.LBlistProposFaites = new System.Windows.Forms.ListBox();
            this.LBLnombreEssaisRestant = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LBLhistoriqueResultat2 = new System.Windows.Forms.Label();
            this.LBLhistoriqueNombreEssais2 = new System.Windows.Forms.Label();
            this.LBLhistoriqueMotATrouver2 = new System.Windows.Forms.Label();
            this.LBLhistoriqueResultat = new System.Windows.Forms.Label();
            this.LBLhistoriqueNombreEssais = new System.Windows.Forms.Label();
            this.LBLhistoriqueMotATrouver = new System.Windows.Forms.Label();
            this.CBhistorique = new System.Windows.Forms.ComboBox();
            this.Brejouer = new System.Windows.Forms.Button();
            this.Bquitter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LBLmotATrouver = new System.Windows.Forms.Label();
            this.LBLmotATrouver2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblNbTentaModif = new System.Windows.Forms.Label();
            this.lblNbEssais = new System.Windows.Forms.Label();
            this.lblNbEssais2 = new System.Windows.Forms.Label();
            this.BdarkLight = new System.Windows.Forms.Button();
            this.bParametres = new System.Windows.Forms.Button();
            this.lblModelMSS = new System.Windows.Forms.Label();
            this.lblModelCSms = new System.Windows.Forms.Label();
            this.lblModelMC = new System.Windows.Forms.Label();
            this.lblModelSymbol = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaillePolice)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBproposition);
            this.groupBox1.Controls.Add(this.Btester);
            this.groupBox1.Controls.Add(this.rbCSms);
            this.groupBox1.Controls.Add(this.lblTt);
            this.groupBox1.Controls.Add(this.nudTaillePolice);
            this.groupBox1.Controls.Add(this.rbSymbol);
            this.groupBox1.Controls.Add(this.rbMC);
            this.groupBox1.Controls.Add(this.rbMSS);
            this.groupBox1.Location = new System.Drawing.Point(31, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proposition";
            // 
            // TBproposition
            // 
            this.TBproposition.Location = new System.Drawing.Point(22, 37);
            this.TBproposition.Name = "TBproposition";
            this.TBproposition.Size = new System.Drawing.Size(200, 20);
            this.TBproposition.TabIndex = 0;
            // 
            // Btester
            // 
            this.Btester.Location = new System.Drawing.Point(240, 30);
            this.Btester.Name = "Btester";
            this.Btester.Size = new System.Drawing.Size(85, 35);
            this.Btester.TabIndex = 0;
            this.Btester.Text = "Tester";
            this.Btester.UseVisualStyleBackColor = true;
            this.Btester.Click += new System.EventHandler(this.Btester_Click);
            // 
            // rbCSms
            // 
            this.rbCSms.AutoSize = true;
            this.rbCSms.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCSms.Location = new System.Drawing.Point(16, 56);
            this.rbCSms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCSms.Name = "rbCSms";
            this.rbCSms.Size = new System.Drawing.Size(105, 19);
            this.rbCSms.TabIndex = 9;
            this.rbCSms.Text = "Comic Sans MS";
            this.rbCSms.UseVisualStyleBackColor = true;
            this.rbCSms.Visible = false;
            this.rbCSms.CheckedChanged += new System.EventHandler(this.rbCSms_CheckedChanged);
            // 
            // lblTt
            // 
            this.lblTt.AutoSize = true;
            this.lblTt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTt.Location = new System.Drawing.Point(301, 36);
            this.lblTt.Name = "lblTt";
            this.lblTt.Size = new System.Drawing.Size(19, 13);
            this.lblTt.TabIndex = 14;
            this.lblTt.Text = "Tt";
            // 
            // nudTaillePolice
            // 
            this.nudTaillePolice.Location = new System.Drawing.Point(294, 50);
            this.nudTaillePolice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudTaillePolice.Name = "nudTaillePolice";
            this.nudTaillePolice.Size = new System.Drawing.Size(32, 20);
            this.nudTaillePolice.TabIndex = 13;
            this.nudTaillePolice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTaillePolice.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudTaillePolice.Visible = false;
            // 
            // rbSymbol
            // 
            this.rbSymbol.AutoSize = true;
            this.rbSymbol.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.rbSymbol.Location = new System.Drawing.Point(140, 56);
            this.rbSymbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSymbol.Name = "rbSymbol";
            this.rbSymbol.Size = new System.Drawing.Size(63, 17);
            this.rbSymbol.TabIndex = 10;
            this.rbSymbol.Text = "Symbol";
            this.rbSymbol.UseVisualStyleBackColor = true;
            this.rbSymbol.Visible = false;
            this.rbSymbol.CheckedChanged += new System.EventHandler(this.rbSymbol_CheckedChanged);
            // 
            // rbMC
            // 
            this.rbMC.AutoSize = true;
            this.rbMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMC.Location = new System.Drawing.Point(140, 31);
            this.rbMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMC.Name = "rbMC";
            this.rbMC.Size = new System.Drawing.Size(122, 19);
            this.rbMC.TabIndex = 11;
            this.rbMC.Text = "Monotype Corsiva";
            this.rbMC.UseVisualStyleBackColor = true;
            this.rbMC.Visible = false;
            this.rbMC.CheckedChanged += new System.EventHandler(this.rbMC_CheckedChanged);
            // 
            // rbMSS
            // 
            this.rbMSS.AutoSize = true;
            this.rbMSS.Checked = true;
            this.rbMSS.Location = new System.Drawing.Point(16, 31);
            this.rbMSS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMSS.Name = "rbMSS";
            this.rbMSS.Size = new System.Drawing.Size(119, 17);
            this.rbMSS.TabIndex = 12;
            this.rbMSS.TabStop = true;
            this.rbMSS.Text = "Microsoft Sans Serif";
            this.rbMSS.UseVisualStyleBackColor = true;
            this.rbMSS.Visible = false;
            this.rbMSS.CheckedChanged += new System.EventHandler(this.rbMSS_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTextes);
            this.groupBox2.Controls.Add(this.rbBoutons);
            this.groupBox2.Controls.Add(this.rbBoites);
            this.groupBox2.Controls.Add(this.rbFond);
            this.groupBox2.Controls.Add(this.rbOverAll);
            this.groupBox2.Controls.Add(this.lblB);
            this.groupBox2.Controls.Add(this.lblG);
            this.groupBox2.Controls.Add(this.lblR);
            this.groupBox2.Controls.Add(this.tbR);
            this.groupBox2.Controls.Add(this.tbG);
            this.groupBox2.Controls.Add(this.tbB);
            this.groupBox2.Controls.Add(this.LBLnombreEssaisRestant2);
            this.groupBox2.Controls.Add(this.LBlistProposFaites);
            this.groupBox2.Controls.Add(this.LBLnombreEssaisRestant);
            this.groupBox2.Location = new System.Drawing.Point(31, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Essais";
            // 
            // rbTextes
            // 
            this.rbTextes.AutoSize = true;
            this.rbTextes.Location = new System.Drawing.Point(14, 113);
            this.rbTextes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTextes.Name = "rbTextes";
            this.rbTextes.Size = new System.Drawing.Size(57, 17);
            this.rbTextes.TabIndex = 25;
            this.rbTextes.Text = "Textes";
            this.rbTextes.UseVisualStyleBackColor = true;
            this.rbTextes.Visible = false;
            this.rbTextes.CheckedChanged += new System.EventHandler(this.rbTextes_CheckedChanged);
            // 
            // rbBoutons
            // 
            this.rbBoutons.AutoSize = true;
            this.rbBoutons.Location = new System.Drawing.Point(14, 138);
            this.rbBoutons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbBoutons.Name = "rbBoutons";
            this.rbBoutons.Size = new System.Drawing.Size(64, 17);
            this.rbBoutons.TabIndex = 24;
            this.rbBoutons.Text = "Boutons";
            this.rbBoutons.UseVisualStyleBackColor = true;
            this.rbBoutons.Visible = false;
            this.rbBoutons.CheckedChanged += new System.EventHandler(this.rbBoutons_CheckedChanged);
            // 
            // rbBoites
            // 
            this.rbBoites.AutoSize = true;
            this.rbBoites.Location = new System.Drawing.Point(14, 88);
            this.rbBoites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbBoites.Name = "rbBoites";
            this.rbBoites.Size = new System.Drawing.Size(54, 17);
            this.rbBoites.TabIndex = 22;
            this.rbBoites.Text = "Boites";
            this.rbBoites.UseVisualStyleBackColor = true;
            this.rbBoites.Visible = false;
            this.rbBoites.CheckedChanged += new System.EventHandler(this.rbBoites_CheckedChanged);
            // 
            // rbFond
            // 
            this.rbFond.AutoSize = true;
            this.rbFond.Location = new System.Drawing.Point(14, 63);
            this.rbFond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFond.Name = "rbFond";
            this.rbFond.Size = new System.Drawing.Size(49, 17);
            this.rbFond.TabIndex = 21;
            this.rbFond.Text = "Fond";
            this.rbFond.UseVisualStyleBackColor = true;
            this.rbFond.Visible = false;
            this.rbFond.CheckedChanged += new System.EventHandler(this.rbFond_CheckedChanged);
            // 
            // rbOverAll
            // 
            this.rbOverAll.AutoSize = true;
            this.rbOverAll.Checked = true;
            this.rbOverAll.Location = new System.Drawing.Point(14, 37);
            this.rbOverAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOverAll.Name = "rbOverAll";
            this.rbOverAll.Size = new System.Drawing.Size(59, 17);
            this.rbOverAll.TabIndex = 15;
            this.rbOverAll.TabStop = true;
            this.rbOverAll.Text = "OverAll";
            this.rbOverAll.UseVisualStyleBackColor = true;
            this.rbOverAll.Visible = false;
            this.rbOverAll.CheckedChanged += new System.EventHandler(this.rbOverAll_CheckedChanged);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(313, 130);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(25, 13);
            this.lblB.TabIndex = 20;
            this.lblB.Text = "255";
            this.lblB.Visible = false;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(313, 86);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(25, 13);
            this.lblG.TabIndex = 19;
            this.lblG.Text = "255";
            this.lblG.Visible = false;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(313, 41);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(25, 13);
            this.lblR.TabIndex = 18;
            this.lblR.Text = "255";
            this.lblR.Visible = false;
            // 
            // tbR
            // 
            this.tbR.LargeChange = 15;
            this.tbR.Location = new System.Drawing.Point(81, 38);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(234, 45);
            this.tbR.TabIndex = 16;
            this.tbR.Value = 125;
            this.tbR.Visible = false;
            this.tbR.Scroll += new System.EventHandler(this.tbR_Scroll);
            // 
            // tbG
            // 
            this.tbG.LargeChange = 15;
            this.tbG.Location = new System.Drawing.Point(81, 83);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(234, 45);
            this.tbG.TabIndex = 17;
            this.tbG.Value = 125;
            this.tbG.Visible = false;
            this.tbG.Scroll += new System.EventHandler(this.tbG_Scroll);
            // 
            // tbB
            // 
            this.tbB.LargeChange = 15;
            this.tbB.Location = new System.Drawing.Point(81, 128);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(234, 45);
            this.tbB.TabIndex = 15;
            this.tbB.Value = 125;
            this.tbB.Visible = false;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            // 
            // LBLnombreEssaisRestant2
            // 
            this.LBLnombreEssaisRestant2.AutoSize = true;
            this.LBLnombreEssaisRestant2.Location = new System.Drawing.Point(141, 23);
            this.LBLnombreEssaisRestant2.Name = "LBLnombreEssaisRestant2";
            this.LBLnombreEssaisRestant2.Size = new System.Drawing.Size(0, 13);
            this.LBLnombreEssaisRestant2.TabIndex = 8;
            // 
            // LBlistProposFaites
            // 
            this.LBlistProposFaites.FormattingEnabled = true;
            this.LBlistProposFaites.Location = new System.Drawing.Point(6, 54);
            this.LBlistProposFaites.Name = "LBlistProposFaites";
            this.LBlistProposFaites.Size = new System.Drawing.Size(332, 121);
            this.LBlistProposFaites.TabIndex = 7;
            // 
            // LBLnombreEssaisRestant
            // 
            this.LBLnombreEssaisRestant.AutoSize = true;
            this.LBLnombreEssaisRestant.Location = new System.Drawing.Point(19, 23);
            this.LBLnombreEssaisRestant.Name = "LBLnombreEssaisRestant";
            this.LBLnombreEssaisRestant.Size = new System.Drawing.Size(128, 13);
            this.LBLnombreEssaisRestant.TabIndex = 5;
            this.LBLnombreEssaisRestant.Text = "Nombre restant d\'essais : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LBLhistoriqueResultat2);
            this.groupBox3.Controls.Add(this.LBLhistoriqueNombreEssais2);
            this.groupBox3.Controls.Add(this.LBLhistoriqueMotATrouver2);
            this.groupBox3.Controls.Add(this.LBLhistoriqueResultat);
            this.groupBox3.Controls.Add(this.LBLhistoriqueNombreEssais);
            this.groupBox3.Controls.Add(this.LBLhistoriqueMotATrouver);
            this.groupBox3.Controls.Add(this.CBhistorique);
            this.groupBox3.Location = new System.Drawing.Point(399, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 178);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historique des parties";
            // 
            // LBLhistoriqueResultat2
            // 
            this.LBLhistoriqueResultat2.AutoSize = true;
            this.LBLhistoriqueResultat2.Location = new System.Drawing.Point(73, 137);
            this.LBLhistoriqueResultat2.Name = "LBLhistoriqueResultat2";
            this.LBLhistoriqueResultat2.Size = new System.Drawing.Size(0, 13);
            this.LBLhistoriqueResultat2.TabIndex = 6;
            // 
            // LBLhistoriqueNombreEssais2
            // 
            this.LBLhistoriqueNombreEssais2.AutoSize = true;
            this.LBLhistoriqueNombreEssais2.Location = new System.Drawing.Point(111, 114);
            this.LBLhistoriqueNombreEssais2.Name = "LBLhistoriqueNombreEssais2";
            this.LBLhistoriqueNombreEssais2.Size = new System.Drawing.Size(0, 13);
            this.LBLhistoriqueNombreEssais2.TabIndex = 5;
            // 
            // LBLhistoriqueMotATrouver2
            // 
            this.LBLhistoriqueMotATrouver2.AutoSize = true;
            this.LBLhistoriqueMotATrouver2.Location = new System.Drawing.Point(99, 91);
            this.LBLhistoriqueMotATrouver2.Name = "LBLhistoriqueMotATrouver2";
            this.LBLhistoriqueMotATrouver2.Size = new System.Drawing.Size(0, 13);
            this.LBLhistoriqueMotATrouver2.TabIndex = 4;
            // 
            // LBLhistoriqueResultat
            // 
            this.LBLhistoriqueResultat.AutoSize = true;
            this.LBLhistoriqueResultat.Location = new System.Drawing.Point(24, 137);
            this.LBLhistoriqueResultat.Name = "LBLhistoriqueResultat";
            this.LBLhistoriqueResultat.Size = new System.Drawing.Size(52, 13);
            this.LBLhistoriqueResultat.TabIndex = 3;
            this.LBLhistoriqueResultat.Text = "Résultat :";
            // 
            // LBLhistoriqueNombreEssais
            // 
            this.LBLhistoriqueNombreEssais.AutoSize = true;
            this.LBLhistoriqueNombreEssais.Location = new System.Drawing.Point(24, 114);
            this.LBLhistoriqueNombreEssais.Name = "LBLhistoriqueNombreEssais";
            this.LBLhistoriqueNombreEssais.Size = new System.Drawing.Size(93, 13);
            this.LBLhistoriqueNombreEssais.TabIndex = 2;
            this.LBLhistoriqueNombreEssais.Text = "Nombre d\'essais : ";
            // 
            // LBLhistoriqueMotATrouver
            // 
            this.LBLhistoriqueMotATrouver.AutoSize = true;
            this.LBLhistoriqueMotATrouver.Location = new System.Drawing.Point(24, 91);
            this.LBLhistoriqueMotATrouver.Name = "LBLhistoriqueMotATrouver";
            this.LBLhistoriqueMotATrouver.Size = new System.Drawing.Size(78, 13);
            this.LBLhistoriqueMotATrouver.TabIndex = 1;
            this.LBLhistoriqueMotATrouver.Text = "Mot à deviner :";
            // 
            // CBhistorique
            // 
            this.CBhistorique.FormattingEnabled = true;
            this.CBhistorique.Location = new System.Drawing.Point(114, 43);
            this.CBhistorique.Name = "CBhistorique";
            this.CBhistorique.Size = new System.Drawing.Size(149, 21);
            this.CBhistorique.TabIndex = 0;
            this.CBhistorique.SelectedIndexChanged += new System.EventHandler(this.CBhistorique_SelectedIndexChanged);
            // 
            // Brejouer
            // 
            this.Brejouer.Location = new System.Drawing.Point(531, 330);
            this.Brejouer.Name = "Brejouer";
            this.Brejouer.Size = new System.Drawing.Size(100, 43);
            this.Brejouer.TabIndex = 3;
            this.Brejouer.Text = "Rejouer";
            this.Brejouer.UseVisualStyleBackColor = true;
            this.Brejouer.Click += new System.EventHandler(this.Brejouer_Click);
            // 
            // Bquitter
            // 
            this.Bquitter.Location = new System.Drawing.Point(662, 330);
            this.Bquitter.Name = "Bquitter";
            this.Bquitter.Size = new System.Drawing.Size(100, 43);
            this.Bquitter.TabIndex = 4;
            this.Bquitter.Text = "Quitter";
            this.Bquitter.UseVisualStyleBackColor = true;
            this.Bquitter.Click += new System.EventHandler(this.Bquitter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Devinez le mot dont les lettres sont :";
            // 
            // LBLmotATrouver
            // 
            this.LBLmotATrouver.AutoSize = true;
            this.LBLmotATrouver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLmotATrouver.Location = new System.Drawing.Point(28, 46);
            this.LBLmotATrouver.Name = "LBLmotATrouver";
            this.LBLmotATrouver.Size = new System.Drawing.Size(71, 29);
            this.LBLmotATrouver.TabIndex = 6;
            this.LBLmotATrouver.Text = "MTO";
            // 
            // LBLmotATrouver2
            // 
            this.LBLmotATrouver2.AutoSize = true;
            this.LBLmotATrouver2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLmotATrouver2.Location = new System.Drawing.Point(107, 46);
            this.LBLmotATrouver2.Name = "LBLmotATrouver2";
            this.LBLmotATrouver2.Size = new System.Drawing.Size(71, 29);
            this.LBLmotATrouver2.TabIndex = 7;
            this.LBLmotATrouver2.Text = "MOT";
            this.LBLmotATrouver2.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(399, 47);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(243, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblNbTentaModif
            // 
            this.lblNbTentaModif.AutoSize = true;
            this.lblNbTentaModif.Location = new System.Drawing.Point(380, 18);
            this.lblNbTentaModif.Name = "lblNbTentaModif";
            this.lblNbTentaModif.Size = new System.Drawing.Size(181, 13);
            this.lblNbTentaModif.TabIndex = 9;
            this.lblNbTentaModif.Text = "Combien de tentatives voulez vous ?";
            // 
            // lblNbEssais
            // 
            this.lblNbEssais.AutoSize = true;
            this.lblNbEssais.Location = new System.Drawing.Point(410, 88);
            this.lblNbEssais.Name = "lblNbEssais";
            this.lblNbEssais.Size = new System.Drawing.Size(88, 13);
            this.lblNbEssais.TabIndex = 10;
            this.lblNbEssais.Text = "nombre d\'essais :";
            // 
            // lblNbEssais2
            // 
            this.lblNbEssais2.AutoSize = true;
            this.lblNbEssais2.Location = new System.Drawing.Point(495, 88);
            this.lblNbEssais2.Name = "lblNbEssais2";
            this.lblNbEssais2.Size = new System.Drawing.Size(0, 13);
            this.lblNbEssais2.TabIndex = 11;
            // 
            // BdarkLight
            // 
            this.BdarkLight.Location = new System.Drawing.Point(662, 43);
            this.BdarkLight.Name = "BdarkLight";
            this.BdarkLight.Size = new System.Drawing.Size(100, 43);
            this.BdarkLight.TabIndex = 12;
            this.BdarkLight.Text = "Mode sombre";
            this.BdarkLight.UseVisualStyleBackColor = true;
            this.BdarkLight.Click += new System.EventHandler(this.BdarkLight_Click);
            // 
            // bParametres
            // 
            this.bParametres.Location = new System.Drawing.Point(399, 330);
            this.bParametres.Name = "bParametres";
            this.bParametres.Size = new System.Drawing.Size(99, 43);
            this.bParametres.TabIndex = 14;
            this.bParametres.Text = "Paramétrer";
            this.bParametres.UseVisualStyleBackColor = true;
            this.bParametres.Click += new System.EventHandler(this.bParametres_Click_1);
            // 
            // lblModelMSS
            // 
            this.lblModelMSS.AutoSize = true;
            this.lblModelMSS.Location = new System.Drawing.Point(255, 7);
            this.lblModelMSS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelMSS.Name = "lblModelMSS";
            this.lblModelMSS.Size = new System.Drawing.Size(101, 13);
            this.lblModelMSS.TabIndex = 15;
            this.lblModelMSS.Text = "Microsoft Sans Serif";
            this.lblModelMSS.Visible = false;
            // 
            // lblModelCSms
            // 
            this.lblModelCSms.AutoSize = true;
            this.lblModelCSms.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelCSms.Location = new System.Drawing.Point(256, 21);
            this.lblModelCSms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelCSms.Name = "lblModelCSms";
            this.lblModelCSms.Size = new System.Drawing.Size(87, 15);
            this.lblModelCSms.TabIndex = 16;
            this.lblModelCSms.Text = "Comic Sans MS";
            this.lblModelCSms.Visible = false;
            // 
            // lblModelMC
            // 
            this.lblModelMC.AutoSize = true;
            this.lblModelMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelMC.Location = new System.Drawing.Point(255, 35);
            this.lblModelMC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelMC.Name = "lblModelMC";
            this.lblModelMC.Size = new System.Drawing.Size(104, 15);
            this.lblModelMC.TabIndex = 17;
            this.lblModelMC.Text = "Monotype Corsiva";
            this.lblModelMC.Visible = false;
            // 
            // lblModelSymbol
            // 
            this.lblModelSymbol.AutoSize = true;
            this.lblModelSymbol.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.lblModelSymbol.Location = new System.Drawing.Point(256, 49);
            this.lblModelSymbol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelSymbol.Name = "lblModelSymbol";
            this.lblModelSymbol.Size = new System.Drawing.Size(45, 13);
            this.lblModelSymbol.TabIndex = 18;
            this.lblModelSymbol.Text = "Symbol";
            this.lblModelSymbol.Visible = false;
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.lblModelSymbol);
            this.Controls.Add(this.lblModelMC);
            this.Controls.Add(this.lblModelCSms);
            this.Controls.Add(this.lblModelMSS);
            this.Controls.Add(this.bParametres);
            this.Controls.Add(this.BdarkLight);
            this.Controls.Add(this.lblNbEssais2);
            this.Controls.Add(this.lblNbEssais);
            this.Controls.Add(this.lblNbTentaModif);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LBLmotATrouver2);
            this.Controls.Add(this.LBLmotATrouver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bquitter);
            this.Controls.Add(this.Brejouer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormPrincipale";
            this.Text = "Jeu des mots : Anagramme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaillePolice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btester;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LBLhistoriqueNombreEssais;
        private System.Windows.Forms.Label LBLhistoriqueMotATrouver;
        private System.Windows.Forms.ComboBox CBhistorique;
        private System.Windows.Forms.Button Brejouer;
        private System.Windows.Forms.Button Bquitter;
        private System.Windows.Forms.TextBox TBproposition;
        private System.Windows.Forms.Label LBLnombreEssaisRestant;
        private System.Windows.Forms.Label LBLhistoriqueResultat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBLmotATrouver;
        private System.Windows.Forms.ListBox LBlistProposFaites;
        private System.Windows.Forms.Label LBLmotATrouver2;
        private System.Windows.Forms.Label LBLnombreEssaisRestant2;
        private System.Windows.Forms.Label LBLhistoriqueMotATrouver2;
        private System.Windows.Forms.Label LBLhistoriqueResultat2;
        private System.Windows.Forms.Label LBLhistoriqueNombreEssais2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblNbTentaModif;
        private System.Windows.Forms.Label lblNbEssais;
        private System.Windows.Forms.Label lblNbEssais2;
        private System.Windows.Forms.Button BdarkLight;
        private System.Windows.Forms.Button bParametres;
        private System.Windows.Forms.NumericUpDown nudTaillePolice;
        private System.Windows.Forms.RadioButton rbMSS;
        private System.Windows.Forms.RadioButton rbMC;
        private System.Windows.Forms.RadioButton rbSymbol;
        private System.Windows.Forms.RadioButton rbCSms;
        private System.Windows.Forms.Label lblTt;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.RadioButton rbTextes;
        private System.Windows.Forms.RadioButton rbBoutons;
        private System.Windows.Forms.RadioButton rbBoites;
        private System.Windows.Forms.RadioButton rbFond;
        private System.Windows.Forms.RadioButton rbOverAll;
        private System.Windows.Forms.Label lblModelMSS;
        private System.Windows.Forms.Label lblModelCSms;
        private System.Windows.Forms.Label lblModelMC;
        private System.Windows.Forms.Label lblModelSymbol;
    }
}

