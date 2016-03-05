using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * this class is designed for setting a connection to the database and retrieve
 * the data specific to the quary that is given.
 * 
 */
namespace DigitalSolutions___Prototype1___SB
{
    class RetrieveData
    {

        //fields
        private string connectionString;
        private MySqlConnection connection;
        private MySqlDataAdapter dbAdapter;
        private string quary;

        //constructor
        public RetrieveData(string quary)
        {
            this.quary = quary;
            connectionString = "datasource=localhost;port=3306;username=root;password=root";
            connection = new MySqlConnection(connectionString);
        }

        //retrieve method will get the specific
        //data from the given quary
        public DataSet retrieveData()
        {

            DataSet ds = new DataSet();
            dbAdapter = new MySqlDataAdapter(quary, connection);
            try
            {
                connection.Open();
                dbAdapter.Fill(ds);
            }
            catch (MySqlException mse) { }
            connection.Close();

            return ds;
        }
    }
}

