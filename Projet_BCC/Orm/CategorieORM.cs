using System;
using System.Collections.ObjectModel;

namespace Projet_BCC
{
    public class CategorieORM
    {
        public static CategorieView getCategorie(int idCategorie)
        {
            CategorieDAO categorieDAO = CategorieDAO.getCategorie(idCategorie);
            CategorieView categorieView = new CategorieView(categorieDAO.idCategorieDao, categorieDAO.NomDao);
            return categorieView;
        }
        public static void insertCategorie(CategorieView c)
        {
            CategorieDAO.insertCategorie(new CategorieDAO(c.idCategorieView, c.nomView));
        }

        public static ObservableCollection<CategorieView> listeCategoriesORM()
        {
            ObservableCollection<CategorieDAO> listeDesCategoriesDAO = CategorieDAO.listeCategoriesDAO();
            ObservableCollection<CategorieView> listeDesCategoriesView = new ObservableCollection<CategorieView>();

            foreach (CategorieDAO categorie in listeDesCategoriesDAO)
            {
                CategorieView categorieView = new CategorieView(categorie.idCategorieDao, categorie.NomDao);
                listeDesCategoriesView.Add(categorieView);
            }
            return listeDesCategoriesView;
        }
    }
}