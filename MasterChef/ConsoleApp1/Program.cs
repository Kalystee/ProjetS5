using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Cuisine.Plats;
using Controlleur.Entity.Salle;
using Controlleur.Entity.Salle.Disposition;
using Controlleur.Entity.Salle.Personnels;
using Modele;
using System.Data;
using Controlleur;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            CnxBDD bdd = new CnxBDD();
            CuisineController cuisineController = new CuisineController();
            

             try
             {
                Plat plat = new Plat();
                plat.Id = 1;
                plat.EstPret = false;
                Table table = new Table(1, 4);
                Commande commande = new Commande(table,plat);
                commande.Plat = cuisineController.Cuisinier.preparerPlat(plat);

             }
             catch (Exception e)
             {
                 Console.WriteLine(e.StackTrace);
             }
             finally
             {
                 Console.Read();
             }
        }
    }
}
