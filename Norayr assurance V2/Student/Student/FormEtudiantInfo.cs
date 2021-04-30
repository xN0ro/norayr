using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class FormEtudiantInfo : Form
    {
        FormEtudiant form;

        public FormEtudiantInfo()
        {
            InitializeComponent();
            form = new FormEtudiant(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            DbEtudiant.DisplayAndSearch("SELECT ID , Prenom, Nom, Cours, Notes From tableau_etudiant", dataGridView);
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {

            form.Clear();
            form.ShowDialog();
        }

        private void FormEtudiantInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.prenom = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.cours = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.notes = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Voulez-vous effacer l'etudiant?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbEtudiant.DeleteEtudiant(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }

                return;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
