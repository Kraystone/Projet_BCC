using System.Windows;
using System.Collections.ObjectModel;
using System.Linq;

namespace Projet_BCC
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<ProduitView> listProduit;
        ProduitView data;
        int index = 0;
        public MainWindow()
        {
            InitializeComponent();
            ConnectionDAL.OpenConnection();
            loadProduct();
        }
        void loadProduct()
        {
            listProduit = ProduitORM.listesProduit();
            data = new ProduitView();
            listeEnchere.ItemsSource = listProduit;
        }
        private void ajoutProduit(object sender, RoutedEventArgs r)
        {
            //ajout d'un nouveau produit
            data.idProduitProperty = ProduitDAL.getMaxId() + 1;
            data.categorieProperty = new CategorieView(99, "Ajout");

            //ajout du produit das la base
            listProduit.Add(data);
            ProduitORM.insertProduit(data);
            index = listProduit.Count();

            //creation d'un nouveau produit
            listeEnchere.Items.Refresh();
            data = new ProduitView();

            //on lit le nouveau produit aux élèments de la vue
            //nomTextBox.DataContext = myDataObject;
            nomEnchereAjout.DataContext = data;
            desProduitAjout.DataContext = data;
            prixProduitAjout.DataContext = data;
            dateProduitAjout.DataContext = data;
        }
    }
}
