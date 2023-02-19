using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevineurForms
{
    public partial class Form2 : Form
    {
        private Form1 leParent;
        private List<String> listeMot;

        public Form2(List<String> listeMot, Form1 parent)
        {
            InitializeComponent();

            this.listeMot = listeMot;
            foreach (String mot in listeMot) listBoxMots.Items.Add(mot);
            leParent = parent;
        
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

        private void btAppliquer_Click(object sender, EventArgs e) { leParent.tabMots = listeMot; }

        private void btQuitter_Click(object sender, EventArgs e) { this.Close(); }

        private void listBoxMots_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxMots.SelectedIndex;

            if (selectedIndex == -1) { return; }
            if (listBoxMots.Items.Count < 2) { shake(); return; }

            String txt = listBoxMots.GetItemText(listBoxMots.SelectedIndex);
            listBoxMots.Items.RemoveAt(selectedIndex);
            listeMot.Remove(txt);
            listeMot.RemoveAt(selectedIndex);
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            String txt = textBoxMot.Text.Trim().ToUpper();

            if (txt.Length > 0)
            {
                listeMot.Add(txt);
                listBoxMots.Items.Add(txt);

                textBoxMot.Text = "";
            }
            else shake();
        }
    }
}
