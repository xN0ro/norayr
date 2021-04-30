using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class FormEtudiant : Form
    {
        private readonly FormEtudiantInfo _parent;
       public string id, prenom, nom, cours, notes;
        public FormEtudiant(FormEtudiantInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            lbltext.Text = "Update Etudiant";
            buttonSave.Text = "Update";
            textPrenom.Text = prenom;
            textNom.Text = nom;
            textCours.Text = cours;
            textNotes.Text = notes;

        }
        public void Clear()
        {
            textPrenom.Text = textNom.Text = textCours.Text = textNotes.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textPrenom.Text.Trim().Length < 3)
            {
                MessageBox.Show("Manque le Prenom (> 3).");
                return;
            }
            if (textNom.Text.Trim().Length < 3)
            {
                MessageBox.Show("Manque le Nom (> 3).");
                return;
            }
            if (textCours.Text.Trim().Length == 0)
            {
                MessageBox.Show("Manque le Cours (> 1).");
                return;
            }
            if (textNotes.Text.Trim().Length == 0)
            {
                MessageBox.Show("Manque la Notes (> 1).");
                return;
            }
            if (buttonSave.Text == "Sauvegarder")
            {
                Etudiant std = new Etudiant(textPrenom.Text.Trim(), textNom.Text.Trim(), textCours.Text.Trim(), textNotes.Text.Trim());
                DbEtudiant.AddStudent(std);
                Clear();
            }
            if(buttonSave.Text == "Update")
            {
                Etudiant std = new Etudiant(textPrenom.Text.Trim(), textNom.Text.Trim(), textCours.Text.Trim(), textNotes.Text.Trim());
                DbEtudiant.UpdateStudent(std, id);
            }
            _parent.Display();

            
        }
    }
}
