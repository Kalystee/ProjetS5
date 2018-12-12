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
using Controlleur.Entity.Salle.Disposition.Personnels;
using Controlleur.Entity.Clients;
using Controlleur.Entity;
using Controlleur.Entity.Cuisine;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* PREPARATION D'UN PLAT
            
            CnxBDD bdd = new CnxBDD();
            CuisineController cuisineController = new CuisineController();
            

             try
             {
                Plat plat = new Plat();
                plat.Id = 1;
                plat.EstPret = false;
                Table table = new Table(1, 4);
                Commande commande = new Commande(table,plat);

                DataSet d = cuisineController.SelectIngredientOfPlat(commande.Plat.Id);
                
                commande.Plat = cuisineController.Cuisinier.preparerPlat(plat);
                


                foreach (DataRow data in cuisineController.SelectIngredientOfPlat(commande.Plat.Id).Tables[0].Rows)
                {
                    Console.WriteLine(data["Nom"] + "------" + data["Quantite"]);
                }

            }
             catch (Exception e)
             {
                 Console.WriteLine(e.StackTrace);
             }
             finally
             {
                 Console.Read();

             }*/



            /*  TEST SALLE
            Salle salle = new Salle(1);
            
            MaitreHotel mh =  MaitreHotel.GetInstance();
            ClientHandler ch = new ClientHandler();
            Client client = new Client("Charles", 1);

            mh.Subscribe(ch); //add mh to the liste of observer
            ch.ClientStatus(client.Name,client.NbPers); //add Client to the list of client (observable)
            salle.AssignerTable(client); //Give an available table to client
            Plat p = client.CommanderPlat();
            Console.WriteLine("I would like to eat and order this disch number : "+p.Id);

            Console.Read();
            */


            /*   TEST SOCKET
            Server.StartServer();
            ReceptionPlatClient.StartClient();
            


        }
    }
}
