using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace AlcoolTest
{
    class SqlConnection
    {
        private string m_hostname;
        private string m_database;
        private string m_user;
        private string m_password;
        private MySqlConnection connection;

        public SqlConnection(string hostname, string database, string user, string password)
        {
            this.m_hostname = hostname;
            this.m_database = database;
            this.m_user = user;
            this.m_password = password;
        }

        public void connexion()
        {
            this.connection = new MySqlConnection(String.Format("SERVER={0}; DATABASE={1}; UID={2}; PASSWORD={3}", m_hostname, m_database, m_user, m_password));
            this.connection.Open();
        }

        private void disconnect()
        {
            this.connection.Close();
        }

        public void creerNouvelleUtilisateur(string taux)
        {
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "INSERT INTO users(taux) VALUES (@taux)";
            cmd.Parameters.AddWithValue("@taux", taux);
            cmd.ExecuteNonQuery();
        }

        private double calculer_pourcentage()
        {
            double taux_pourcentage = 0;
            foreach (double data in read_bdd())
            {
                taux_pourcentage += data;
            }

            return taux_pourcentage / read_bdd().Count;
        }

        private List<Double> read_bdd()
        {
            String sql = "SELECT taux FROM users";
            MySqlCommand cmd = new MySqlCommand(sql, this.connection);
            MySqlDataReader read = cmd.ExecuteReader();
            List<Double> data = new List<double>();
            while (read.Read())
                data.Add(read.GetDouble("taux"));
            read.Close();
            return data;
        }
        
        private int calculer_nb_alcoolique()
        {
            String sql = "SELECT taux FROM users";
            MySqlCommand cmd = new MySqlCommand(sql, this.connection);
            MySqlDataReader read = cmd.ExecuteReader();
            List<Double> data = new List<double>();
            int nb = 0;
            while (read.Read())
                if(read.GetDouble("taux") > 0.5)
                    nb++;
            return nb;
        }

        public void afficher_statistique()
        {
            MessageBox.Show("Le taux moyen est de " + calculer_pourcentage().ToString(".##") + " g/l \nNombre d'alcoolique ayant participer : " + calculer_nb_alcoolique().ToString());
        }

        public MySqlConnection getConnection()
        {
            return this.connection;
        }
    }
}
