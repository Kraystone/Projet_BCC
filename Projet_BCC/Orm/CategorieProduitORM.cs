using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BCC
{
    class CategorieProduitORM
    {
        public static ObservableCollection<ProduitView> getCategorieDUProduitORM(int idProduit)
        {
            ObservableCollection<CategorieProduitDAO> listeCategorieProduitORM = CategorieProduitDAO.getCategorieProduitDAO(idProduit);
            ObservableCollection<ProduitView> listeProduitViews = new ObservableCollection<ProduitView>();

            foreach(CategorieProduitDAO categorie in listeCategorieProduitORM)
            {
                ProduitView ProduitView = new ProduitView(); 
                listeProduitViews.Add(ProduitView); 
            }
            return listeProduitViews;
        }
        public static CategorieProduitView getCategorieProduit(int idCategorie, int idProduit)
        {
            CategorieProduitDAO produitCategorie = CategorieProduitDAO.getCategorieProduitDAO(idCategorie, idProduit);
            CategorieProduitView categorieProduit = new CategorieProduitView(produitCategorie.idProduitDAO, produitCategorie.idCategorieDao);
            return categorieProduit;
        }
    }
}
