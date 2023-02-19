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
    // - - - - - - - - - - - GAME OVER - - - - - - - - - - - - - - - - - - - - - - -
    //===============================================================================

    public partial class FormGameOver : Form
    {
        public FormGameOver() { InitializeComponent(); }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set Form's Transperancy 100 %
            this.Opacity = 0;

            // Start the Timer To Animate Form
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Make Form Visible a Bit more on Every timer Tick
            if (this.Opacity < 1) this.Opacity += 0.04;
        }


        //===============================================================================
        // - - - - - - - - - - - BOUTONS - - - - - - - - - - - - - - - - - - - - - - - - 
        //===============================================================================

        private void bRejouer_Click(object sender, EventArgs e)
        {
            // fait pareil que le bouton de la fenêtre principale
            this.Close();
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            // fait pareil que le bouton de la fenêtre principale
        }
    }
}
