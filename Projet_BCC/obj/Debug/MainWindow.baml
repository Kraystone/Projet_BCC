   M S B A M L   `   `   `  ����E  AProjet_BCC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Projet_BCC
Projet_BCC  5   	       Projet_BCC.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Projet_BCC     5   	     � Title$  BitCardCoin��5   	   $	��550��6   $	��800��6*   .��5	      �� .+�5
   
   �� .@�5      �� $��Page de Garde��6   .��5      �  � ColumnDefinitions 5      �� 5      $
��138* �6+   �� 5      $
��239* �6+   .+�5      �� $��Images/logoBCC.png��6   $��450,144,450,1704q�68   $��2��6S   �� 5      -   5         ��Name$ descritpion��5       $��45,772,45,1388q�66   $
��Wrap=�6N   $��2��6b   $��18(�6v   �� 6�   $}�wConsultez les annonces de ventes classées par catégories ou recherchez par mot-clé un artiste, un style ou un objet.��6�   �� 6  �� 6  $M�GNotre moteur de recherche permet de filtrer selon plusieurs critères :��6  �� 6h  �� 6u  �� 6�  $�- Les régions,��6�  �� 6�  �� 6�  $�- Date de vente,��6�  �� 6�  �� 6�  $�- Estimation��6�  �� 6�  �� 6�  �� 6
  $���Et pour ne rien rater des ventes, BidCardCoin vous propose un service gratuit d'alertes par e-mail qui se déclenchent par mots-clés et vous informe automatiquement dès que le lot convoité est proposé aux enchères.��6  6�  5      5      �� 5      $��Ajouter un produit��6   .��5      �� -   5         ��Name$ 
panelAjout��5      $��0,0,0,45q�61   .+�5      �� $��20q�6   $��30(�6(   $��Center=�66   $��Center=�6Q   $��Ajouter un produit��6n   �� 5      $
��Wrap=�6    $��Nom du produit��64   $��150,0,150,0q�6J   �� 5      -   5        $��nomEnchereAjout��5      $��23��65    �� TextWrapping$
 Wrap=�6A   $��150,0,150,0q�6y   ��6U   �� *NomProduitProperty+6y   �� 5      $
��Wrap=�6    $��Descritpion du produit��64   $��150,10,150,0q�6R   �� 5      -   5         ��Name$ desProduitAjout��5      $��23��67   $
 Wrap=�6C   $��150,0,150,0q�6�   ��6W   �� *DescriptionProduitProperty+6�   �� 5      $��150,10,150,0q�6    $��Image du produit��66   $
��Wrap=�6N   �� 5      -   5        $ imgProduitAjout��5      $��23��67   $
 Wrap=�6C   $��150,0,150,0q�6{   ��6W   �� *ImgProduitProperty+6{   �� 5      $
��Wrap=�6    $��Prix du produit��64   $��150,10,150,0q�6K   �� 5      -   5        $ prixProduitAjout��5      $��150,0q�6^   ��69   �� *PrixProduitProperty+6^   �� 5       $
��Wrap=�6    $��Catégorie du produit��64   $��150,10,150,0q�6P   �� 5!      $��150,0q�6   .@�5"      �� ��6'   �� *nomCategorieAffichageProperty+5#      �� 5$      $
��Wrap=�6    $��Ajouter une categorie��64   $��150,10,150,0q�6Q   �� 5%      -   5        $��nomCategorieAjout��5%      $��23��67   $
 Wrap=�6C   $��150,0,400,0q�6W   ��6l   �� *nomCategorieAjoutProperty+�� 5&      -   5        $��150,10,400,10q�5&       J� RenderTransformOrigin$ 0.5,0.5&�64   $��Ajouter la categorie��6T   6s   �� 5'      -	   5        $��150,10,150,10q�5'      $ 0.5,0.5&�64   $��Ajouter le produit��6T   6q   5(      5)      �� 5*      $"��Créer une enchère en ligne��6   .��5+      �� $	��372��6   .+�5,      �� $��30(�6   $��Center=�6*   $��20q�6G   $��Créer une enchère��6S   �� 5-      $
��Wrap=�6    $��Nom de l'enchère��64   $��150,0,150,0q�6L   �� 5.      -
   5        $ nomEnchereTB��5.      $��23��64   $
 Wrap=�6@   $��150,0,150,0q�6�   ��6T   �� *NomEnchereProperty+ �� Mode$ OneWay=�6�   �� 5/      $
��Wrap=�6    $��Date de l'enchère��64   $��150,10,150,0q�6M   (  "System.Windows.Controls.DatePicker  50      -   5          Name$ dateProduitAjout��50   [   $��25��6!   $
��Left=�6-   $��	150,0,0,0q�6H   $	��Top=�6u   $	��156��6�   �� 51      $
��Wrap=�6    $��Lieux de l'enchère��64   $��150,10,150,0q�6N   �� 52      -   5        $ lieuxEnchereTB��52      $��23��66   $
 Wrap=�6B   $��150,0,150,0q�6�   ��6V   �� *LieuxEnchereProperty+$ OneWay=�6�   �� 53      $
��Wrap=�6    $��Categorie de l'enchère��64   $��150,10,150,0q�6R   �� 54      $��150,0q�6   .@�55      �� $��Catégorie 1��6'   �� 56      $��Catégorie 2��6'   57      �� 58      $��150,10,150,10q�6   $��Ajouter le produit��64   59      5:      �� 5;      $��Listes des enchères��6   .��5<      �� .+�5=      �� $��10q�6   $��30(�6(   $��Center=�66   $��Center=�6Q   $��Listes des enchères��6n   � 5>      $��Center=�6   .+�5?      &   System.Windows.Controls.DataGrid  -   5        $��listeEnchere��5?   P  	   AutoGenerateColumns	 .  
���   �
�������$	��300��6�   ��. $
��Auto=�6�   $
��Auto=�6  $	��Top=�68  ��6J   �� 
   Columns
 5@      0  *System.Windows.Controls.DataGridTextColumn  5A   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Numéro��65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *idProduitProperty+$ OneWay=�  5B   "   $ Nom du produit��65    6M   �� *nomProduitProperty+$ OneWay=�  5C   "   -   5        descriptionProduit��$ Description du produit��5C   Q    6q   �� *descriptionProduitProperty+$ TwoWay=�  5D   "   -   5        
prixTB��$ 
Estimation��5D   E    6Y   �� *prixProperty+$ TwoWay=�5F      �� 5G      -   5        $ TextboxProduit��5G   "   $��23��6:   $
 Wrap=�6F   $��513,60,-135,218q�6Z   �� 5H      -   5        $��466,-62,-116,320q�5H   !   $ 0.5,0.5&�6;   $$��Voir les catégorie du produit��6[   ��6�   �� *categorieProduit+� 5I      $	��120��6   $��Right=�6,   $��Center=�6H   $��0,90,104,90q�6c   .+�5J        -   5          Name$ listeCP��5J   '   	 .  $��Center=�6l   
���   ����	#FFA4A4A4��. $
��Auto=�5M      $
��Auto=�5N      $	��123��5O      $��Center=�5P      $��409,-6,-232,-22q�68   $	��148��6Q   ��5J   8   �� 
 5Q   "     5R   &      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 69   $	 Nom��6C    6P   �� *_nomCategorieView+$ OneWay=�5T      5U      5V      5W      5X      �� 5Y      $��Listes des dépots��6   .��5Z      �� .+�5[      �� $��4q�6   $��30(�6'   $��Center=�65   $��Center=�6P   $��Listes des dépots��6m   � 5\      $��Center=�6   .+�5]        	 .  
���   �
�������$	��300��6e   ��. $
��Auto=�6�   $
��Auto=�6�   
 5^        5_   "   $ ID du depot��65    6J   �� *idDepotProperty+$ OneWay=�  5`   "   $ Vendue��65    6E   �� *vendueDepotProperty+$ OneWay=�  5a   "   $ 
