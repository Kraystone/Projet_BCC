﻿using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System;
using System.Data;
using System.Windows;

namespace Projet_BCC
{
    class ProduitDAL
    { 
        public ProduitDAL() { }

        public static ProduitDAO getProduit(int idProduit)
        {
            string query = "SELECT * FROM produit WHERE idProduit="+ idProduit+ ";";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ProduitDAO produit = new  ProduitDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
            reader.Close();
            return produit;
        }
        public static void updatePrixProduit(ProduitDAO produit)
        {
            string query = "UPDATE produit set Estimation=\"" + produit.EstimationDao + ";";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static void insertProduit(ProduitDAO produit)
        {
            int id = getMaxId() + 1;
            String query = "INSERT INTO produit VALUES (\"" + id + produit.NomDao + "\",\"" + produit.DescriptionDao + "\",\"" + produit.EstimationDao + "\",\"" + produit.idCategorieDao + "\");";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }
        public static int getMaxId()
        {
            int idMax = 0;
            string query = "SELECT MAX(idProduit) FROM produit;";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());

            int content = cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable table = reader.GetSchemaTable();

            if (reader.HasRows)
            {
                reader.Read();
                if (!reader.IsDBNull(0))
                {
                    idMax = reader.GetInt32(0);
                }
                else
                {
                    idMax = 0;
                }
            }
            reader.Close();
            return idMax;
        }
        public static ObservableCollection<ProduitDAO> listProduitDAL()
        {
            ObservableCollection<ProduitDAO> liste = new ObservableCollection<ProduitDAO>();
            string query = "SELECT * from produit;";
            MySqlCommand cmd = new MySqlCommand(query, ConnectionDAL.OpenConnection());
            MySqlDataReader reader = null;

           cmd.ExecuteNonQuery();
           reader = cmd.ExecuteReader();

           while (reader.Read())
           {
               ProduitDAO product = new ProduitDAO(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
               liste.Add(product);
           }
            reader.Close();
            return liste;
        }
    }
}