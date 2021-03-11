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
        public static ObservableCollection<CategorieProduitView> getCategorieDUProduitORM(int idProduit)
        {
            ObservableCollection<CategorieProduitDAO> listeCategorieProduitORM = CategorieProduitDAO.getCategorieProduitDAO(idProduit);
            ObservableCollection<CategorieProduitView> listeCategorieProduitViews = new ObservableCollection<CategorieProduitView>();

            foreach(CategorieProduitDAO categorie in listeCategorieProduitORM)
            {
                CategorieProduitView categorieProduitView = new CategorieProduitView(categorie.NomCategorie);
                listeCategorieProduitViews.Add(categorieProduitView); 
            }
            return listeCategorieProduitViews;
        }
        public static CategorieProduitView getCategorieProduit(int idCategorie, int idProduit)
        {
            CategorieProduitDAO produitCategorie = CategorieProduitDAO.getCategorieProduitDAO(idCategorie, idProduit);
            CategorieProduitView categorieProduit = new CategorieProduitView(produitCategorie.idProduitDAO, produitCategorie.idCategorieDao);
            return categorieProduit;
        }
    }
}
