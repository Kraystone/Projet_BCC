
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
        public static void updateCategorie(CategorieDAO categorieDAO)
        {
            CategorieDAL.updateCategorie(categorieDAO.idCategorieDao, categorieDAO.NomDao);
        }
    }
}