using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modele
{
    public class CnxBDD
    {
        public string ChaineConnection { get; set; }
        public SqlConnection Connex { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataAdapter Adapter { get; set; }
        public DataSet DataSet { get; set; }

        public CnxBDD()
        {
            this.ChaineConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\MasterChef.mdf;Integrated Security=True;Connect Timeout=30";
            this.Connex = new SqlConnection(this.ChaineConnection);
            this.Command = new SqlCommand("", this.Connex);
            this.Adapter = new SqlDataAdapter();
            this.DataSet = new DataSet();
        }

        /// <summary>
        ///  Execute a prepared query (INSERT, UPDATE, DELETE)
        /// </summary>
        /// <param name="query">query string</param>
        public void ActionRow(string query)
        {
            this.Connex.Open();
            this.Command.CommandText = query;
            this.Command.Prepare();
            this.Command.ExecuteNonQuery();
            this.Connex.Close();

        }

        /// <summary>
        /// Execute a prepared query and get a Dataset of the query (SELECT)
        /// </summary>
        /// <param name="query">>query string</param>
        /// <param name="TableName">table target</param>
        /// <returns></returns>
        public DataSet GetRows(string query, string TableName)
        {
            this.Connex.Open();
            this.Command.CommandText = query;
            this.Command.Prepare();
            this.Adapter.TableMappings.Add("Table", TableName);
            this.DataSet.DataSetName = TableName;
            this.Adapter.Fill(this.DataSet);
            this.Connex.Close();
            return this.DataSet;
        }

    }
}
