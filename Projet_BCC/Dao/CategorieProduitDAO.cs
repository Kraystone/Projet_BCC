using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BCC
{
    class CategorieProduitDAO
    {
        public int idCategorieDao;
        public string NomCategorieDao;
        public int idProduitDAO;
        public CategorieProduitDAO(int idProduit)
        {
            this.idProduitDAO = idProduit;
        }
        public CategorieProduitDAO(string nom)
        {
            this.NomCategorieDao = nom;
        }
        public CategorieProduitDAO(int idProduit, int idCategorie)
        {
            this.idProduitDAO = idProduit;
            this.idCategorieDao = idCategorie;
        }

        public static ObservableCollection<CategorieProduitDAO> getCategorieProduitDAO(int idProduit)
        {
            ObservableCollection<CategorieProduitDAO> listeCategorieProduit = CategorieProduitDAL.GetCategorieProduitDAL(idProduit);
            return listeCategorieProduit;
        }
        public static CategorieProduitDAO getCategorieProduitDAO(int idCategorie, int idProduit)
        {
            CategorieProduitDAO produit = CategorieProduitDAL.getCategorieProduitDAL(idCategorie, idProduit);
            return produit;
        }
    }
}
