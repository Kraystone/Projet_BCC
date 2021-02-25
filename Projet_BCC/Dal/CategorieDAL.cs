using MySql.Data.MySqlClient;
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace Projet_BCC
{
    public class CategorieDAL
    {
        public static CategorieDAO getCategorie(int idCategorie)
        {
            string query = "SELECT * FROM catégorie WHERE idCatégorie=" + idCategorie + ";";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            CategorieDAO categorie = new CategorieDAO(reader.GetInt32(0), reader.GetString(1));
            reader.Close();
            return categorie;
        }
        
        public static void insertCategorie(CategorieDAO c)
        {
            int id = getMaxIdCategorie() + 1;
            string query = "INSERT INTO catégorie VALUES (\"" + id + "\",\"" + c.NomDao + "\");";
            MySqlCommand cmd2 = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd2);
            cmd2.ExecuteNonQuery();
        }
        public static int getMaxIdCategorie()
        {
            int maxIdCategorie = 0;
            string query = "SELECT MAX(idCatégorie) FROM catégorie;";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            int cnt = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    maxIdCategorie = reader.GetInt32(0);
                }
                else
                {
                    maxIdCategorie = 0;
                }
            }
            reader.Close();
            //Console.WriteLine("MAX:"+maxIdCategorie);
            return maxIdCategorie;
        }

        public static ObservableCollection<CategorieDAO> listCategorieDAL()
        {
            ObservableCollection<CategorieDAO> listeCategorie = new ObservableCollection<CategorieDAO>();
            string query = "SELECT * from catégorie;";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            MySqlDataReader reader = null;

            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CategorieDAO categorie = new CategorieDAO(reader.GetInt32(0), reader.GetString(1));
                listeCategorie.Add(categorie);
            }
            reader.Close();
            return listeCategorie;
        }

        
     
        
    }
}
