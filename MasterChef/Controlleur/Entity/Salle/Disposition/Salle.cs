using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Clients;
using Controlleur.Entity.Salle.Disposition.Personnels;
using Controlleur.Entity.Salle.Personnels;

namespace Controlleur.Entity.Salle.Disposition
{
    public class Salle
    {
        private int id;
        private List<Carre> carres;
        private MaitreHotel maitreHotel;

        /// <summary>
        /// Constructor of Salle
        /// </summary>
        /// <param name="num">Id of Salle</param>
        public Salle(int num)
        {
            this.id = num;
            this.carres = new List<Carre>();
            this.maitreHotel = MaitreHotel.GetInstance();
            for(int i = 0; i < 2; i++)
            {
                this.carres.Add(new Carre(i));
            }
            
            
        }


        /// <summary>
        /// Listing of tables to get one table for Client
        /// and assigned a chefrang to the table
        /// </summary>
        /// <param name="client"></param>
        public void AssignerTable(Client client)
        {
            foreach (Carre carre in this.carres)
            {
                foreach (Rang rang in carre.Rangs)
                {
                    foreach(Table tables in rang.Tables)
                    {
                        if (client.NbPers <= tables.NbPlace && tables.EstDisponible())
                        {
                            tables.Client = client;
                            Console.WriteLine("The table number : " + tables.Id + " - For client : "+ tables.Client.Name);
                            if (carre.ChefRang.TableOccupe == null)
                            {
                                carre.ChefRang.TableOccupe = tables;
                                Console.WriteLine("Hello " + client.Name + " I am " + carre.ChefRang.Name);
                                Console.WriteLine(" Do you want to have a drink or to eat ?");
                            }
                            return;

                        }
                       
                    }
                    
                }


            }

            
        }
    }
}