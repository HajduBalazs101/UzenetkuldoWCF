using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using UzenetkuldoWCF.Models;
using MySql.Data.MySqlClient;

namespace UzenetkuldoWCF
{
    public class UzenetService : IUzenetService
    {
        private string connectionString = "Server=localhost;Database=uzenetkuldo;Uid=root;Pwd=;";

        public List<Uzenet> Read()
        {
            List<Uzenet> uzenetek = new List<Uzenet>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM uzenet";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Uzenet u = new Uzenet();
                        u.Id = reader.GetInt32("Id");
                        u.Szoveg = reader.GetString("Szoveg");
                        u.KuldesiIdo = reader.GetDateTime("KüldesiIdo");
                        u.UzenetTipus = reader.GetString("UzenetTipus");
                        u.Telefon = reader["Telefon"].ToString();
                        u.Email = reader["Email"].ToString();

                        uzenetek.Add(u);
                    }
                }
            }
            return uzenetek;
        }

        public string Create(Uzenet uzenet)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO uzenet (Szoveg, KüldesiIdo, UzenetTipus, Telefon, Email) VALUES (@szoveg, @kuldesiido, @tipus, @telefon, @email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@szoveg", uzenet.Szoveg);
                cmd.Parameters.AddWithValue("@kuldesiido", uzenet.KuldesiIdo);
                cmd.Parameters.AddWithValue("@tipus", uzenet.UzenetTipus);
                cmd.Parameters.AddWithValue("@telefon", uzenet.Telefon);
                cmd.Parameters.AddWithValue("@email", uzenet.Email);

                int result = cmd.ExecuteNonQuery();
                return result > 0 ? "Sikeres rögzítés" : "Hiba a rögzítés során";
            }
        }

        public string Update(Uzenet uzenet)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE uzenet SET Szoveg=@szoveg, KüldesiIdo=@kuldesiido, UzenetTipus=@tipus, Telefon=@telefon, Email=@email WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", uzenet.Id);
                cmd.Parameters.AddWithValue("@szoveg", uzenet.Szoveg);
                cmd.Parameters.AddWithValue("@kuldesiido", uzenet.KuldesiIdo);
                cmd.Parameters.AddWithValue("@tipus", uzenet.UzenetTipus);
                cmd.Parameters.AddWithValue("@telefon", uzenet.Telefon);
                cmd.Parameters.AddWithValue("@email", uzenet.Email);

                int result = cmd.ExecuteNonQuery();
                return result > 0 ? "Sikeres módosítás" : "Hiba a módosítás során";
            }
        }

        public string Delete(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM uzenet WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int result = cmd.ExecuteNonQuery();
                return result > 0 ? "Sikeres törlés" : "Hiba a törlés során";
            }
        }
    }
}