Non vendue��65    6I   �� *nonVendueDepotProperty+$ OneWay=�5c      5d      5e      5f      �� 5g      $'��!Listes des demandes d'estimations��6   .��5h      �� .+�5i      �� $��5q�6   $��30(�6'   $��Center=�65   $��Center=�6P   $'��!Listes des demandes d'estimations��6m   � 5j      $��Center=�6   .+�5k        	 .  
���   �
�������$	��300��6e   ��. $
��Auto=�6�   $
��Auto=�6�   
 5l        5m   "   $
 Date��65    6C   �� *dateEstimationProperty+$ TwoWay=�  5n   "   $	 Nom��65    6B   �� *nomClientEstimationProperty+$ TwoWay=�  5o   "   $ Adresse��65    6F   �� *adresseEstimationProperty+$ TwoWay=�  5p   "   $ 	Telephone��65    6H   �� *telephoneEstimationProperty+$ TwoWay=�  5q   "   $ Description de l'objet��65    6U   �� *$"descriptionObjetEstimationProperty+$ TwoWay=�  5r   "   $ Choix��65    6D   �� *choixEstimationProperty+$ TwoWay=�5t      5u      5v      5w      �� 5x      $��Archives des ventes��6   .��5y      �� .+�5z      �� $��30(�6   $��Center=�6*   $��Center=�6E   $��Archives��6b   � 5{      $��Center=�6   .+�5|        	 .  
���   �
�������$	��300��6e   ��. $
��Auto=�6�   $
��Auto=�6�   
 5}        5~   "   $ Produit��65    6F   �� *produitArchiveProperty+$ OneWay=�  5   "   $ Mode de paiement��65    6O   �� *paiementArchiveProperty+$ OneWay=�  5�   "   $ Acheteur��65    6G   �� *acheteurArchiveProperty+$ OneWay=�  5�   "   $ Vendeur��65    6F   �� *vendeurEstimationProperty+$ OneWay=�5�      5�      5�      5�      5�      5�      5�      