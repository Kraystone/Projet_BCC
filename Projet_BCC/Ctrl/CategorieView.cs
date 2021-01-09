using System.ComponentModel;

namespace Projet_BCC
{
    public class CategorieView : INotifyPropertyChanged
    {
        public int idCategorieView;
        public string nomView;
        public CategorieView(int id, string nom)
        {
            this.idCategorieView = id;
            this.nomView = nom;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
                CategorieORM.updateCategorie(this);
            }
        }
    }
}
