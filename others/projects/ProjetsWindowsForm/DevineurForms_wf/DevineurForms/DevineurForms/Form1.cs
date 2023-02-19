using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DevineurForms
{
    public partial class Form1 : Form
    {
        private List<String> defaultTabMots = new List<String> { "ELEPHANT", "ALPHABET", "TORTUE", "VOITURE", "SOLEIL", "ORDINATEUR", "SOURIS", "ECHARPE" };
        public List<String> tabMots;
        private Random rnd;

        private String motADeviner;
        private String motDeformer;

        private int nbRestant;
        private const int defaultMaxCoups = 10;
        private int maxCoups;

        private IDictionary<string, Partie> lesParties = new Dictionary<string, Partie>();

        public Form1()
        {
            InitializeComponent();
            initialisation();
        }
        private void shake()
        {
            for (int i = 0; i < 5; i++)
            {
                this.Left += 5;
                System.Threading.Thread.Sleep(40);
                this.Left -= 5;
                System.Threading.Thread.Sleep(40);
            }
        }

        private void initialisation()
        {
            maxCoups = defaultMaxCoups;
            sliderEssaies.Value = maxCoups;
            tabMots = defaultTabMots;

            rnd = new Random();

            nouvellePartie();
        }

        private String melanger(String chaine)
        {
            Console.WriteLine("melange!");
            String newRdmStr = "";
            for (int i = 0; i < chaine.Length; i++) newRdmStr = newRdmStr.Insert(rnd.Next(0, newRdmStr.Length), chaine[i].ToString());
            return newRdmStr;
        }

        private void ajouterPartie(Partie unePartie)
        {
            string nom = "Partie " + unePartie.getPartieNumber().ToString();
            lesParties.Add("Partie " + unePartie.getPartieNumber().ToString(), unePartie);
            comboBox1.Items.Add(nom);
            comboBox1.SelectedIndex = unePartie.getPartieNumber()-1;
        }
        private void nouvellePartie()
        {
            motADeviner = tabMots[rnd.Next(tabMots.Count)].ToUpper();
            motDeformer = melanger(motADeviner);
            nbRestant = maxCoups-1;

            lblMot.Text = motDeformer;
            lblNbEssais.Text = nbRestant.ToString();
            lbPrecedent.Items.Clear();
        }

        private void motCorrect()
        {
            string message = "Bravo, veux tu rejouer ?";
            string caption = "Erreur";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No) this.Close();
            else
            {
                ajouterPartie(new Partie(motADeviner, true, maxCoups - nbRestant));
                nouvellePartie();
            }
        }

        private void motIncorrect()
        {
            string message = "Perdu, le mot était \""+motADeviner+"\", veux tu rejouer?";
            string caption = "Erreur";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No) this.Close();
            else
            {
                ajouterPartie(new Partie(motADeviner, false, maxCoups- nbRestant));
                nouvellePartie();
            }
        }
        private void quitter()
        {
            string message = "Es-tu sûr de vouloir quitter?";
            string caption = "Erreur";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes) this.Close();
        }
        private void rejouer()
        {
            string message = "Ceci annulera la partie en cours, es-tu sûr?";
            string caption = "Erreur";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes) nouvellePartie();
        }

        private void btTester_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();

            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.ToUpper() == motADeviner) motCorrect();
                else
                {
                    lbPrecedent.Items.Add(textBox1.Text.ToUpper());
                    if (nbRestant > 0)
                    {
                        nbRestant--;
                        lblNbEssais.Text = nbRestant.ToString();
                    }
                    else motIncorrect();
                }
                textBox1.Text = "";
            } else shake();
        }

        private void button2_Click(object sender, EventArgs e) {    quitter();  }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partieNom = (string)comboBox1.SelectedItem;
            Partie unePartie = lesParties[partieNom];

            lblHistoriqueMotADeviner.Text = unePartie.getMotADeviner();
            lblHistoriqueNbCoups.Text = unePartie.getNbCoups().ToString();

            if (unePartie.getGagner()) lblHistoriqueResultat.Text = "Gagné";
            else lblHistoriqueResultat.Text = "Perdu";
        }

        private void btRejouer_Click(object sender, EventArgs e) {  rejouer();  }

        private void sliderEssaies_Scroll(object sender, EventArgs e)
        {
            labelNbEssaies.Text = sliderEssaies.Value.ToString();
            maxCoups = sliderEssaies.Value;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            maxCoups = defaultMaxCoups;
            sliderEssaies.Value = maxCoups;
            labelNbEssaies.Text = maxCoups.ToString();

            tabMots = defaultTabMots;
        }

        private void btAjouterMot_Click(object sender, EventArgs e)
        {
            Form formPopup = new Form2(tabMots, this);
            formPopup.Show(this);
        }
    }
}
