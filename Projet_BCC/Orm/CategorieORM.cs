namespace Projet_BCC
{
    public class CategorieORM
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategorie"></param>
        /// <returns></returns>
        /// 
        public static CategorieView getCategorie(int idCategorie)
        {
            CategorieDAO categorieDAO = CategorieDAO.getCategorie(idCategorie);
            CategorieView categorieView = new CategorieView(categorieDAO.idCategorieDao, categorieDAO.NomDao);
            return categorieView;
        }
        public static void updateCategorie(CategorieView categorie)
        {
            CategorieDAO.updateCategorie(new CategorieDAO(categorie.idCategorieView, categorie.nomView));
        }
    }
}