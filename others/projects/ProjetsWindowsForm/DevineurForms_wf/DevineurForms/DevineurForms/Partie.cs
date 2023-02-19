using System;
using System.Collections.Generic;
using System.Text;

namespace DevineurForms
{
    class Partie
    {
        private static int compteurPartie = 0;

        int numPartie;
        String motADeviner;
        bool gagner;
        int nbCoups;

        public Partie(String motADeviner,bool gagner, int nbCoups)
        {
            compteurPartie++;
            numPartie = compteurPartie;

            this.motADeviner = motADeviner;
            this.gagner = gagner;
            this.nbCoups = nbCoups;
        }

        public int getPartieNumber() { return numPartie; }
        public String getMotADeviner() { return motADeviner; }
        public bool getGagner() { return gagner; }
        public int getNbCoups() { return nbCoups; }
    }
}
