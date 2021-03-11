using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Projet_BCC
{
    public class CategorieProduitView : INotifyPropertyChanged
    {
        public int idProduit;
        public int idCategorie;
        private string nomCategorieView;

        public event PropertyChangedEventHandler PropertyChanged;

        public CategorieProduitView() { }

        public CategorieProduitView(int idproduit, int idcategorie) 
        {
            idProduit = idproduit;
            idCategorie = idcategorie;
        }

        public CategorieProduitView(string nomCategorieView)
        {
            
            this.nomCategorieView = nomCategorieView;
        }

        public string _nomCategorieView
        {
            get { return nomCategorieView; }
            set
            {
                nomCategorieView = value; OnPropertyChanged("nomCategorieView");
            }
        }

        private void OnPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }
    }
}
