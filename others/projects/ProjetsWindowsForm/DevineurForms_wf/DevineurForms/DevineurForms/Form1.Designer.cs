
namespace DevineurForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeviner = new System.Windows.Forms.Label();
            this.lblMot = new System.Windows.Forms.Label();
            this.gbProposition = new System.Windows.Forms.GroupBox();
            this.btTester = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpEssais = new System.Windows.Forms.GroupBox();
            this.lbPrecedent = new System.Windows.Forms.ListBox();
            this.lblEssaisPrecedent = new System.Windows.Forms.Label();
            this.lblNbEssais = new System.Windows.Forms.Label();
            this.lblEssaisRestant = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHistoriqueResultat = new System.Windows.Forms.Label();
            this.lblHistoriqueNbCoups = new System.Windows.Forms.Label();
            this.lblHistoriqueMotADeviner = new System.Windows.Forms.Label();
            this.lblHistoriqueResultatNotice = new System.Windows.Forms.Label();
            this.lblHistoriqueNbCoupsNotice = new System.Windows.Forms.Label();
            this.lblHistoriqueMotADevinerNotice = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btRejouer = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btAjouterMot = new System.Windows.Forms.Button();
            this.labelNbEssaies = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderEssaies = new System.Windows.Forms.TrackBar();
            this.gbProposition.SuspendLayout();
            this.gpEssais.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderEssaies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeviner
            // 
            this.lblDeviner.AutoSize = true;
            this.lblDeviner.Location = new System.Drawing.Point(57, 23);
            this.lblDeviner.Name = "lblDeviner";
            this.lblDeviner.Size = new System.Drawing.Size(83, 15);
            this.lblDeviner.TabIndex = 0;
            this.lblDeviner.Text = "Mot à deviner:";
            // 
            // lblMot
            // 
            this.lblMot.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMot.Location = new System.Drawing.Point(57, 38);
            this.lblMot.Name = "lblMot";
            this.lblMot.Size = new System.Drawing.Size(405, 58);
            this.lblMot.TabIndex = 1;
            // 
            // gbProposition
            // 
            this.gbProposition.Controls.Add(this.btTester);
            this.gbProposition.Controls.Add(this.textBox1);
            this.gbProposition.Location = new System.Drawing.Point(57, 99);
            this.gbProposition.Name = "gbProposition";
            this.gbProposition.Size = new System.Drawing.Size(405, 100);
            this.gbProposition.TabIndex = 2;
            this.gbProposition.TabStop = false;
            this.gbProposition.Text = "Proposition";
            // 
            // btTester
            // 
            this.btTester.Location = new System.Drawing.Point(270, 38);
            this.btTester.Name = "btTester";
            this.btTester.Size = new System.Drawing.Size(84, 35);
            this.btTester.TabIndex = 1;
            this.btTester.Text = "Tester";
            this.btTester.UseVisualStyleBackColor = true;
            this.btTester.Click += new System.EventHandler(this.btTester_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 0;
            // 
            // gpEssais
            // 
            this.gpEssais.Controls.Add(this.lbPrecedent);
            this.gpEssais.Controls.Add(this.lblEssaisPrecedent);
            this.gpEssais.Controls.Add(this.lblNbEssais);
            this.gpEssais.Controls.Add(this.lblEssaisRestant);
            this.gpEssais.Location = new System.Drawing.Point(57, 205);
            this.gpEssais.Name = "gpEssais";
            this.gpEssais.Size = new System.Drawing.Size(405, 209);
            this.gpEssais.TabIndex = 3;
            this.gpEssais.TabStop = false;
            this.gpEssais.Text = "Essais";
            // 
            // lbPrecedent
            // 
            this.lbPrecedent.FormattingEnabled = true;
            this.lbPrecedent.ItemHeight = 15;
            this.lbPrecedent.Location = new System.Drawing.Point(23, 84);
            this.lbPrecedent.Name = "lbPrecedent";
            this.lbPrecedent.Size = new System.Drawing.Size(359, 109);
            this.lbPrecedent.TabIndex = 3;
            // 
            // lblEssaisPrecedent
            // 
            this.lblEssaisPrecedent.AutoSize = true;
            this.lblEssaisPrecedent.Location = new System.Drawing.Point(23, 66);
            this.lblEssaisPrecedent.Name = "lblEssaisPrecedent";
            this.lblEssaisPrecedent.Size = new System.Drawing.Size(101, 15);
            this.lblEssaisPrecedent.TabIndex = 2;
            this.lblEssaisPrecedent.Text = "Essais précédents:";
            // 
            // lblNbEssais
            // 
            this.lblNbEssais.AutoSize = true;
            this.lblNbEssais.Location = new System.Drawing.Point(166, 38);
            this.lblNbEssais.Name = "lblNbEssais";
            this.lblNbEssais.Size = new System.Drawing.Size(13, 15);
            this.lblNbEssais.TabIndex = 1;
            this.lblNbEssais.Text = "0";
            // 
            // lblEssaisRestant
            // 
            this.lblEssaisRestant.AutoSize = true;
            this.lblEssaisRestant.Location = new System.Drawing.Point(23, 38);
            this.lblEssaisRestant.Name = "lblEssaisRestant";
            this.lblEssaisRestant.Size = new System.Drawing.Size(136, 15);
            this.lblEssaisRestant.TabIndex = 0;
            this.lblEssaisRestant.Text = "Nombre d\'essais restant:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHistoriqueResultat);
            this.groupBox1.Controls.Add(this.lblHistoriqueNbCoups);
            this.groupBox1.Controls.Add(this.lblHistoriqueMotADeviner);
            this.groupBox1.Controls.Add(this.lblHistoriqueResultatNotice);
            this.groupBox1.Controls.Add(this.lblHistoriqueNbCoupsNotice);
            this.groupBox1.Controls.Add(this.lblHistoriqueMotADevinerNotice);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(486, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historique des parties";
            // 
            // lblHistoriqueResultat
            // 
            this.lblHistoriqueResultat.Location = new System.Drawing.Point(156, 144);
            this.lblHistoriqueResultat.Name = "lblHistoriqueResultat";
            this.lblHistoriqueResultat.Size = new System.Drawing.Size(100, 23);
            this.lblHistoriqueResultat.TabIndex = 6;
            // 
            // lblHistoriqueNbCoups
            // 
            this.lblHistoriqueNbCoups.Location = new System.Drawing.Point(156, 106);
            this.lblHistoriqueNbCoups.Name = "lblHistoriqueNbCoups";
            this.lblHistoriqueNbCoups.Size = new System.Drawing.Size(100, 23);
            this.lblHistoriqueNbCoups.TabIndex = 5;
            // 
            // lblHistoriqueMotADeviner
            // 
            this.lblHistoriqueMotADeviner.Location = new System.Drawing.Point(156, 85);
            this.lblHistoriqueMotADeviner.Name = "lblHistoriqueMotADeviner";
            this.lblHistoriqueMotADeviner.Size = new System.Drawing.Size(100, 23);
            this.lblHistoriqueMotADeviner.TabIndex = 4;
            // 
            // lblHistoriqueResultatNotice
            // 
            this.lblHistoriqueResultatNotice.AutoSize = true;
            this.lblHistoriqueResultatNotice.Location = new System.Drawing.Point(28, 144);
            this.lblHistoriqueResultatNotice.Name = "lblHistoriqueResultatNotice";
            this.lblHistoriqueResultatNotice.Size = new System.Drawing.Size(52, 15);
            this.lblHistoriqueResultatNotice.TabIndex = 3;
            this.lblHistoriqueResultatNotice.Text = "Résultat:";
            // 
            // lblHistoriqueNbCoupsNotice
            // 
            this.lblHistoriqueNbCoupsNotice.AutoSize = true;
            this.lblHistoriqueNbCoupsNotice.Location = new System.Drawing.Point(28, 106);
            this.lblHistoriqueNbCoupsNotice.Name = "lblHistoriqueNbCoupsNotice";
            this.lblHistoriqueNbCoupsNotice.Size = new System.Drawing.Size(105, 15);
            this.lblHistoriqueNbCoupsNotice.TabIndex = 2;
            this.lblHistoriqueNbCoupsNotice.Text = "Nombre de coups:";
            // 
            // lblHistoriqueMotADevinerNotice
            // 
            this.lblHistoriqueMotADevinerNotice.AutoSize = true;
            this.lblHistoriqueMotADevinerNotice.Location = new System.Drawing.Point(28, 85);
            this.lblHistoriqueMotADevinerNotice.Name = "lblHistoriqueMotADevinerNotice";
            this.lblHistoriqueMotADevinerNotice.Size = new System.Drawing.Size(83, 15);
            this.lblHistoriqueMotADevinerNotice.TabIndex = 1;
            this.lblHistoriqueMotADevinerNotice.Text = "Mot à deviner:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btRejouer
            // 
            this.btRejouer.Location = new System.Drawing.Point(509, 376);
            this.btRejouer.Name = "btRejouer";
            this.btRejouer.Size = new System.Drawing.Size(86, 38);
            this.btRejouer.TabIndex = 5;
            this.btRejouer.Text = "Rejouer";
            this.btRejouer.UseVisualStyleBackColor = true;
            this.btRejouer.Click += new System.EventHandler(this.btRejouer_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(640, 376);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(86, 38);
            this.btQuitter.TabIndex = 6;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btReset);
            this.groupBox2.Controls.Add(this.btAjouterMot);
            this.groupBox2.Controls.Add(this.labelNbEssaies);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sliderEssaies);
            this.groupBox2.Location = new System.Drawing.Point(486, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(180, 26);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(103, 30);
            this.btReset.TabIndex = 4;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btAjouterMot
            // 
            this.btAjouterMot.Location = new System.Drawing.Point(18, 26);
            this.btAjouterMot.Name = "btAjouterMot";
            this.btAjouterMot.Size = new System.Drawing.Size(105, 30);
            this.btAjouterMot.TabIndex = 3;
            this.btAjouterMot.Text = "Ajouter Mots";
            this.btAjouterMot.UseVisualStyleBackColor = true;
            this.btAjouterMot.Click += new System.EventHandler(this.btAjouterMot_Click);
            // 
            // labelNbEssaies
            // 
            this.labelNbEssaies.AutoSize = true;
            this.labelNbEssaies.Location = new System.Drawing.Point(86, 71);
            this.labelNbEssaies.Name = "labelNbEssaies";
            this.labelNbEssaies.Size = new System.Drawing.Size(19, 15);
            this.labelNbEssaies.TabIndex = 2;
            this.labelNbEssaies.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nb Essaies:";
            // 
            // sliderEssaies
            // 
            this.sliderEssaies.Location = new System.Drawing.Point(6, 89);
            this.sliderEssaies.Maximum = 25;
            this.sliderEssaies.Minimum = 1;
            this.sliderEssaies.Name = "sliderEssaies";
            this.sliderEssaies.Size = new System.Drawing.Size(290, 45);
            this.sliderEssaies.TabIndex = 0;
            this.sliderEssaies.Tag = "";
            this.sliderEssaies.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sliderEssaies.Value = 1;
            this.sliderEssaies.Scroll += new System.EventHandler(this.sliderEssaies_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btRejouer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpEssais);
            this.Controls.Add(this.gbProposition);
            this.Controls.Add(this.lblMot);
            this.Controls.Add(this.lblDeviner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbProposition.ResumeLayout(false);
            this.gbProposition.PerformLayout();
            this.gpEssais.ResumeLayout(false);
            this.gpEssais.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderEssaies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviner;
        private System.Windows.Forms.Label lblMot;
        private System.Windows.Forms.GroupBox gbProposition;
        private System.Windows.Forms.GroupBox gpEssais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRejouer;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btTester;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbPrecedent;
        private System.Windows.Forms.Label lblEssaisPrecedent;
        private System.Windows.Forms.Label lblNbEssais;
        private System.Windows.Forms.Label lblEssaisRestant;
        private System.Windows.Forms.Label lblHistoriqueResultat;
        private System.Windows.Forms.Label lblHistoriqueNbCoups;
        private System.Windows.Forms.Label lblHistoriqueMotADeviner;
        private System.Windows.Forms.Label lblHistoriqueResultatNotice;
        private System.Windows.Forms.Label lblHistoriqueNbCoupsNotice;
        private System.Windows.Forms.Label lblHistoriqueMotADevinerNotice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sliderEssaies;
        private System.Windows.Forms.Label labelNbEssaies;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btAjouterMot;
    }
}

