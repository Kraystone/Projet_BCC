using MySql.Data.MySqlClient;

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
        public static void updateCategorie(int idCatégorie, string nom)
        {
            string query = "UPDATE catégorie set nom=\"" + nom + "\" where idCatégorie=" + idCatégorie + ";";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
    }
}
