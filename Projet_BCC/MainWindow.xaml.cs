using System.Windows;
using System.Collections.ObjectModel;

namespace Projet_BCC
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<ProduitView> list; 
        ProduitView data;
        public MainWindow()
        {
            InitializeComponent();
            ConnectionDAL.OpenConnection();
            loadProduct();
        }
        void loadProduct()
        {
            list = ProduitORM.listesProduit();
            data = new ProduitView();
            listeEnchere.ItemsSource = list;
        }
    }
}
