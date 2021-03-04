using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BCC
{
    class CategorieProduitDAL
    {
        public static ObservableCollection<CategorieProduitDAO> GetCategorieProduitDAL(int idProduit)
        {
            ObservableCollection<CategorieProduitDAO> listeCategorieProduit = new ObservableCollection<CategorieProduitDAO>();
            string query = "SELECT c.Nom FROM catégorie c JOIN categorie_produit cp on c.idCatégorie=cp.idCatégorie JOIN produit p on cp.idProduit=p.idProduit WHERE p.idProduit=" + idProduit;
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            MySqlDataReader reader = null;

            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CategorieProduitDAO categorieProduit = new CategorieProduitDAO(reader.GetString(0));
                listeCategorieProduit.Add(categorieProduit);
            }
            reader.Close();
            return listeCategorieProduit;
        }
        public static CategorieProduitDAO getCategorieProduitDAL(int idCategorie, int idProduit)
        {
            string query = "SELECT * FROM categorie_produit WHERE idCatégorie = \"" + idCategorie + "\" and idProduit=" + idProduit + ";";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            CategorieProduitDAO categorieProduit = new CategorieProduitDAO(reader.GetInt32(0), reader.GetInt32(1));
            reader.Close();
            return categorieProduit;
        }
    }
}
