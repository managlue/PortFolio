
namespace DevineurForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxMots = new System.Windows.Forms.ListBox();
            this.btAppliquer = new System.Windows.Forms.Button();
            this.labelListMot = new System.Windows.Forms.Label();
            this.textBoxMot = new System.Windows.Forms.TextBox();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMots
            // 
            this.listBoxMots.FormattingEnabled = true;
            this.listBoxMots.ItemHeight = 15;
            this.listBoxMots.Location = new System.Drawing.Point(252, 56);
            this.listBoxMots.Name = "listBoxMots";
            this.listBoxMots.Size = new System.Drawing.Size(196, 364);
            this.listBoxMots.TabIndex = 0;
            this.listBoxMots.SelectedIndexChanged += new System.EventHandler(this.listBoxMots_SelectedIndexChanged);
            // 
            // btAppliquer
            // 
            this.btAppliquer.Location = new System.Drawing.Point(55, 326);
            this.btAppliquer.Name = "btAppliquer";
            this.btAppliquer.Size = new System.Drawing.Size(140, 42);
            this.btAppliquer.TabIndex = 1;
            this.btAppliquer.Text = "Appliquer";
            this.btAppliquer.UseVisualStyleBackColor = true;
            this.btAppliquer.Click += new System.EventHandler(this.btAppliquer_Click);
            // 
            // labelListMot
            // 
            this.labelListMot.AutoSize = true;
            this.labelListMot.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelListMot.Location = new System.Drawing.Point(252, 25);
            this.labelListMot.Name = "labelListMot";
            this.labelListMot.Size = new System.Drawing.Size(93, 28);
            this.labelListMot.TabIndex = 2;
            this.labelListMot.Text = "Les Mots:";
            // 
            // textBoxMot
            // 
            this.textBoxMot.Location = new System.Drawing.Point(39, 84);
            this.textBoxMot.Name = "textBoxMot";
            this.textBoxMot.Size = new System.Drawing.Size(180, 23);
            this.textBoxMot.TabIndex = 3;
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(81, 113);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(84, 42);
            this.btAjouter.TabIndex = 4;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(55, 374);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(140, 42);
            this.btQuitter.TabIndex = 5;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nouveau mot";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.textBoxMot);
            this.Controls.Add(this.labelListMot);
            this.Controls.Add(this.btAppliquer);
            this.Controls.Add(this.listBoxMots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Mots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMots;
        private System.Windows.Forms.Button btAppliquer;
        private System.Windows.Forms.Label labelListMot;
        private System.Windows.Forms.TextBox textBoxMot;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label label1;
    }
}