using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace bijouterie
{
    class LaBasemysql
    {
        string nomBDD;
        MySqlConnection connectionBDD = new MySqlConnection();
        MySqlCommand commande = new MySqlCommand();

        public LaBasemysql(string nomBDD)
        {
            this.nomBDD = nomBDD;

            String chConnexion = "Server=127.0.0.1; Database=bijouterie; UID=root; PASSWORD=";
                              
                                
                                //"Driver={MySQL ODBC 5.2 Driver};"
                                
            
            connectionBDD.ConnectionString = chConnexion;
            commande.Connection = connectionBDD;
        }

        public bool ouvrir()
        {
            if (connectionBDD.State != System.Data.ConnectionState.Open)
            {
                connectionBDD.Open();
            }
            if (connectionBDD.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool fermer()
        {
            connectionBDD.Close();
            {
                if (connectionBDD.State == System.Data.ConnectionState.Closed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //public OdbcDataReader executerSelect(string req)
        //{

        //    commande.CommandText = req;
        //    return commande.ExecuteReader();

        //}

        //public int executerinsert(string req)
        //{

        //    commande.CommandText = req;
        //    return commande.ExecuteNonQuery();

        //}

        //internal OdbcDataReader executerSelect(string req)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
