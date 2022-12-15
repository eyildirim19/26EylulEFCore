﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet2
{
    public class ShippersOperation
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public ShippersOperation()
        {
            cnn = new SqlConnection(@"Server=.\MSSQL2019; Database=Northwind; uid=sa;pwd=123");
        }
        public List<Shippers> ShipList()
        {
            List<Shippers> shipList = new List<Shippers>();
            cmd = new SqlCommand("select * from Shippers", cnn);

            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Shippers shippers = new Shippers();
                //shippers.ShipperId = rdr.GetInt32(0); // 0. kolonu shipperId'ye set et..
                //shippers.ShipperId = (int)rdr[0];
                shippers.ShipperId = (int)rdr["ShipperID"];
                shippers.CompanyName = (string)rdr["CompanyName"];
                shippers.Phone = (string)rdr["Phone"];
                shipList.Add(shippers); // listeye nesneyi ekliyoruz...
            }
            cnn.Close();
            return shipList;
        }
        //public int Add(string CompanyName,string Phone)
        public int Add(Shippers ship)
        {
            cmd = new SqlCommand("insert Shippers (CompanyName,Phone) values (@CompanyName,@Phone)", cnn);
            cmd.Parameters.AddWithValue("@CompanyName", ship.CompanyName);
            cmd.Parameters.AddWithValue("@Phone", ship.Phone);

            cnn.Open();
            int returnVal = cmd.ExecuteNonQuery();
            cnn.Close();

            return returnVal;
        }
    }

    // ExecuteReader => sql ifadesinden tablo döndürür
    // ExecuteNonQuery => sql ifadesinden etkilenen satır sayısını döndürür (insert,update,delete)
    // ExecuteScalar => sql ifadesinden function değeri döndürür... 
}
