
using System;
using System.Collections.ObjectModel;

namespace Projet_BCC
{
     public class CategorieDAO
    {
        public int idCategorieDao;
        public string NomDao;

        public CategorieDAO(int id, string nom)
        {
            this.idCategorieDao = id;
            this.NomDao = nom;
        }

        public static CategorieDAO getCategorie(int idCategorie)
        {
            CategorieDAO categorie = CategorieDAL.getCategorie(idCategorie);
            return categorie;
        }

        public static void insertCategorie(CategorieDAO categorieDAO)
        {
            Console.WriteLine("DAO INSERT:"+categorieDAO.NomDao);
            CategorieDAL.insertCategorie(categorieDAO);
        }
        public static ObservableCollection<CategorieDAO> listeCategoriesDAO()
        {
            ObservableCollection<CategorieDAO> listeCategories = CategorieDAL.listCategorieDAL();
            return listeCategories;
        }
    }
}