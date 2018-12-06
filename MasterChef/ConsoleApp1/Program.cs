using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CnxBDD bdd = new CnxBDD();
            try
            {
                bdd.Connex.Open();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                bdd.Connex.Close();
                
            }
        } 
    }
}
