   M S B A M L   `   `   `  ���� E  AProjet_BCC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Projet_BCC
Projet_BCC      Projet_BCC.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:Projet_BCC       � Title$  BitCardCoin��$	��550��$	��800��.���� .+��� .@��� $��Page de Garde��.���  � ColumnDefinitions �� $
��138* ��� $
��239* �.+��� $��Images/logoBCC.png��$��450,144,450,1704q�$��2���� -    ��Name$ descritpion��$��45,772,45,1388q�$
��Wrap=�$��2��$��18(��� $}�wConsultez les annonces de ventes classées par catégories ou recherchez par mot-clé un artiste, un style ou un objet.���� �� $M�GNotre moteur de recherche permet de filtrer selon plusieurs critères :���� �� �� $�- Les régions,���� �� $�- Date de vente,���� �� $�- Estimation���� �� �� $���Et pour ne rien rater des ventes, BidCardCoin vous propose un service gratuit d'alertes par e-mail qui se déclenchent par mots-clés et vous informe automatiquement dès que le lot convoité est proposé aux enchères.���� $��Ajouter un produit��.���� -    ��Name$ 
panelAjout��$��0,0,0,45q�.+��� $��20q�$��30(�$��Center=�$��Center=�$��Ajouter un produit���� $
��Wrap=�$��Nom du produit��$��150,0,150,0q��� -   $��nomEnchereAjout��$��23�� �� TextWrapping$
 Wrap=�$��150,0,150,0q����� *NomProduitProperty+�� $
��Wrap=�$��Descritpion du produit��$��150,10,150,0q��� -    ��Name$ desProduitAjout��$��23��$
 Wrap=�$��150,0,150,0q����� *DescriptionProduitProperty+�� $��150,10,150,0q�$��Image du produit��$
��Wrap=��� -   $ imgProduitAjout��$��23��$
 Wrap=�$��150,0,150,0q����� *ImgProduitProperty+�� $
��Wrap=�$��Prix du produit��$��150,10,150,0q��� -   $ prixProduitAjout��$��150,0q����� *PrixProduitProperty+�� $
��Wrap=�$��Catégorie du produit��$��150,10,150,0q��� $��150,0q�.@��� ���� *nomCategorieAffichageProperty+�� $
��Wrap=�$��Ajouter une categorie��$��150,10,150,0q��� -   $ nomCategorieAjout��$��23��$
 Wrap=�$��150,0,400,0q����� *nomCategorieAjoutProperty+�� -   $��150,10,400,10q� J� RenderTransformOrigin$ 0.5,0.5&�$��Ajouter la categorie���� -	   $��150,10,150,10q�$ 0.5,0.5&�$��Ajouter le produit���� $"��Créer une enchère en ligne��.���� $	��372��.+��� $��30(�$��Center=�$��20q�$��Créer une enchère���� $
��Wrap=�$��Nom de l'enchère��$��150,0,150,0q��� -
   $ nomEnchereTB��$��23��$
 Wrap=�$��150,0,150,0q����� *NomEnchereProperty+ �� Mode$ OneWay=��� $
��Wrap=�$��Date de l'enchère��$��150,10,150,0q�(  "System.Windows.Controls.DatePicker  -     Name$ dateProduitAjout��$��25��$
��Left=�$��	150,0,0,0q�$	��Top=�$	��156���� $
��Wrap=�$��Lieux de l'enchère��$��150,10,150,0q��� -   $ lieuxEnchereTB��$��23��$
 Wrap=�$��150,0,150,0q����� *LieuxEnchereProperty+$ OneWay=��� $
��Wrap=�$��Categorie de l'enchère��$��150,10,150,0q��� $��150,0q�.@��� $��Catégorie 1���� $��Catégorie 2���� $��150,10,150,10q�$��Ajouter le produit���� $��Listes des enchères��.���� .+��� $��10q�$��30(�$��Center=�$��Center=�$��Listes des enchères��� $��Center=�.+�&   System.Windows.Controls.DataGrid  -   	  Name$	 listeEnchere��
   AutoGenerateColumns
 .  
���   �
�������$	��300����. $
��Auto=�$
��Auto=�$	��Top=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Numéro��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *idProduitProperty+$ OneWay=�  $ Nom du produit�� �� *nomProduitProperty+$ OneWay=�  -   descriptionProduit��$ Description du produit�� �� *descriptionProduitProperty+$ TwoWay=�  $ Categorie du produit�� �� * categorieProperty.libCategorie+$ OneWay=�  $ 
Estimation�� �� *prixProperty+$ OneWay=�  $ Choix�� �� *choixProperty+$ OneWay=��� $��Listes des dépots��.���� .+��� $��4q�$��30(�$��Center=�$��Center=�$��Listes des dépots��� $��Center=�.+�  
 .  
���   �
�������$	��300����. $
��Auto=�$
��Auto=�   $ ID du depot�� �� *idDepotProperty+$ OneWay=�  $ Vendue�� �� *vendueDepotProperty+$ OneWay=�  $ 
Non vendue�� �� *nonVendueDepotProperty+$ OneWay=��� $'��!Listes des demandes d'estimations��.���� .+��� $��5q�$��30(�$��Center=�$��Center=�$'��!Listes des demandes d'estimations��� $��Center=�.+�  
 .  
���   �
�������$	��300����. $
��Auto=�$
��Auto=�   $
 Date�� �� *dateEstimationProperty+$ TwoWay=�  $	 Nom�� �� *nomClientEstimationProperty+$ TwoWay=�  $ Adresse�� �� *adresseEstimationProperty+$ TwoWay=�  $ 	Telephone�� �� *telephoneEstimationProperty+$ TwoWay=�  $ Description de l'objet�� �� *%#desscriptionObjetEstimationProperty+$ TwoWay=�  $ Choix�� �� *choixEstimationProperty+$ TwoWay=��� $��Archives des ventes��.���� .+��� $��30(�$��Center=�$��Center=�$��Archives��� $��Center=�.+�  
 .  
���   �
�������$	��300����. $
��Auto=�$
��Auto=�   $ Produit�� �� *produitArchiveProperty+$ OneWay=�  $ Mode de paiement�� �� *paiementArchiveProperty+$ OneWay=�  $ Acheteur�� �� *acheteurArchiveProperty+$ OneWay=�  $ Vendeur�� �� *vendeurEstimationProperty+$ OneWay=