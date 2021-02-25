using System.ComponentModel;

namespace Projet_BCC
{
    public class CategorieView
    {
        public int idCategorieView;
        public string nomView;

        public CategorieView() { }
        public CategorieView(int id, string nom)
        {
            this.idCategorieView = id;
            this.nomView = nom;
        }

        public string nomCategorieAjoutProperty
        {
            get { return nomView; }
            set => nomView = value;
        }
        public int idCategorieProperty
        {
            get { return idCategorieView; }
            set => idCategorieView = value;
        }
    }
}
