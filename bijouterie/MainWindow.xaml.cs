using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Odbc;

namespace bijouterie
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //LaBaseserveur BDDnwsrv = new LaBaseserveur("bijouterie");
        LaBasemysql BDDnwmysql = new LaBasemysql("bijouterie");

        public MainWindow()
        {
            InitializeComponent();

            connection.Click +=
                new System.Windows.RoutedEventHandler(this.connexion);

            requete.Click +=
                new System.Windows.RoutedEventHandler(this.listedevis);
        }

        private void connexion(object sender, RoutedEventArgs e)
        {
            if (connection.Content != "Déconnecté")
            {
                BDDnwmysql.ouvrir();
                connection.Content = "Connecté";
            }
            else
            {
                BDDnwmysql.fermer();
                connection.Content = "Déconnecté";
            }
        }
        //private void listedevis(object sender, RoutedEventArgs e)
        //{
        //    string req = "SELECT * From devis;";
        //    OdbcDataReader resultat;
        //    resultat = BDDnwmysql.executerSelect(req);
        //    resultatbox.Items.Clear();

        //    while (resultat.Read())
        //    {
        //        this.resultatbox.Items.Add(resultat.GetValue(0) + " " + resultat.GetValue(1));
        //    }

        //    reqbox.Items.Add(req);
        //}

        /*private void ajouteremploye(object sender, RoutedEventArgs e)
        {
            String req = "INSERT INTO Employees (lastname, firstname) VALUES (";
            req = req + "'" + nomemploye.Text + "' ,";
            req = req + "'" + prenomemploye.Text + "')";

            OdbcDataReader resultat;
            resultat = BDDnw.executerSelect(req);

            reqbox.Items.Add(req);
        }*/

        /*private void suprimer(object sender, RoutedEventArgs e)
        {
            String req = "DELETE FROM Employees WHERE ( lastname =";
            req = req + "'" + nomemploye.Text + "' AND firstname =";
            req = req + "'" + prenomemploye.Text + "')";

            reqbox.Items.Add(req);

            OdbcDataReader resultat;
            resultat = BDDnw.executerSelect(req);
        }*/
     }
}
