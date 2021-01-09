using System.Collections.ObjectModel;

namespace Projet_BCC
{
    public class ProduitDAO
    {
        public int idProduitDao;
        public string NomDao;
        public string DescriptionDao;
        public int EstimationDao;
        public int idCategorieDao;

        public ProduitDAO(int id, string nom, string description, int estimation, int idCategorie)
        {
            this.idProduitDao = id;
            this.NomDao = nom;
            this.DescriptionDao = description;
            this.EstimationDao = estimation;
            this.idCategorieDao = idCategorie;
        }
        public ProduitDAO(int id, string nom, string description, int estimation)
        {
            this.idProduitDao = id;
            this.NomDao = nom;
            this.DescriptionDao = description;
            this.EstimationDao = estimation;
        }
        public ProduitDAO(string nom)
        {
            this.NomDao = nom;
        }
        public static ProduitDAO getProduit(int idProduit)
        {
            ProduitDAO produit = ProduitDAL.getProduit(idProduit);
            return produit;
        }
        public static void updateNomProduit(ProduitDAO produit)
        {
            ProduitDAL.updateNomProduit(produit);
        }
        public static void insertProduit(ProduitDAO produit)
        {
            ProduitDAL.insertProduit(produit);
        }
        public static ObservableCollection<ProduitDAO> listeProduits()
        {
            ObservableCollection<ProduitDAO> liste = ProduitDAL.selectProduit();
            return liste;
        }
    }
}