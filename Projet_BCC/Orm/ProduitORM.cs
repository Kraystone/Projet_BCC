using System.Collections.ObjectModel;

namespace Projet_BCC
{
    public class ProduitORM
    {
        public static ProduitView getProduit(int idProduit)
        {
            ProduitDAO produit = ProduitDAO.getProduit(idProduit);
            int idCategorie = produit.idCategorieDao;
            CategorieView categorieView = CategorieORM.getCategorie(idCategorie);
            ProduitView produitView = new ProduitView(produit.idProduitDao, produit.NomDao, produit.DescriptionDao, produit.EstimationDao, categorieView);
            return produitView;
        }
        public static void updateProduit(ProduitView produit)
        {
            ProduitDAO.updatePrixProduit(new ProduitDAO(produit.idProduitProperty, produit.nomProduitProperty, produit.descriptionProduitProperty, produit.prixProperty, produit.categorieProperty.idCategorieView));
        }
        public static void insertProduit(ProduitView produit)
        {
            ProduitDAO.insertProduit(new ProduitDAO(produit.idProduitProperty, produit.nomProduitProperty, produit.descriptionProduitProperty, produit.prixProperty, produit.categorieProperty.idCategorieView));
        }
        public static ObservableCollection<ProduitView> listesProduit()
        {
            ObservableCollection<ProduitDAO> listeDesProduits = ProduitDAO.listeProduits();
            ObservableCollection<ProduitView> viewProduit = new ObservableCollection<ProduitView>();
            foreach(ProduitDAO product in listeDesProduits)
            {
                int idCategorie = product.idCategorieDao;
                CategorieView viewCategorie = CategorieORM.getCategorie(idCategorie);
                ProduitView produitView = new ProduitView(product.idProduitDao, product.NomDao, product.DescriptionDao, product.EstimationDao, viewCategorie);
                viewProduit.Add(produitView);
            }
            return viewProduit;
        }
    }
}