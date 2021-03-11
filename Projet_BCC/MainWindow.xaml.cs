using System.Windows;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System;

namespace Projet_BCC
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProduitView dataProduit;
        CategorieView dataCategorie;
        CategorieProduitView datacategorieProduit;
        ObservableCollection<ProduitView> listProduit;
        ObservableCollection<CategorieView> listCategorie;
        ObservableCollection<CategorieProduitView> listCategorieProduit2;

        int index = 0;
        int selectedProduct = 0;

        public MainWindow()
        {
            InitializeComponent();
            ConnectionDAL.OpenConnection();
            loadProduct();
            loadCategorie();
            loadContexte();
            loadcategorieProduit();
        }
        void loadProduct()
        {
            listProduit = ProduitORM.listesProduit();
            dataProduit = new ProduitView();
            listeEnchere.ItemsSource = listProduit;
        }

        void loadCategorie()
        {
            listCategorie = CategorieORM.listeCategoriesORM();
            dataCategorie = new CategorieView();
        }
        void loadcategorieProduit()
        {
            listCategorieProduit2 = CategorieProduitORM.getCategorieDUProduitORM(2);
            datacategorieProduit = new CategorieProduitView();
        }
        private void ajoutProduit(object sender, RoutedEventArgs r)
        {
            //ajout d'un nouveau produit
            dataProduit.idProduitProperty = ProduitDAL.getMaxId() + 1;
            //dataProduit.categorieProperty = new CategorieView(dataProduit.idProduitProperty, dataProduit.);

            //ajout du produit dans la base
            listProduit.Add(dataProduit);
            ProduitORM.insertProduit(dataProduit);
            index = listProduit.Count();

            //creation d'un nouveau produit
            listeEnchere.Items.Refresh();
            dataProduit = new ProduitView();

            //on lit le nouveau produit aux élèments de la vue
            nomEnchereAjout.DataContext = dataProduit;
            desProduitAjout.DataContext = dataProduit;
            prixProduitAjout.DataContext = dataProduit;
            dateProduitAjout.DataContext = dataProduit;
            imgProduitAjout.DataContext = dataProduit;
            nomCategorieAjout.DataContext = dataProduit;
        }
        private void ajoutCategorie(object sender, RoutedEventArgs r)
        {
            dataCategorie.idCategorieProperty = CategorieDAL.getMaxIdCategorie() + 1;
            
            listCategorie.Add(dataCategorie);
            CategorieORM.insertCategorie(dataCategorie);
            dataCategorie = new CategorieView();

            nomCategorieAjout.DataContext = dataCategorie;
        }

        void loadContexte()
        {
            nomCategorieAjout.DataContext = dataCategorie;
        }

        private void estimationChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            //dataProduit.prixProperty = prixTB.Text;
        }
        private void listeEnchereChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((listeEnchere.SelectedIndex < listProduit.Count) && listeEnchere.SelectedIndex >= 0)
            {
                selectedProduct = listProduit.ElementAt<ProduitView>(listeEnchere.SelectedIndex).idProduitProperty;
            }
        }
        private void categorieProduit(object sender, RoutedEventArgs r)
        {
            listCategorieProduit2 = CategorieProduitORM.getCategorieDUProduitORM(Convert.ToInt32(TextboxProduit.Text));
            datacategorieProduit = new CategorieProduitView();

            listeCP.ItemsSource = listCategorieProduit2;

            listeCP.DataContext = listCategorieProduit2;

            listeCP.Items.Refresh();
        }
    }
}
