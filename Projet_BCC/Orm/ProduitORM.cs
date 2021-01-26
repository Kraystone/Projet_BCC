using System.Collections.ObjectModel;

namespace Projet_BCC
{
    public class ProduitORM
    {
        public static ProduitView getProduit(int idProduit)
        {
            ProduitDAO produit = ProduitDAO.getProduit(idProduit);
            int idCategorie = produit.idCategorieDao;
            CategorieView categorieView = CategorieORM.getCategorie(idProduit);
            ProduitView produitView = new ProduitView(produit.NomDao);
            return produitView;
        }
        public static void updateProduit(ProduitView produit)
        {
            ProduitDAO.updateNomProduit(new ProduitDAO(produit.nomProduitProperty));
        }
        public static void insertProduit(ProduitView produit)
        {
            ProduitDAO.insertProduit(new ProduitDAO(produit.idProduitProperty, produit.nomProduitProperty, produit.categorieProperty, produit.prixProperty));
        }
        public static ObservableCollection<ProduitView> listesProduit()
        {
            ObservableCollection<ProduitDAO> listeDesProduits = ProduitDAO.listeProduits();
            ObservableCollection<ProduitView> viewProduit = new ObservableCollection<ProduitView>();
            foreach(ProduitDAO product in listeDesProduits) 
            {
                int idCategorie = product.idCategorieDao;
                CategorieView viewCategorie = CategorieORM.getCategorie(idCategorie);
                ProduitView produitView = new ProduitView(product.idCategorieDao, product.NomDao, product.EstimationDao, viewCategorie);
                viewProduit.Add(produitView);
            }
            return viewProduit;
        }
    }
}