using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace bijouterie
{
    class LaBaseserveur
    {

        string nomBDD;
        OdbcConnection connectionBDD = new OdbcConnection();
        OdbcCommand commande = new OdbcCommand();

        public LaBaseserveur(string nomBDD)
        {
            this.nomBDD = nomBDD;

            String chConnexion = "Driver={SQL Server};"
                   + "Server=localhost,"//192.168.177.200
                + "Database=" + nomBDD + ";"
                //+ "Database=bdd_adrien_le;"
                + "Trusted_Connection=YES;"
                + "UID=bts2;"
                + "PWD=bts2bts2;";

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

        public OdbcDataReader executerSelect(string req)
        {

            commande.CommandText = req;
            return commande.ExecuteReader();

        }

        public int executerinsert(string req)
        {

            commande.CommandText = req;
            return commande.ExecuteNonQuery();

        }
    }
}

