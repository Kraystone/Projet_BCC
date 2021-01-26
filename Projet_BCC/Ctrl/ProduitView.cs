namespace Projet_BCC
{
    public class ProduitView
    {
        private string NomView;
        private string DescriptionView;
        private int EstimationView;
        private CategorieView CategorieProduitView;

        public ProduitView() { }


        public ProduitView(int id, string nom, int estimation, CategorieView categorie)
        { 
            this.nomProduitProperty = nom;
            this.idProduitProperty = id;
            this.prixProperty = estimation;
            this.CategorieProduitView = categorie;
        }
        public ProduitView(string nom)
        {
            this.NomView = nom;
        }

        public string nomProduitProperty
        {
            get { return NomView; }
            set => NomView = value.ToUpper();
        }
        public string descriptionProduitProperty
        {
            get { return DescriptionView; }
            set => DescriptionView = value;
        }
        public int idProduitProperty { get; set; }
        public int prixProperty 
        {
            get { return EstimationView; }
            set => EstimationView = value; 
        }
        public int categorieProperty
        {
            get { return EstimationView; }
            set => EstimationView = value; 
        }
    }
}
