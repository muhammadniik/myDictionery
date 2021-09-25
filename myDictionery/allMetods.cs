using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace myDictionery
{
    class allMetods
    {
        SqlCommand command = new SqlCommand();

        SqlDataAdapter adaptor = new SqlDataAdapter();
        SqlConnection connection = new SqlConnection();

        public allMetods()
        {

        }




        public void upDate(string EnglishWord, string iraniWord, string connectionString, string mainDataTabl)
        {
            connection.ConnectionString = connectionString;
            connection.Open();
            command.Connection = connection;
            command.CommandText = "UPDATE " + mainDataTabl + " set persan = @p1 WHERE EnglishWord = @p2 ";

            command.Parameters.AddWithValue("@p1", iraniWord);
            command.Parameters.AddWithValue("@p2", EnglishWord);
            command.ExecuteNonQuery();
            connection.Close();

            //            UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE


        }
        public void fillGrid(string connectionString, string mainDataTabl, DataSet dataset, string nameNewDataTabl, string vlue, string columnName)
        {


            connection.ConnectionString = connectionString;
            command.CommandText = "select * from " + mainDataTabl + " where " + columnName + " Like N'%" + vlue + "%'";
            command.Connection = connection;
            adaptor.SelectCommand = command;

            adaptor.Fill(dataset, nameNewDataTabl);

        }



    }
}
