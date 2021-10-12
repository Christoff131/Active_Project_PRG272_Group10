using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace First_Form_Login
{
    class DataHandler
    {

        public DataHandler() { }

        string conn = "Server=(Local); Initial Catalog=BelgiumCampus; Integrated Security=SSPI";

        public DataSet displayStudentInformation()
        {
            //Set the SQL query to run
            string query = @"SELECT * FROM StudentInformation";

            //Creating the SQLDataAdapter Object, and passing its query and connection Strings
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            //Create DataSet object
            DataSet ds = new DataSet();

            da.Fill(ds);        //Fill DataSet object with data fetched by SQLDataAdapter
            return ds;

        }

        public DataSet displayModuleInformation()
        {
            //Set the SQL query to run
            string query = @"SELECT * FROM Module";

            //Creating the SQLDataAdapter Object, and passing its query and connection Strings
            SqlDataAdapter da2 = new SqlDataAdapter(query, conn);

            //Create DataSet object
            DataSet ds2 = new DataSet();

            da2.Fill(ds2);        //Fill DataSet object with data fetched by SQLDataAdapter
            return ds2;
        }

    

        

    }
}
