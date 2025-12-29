using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectricityMiniProject
{

    public class ElectricityBoard
    {
        public void CalculateBill(ElectricityBill eb)
        {
            int u = eb.UnitsConsumed;
            double bill = 0;

            if (u > 100)
            {
                bill += Math.Min(u - 100, 200) * 1.5;
                u -= 200;
            }
            if (u > 300)
            {
                bill += Math.Min(u - 300, 300) * 3.5;
                u -= 300;
            }
            if (u > 600)
            {
                bill += Math.Min(u - 600, 400) * 5.5;
                u -= 400;
            }
            if (u > 1000)
            {
                bill += (u - 1000) * 7.5;
            }

            eb.BillAmount = bill;
        }

        public void AddBill(ElectricityBill eb)
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ElectricityBillDB;server=(localdb)\\MSSQLLocalDB");

            {
                string q = "Insert Into ElectricityBill Values (@cno,@cname,@units,@bill)";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@cno", eb.ConsumerNumber);
                cmd.Parameters.AddWithValue("@cname", eb.ConsumerName);
                cmd.Parameters.AddWithValue("@units", eb.UnitsConsumed);
                cmd.Parameters.AddWithValue("@bill", eb.BillAmount);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<ElectricityBill> Generate_N_BillDetails(int n)
        {
            List<ElectricityBill> list = new List<ElectricityBill>();

            using (SqlConnection con = DBHandler.GetConnection())
            {
                string q = "Select Top (@n) * From ElectricityBill Order By consumer_number Desc";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@n", n);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new ElectricityBill
                    {
                        ConsumerNumber = dr["consumer_number"].ToString(),
                        ConsumerName = dr["consumer_name"].ToString(),
                        UnitsConsumed = Convert.ToInt32(dr["units_consumed"]),
                        BillAmount = Convert.ToDouble(dr["bill_amount"])
                    });
                }
            }
            return list;
        }
    }
}

    
