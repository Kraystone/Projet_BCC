using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_BCC
{
    class CategorieProduitView
    {
        public int idProduit;
        public int idCategorie;
        public string nomCategorieView;

        public CategorieProduitView() { }

        public CategorieProduitView(int idproduit, int idcategorie) 
        {
            idProduit = idproduit;
            idCategorie = idcategorie;
        }

        public CategorieProduitView(string nom)
        {
            
            nomCategorieView = nom;
        }

        public string categorieProperty
        {
            get { return nomCategorieView; }
        }

    }
}
