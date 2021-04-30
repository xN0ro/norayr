using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    class DbEtudiant
    {
        public static MySqlConnection GetConnection()
        {
            
            string sql = "Server = localhost; Port = 3306; Database = etudiant; Uid = root; Pwd =";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            return con;
        }
        public static void AddStudent(Etudiant std)
        {
            string sql = "INSERT INTO tableau_etudiant(Prenom, Nom, Cours, Notes) VALUES (@PrenomEtudiant, @NomEtudiant,@CoursEtudiant,@NotesEtudiant)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@PrenomEtudiant", MySqlDbType.VarChar).Value = std.Prenom;
            cmd.Parameters.Add("@NomEtudiant", MySqlDbType.VarChar).Value = std.Nom;
            cmd.Parameters.Add("@CoursEtudiant", MySqlDbType.VarChar).Value = std.Cours;
            cmd.Parameters.Add("@NotesEtudiant", MySqlDbType.VarChar).Value = std.Notes;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouter avec sucee" ,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Etudiant non entrer. !\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateStudent(Etudiant std, string id)
        {
            string sql = "UPDATE tableau_etudiant SET Prenom = @PrenomEtudiant, Nom = @NomEtudiant, Cours = @CoursEtudiant , Notes = @NotesEtudiant WHERE id = @IDEtudiant";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDEtudiant", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@PrenomEtudiant", MySqlDbType.VarChar).Value = std.Prenom;
            cmd.Parameters.Add("@NomEtudiant", MySqlDbType.VarChar).Value = std.Nom;
            cmd.Parameters.Add("@CoursEtudiant", MySqlDbType.VarChar).Value = std.Cours;
            cmd.Parameters.Add("@NotesEtudiant", MySqlDbType.VarChar).Value = std.Notes;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update avec sucee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Etudiant non Updater. !\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        public static void DeleteEtudiant(string id)
        {
            string sql = "DELETE FROM tableau_etudiant WHERE ID = @IDEtudiant";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDEtudiant", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Effacer avec sucee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Etudiant non Effacer. !\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
